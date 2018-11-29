using Newtonsoft.Json;
using System;

namespace GarminConnectClient.Lib.Dto
{
    /// <summary>
    /// User info
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the profile identifier.
        /// </summary>
        /// <value>
        /// The profile identifier.
        /// </value>
        [JsonProperty("profileId")]
        public long ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the garmin unique identifier.
        /// </summary>
        /// <value>
        /// The garmin unique identifier.
        /// </value>
        [JsonProperty("garminGUID")]
        public Guid GarminGuid { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        [JsonProperty("displayName")]
        public Guid DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [JsonProperty("userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the profile image URL large.
        /// </summary>
        /// <value>
        /// The profile image URL large.
        /// </value>
        [JsonProperty("profileImageUrlLarge")]
        public Uri ProfileImageUrlLarge { get; set; }

        /// <summary>
        /// Gets or sets the profile image URL medium.
        /// </summary>
        /// <value>
        /// The profile image URL medium.
        /// </value>
        [JsonProperty("profileImageUrlMedium")]
        public Uri ProfileImageUrlMedium { get; set; }

        /// <summary>
        /// Gets or sets the profile image URL small.
        /// </summary>
        /// <value>
        /// The profile image URL small.
        /// </value>
        [JsonProperty("profileImageUrlSmall")]
        public Uri ProfileImageUrlSmall { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        [JsonProperty("location")]
        public object Location { get; set; }

        /// <summary>
        /// Gets or sets the facebook URL.
        /// </summary>
        /// <value>
        /// The facebook URL.
        /// </value>
        [JsonProperty("facebookUrl")]
        public object FacebookUrl { get; set; }

        /// <summary>
        /// Gets or sets the twitter URL.
        /// </summary>
        /// <value>
        /// The twitter URL.
        /// </value>
        [JsonProperty("twitterUrl")]
        public object TwitterUrl { get; set; }

        /// <summary>
        /// Gets or sets the personal website.
        /// </summary>
        /// <value>
        /// The personal website.
        /// </value>
        [JsonProperty("personalWebsite")]
        public object PersonalWebsite { get; set; }

        /// <summary>
        /// Gets or sets the motivation.
        /// </summary>
        /// <value>
        /// The motivation.
        /// </value>
        [JsonProperty("motivation")]
        public long Motivation { get; set; }

        /// <summary>
        /// Gets or sets the bio.
        /// </summary>
        /// <value>
        /// The bio.
        /// </value>
        [JsonProperty("bio")]
        public object Bio { get; set; }

        /// <summary>
        /// Gets or sets the primary activity.
        /// </summary>
        /// <value>
        /// The primary activity.
        /// </value>
        [JsonProperty("primaryActivity")]
        public string PrimaryActivity { get; set; }

        /// <summary>
        /// Gets or sets the favorite activity types.
        /// </summary>
        /// <value>
        /// The favorite activity types.
        /// </value>
        [JsonProperty("favoriteActivityTypes")]
        public string[] FavoriteActivityTypes { get; set; }

        /// <summary>
        /// Gets or sets the running training speed.
        /// </summary>
        /// <value>
        /// The running training speed.
        /// </value>
        [JsonProperty("runningTrainingSpeed")]
        public double RunningTrainingSpeed { get; set; }

        /// <summary>
        /// Gets or sets the cycling training speed.
        /// </summary>
        /// <value>
        /// The cycling training speed.
        /// </value>
        [JsonProperty("cyclingTrainingSpeed")]
        public long CyclingTrainingSpeed { get; set; }

        /// <summary>
        /// Gets or sets the favorite cycling activity types.
        /// </summary>
        /// <value>
        /// The favorite cycling activity types.
        /// </value>
        [JsonProperty("favoriteCyclingActivityTypes")]
        public string[] FavoriteCyclingActivityTypes { get; set; }

        /// <summary>
        /// Gets or sets the cycling classification.
        /// </summary>
        /// <value>
        /// The cycling classification.
        /// </value>
        [JsonProperty("cyclingClassification")]
        public string CyclingClassification { get; set; }

        /// <summary>
        /// Gets or sets the cycling maximum average power.
        /// </summary>
        /// <value>
        /// The cycling maximum average power.
        /// </value>
        [JsonProperty("cyclingMaxAvgPower")]
        public long CyclingMaxAvgPower { get; set; }

        /// <summary>
        /// Gets or sets the swimming training speed.
        /// </summary>
        /// <value>
        /// The swimming training speed.
        /// </value>
        [JsonProperty("swimmingTrainingSpeed")]
        public double SwimmingTrainingSpeed { get; set; }

        /// <summary>
        /// Gets or sets the profile visibility.
        /// </summary>
        /// <value>
        /// The profile visibility.
        /// </value>
        [JsonProperty("profileVisibility")]
        public string ProfileVisibility { get; set; }

        /// <summary>
        /// Gets or sets the activity start visibility.
        /// </summary>
        /// <value>
        /// The activity start visibility.
        /// </value>
        [JsonProperty("activityStartVisibility")]
        public string ActivityStartVisibility { get; set; }

        /// <summary>
        /// Gets or sets the activity map visibility.
        /// </summary>
        /// <value>
        /// The activity map visibility.
        /// </value>
        [JsonProperty("activityMapVisibility")]
        public string ActivityMapVisibility { get; set; }

        /// <summary>
        /// Gets or sets the course visibility.
        /// </summary>
        /// <value>
        /// The course visibility.
        /// </value>
        [JsonProperty("courseVisibility")]
        public string CourseVisibility { get; set; }

        /// <summary>
        /// Gets or sets the activity heart rate visibility.
        /// </summary>
        /// <value>
        /// The activity heart rate visibility.
        /// </value>
        [JsonProperty("activityHeartRateVisibility")]
        public string ActivityHeartRateVisibility { get; set; }

        /// <summary>
        /// Gets or sets the activity power visibility.
        /// </summary>
        /// <value>
        /// The activity power visibility.
        /// </value>
        [JsonProperty("activityPowerVisibility")]
        public string ActivityPowerVisibility { get; set; }

        /// <summary>
        /// Gets or sets the badge visibility.
        /// </summary>
        /// <value>
        /// The badge visibility.
        /// </value>
        [JsonProperty("badgeVisibility")]
        public string BadgeVisibility { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show age].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show age]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showAge")]
        public bool ShowAge { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show weight].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show weight]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showWeight")]
        public bool ShowWeight { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show height].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show height]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showHeight")]
        public bool ShowHeight { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show weight class].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show weight class]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showWeightClass")]
        public bool ShowWeightClass { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show age range].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show age range]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showAgeRange")]
        public bool ShowAgeRange { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show gender].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show gender]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showGender")]
        public bool ShowGender { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show activity class].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show activity class]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showActivityClass")]
        public bool ShowActivityClass { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show vo2 maximum].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show vo2 maximum]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showVO2Max")]
        public bool ShowVo2Max { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show personal records].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show personal records]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showPersonalRecords")]
        public bool ShowPersonalRecords { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show last12 months].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show last12 months]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showLast12Months")]
        public bool ShowLast12Months { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show lifetime totals].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show lifetime totals]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showLifetimeTotals")]
        public bool ShowLifetimeTotals { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show upcoming events].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show upcoming events]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showUpcomingEvents")]
        public bool ShowUpcomingEvents { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show recent favorites].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show recent favorites]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showRecentFavorites")]
        public bool ShowRecentFavorites { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show recent device].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show recent device]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showRecentDevice")]
        public bool ShowRecentDevice { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show recent gear].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show recent gear]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showRecentGear")]
        public bool ShowRecentGear { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show badges].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show badges]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("showBadges")]
        public bool ShowBadges { get; set; }

        /// <summary>
        /// Gets or sets the other activity.
        /// </summary>
        /// <value>
        /// The other activity.
        /// </value>
        [JsonProperty("otherActivity")]
        public object OtherActivity { get; set; }

        /// <summary>
        /// Gets or sets the other primary activity.
        /// </summary>
        /// <value>
        /// The other primary activity.
        /// </value>
        [JsonProperty("otherPrimaryActivity")]
        public object OtherPrimaryActivity { get; set; }

        /// <summary>
        /// Gets or sets the other motivation.
        /// </summary>
        /// <value>
        /// The other motivation.
        /// </value>
        [JsonProperty("otherMotivation")]
        public object OtherMotivation { get; set; }

        /// <summary>
        /// Gets or sets the user roles.
        /// </summary>
        /// <value>
        /// The user roles.
        /// </value>
        [JsonProperty("userRoles")]
        public string[] UserRoles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [name approved].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [name approved]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("nameApproved")]
        public bool NameApproved { get; set; }

        /// <summary>
        /// Gets or sets the full name of the user profile.
        /// </summary>
        /// <value>
        /// The full name of the user profile.
        /// </value>
        [JsonProperty("userProfileFullName")]
        public string UserProfileFullName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [make golf scorecards private].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [make golf scorecards private]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("makeGolfScorecardsPrivate")]
        public bool MakeGolfScorecardsPrivate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow golf live scoring].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow golf live scoring]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("allowGolfLiveScoring")]
        public bool AllowGolfLiveScoring { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow golf scoring by connections].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow golf scoring by connections]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("allowGolfScoringByConnections")]
        public bool AllowGolfScoringByConnections { get; set; }

        /// <summary>
        /// Gets or sets the user level.
        /// </summary>
        /// <value>
        /// The user level.
        /// </value>
        [JsonProperty("userLevel")]
        public long UserLevel { get; set; }

        /// <summary>
        /// Gets or sets the user point.
        /// </summary>
        /// <value>
        /// The user point.
        /// </value>
        [JsonProperty("userPoint")]
        public long UserPoint { get; set; }

        /// <summary>
        /// Gets or sets the level update date.
        /// </summary>
        /// <value>
        /// The level update date.
        /// </value>
        [JsonProperty("levelUpdateDate")]
        public DateTimeOffset LevelUpdateDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [level is viewed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [level is viewed]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("levelIsViewed")]
        public bool LevelIsViewed { get; set; }

        /// <summary>
        /// Gets or sets the level point threshold.
        /// </summary>
        /// <value>
        /// The level point threshold.
        /// </value>
        [JsonProperty("levelPointThreshold")]
        public long LevelPointThreshold { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [user pro].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [user pro]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("userPro")]
        public bool UserPro { get; set; }
    }
}