using Newtonsoft.Json;

namespace GarminConnectClient.Lib.Dto
{
    /// <summary>
    /// Activity type
    /// </summary>
    public class ActivityType
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

        /// <summary>
        /// Gets or sets the parent type identifier.
        /// </summary>
        /// <value>
        /// The parent type identifier.
        /// </value>
        [JsonProperty("parentTypeId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the sort order.
        /// </summary>
        /// <value>
        /// The sort order.
        /// </value>
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }
    }
}