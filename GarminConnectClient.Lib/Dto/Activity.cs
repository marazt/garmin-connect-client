using Newtonsoft.Json;

namespace GarminConnectClient.Lib.Dto
{
    /// <summary>
    /// Activity
    /// </summary>
    public class Activity
    {
        /// <summary>
        /// Gets or sets the activity identifier.
        /// </summary>
        /// <value>
        /// The activity identifier.
        /// </value>
        [JsonProperty("activityId")]
        public long ActivityId { get; set; }

        /// <summary>
        /// Gets or sets the name of the activity.
        /// </summary>
        /// <value>
        /// The name of the activity.
        /// </value>
        [JsonProperty("activityName")]
        public string ActivityName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the user profile identifier.
        /// </summary>
        /// <value>
        /// The user profile identifier.
        /// </value>
        [JsonProperty("userProfileId")]
        public long UserProfileId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is multi sport parent.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is multi sport parent; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isMultiSportParent")]
        public bool IsMultiSportParent { get; set; }

        /// <summary>
        /// Gets or sets the type of the activity.
        /// </summary>
        /// <value>
        /// The type of the activity.
        /// </value>
        [JsonProperty("activityTypeDTO")]
        public ActivityType ActivityType { get; set; }


        /// <summary>
        /// Gets or sets the type of the activity.
        /// Overloaded JsonProperty for the same property - "activityTypeDTO".
        /// </summary>
        /// <value>
        /// The type of the activity.
        /// </value>
        [JsonProperty("activityType")]
#pragma warning disable IDE0051 // Remove unused private members
        private ActivityType ActivityTypeInternal { set { this.ActivityType = value; } }
#pragma warning restore IDE0051 // Remove unused private members

        /// <summary>
        /// Gets or sets the type of the event.
        /// </summary>
        /// <value>
        /// The type of the event.
        /// </value>
        [JsonProperty("eventTypeDTO")]
        public ActivityType EventType { get; set; }

        /// <summary>
        /// Gets or sets the access control rule.
        /// </summary>
        /// <value>
        /// The access control rule.
        /// </value>
        [JsonProperty("accessControlRuleDTO")]
        public AccessControlRule AccessControlRule { get; set; }

        /// <summary>
        /// Gets or sets the time zone unit.
        /// </summary>
        /// <value>
        /// The time zone unit.
        /// </value>
        [JsonProperty("timeZoneUnitDTO")]
        public TimeZoneUnit TimeZoneUnit { get; set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        /// <value>
        /// The metadata.
        /// </value>
        [JsonProperty("metadataDTO")]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Gets or sets the summary.
        /// </summary>
        /// <value>
        /// The summary.
        /// </value>
        [JsonProperty("summaryDTO")]
        public Summary Summary { get; set; }

        /// <summary>
        /// Gets or sets the name of the location.
        /// </summary>
        /// <value>
        /// The name of the location.
        /// </value>
        [JsonProperty("locationName")]
        public string LocationName { get; set; }
    }
}
