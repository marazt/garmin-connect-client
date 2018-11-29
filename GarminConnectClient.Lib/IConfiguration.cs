namespace GarminConnectClient.Lib
{
    /// <summary>
    /// Configuration interface
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        string Username { get; }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        string Password { get; }

        /// <summary>
        /// Gets the backup dir.
        /// </summary>
        /// <value>
        /// The backup dir.
        /// </value>
        string BackupDir { get; }

        /// <summary>
        /// Gets the storage connection string.
        /// </summary>
        /// <value>
        /// The storage connection string.
        /// </value>
        string StorageConnectionString { get; }

        /// <summary>
        /// Gets the name of the container.
        /// </summary>
        /// <value>
        /// The name of the container.
        /// </value>
        string ContainerName { get; }
    }
}