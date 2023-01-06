# Demo API .NET 7

Check installed dotnet SDKs
```
dotnet --list-sdks
```
Create WepApi project (with name `DemoApiDotnet7`)
```
dotnet new webapi -o DemoApiDotnet7
```
Commands used (to install packages)
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer 
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-ef
```
Run application
```
dotnet watch run
```

