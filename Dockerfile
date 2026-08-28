FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish src/MobilityBridge.Api/MobilityBridge.Api.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:9.0
RUN useradd --system --uid 10001 mobilitybridge
USER mobilitybridge
COPY --from=build /app .
EXPOSE 8080
ENTRYPOINT ["dotnet","MobilityBridge.Api.dll"]
