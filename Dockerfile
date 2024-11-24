FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .
RUN dotnet publish -c Release -r linux-x64 -p:PublishReadyToRun=true -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0-noble-chiseled
WORKDIR /app
COPY --from=build /publish /app

EXPOSE 8080
ENTRYPOINT ["./Tarot"]
