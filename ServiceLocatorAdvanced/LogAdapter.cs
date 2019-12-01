using Microsoft.Extensions.Configuration;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ServiceLocatorAdvanced
{
    public class LogAdapter: ILog
    {
        private static log4net.ILog log =
               log4net.LogManager.GetLogger(typeof(LogAdapter));

        public LogAdapter()
        {
            ConfigureLogger();
        }
        public void Log(string txt)
        {
            log.Info(txt);
        }

        public void LogFormat(string txt, params object[] p)
        {
            log.InfoFormat(txt, p);
        }

        private void ConfigureLogger()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            
            XmlDocument log4netConfig = new XmlDocument();
            log4netConfig.Load(File.OpenRead("log4net.config"));
            var repo = log4net.LogManager.CreateRepository(
                Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
            log4net.Config.XmlConfigurator.Configure(repo, log4netConfig["log4net"]);
        }
    }
}
