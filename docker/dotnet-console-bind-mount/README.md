# Running console app as bind mount

`cd app`

`docker run -it -w /app -v "$(pwd):/app" --name consoleapp mcr.microsoft.com/dotnet/sdk:6.0 bash -c "dotnet build & dotnet run"`

`docker inspect consoleapp`

# Running web app as bind mount

`cd web`

`docker run -it -p 5253:5253 -v "$(pwd):/web/ww" -w "/web" --name webapp mcr.microsoft.com/dotnet/sdk:6.0 /bin/bash`

`dotnet run`

# We have no Dockerfile !!!