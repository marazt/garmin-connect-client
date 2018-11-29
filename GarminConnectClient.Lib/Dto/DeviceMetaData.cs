using Newtonsoft.Json;

namespace GarminConnectClient.Lib.Dto
{
    /// <summary>
    /// Device metadata
    /// </summary>
    public class DeviceMetaData
    {
        /// <summary>
        /// Gets or sets the device identifier.
        /// </summary>
        /// <value>
        /// The device identifier.
        /// </value>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets the device type pk.
        /// </summary>
        /// <value>
        /// The device type pk.
        /// </value>
        [JsonProperty("deviceTypePk")]
        public long DeviceTypePk { get; set; }

        /// <summary>
        /// Gets or sets the device version pk.
        /// </summary>
        /// <value>
        /// The device version pk.
        /// </value>
        [JsonProperty("deviceVersionPk")]
        public long DeviceVersionPk { get; set; }
    }
}