#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/BlackJack.Cli/BlackJack.Cli.csproj", "src/BlackJack.Cli/"]
COPY ["src/BlackJack.Domain/BlackJack.Domain.csproj", "src/BlackJack.Domain/"]
RUN dotnet restore "./src/BlackJack.Cli/./BlackJack.Cli.csproj"
COPY . .
WORKDIR "/src/src/BlackJack.Cli"
RUN dotnet build "./BlackJack.Cli.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./BlackJack.Cli.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlackJack.Cli.dll"]