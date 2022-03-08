# Albert Rick Martires
##  Sample Chatter

## Tech
- Angular for Front-End
- .NET 5 for Back-End
- Entity Framework Core (ORM)
- SQL Server for Database

## Required Tools
VS Code - requirements for Angular and .NET development
SQL Server - requirements for Database
Postman/Curl - to test API
Install latest version of Node.JS

## Setting up SQL Database
Run sql database script 
```sh
SQLScripts\SampleChatterDb.sql
```

## Setup configurations
Create a copy of the following configuration files
```sh
ApiService\appsettings - Sample,json -> appsettings.json
ApiService\appsettings.Development - Sample,json -> appsettings.Development.json
ApiService\nlog - Sample,config -> nlog.config
```
Change database connection string configuration in `appsettings.Development.json`
```
"ConnectionStrings": {
    "DefaultConnection": "Server=[servername];Database=[dbname];Trusted_Connection=True;"
}
```

## Run the codes
In VSCode Terminal, change the directory to `ApiService` then type the following command to build and run the application
```
dotnet run
```

## Setting up the Development Environment
In VSCode Terminal, change the directory `ApiService` then type the following command to restore nuget packages
```
dotnet restore
```
Then go to `ApiService\ClientApp` run the following command to install npm packages
```
npm install
```

## Build and Deployment
In VSCode Terminal, change the directory to `ApiService\ClientApp` then type following command build the Angular app to production
```
ng build --prod
```
Then change the directory to `ApiService` then type the following command to build and deploy the ApiService project along with the published Angular app
```
dotnet publish --configuration Release
```

**Done!**
