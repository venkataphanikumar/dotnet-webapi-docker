# Running a .NET Core Web API inside Docker

## Run locally
- Navigate to the `src` directory
- `dotnet run .`

## Run in Docker

- Build the image:
`docker build -t smholvoet/dotnet-webapi .`
- Start a new container:
`docker run -p 9000:80 smholvoet/dotnet-webapi`
