# Docker-KickStart
A Docker tutorial to kick start your docker journey

## CountriesApi

#### CountriesApi - Dockerfile
```
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS sdkImage <br/>
WORKDIR build <br/>
COPY . . <br/>
RUN dotnet restore <br/>
RUN dotnet publish -c Release -o output <br/><br/>

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 <br/>
WORKDIR app <br/>
COPY --from=sdkImage /build/output . <br/>
ENTRYPOINT ["dotnet","CountriesApi.dll"] <br/>
```

#### Steps to create custom *countries\api* image:

Navigate to the "\Docker-KickStart\CountriesApi" folder (where the Dockerfile exists)<br/>
`docker build -t countries/api:1.0.0 .` <br/>

###### *Note: You can provide the Dockerfile path if you wish to run the command from a different location*

#### Steps to run a container *countries_api*:

`docker run -d -p 5000:80 --name countries_api countries/api:1.0.0`

#### Accessing the api from the HOST machine

###### *Swagger documentation*
http://localhost:5000/api                     

###### *Get All Countries*
http://localhost:5000/api/countries             

###### *Get All States within a Country*
http://localhost:5000/api/countries/india       

Enjoy :+1:
