using Newtonsoft.Json;
using System;

namespace GarminConnectClient.Lib.Dto
{
    /// <summary>
    /// Activity image
    /// </summary>
    public class ActivityImage
    {
        /// <summary>
        /// Gets or sets the image identifier.
        /// </summary>
        /// <value>
        /// The image identifier.
        /// </value>
        [JsonProperty("imageId")]
        public string ImageId { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// Gets or sets the small URL.
        /// </summary>
        /// <value>
        /// The small URL.
        /// </value>
        [JsonProperty("smallUrl")]
        public Uri SmallUrl { get; set; }

        /// <summary>
        /// Gets or sets the medium URL.
        /// </summary>
        /// <value>
        /// The medium URL.
        /// </value>
        [JsonProperty("mediumUrl")]
        public Uri MediumUrl { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>
        /// The latitude.
        /// </value>
        [JsonProperty("latitude")]
        public object Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>
        /// The longitude.
        /// </value>
        [JsonProperty("longitude")]
        public object Longitude { get; set; }

        /// <summary>
        /// Gets or sets the photo date.
        /// </summary>
        /// <value>
        /// The photo date.
        /// </value>
        [JsonProperty("photoDate")]
        public DateTimeOffset PhotoDate { get; set; }
    }
}