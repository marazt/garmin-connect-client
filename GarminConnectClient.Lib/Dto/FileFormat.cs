using Newtonsoft.Json;

namespace GarminConnectClient.Lib.Dto
{
    /// <summary>
    /// File format
    /// </summary>
    public class FileFormat
    {
        /// <summary>
        /// Gets or sets the format identifier.
        /// </summary>
        /// <value>
        /// The format identifier.
        /// </value>
        [JsonProperty("formatId")]
        public long FormatId { get; set; }

        /// <summary>
        /// Gets or sets the format key.
        /// </summary>
        /// <value>
        /// The format key.
        /// </value>
        [JsonProperty("formatKey")]
        public string FormatKey { get; set; }
    }
}