# Running a .NET Core Web API inside Docker

## Run locally
- Navigate to the `src` directory
- `dotnet run .`

## Run in Docker

Build image:
`docker build -t smholvoet/dotnet-webapi .`

Run container:
`docker run -p 9000:80 smholvoet/dotnet-webapi`
