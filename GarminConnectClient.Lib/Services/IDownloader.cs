using GarminConnectClient.Lib.Dto;
using GarminConnectClient.Lib.Enum;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GarminConnectClient.Lib.Services
{
    /// <summary>
    /// Data downloader.
    /// </summary>
    public interface IDownloader
    {
        /// <summary>
        /// Downloads the last user activities.
        /// </summary>
        /// <returns>List of activities</returns>
        Task<IList<Activity>> DownloadLastUserActivities();

        /// <summary>
        /// Gets the and store GPS data.
        /// </summary>
        /// <param name="activityId">The activity identifier.</param>
        /// <param name="exportFormat">The export format.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>Task result</returns>
        Task GetAndStoreGpsData(long activityId, ActivityFileTypeEnum exportFormat,
            string fileName);

        /// <summary>
        /// Downloads the activity.
        /// </summary>
        /// <param name="activity">The activity instance.</param>
        /// <param name="checkFileExistence">Should check activity directory existence.</param>
        /// <returns>Activity instance</returns>
        Task<Activity> DownloadActivity(Activity activity, bool checkFileExistence);

        /// <summary>
        /// Downloads the activity.
        /// </summary>
        /// <param name="activityId">The activity identifier.</param>
        /// <returns>Activity instance</returns>
        Task<Activity> DownloadActivity(long activityId);

        /// <summary>
        /// Creates the name of the GPS file map.
        /// </summary>
        /// <param name="exportFormat">The export format.</param>
        /// <returns>GPS file name</returns>
        string CreateGpsFileMapName(ActivityFileTypeEnum exportFormat);
    }
}