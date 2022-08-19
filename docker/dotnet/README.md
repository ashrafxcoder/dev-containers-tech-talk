# C# (.NET)

*Develop C# and .NET based applications. Includes all needed SDKs, extensions, and dependencies.*

## Using this definition

While this definition should work unmodified, you can select the version of .NET / .NET Core the container uses by updating the `VARIANT` arg in the included `devcontainer.json` (and rebuilding if you've already created the container).

```json
// Or you can use 3.1-bullseye or 3.1-focal if you want to pin to an OS version
"args": { "VARIANT": "3.1" }
```

Note that .NET 6.0 has switched its default OS to Debian 12 / bullseye.

- `mcr.microsoft.com/vscode/devcontainers/dotnet` (latest)
- `mcr.microsoft.com/vscode/devcontainers/dotnet:3.1` (or `3.1-bullseye`, `3.1-focal` to pin to an OS version)
- `mcr.microsoft.com/vscode/devcontainers/dotnet:6.0` (or `6.0-bullseye`, `6.0-focal` to pin to an OS version)

### Debug Configuration

Only the integrated terminal is supported by the Remote - Containers extension. You may need to modify your `.vscode/launch.json` configurations to include the following:

```json
"console": "integratedTerminal"
```

# Run

`dotnet watch --no-hot-reload`

Only for new projects - Just for testing, better to mount it from Host OS
`dotnet dev-certs https`