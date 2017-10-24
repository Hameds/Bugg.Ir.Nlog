# Bugg.Ir.Nlog
[![NuGet](https://img.shields.io/nuget/v/Bugg.Ir.NLog.svg)]()

Bugg is a nuget package based on [NLog](https://github.com/NLog/NLog) for logging in ASP.NET projects and sends your ASP.NET project logs to [bugg.ir](https://www.bugg.ir) for better log search & analytics

## Getting started
Bugg is a nuget package, to install Bugg using, run `Install-Package Bugg.Ir.NLog` command in the [Package Manager Console](https://docs.nuget.org/docs/start-here/using-the-package-manager-console)

## Configuration options
after you install Bugg nuget package in your ASP.NET project, you will have two new appsetting keys in your web.config
- BuggAPIKey (Required) : your bugg.ir APIKey (read Get your APIKey section below)
- BuggLevel (Required) : your log level, must be one of these values: Fatal, Error, Warn, Info, Debug, Trace

### Get your APIKey
[bugg.ir](https://bugg.ir) dashboard is currently on private beta. public beta request will be available soon

## How to start logging
Bugg is based on [NLog](https://github.com/NLog/NLog) so you can use NLog tutorial on [logging](https://github.com/NLog/NLog/wiki/Tutorial) 
if you want to automatically log unhandled exceptions in your web application just add [this method](https://gist.github.com/Hameds/6373afcae7d2d317aa16db4d2ca8f524) to your Global.asax file 
