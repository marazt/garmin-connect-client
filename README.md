# Garmin Connect Client

GarminConnectClient is a library for communication with **GarminConnect**. It allows to list, download and upload Garmin activities. 
It is inspired by https://github.com/La0/garmin-uploader.
 
## Version

- **Version 1.0.1** - 2018-11-29

### Getting Started/Installing

```ps
PM> Install-Package GarminConnectClientNet -Version 1.0.1
```

## Project Description

The solution consists of the following projects:

- **GarminConnectClient.Lib** is the main library containing client.

- **GarminConnectClient.Console** is just a sample that uploads *Movescount* moves data, to *GarminConnect*.

- **GarminConnectClient.Lib.Spec** TODO.


### Prerequisites

- .NET Core 2.0.


### Configuration

#### GarminConnectClient.Lib

- **Username** - Garmin Connect username.
- **Password** - Garmin Connect password.
- **BackupDir** - Name of backup directory.
- **StorageConnectionString** - Connection string of Azure Storage, needed by CloudStorage class. Optional.
- **ContainerName** - Name of Azure Storage container, needed by CloudStorage class. Optional.

#### GarminConnectClient.Console

- **Username** - Garmin Connect username.
- **Password** - Garmin Connect password.
- **BackupDir** - Name of backup directory.
- **StorageConnectionString** - Connection string of Azure Storage, needed by CloudStorage class. Optional.
- **ContainerName** - Name of Azure Storage container, needed by CloudStorage class. Optional.


## Deployment

- Just install package by NuGet.


## Contributing

Any contribution is welcomed.

## Authors

- **Marek Polak** - *Initial work* - [marazt](https://github.com/marazt)

## License

© 2018 Marek Polak. This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgments

- Enjoy it!
- If you want, you can support this project too.