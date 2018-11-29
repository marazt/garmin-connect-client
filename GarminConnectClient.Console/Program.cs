using GarminConnectClient.Lib;
using GarminConnectClient.Lib.Dto;
using GarminConnectClient.Lib.Enum;
using GarminConnectClient.Lib.Services;
using Microsoft.Extensions.Configuration;
using MovescountBackup.Lib.Dto;
using MovescountBackup.Lib.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable RedundantCaseLabel

namespace GarminConnectClient.Console
{
    // ReSharper disable once ArrangeTypeModifiers
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private const int Timeout = 20000;

        // ReSharper disable once ArrangeTypeMemberModifiers
        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {
            var storedFiles = new Dictionary<string, string>();
            using (var stream = new FileStream(@"C:\Users\maraz\Desktop\moves\log.txt", FileMode.OpenOrCreate))
            {
                using (var logFile = new StreamReader(stream))
                {
                    var records = logFile.ReadToEnd().Split(Environment.NewLine);
                    if (records.Length > 1)
                    {
                        storedFiles = records.Where(e => e.Contains("|")).Select(e =>
                        {
                            var parts = e.Split("|");
                            return new { Key = parts[0], Value = parts[1] };
                        })
                        .ToDictionary(e => e.Key, e => e.Value);
                    }
                }
            }

            var configuration = SetupConfiguration();
            var client = new Client(configuration, new ConsoleLogger<Client>());

            System.Console.WriteLine("Loading event types");

            client.Authenticate().Wait();
            var eventTypes = client.LoadEventTypes().Result;

            Task.Delay(Timeout).Wait();

            System.Console.WriteLine("Loading activity types");

            var activityTypes = client.LoadActivityTypes().Result;

            System.Console.WriteLine("-------------------------------------------------------------------------------");

            var allGpxFiles = Directory.GetFiles(@"C:\Users\maraz\Desktop\moves", "*.gpx*", SearchOption.AllDirectories);
            foreach (var gpxFile in allGpxFiles)
            {
                Move activityData = null;

                try
                {
                    var jsonDataFile = gpxFile.Replace("gps_data.gpx", "move_data.json");

                    using (var jsonDataStream = new StreamReader(jsonDataFile))
                    {
                        activityData = JsonConvert.DeserializeObject<Move>(jsonDataStream.ReadToEnd());
                    }

                    if (storedFiles.ContainsKey(activityData.MoveId.ToString()))
                    {
                        System.Console.WriteLine($"Garmin Connect move {activityData.MoveId} (Garmin activity {storedFiles[activityData.MoveId.ToString()]}) should be already stored or upload failed.");
                        System.Console.WriteLine("-------------------------------------------------------------------------------");
                        continue;
                    }

                    System.Console.WriteLine($"Uploading Garmin Connect move {activityData.MoveId}");
                    var result = client.UploadActivity(gpxFile, new FileFormat { FormatKey = "gpx" }).Result;
                    if (!result.Success)
                    {
                        System.Console.WriteLine($"Error while uploading uploading Garmin Connect move {activityData.MoveId}.");
                        throw new Exception("Error while uploading uploading Garmin Connect move {activityData.MoveId}.");
                    }

                    var name = activityData.Notes != null
                ? activityData.Notes.Split('.').FirstOrDefault() ?? activityData.MoveId.ToString()
                : activityData.MoveId.ToString();

                    System.Console.WriteLine($"Setting name of Garmin Connect move {activityData.MoveId} (Garmin activity {result.ActivityId}) to '{name}'.");
                    client.SetActivityName(result.ActivityId, name).Wait();

                    Task.Delay(Timeout).Wait();

                    var description = CreateDescription(activityData);

                    System.Console.WriteLine($"Setting description of Garmin Connect move {activityData.MoveId} (Garmin activity {result.ActivityId}) to '{description}'.");
                    client.SetActivityDescription(result.ActivityId, description).Wait();

                    Task.Delay(Timeout).Wait();

                    var activityType = activityTypes.FirstOrDefault(e => string.Equals(e.TypeKey, ResolveActivityType(activityData.ActivityID).TypeKey, StringComparison.InvariantCultureIgnoreCase));
                    if (activityType != null)
                    {
                        System.Console.WriteLine($"Setting activity type of Garmin Connect move {activityData.MoveId} (Garmin activity {result.ActivityId}) to '{activityType.TypeKey}'.");
                        client.SetActivityType(result.ActivityId, activityType).Wait();
                        Task.Delay(Timeout).Wait();
                    }

                    var eventType = eventTypes.FirstOrDefault(e => string.Equals(e.TypeKey, activityType != null && activityType.TypeId == (int)ActivityTypeEnum.Running
                        ? EventTypeEnum.Training.ToString()
                        : EventTypeEnum.Fitness.ToString(), StringComparison.InvariantCultureIgnoreCase));

                    if (eventType != null)
                    {
                        System.Console.WriteLine($"Setting event type of Garmin Connect move {activityData.MoveId} (Garmin activity {result.ActivityId}) to '{eventType.TypeKey}'.");
                        client.SetEventType(result.ActivityId, eventType).Wait();
                        Task.Delay(Timeout).Wait();
                    }

                    storedFiles.Add(activityData.MoveId.ToString(), result.ActivityId.ToString());
                    UpdateLogFile(activityData.MoveId, result.ActivityId);

                    System.Console.WriteLine("-------------------------------------------------------------------------------");
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine($"Error while uploading Garmin Connect move {activityData?.MoveId}: {ex.Message}.");
                    System.Console.WriteLine($"Error while uploading move: {ex.StackTrace}.");
                    storedFiles.Add(activityData.MoveId.ToString(), "0");
                    UpdateLogFile(activityData.MoveId, 0);
                }
            }
        }

        private static void UpdateLogFile(int moveId, long activityId)
        {
            using (var stream = new FileStream(@"C:\Users\maraz\Desktop\moves\log.txt", FileMode.Append))
            {
                System.Console.WriteLine($"Updating log file of move {moveId} (Garmin activity {activityId}).");
                using (var logFile = new StreamWriter(stream))
                {
                    logFile.WriteLine($"{moveId}|{activityId}");
                }
            }
        }

        private static ActivityType ResolveActivityType(ActivityIdEnum activityId)
        {
            switch (activityId)
            {
                case ActivityIdEnum.CircuitTraining:
                    return new ActivityType { TypeKey = "indoor_cardio" };

                case ActivityIdEnum.Climbing:
                    return new ActivityType { TypeKey = "rock_climbing" };

                case ActivityIdEnum.CrossFit:
                    return new ActivityType { TypeKey = "strength_training" };

                case ActivityIdEnum.Cycling:
                    return new ActivityType { TypeKey = "cycling" };

                case ActivityIdEnum.MultiSport:
                    return new ActivityType { TypeKey = "multi_sport" };

                case ActivityIdEnum.NotSpecifiedSport:
                    return new ActivityType { TypeKey = "uncategorized" };

                case ActivityIdEnum.Run:
                    return new ActivityType { TypeKey = "running" };

                case ActivityIdEnum.Walking:
                    return new ActivityType { TypeKey = "walking" };

                case ActivityIdEnum.NordicWalking:
                case ActivityIdEnum.Trekking:
                    return new ActivityType { TypeKey = "walking" };

                case ActivityIdEnum.Swimming:
                    return new ActivityType { TypeKey = "swimming" };

                case ActivityIdEnum.OpenWaterSwimming:
                    return new ActivityType { TypeKey = "open_water_swimming" };

                case ActivityIdEnum.Skating:
                    return new ActivityType { TypeKey = "inline_skating" };

                case ActivityIdEnum.IceSkating:
                    return new ActivityType { TypeKey = "skating" };

                case ActivityIdEnum.CrosscountrySkiing:
                    return new ActivityType { TypeKey = "cross_country_skiing" };

                case ActivityIdEnum.AlpineSkiing:
                    return new ActivityType { TypeKey = "skate_skiing" };

                case ActivityIdEnum.IndoorTraining:
                    return new ActivityType { TypeKey = "indoor_cardio" };

                case ActivityIdEnum.TrailRunning:
                    return new ActivityType { TypeKey = "trail_running" };

                case ActivityIdEnum.MountainBiking:
                case ActivityIdEnum.Aerobics:
                case ActivityIdEnum.YogaPilates:
                case ActivityIdEnum.Sailing:
                case ActivityIdEnum.Kayaking:
                case ActivityIdEnum.Rowing:
                case ActivityIdEnum.IndoorCycling:
                case ActivityIdEnum.Triathlon:
                case ActivityIdEnum.Snowboarding:
                case ActivityIdEnum.WeightTraining:
                case ActivityIdEnum.Basketball:
                case ActivityIdEnum.Soccer:
                case ActivityIdEnum.IceHockey:
                case ActivityIdEnum.Volleyball:
                case ActivityIdEnum.Football:
                case ActivityIdEnum.Softball:
                case ActivityIdEnum.Cheerleading:
                case ActivityIdEnum.Baseball:
                case ActivityIdEnum.Tennis:
                case ActivityIdEnum.Badminton:
                case ActivityIdEnum.TableTennis:
                case ActivityIdEnum.RacquetBall:
                case ActivityIdEnum.Squash:
                case ActivityIdEnum.CombatSport:
                case ActivityIdEnum.Boxing:
                case ActivityIdEnum.Floorball:
                case ActivityIdEnum.ScubaDiving:
                case ActivityIdEnum.FreeDiving:
                case ActivityIdEnum.AdventureRacing:
                case ActivityIdEnum.Bowling:
                case ActivityIdEnum.Cricket:
                case ActivityIdEnum.Crosstrainer:
                case ActivityIdEnum.Dancing:
                case ActivityIdEnum.Golf:
                case ActivityIdEnum.Gymnastics:
                case ActivityIdEnum.Handball:
                case ActivityIdEnum.HorsebackRiding:
                case ActivityIdEnum.IndoorRowing:
                case ActivityIdEnum.Canoeing:
                case ActivityIdEnum.Motorsports:
                case ActivityIdEnum.Mountaineering:
                case ActivityIdEnum.Orienteering:
                case ActivityIdEnum.Rugby:
                case ActivityIdEnum.SkiTouring:
                case ActivityIdEnum.Stretching:
                case ActivityIdEnum.TelemarkSkiing:
                case ActivityIdEnum.TrackAndField:
                case ActivityIdEnum.SnowShoeing:
                case ActivityIdEnum.Surfing:
                case ActivityIdEnum.Kettlebell:
                case ActivityIdEnum.RollerSkiing:
                case ActivityIdEnum.StandupPaddling:
                case ActivityIdEnum.Kiting:
                case ActivityIdEnum.Paragliding:
                case ActivityIdEnum.Treadmill:
                case ActivityIdEnum.Frisbee:
                default:
                    return new ActivityType { TypeKey = "uncategorized" };
            }
        }

        private static string CreateDescription(Move move)
        {
            var notes = new StringBuilder(string.Empty);
            notes.AppendLine("Garmin Connect data:");
            notes.AppendLine($"Move: http://www.movescount.com/moves/move{move.MoveId}");
            notes.AppendLine(
                $"Feeling: {(move.Feeling.HasValue ? Enum.Parse(typeof(FeelingEnum), move.Feeling.ToString()).ToString() : "-")}");
            notes.AppendLine(
                $"Weather: {(move.Weather.HasValue ? Enum.Parse(typeof(WeatherEnum), move.Weather.ToString()).ToString() : "-")}");
            notes.AppendLine($"Tags: {move.Tags}");
            notes.AppendLine(
                $"RecoveryTime: {(move.RecoveryTime.HasValue ? $"{Math.Round(move.RecoveryTime.Value / 3600, 1)}h" : "-")}");

            return $"{move.Notes?.Replace(" + ", " plus ")}\n{notes}";
        }

        private static Lib.IConfiguration SetupConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables();
            var configuration = builder.Build();
            return new Configuration(configuration);
        }
    }
}