--- What is bugg?
Bugg is based on NLog (https://github.com/NLog/NLog) and sends your ASP.NET project logs to https://www.bugg.ir for better log search & analytics

--- Configuration options
after you install Bugg nuget package in your ASP.NET project, you will have two new appsetting keys in your web.config
	- BuggAPIKey (Required) : your bugg.ir APIKey (read Get your APIKey section below)
	- BuggLevel  (Required) : your log level, must be one of these values: Fatal, Error, Warn, Info, Debug, Trace

--- Get your APIKey
request APIKey from https://www.bugg.ir	

--- How to start logging
Bugg is based on NLog (https://github.com/NLog/NLog) so you can use NLog tutorial on logging (https://github.com/NLog/NLog/wiki/Tutorial)
if you want to automatically log unhandled exceptions in your web application just add method below to your Global.asax file

	protected void Application_Error()
	{
		Exception lastException = Server.GetLastError();
		NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
		logger.Fatal(lastException);
	}

--- Contribute
Bugg source code is available on github (https://github.com/Hameds/Bugg.Ir.Nlog)

Made with ♥ in Iran  