using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Bugg.Ir.NLog
{
    public class ConfigManager
    {
        public static LoggingConfiguration GetBuggNLogConfig()
        {
            var config = new LoggingConfiguration();

            var buggTarget = new WebServiceTarget();
            config.AddTarget("bugg", buggTarget);
            buggTarget.Url = new Uri("https://www.bugg.ir/api/log");
            buggTarget.Protocol = WebServiceProtocol.HttpPost;
            buggTarget.Encoding = Encoding.UTF8;

            //Log Parameters for ASP.NET projects
            foreach (var logParatmer in Model.NLogModel)
            {                
                buggTarget.Parameters.Add(new MethodCallParameter(logParatmer.Item1, logParatmer.Item2, typeof(System.String)));                
            }

            string buggAPIKey = ConfigurationManager.AppSettings["BuggAPIKey"]??"";
            buggTarget.Parameters.Add(new MethodCallParameter("APIKeyId", buggAPIKey, typeof(System.String)));

            string buggLevel= ConfigurationManager.AppSettings["BuggLevel"]??"Trace";
            var logLevel = LogLevel.AllLevels.Where(c => c.Name.ToLower() == buggLevel.ToLower()).SingleOrDefault()??LogLevel.Trace;

            var buggLogRule = new LoggingRule("*", logLevel, buggTarget);
            config.LoggingRules.Add(buggLogRule);

            return config;
        }
    }
}
