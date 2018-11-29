using Newtonsoft.Json;

namespace GarminConnectClient.Lib.Dto
{
    /// <summary>
    /// Time zone
    /// </summary>
    public class TimeZoneUnit
    {
        /// <summary>
        /// Gets or sets the unit identifier.
        /// </summary>
        /// <value>
        /// The unit identifier.
        /// </value>
        [JsonProperty("unitId")]
        public long UnitId { get; set; }

        /// <summary>
        /// Gets or sets the unit key.
        /// </summary>
        /// <value>
        /// The unit key.
        /// </value>
        [JsonProperty("unitKey")]
        public string UnitKey { get; set; }

        /// <summary>
        /// Gets or sets the factor.
        /// </summary>
        /// <value>
        /// The factor.
        /// </value>
        [JsonProperty("factor")]
        public long Factor { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>
        /// The time zone.
        /// </value>
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }
}