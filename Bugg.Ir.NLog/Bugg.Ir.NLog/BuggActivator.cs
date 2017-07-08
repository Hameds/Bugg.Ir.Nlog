using NLog;
using System;
using System.Configuration;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(Bugg.Ir.NLog.BuggActivator), "Start",Order =10)]


namespace Bugg.Ir.NLog
{
    public static class BuggActivator
    {
        /// <summary>Integrates Bugg when the application starts.</summary>
        public static void Start()
        {
            LogManager.Configuration = Bugg.Ir.NLog.ConfigManager.GetBuggNLogConfig();
           
        }
    }
}
