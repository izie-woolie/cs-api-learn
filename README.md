# Build REST APIs in .NET 9

Building APIs in .NET frameworkk

## References
- Video:  [Link](https://www.youtube.com/watch?v=38GNKtclDdE)

## Dependencies
1. EntityFrameworkCore
2. EntityFrameworkCore.SqlServer
3. EntityFrameworkCore.Tools

## Create Database Connection
1. View > Server Explorer > Data Connections > Create New SQL Server Database
2. Enter the Server Name from SSMS
3. Set Encrypt to Optional for Fast Access to Database
4. Copy Connection String from Properties
5. Insert into appsettings.json

## Add Migrations
1. Tools > NuGet Package Manager > Package Manager Console
2. Add Migration Using Command
``` 
Add-Migration "<migration name>"
```
3. Press <"Shift-Enter">"

4. Apply Migration To The Database
``` 
Update-Database "<migration name>"
```
5. Press <"Shift-Enter">"
