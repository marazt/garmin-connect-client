using Newtonsoft.Json;
using System;

namespace GarminConnectClient.Lib.Dto
{
    /// <summary>
    /// Summary
    /// </summary>
    public class Summary
    {
        /// <summary>
        /// Gets or sets the start time local.
        /// </summary>
        /// <value>
        /// The start time local.
        /// </value>
        [JsonProperty("startTimeLocal")]
        public DateTimeOffset StartTimeLocal { get; set; }

        /// <summary>
        /// Gets or sets the start time GMT.
        /// </summary>
        /// <value>
        /// The start time GMT.
        /// </value>
        [JsonProperty("startTimeGMT")]
        public DateTimeOffset StartTimeGmt { get; set; }

        /// <summary>
        /// Gets or sets the start latitude.
        /// </summary>
        /// <value>
        /// The start latitude.
        /// </value>
        [JsonProperty("startLatitude")]
        public double StartLatitude { get; set; }

        /// <summary>
        /// Gets or sets the start longitude.
        /// </summary>
        /// <value>
        /// The start longitude.
        /// </value>
        [JsonProperty("startLongitude")]
        public double StartLongitude { get; set; }

        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        [JsonProperty("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        [JsonProperty("duration")]
        public double Duration { get; set; }

        /// <summary>
        /// Gets or sets the duration of the moving.
        /// </summary>
        /// <value>
        /// The duration of the moving.
        /// </value>
        [JsonProperty("movingDuration")]
        public long MovingDuration { get; set; }

        /// <summary>
        /// Gets or sets the duration of the elapsed.
        /// </summary>
        /// <value>
        /// The duration of the elapsed.
        /// </value>
        [JsonProperty("elapsedDuration")]
        public double ElapsedDuration { get; set; }

        /// <summary>
        /// Gets or sets the elevation gain.
        /// </summary>
        /// <value>
        /// The elevation gain.
        /// </value>
        [JsonProperty("elevationGain")]
        public long ElevationGain { get; set; }

        /// <summary>
        /// Gets or sets the elevation loss.
        /// </summary>
        /// <value>
        /// The elevation loss.
        /// </value>
        [JsonProperty("elevationLoss")]
        public long ElevationLoss { get; set; }

        /// <summary>
        /// Gets or sets the maximum elevation.
        /// </summary>
        /// <value>
        /// The maximum elevation.
        /// </value>
        [JsonProperty("maxElevation")]
        public double MaxElevation { get; set; }

        /// <summary>
        /// Gets or sets the minimum elevation.
        /// </summary>
        /// <value>
        /// The minimum elevation.
        /// </value>
        [JsonProperty("minElevation")]
        public double MinElevation { get; set; }

        /// <summary>
        /// Gets or sets the average speed.
        /// </summary>
        /// <value>
        /// The average speed.
        /// </value>
        [JsonProperty("averageSpeed")]
        public double AverageSpeed { get; set; }

        /// <summary>
        /// Gets or sets the average moving speed.
        /// </summary>
        /// <value>
        /// The average moving speed.
        /// </value>
        [JsonProperty("averageMovingSpeed")]
        public double AverageMovingSpeed { get; set; }

        /// <summary>
        /// Gets or sets the maximum speed.
        /// </summary>
        /// <value>
        /// The maximum speed.
        /// </value>
        [JsonProperty("maxSpeed")]
        public double MaxSpeed { get; set; }

        /// <summary>
        /// Gets or sets the calories.
        /// </summary>
        /// <value>
        /// The calories.
        /// </value>
        [JsonProperty("calories")]
        public double Calories { get; set; }

        /// <summary>
        /// Gets or sets the average hr.
        /// </summary>
        /// <value>
        /// The average hr.
        /// </value>
        [JsonProperty("averageHR")]
        public long AverageHr { get; set; }

        /// <summary>
        /// Gets or sets the maximum hr.
        /// </summary>
        /// <value>
        /// The maximum hr.
        /// </value>
        [JsonProperty("maxHR")]
        public long MaxHr { get; set; }

        /// <summary>
        /// Gets or sets the average run cadence.
        /// </summary>
        /// <value>
        /// The average run cadence.
        /// </value>
        [JsonProperty("averageRunCadence")]
        public double AverageRunCadence { get; set; }

        /// <summary>
        /// Gets or sets the maximum run cadence.
        /// </summary>
        /// <value>
        /// The maximum run cadence.
        /// </value>
        [JsonProperty("maxRunCadence")]
        public long MaxRunCadence { get; set; }

        /// <summary>
        /// Gets or sets the average temperature.
        /// </summary>
        /// <value>
        /// The average temperature.
        /// </value>
        [JsonProperty("averageTemperature")]
        public double AverageTemperature { get; set; }

        /// <summary>
        /// Gets or sets the maximum temperature.
        /// </summary>
        /// <value>
        /// The maximum temperature.
        /// </value>
        [JsonProperty("maxTemperature")]
        public long MaxTemperature { get; set; }

        /// <summary>
        /// Gets or sets the minimum temperature.
        /// </summary>
        /// <value>
        /// The minimum temperature.
        /// </value>
        [JsonProperty("minTemperature")]
        public long MinTemperature { get; set; }

        /// <summary>
        /// Gets or sets the length of the stride.
        /// </summary>
        /// <value>
        /// The length of the stride.
        /// </value>
        [JsonProperty("strideLength")]
        public double StrideLength { get; set; }

        /// <summary>
        /// Gets or sets the training effect.
        /// </summary>
        /// <value>
        /// The training effect.
        /// </value>
        [JsonProperty("trainingEffect")]
        public double TrainingEffect { get; set; }

        /// <summary>
        /// Gets or sets the anaerobic training effect.
        /// </summary>
        /// <value>
        /// The anaerobic training effect.
        /// </value>
        [JsonProperty("anaerobicTrainingEffect")]
        public double AnaerobicTrainingEffect { get; set; }

        /// <summary>
        /// Gets or sets the aerobic training effect message.
        /// </summary>
        /// <value>
        /// The aerobic training effect message.
        /// </value>
        [JsonProperty("aerobicTrainingEffectMessage")]
        public string AerobicTrainingEffectMessage { get; set; }

        /// <summary>
        /// Gets or sets the anaerobic training effect message.
        /// </summary>
        /// <value>
        /// The anaerobic training effect message.
        /// </value>
        [JsonProperty("anaerobicTrainingEffectMessage")]
        public string AnaerobicTrainingEffectMessage { get; set; }

        /// <summary>
        /// Gets or sets the end latitude.
        /// </summary>
        /// <value>
        /// The end latitude.
        /// </value>
        [JsonProperty("endLatitude")]
        public double EndLatitude { get; set; }

        /// <summary>
        /// Gets or sets the end longitude.
        /// </summary>
        /// <value>
        /// The end longitude.
        /// </value>
        [JsonProperty("endLongitude")]
        public double EndLongitude { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is deco dive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is deco dive; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isDecoDive")]
        public bool IsDecoDive { get; set; }

        /// <summary>
        /// Gets or sets the average vertical speed.
        /// </summary>
        /// <value>
        /// The average vertical speed.
        /// </value>
        [JsonProperty("avgVerticalSpeed")]
        public long AvgVerticalSpeed { get; set; }

        /// <summary>
        /// Gets or sets the maximum vertical speed.
        /// </summary>
        /// <value>
        /// The maximum vertical speed.
        /// </value>
        [JsonProperty("maxVerticalSpeed")]
        public double MaxVerticalSpeed { get; set; }
    }
}