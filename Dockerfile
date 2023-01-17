# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ["WebAPI/WebAPI.csproj", "WebAPI/"]
COPY ["DAL/DAL.csproj", "DAL/"]
COPY ["BLL/BLL.csproj", "BLL/"]
RUN dotnet restore WebAPI/WebAPI.csproj

COPY WebAPI/. ./WebAPI
COPY DAL/. ./DAL
COPY BLL/. ./BLL
RUN dotnet publish WebAPI/WebAPI.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "WebAPI.dll"]