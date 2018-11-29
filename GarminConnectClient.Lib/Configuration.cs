using Microsoft.Extensions.Configuration;

namespace GarminConnectClient.Lib
{
    /// <inheritdoc />
    /// <summary>
    /// Configuration
    /// </summary>
    /// <seealso cref="T:GarminConnectClient.Lib.IConfiguration" />
    public class Configuration : IConfiguration
    {
        // ReSharper disable once InconsistentNaming
        private readonly IConfigurationRoot root;

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration"/> class.
        /// </summary>
        /// <param name="root">The root.</param>
        public Configuration(IConfigurationRoot root)
        {
            this.root = root;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username => this.root["AppConfig:Username"];

        /// <inheritdoc />
        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password => this.root["AppConfig:Password"];

        /// <inheritdoc />
        /// <summary>
        /// Gets the backup dir.
        /// </summary>
        /// <value>
        /// The backup dir.
        /// </value>
        public string BackupDir => this.root["AppConfig:BackupDir"];

        /// <inheritdoc />
        /// <summary>
        /// Gets the storage connection string.
        /// </summary>
        /// <value>
        /// The storage connection string.
        /// </value>
        public string StorageConnectionString => this.root["AppConfig:StorageConnectionString"];

        /// <inheritdoc />
        /// <summary>
        /// Gets the name of the container.
        /// </summary>
        /// <value>
        /// The name of the container.
        /// </value>
        public string ContainerName => this.root["AppConfig:ContainerName"];
    }
}