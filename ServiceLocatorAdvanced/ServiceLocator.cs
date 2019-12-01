using System.Collections;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Xml;
using System.IO;

namespace ServiceLocatorAdvanced
{
    internal class ServiceLocator
    {
        private static readonly Hashtable services = new Hashtable();

        public static void AddService<T>(T t)
        {
            services.Add(typeof(T).Name, t);
        }

        public static void AddService<T>(string name, T t)
        {
            services.Add(name, t);
        }

        public static T GetService<T>()
        {
            return (T)services[typeof(T).Name];
        }

        public static T GetService<T>(string serviceName)
        {
            return (T)services[serviceName];
        }

        public static void RegisterServiceFromAppSettings(string serviceName)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();


            var loggerEntry = config[serviceName];
            var loggingObject = Assembly.GetExecutingAssembly().CreateInstance(loggerEntry);



            //log4net.ILog log = log4net.LogManager.GetLogger(loggingObject.GetType());
            //XmlDocument log4netConfig = new XmlDocument();
            //log4netConfig.Load(File.OpenRead("log4net.config"));
            //var repo = log4net.LogManager.CreateRepository(
            //Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
            //log4net.Config.XmlConfigurator.Configure(repo, log4netConfig["log4net"]);
            ServiceLocator.AddService(serviceName, loggingObject);
        }
    }
}
