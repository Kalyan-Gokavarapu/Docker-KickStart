FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /build
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o output

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
copy --from=build /build/output .
ENTRYPOINT ["dotnet", "ConferenceApp.dll"]