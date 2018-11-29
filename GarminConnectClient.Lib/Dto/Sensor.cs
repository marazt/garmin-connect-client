using Newtonsoft.Json;

namespace GarminConnectClient.Lib.Dto
{
    /// <summary>
    /// Sensor
    /// </summary>
    public class Sensor
    {
        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        /// <value>
        /// The sku.
        /// </value>
        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets the type of the source.
        /// </summary>
        /// <value>
        /// The type of the source.
        /// </value>
        [JsonProperty("sourceType")]
        public string SourceType { get; set; }

        /// <summary>
        /// Gets or sets the software version.
        /// </summary>
        /// <value>
        /// The software version.
        /// </value>
        [JsonProperty("softwareVersion")]
        public double SoftwareVersion { get; set; }

        /// <summary>
        /// Gets or sets the type of the local device.
        /// </summary>
        /// <value>
        /// The type of the local device.
        /// </value>
        [JsonProperty("localDeviceType", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalDeviceType { get; set; }
    }
}