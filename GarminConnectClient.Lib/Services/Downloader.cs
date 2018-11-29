using GarminConnectClient.Lib.Dto;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GarminConnectClient.Lib.Enum;

namespace GarminConnectClient.Lib.Services
{
    /// <inheritdoc />
    /// <summary>
    /// Garmin Connect downloader
    /// </summary>
    /// <seealso cref="T:GarminConnectClient.Lib.Services.IDownloader" />
    public class Downloader : IDownloader
    {
        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary>
        /// The activity data file
        /// </summary>
        public const string ActivityDataFile = "activity_data.json";

        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary>
        /// The activity data file
        /// </summary>
        public const string GpsDataFile = "gps_data";

        /// <summary>
        /// The configuration
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILogger logger;

        /// <summary>
        /// The client
        /// </summary>
        private readonly IClient client;

        /// <summary>
        /// The storage
        /// </summary>
        private readonly IStorage storage;

        /// <summary>
        /// Initializes a new instance of the <see cref="Downloader"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="client">The client.</param>
        /// <param name="storage">The storage.</param>
        /// <param name="logger">The logger.</param>
        public Downloader(IConfiguration configuration, IClient client, IStorage storage, ILogger logger)
        {
            this.configuration = configuration;
            this.client = client;
            this.storage = storage;
            this.logger = logger;
        }

        /// <inheritdoc />
        /// <summary>
        /// Downloads the last user activities.
        /// </summary>
        /// <returns>List of activities</returns>
        public async Task<IList<Activity>> DownloadLastUserActivities()
        {
            const int limit = 50;
            var from = DateTime.UtcNow;
            await this.client.Authenticate();
            var activities = await this.client.LoadActivities(limit, 0, from);
            var allActivities = new List<Activity>();

            while (activities.Any() && allActivities.Count < limit)
            {
                foreach (var activity in activities)
                {
                    var downloadedActivity = await this.DownloadActivity(activity.ActivityId);
                    if (downloadedActivity == null)
                    {
                        return allActivities;
                    }
                    allActivities.Add(downloadedActivity);
                }

                var firstItem = allActivities.OrderBy(e => e.Summary.StartTimeGmt).FirstOrDefault();
                if (firstItem != null)
                {
                    from = firstItem.Summary.StartTimeGmt.UtcDateTime;
                }

                activities = await this.client.LoadActivities(limit, 0, from);
            }

            return allActivities;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the and store GPS data.
        /// </summary>
        /// <param name="activityId">The activity identifier.</param>
        /// <param name="fileFormat">File format.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>Task result</returns>
        public async Task GetAndStoreGpsData(long activityId, ActivityFileTypeEnum fileFormat,
            string fileName)
        {
            this.logger.LogInformation($"Downloading of GPS data in {fileFormat.ToString()} format started.");
            using (var data = await this.client.DownloadActivityFile(activityId, fileFormat))
            {
                //data.Position = 0;
                await this.storage.StoreData(fileName, data);
            }

            this.logger.LogInformation($"Downloading of GPS data in {fileFormat.ToString()} format done.");
        }

        /// <summary>
        /// Creates the name of the file.
        /// </summary>
        /// <param name="rootDir">The root dir.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>File name</returns>
        private static string CreateFileName(string rootDir, string fileName) => Path.Combine(rootDir, fileName);

        /// <inheritdoc />
        /// <summary>
        /// Creates the name of the GPS file map.
        /// </summary>
        /// <param name="exportFormat">The export format.</param>
        /// <returns>GPS file name</returns>
        public string CreateGpsFileMapName(ActivityFileTypeEnum exportFormat) =>
            $"{GpsDataFile}.{(exportFormat == ActivityFileTypeEnum.Fit ? "zip" : exportFormat.ToString().ToLower())}";

        /// <inheritdoc />
        /// <summary>
        /// Downloads the activity.
        /// </summary>
        /// <param name="activity">Activity.</param>
        /// <param name="checkFileExistence">Should be file existence checked.</param>
        /// <returns>Move instance</returns>
        public async Task<Activity> DownloadActivity(Activity activity, bool checkFileExistence)
        {
            var activityDir = string.IsNullOrWhiteSpace(this.configuration.BackupDir) ? activity.ActivityId.ToString() : Path.Combine(this.configuration.BackupDir, activity.ActivityId.ToString());
            var activityDataFile = CreateFileName(activityDir, ActivityDataFile);

            if (checkFileExistence)
            {
                if (await this.storage.FileExists(activityDataFile))
                {
                    this.logger.LogInformation($"Activity {activity.ActivityId} is already downloaded.");
                    return null;
                }
            }

            var mediaDir = Path.Combine(activityDir, "media");

            this.storage.CreateDirectory(activityDir);
            this.storage.CreateDirectory(mediaDir);

            this.logger.LogInformation("Saving of activity data started.");
            await this.storage.StoreData(activityDataFile, JsonConvert.SerializeObject(activity));
            this.logger.LogInformation("Saving of activity data done.");

            this.logger.LogInformation("Saving of activity media started.");
            foreach (var image in activity.Metadata.ActivityImages ?? new ActivityImage[0])
            {
                using (var httpClient = new HttpClient())
                {
                    var data = await httpClient.GetByteArrayAsync(image.Url);
                    var urlParts = image.Url.ToString().Split('/');
                    await this.storage.StoreData(CreateFileName(mediaDir, urlParts[urlParts.Length - 1]), data);
                }
            }
            this.logger.LogInformation("Saving of activity media done.");

            foreach (var exportFormat in new[] {
                ActivityFileTypeEnum.Kml,
                ActivityFileTypeEnum.Gpx,
                ActivityFileTypeEnum.Csv,
                ActivityFileTypeEnum.Fit,
                ActivityFileTypeEnum.Tcx
            })
            {
                await this.GetAndStoreGpsData(activity.ActivityId, exportFormat, CreateFileName(activityDir, this.CreateGpsFileMapName(exportFormat)));
            }

            this.logger.LogInformation($"Downloading of activity {activity.ActivityId} done.");
            return activity;
        }

        /// <inheritdoc />
        /// <summary>
        /// Downloads the activity.
        /// </summary>
        /// <param name="activityId">The activity identifier.</param>
        /// <returns>
        /// Activity instance
        /// </returns>
        public async Task<Activity> DownloadActivity(long activityId)
        {
            this.logger.LogInformation($"Downloading of activity {activityId} started.");
            var activityDir = string.IsNullOrWhiteSpace(this.configuration.BackupDir) ? activityId.ToString() : Path.Combine(this.configuration.BackupDir, activityId.ToString());
            var activityDataFile = CreateFileName(activityDir, ActivityDataFile);

            if (await this.storage.FileExists(activityDataFile))
            {
                this.logger.LogInformation($"Activity {activityId} is already downloaded.");
                return null;
            }

            this.logger.LogInformation("Saving of activity data started.");
            var activity = await this.client.LoadActivity(activityId);
            return await this.DownloadActivity(activity, false);
        }
    }
}