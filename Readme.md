# Source
### Crete root project folder
> mkdir app

All the commands bellow will be executed in this root project folder
## Docker SDK .NET

### geting image
> docker pull mcr.microsoft.com/dotnet/sdk:5.0-buster-slim

### creating Solution
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet new sln -n app

### creating API project in Services folder
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet new webapi -n Services
### add API project in Solution
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet sln add Services

### creating Class Libraries
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet new classlib -n Application
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet new classlib -n Domain
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet new classlib -n Domain.Core
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet new classlib -n Domain.Service
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet new classlib -n Infraestructure
### add Class Libraries in Solution
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet sln add Application
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet sln add Domain
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet sln add Domain.Core
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet sln add Domain.Service
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet sln add Infraestructure

### installing Autofac package (IOC)
#### na pasta Infraestructure
> docker run --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet add package Autofac

### building application
With this command you can generate bin folder in app folder:
> docker run --rm -v $(pwd):/app -w /app/Services mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet build
### running application
Run this command on app folder:
> docker run --rm -it -p 8000:80 -v $(pwd):/app/ -w /app/Services -e ASPNETCORE_URLS=http://+:80 -e ASPNETCORE_ENVIRONMENT=Development mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet run --no-launch-profile

## Add DB Dependencies into Infraestructure
### installing Microsoft.EntityFrameworkCore package
> docker run --rm -v $(pwd):/app -w /app/Infraestructure mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet add package Microsoft.EntityFrameworkCore --version 5
### installing Microsoft.EntityFrameworkCore.SqlServer package
> docker run --rm -v $(pwd):/app -w /app/Infraestructure mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5
### installing Microsoft.EntityFrameworkCore.Tools package
> docker run --rm -v $(pwd):/app -w /app/Infraestructure mcr.microsoft.com/dotnet/sdk:5.0-buster-slim dotnet add package Microsoft.EntityFrameworkCore.Tools --version=5

## Docker SQL SERVER
### geting image
> docker pull mcr.microsoft.com/mssql/server:2019-latest
### creating volume container
> docker create -v /var/opt/mssql --name mssqldata  mcr.microsoft.com/mssql/server:2019-latest /bin/true
### running container
> docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=eK@%UbHH" -p 1433:1433 --volumes-from mssqldata --name sql-server -d mcr.microsoft.com/mssql/server:2019-latest
> SA_PASSWORD needs to attend sql server policy
### install SQL server extension on VS Code
#### click on Add Connection on SQL Server extension tab
> use localhost as hostname, sa as user, SA_PASSWORD content as password and give a name to your connection

## Dockerfile - development
> https://www.pluralsight.com/blog/software-development/how-to-build-custom-containers-dockercd

