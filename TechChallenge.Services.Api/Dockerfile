#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TechChallenge.Services.Api/TechChallenge.Services.Api.csproj", "TechChallenge.Services.Api/"]
COPY ["TechChallenge.Application/TechChallenge.Application.csproj", "TechChallenge.Application/"]
COPY ["TechChallenge.Domain/TechChallenge.Domain.csproj", "TechChallenge.Domain/"]
COPY ["TechChallenge.Domain.Core/TechChallenge.Domain.Core.csproj", "TechChallenge.Domain.Core/"]
COPY ["TechChallenge.Infra.Cache.MongoDb/TechChallenge.Infra.Cache.MongoDb.csproj", "TechChallenge.Infra.Cache.MongoDb/"]
COPY ["TechChallenge.Infra.Data.SqlServer/TechChallenge.Infra.Data.SqlServer.csproj", "TechChallenge.Infra.Data.SqlServer/"]
RUN dotnet restore "./TechChallenge.Services.Api/TechChallenge.Services.Api.csproj"
COPY . .
WORKDIR "/src/TechChallenge.Services.Api"
RUN dotnet build "./TechChallenge.Services.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./TechChallenge.Services.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TechChallenge.Services.Api.dll"]