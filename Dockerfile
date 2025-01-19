FROM mcr.microsoft.com/dotnet/sdk:8.0.101 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsofot.com/dotnet/aspnet:8.0.101
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "blogging-platform.dll"]