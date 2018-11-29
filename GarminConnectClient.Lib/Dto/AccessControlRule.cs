using Newtonsoft.Json;

namespace GarminConnectClient.Lib.Dto
{
    /// <summary>
    /// Access control rule
    /// </summary>
    public class AccessControlRule
    {
        /// <summary>
        /// Gets or sets the type identifier.
        /// </summary>
        /// <value>
        /// The type identifier.
        /// </value>
        [JsonProperty("typeId")]
        public long TypeId { get; set; }

        /// <summary>
        /// Gets or sets the type key.
        /// </summary>
        /// <value>
        /// The type key.
        /// </value>
        [JsonProperty("typeKey")]
        public string TypeKey { get; set; }
    }
}