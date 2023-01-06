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
### [Read more...](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio-code)