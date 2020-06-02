FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS sdkImage
WORKDIR build
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o output

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR app
COPY --from=sdkImage /build/output .
ENTRYPOINT ["dotnet","CountriesApi.dll"]