# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [0.9.5] - 2023-06-11

### Added

- Added checking for socket-state and recreation of SocketClient if it was aborted (by server?)

### Fixed

### Changed

- Added Gift-Name to example-code

### Removed

- Removed Icon (in TTLUnity) only used for NuGet-Package

## [0.9.4] - 2023-05-20

### Added

- Added Static GetUserExists & GetUserStreaming-Methods that can be used to check if a user-profile exists and/or is livestreaming
- Added newly found Message-Data (recently added by ByteDance)

### Fixed

- Fixed Message-Data not being logged alongside (some) exceptions

### Changed

- Updated ProtoSchema to reflect updates in messaging

### Removed


## [0.9.3] - 2023-04-29

### Added

- Added newly found Message-Data (recently added by ByteDance)

### Fixed

### Changed

- Changed Message-Data in (Hourly)RankMessages (recently changed by ByteDance)

### Removed

- Disabled downloading of Textures/Sprites in Example-Code for TikTokLiveUnity, as it seems to be leading to random crashes somehow.

## [0.9.2] - 2023-04-25

### Added

- Added newly found Message-Data (recently added by ByteDance)

### Fixed

- Fixed bugs in Disconnect causing disconnect to throw an exception.

### Changed

- Set Assemblies to be auto-referenced, so users do not need their own AssemblyDef to use the project

### Removed

## [0.9.1] - 2023-03-31

### Added

- Added newly found Message-Data (recently added by ByteDance)

### Fixed

- Added overly cautious Null-Checking in Model. Instead of Nullref, data will now simply default to NULL if not available
- Fixed invalid DataType in WebcastRoomPinMessage (Pos 35)

### Changed

- Updated Model based on Protobuf
- Buffer-array for messages is now re-used to minimize garbage
- Connecting-Boolean is now set to False once fully connected

### Removed

- Removed Dispatching for Debug-Logs in Unity, as it is not required and only adds overhead.


## [0.9.0] - 2023-03-11

### Added

- Initial release of new Fork for this Project. Consists of many breaking changes with previous version.

### Fixed

### Changed

### Removed
