#Tech Info
##Packages
Microsoft.AspNetCore.Identity.UI
Microsoft.EntityFrameworkCore.Design

##Packages DataAcces
Microsoft.EntityFrameworkCore 
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.SqlServer

Microsoft.AspNetCore.Identity.EntityFrameworkCore


##Packages Domains
AutoMapper.Extensions.Microsoft.DependencyInjectio

##PM
In Visual Studio, use the Package Manager Console to scaffold a new migration for these changes and apply them to the database:
PM> Add-Migration [migration name]
PM> Update-Database
Alternatively, you can scaffold a new migration and apply it from a command prompt at your project directory:
ls
cd Meg
dotnet ef migrations add [migration name]
dotnet ef database update

## DB Browser for SQLite
https://sqlitebrowser.org/

### for sqlite migrations errors OR restart migrations...
table.Column<string>(nullable:  -> table.Column<string>(maxLength: 256, nullable:
(max) -> (256)
