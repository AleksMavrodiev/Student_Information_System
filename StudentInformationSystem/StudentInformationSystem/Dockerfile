#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["StudentInformationSystem/StudentInformationSystem.csproj", "StudentInformationSystem/"]
COPY ["StudentInformationSystem.Services/StudentInformationSystem.Services.csproj", "StudentInformationSystem.Services/"]
COPY ["StudentInformationSystem.Web.ViewModels/StudentInformationSystem.Web.ViewModels.csproj", "StudentInformationSystem.Web.ViewModels/"]
COPY ["StudentInformationSystem.Common/StudentInformationSystem.Common.csproj", "StudentInformationSystem.Common/"]
COPY ["StudentInfromationSystem.Data/StudentInfromationSystem.Data.csproj", "StudentInfromationSystem.Data/"]
COPY ["StudentInfromationSystem.Web.Infrastructure/StudentInfromationSystem.Web.Infrastructure.csproj", "StudentInfromationSystem.Web.Infrastructure/"]
RUN dotnet restore "./StudentInformationSystem/./StudentInformationSystem.csproj"
COPY . .
WORKDIR "/src/StudentInformationSystem"
RUN dotnet build "./StudentInformationSystem.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./StudentInformationSystem.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StudentInformationSystem.dll"]