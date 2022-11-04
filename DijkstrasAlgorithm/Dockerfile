FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DijkstrasAlgorithm/DijkstrasAlgorithm.csproj", "DijkstrasAlgorithm/"]
RUN dotnet restore "DijkstrasAlgorithm/DijkstrasAlgorithm.csproj"
COPY . .
WORKDIR "/src/DijkstrasAlgorithm"
RUN dotnet build "DijkstrasAlgorithm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DijkstrasAlgorithm.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DijkstrasAlgorithm.dll"]
