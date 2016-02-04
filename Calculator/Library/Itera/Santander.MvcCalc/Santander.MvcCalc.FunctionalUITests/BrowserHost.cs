using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using OpenQA.Selenium.Firefox;
using TestStack.Seleno.Configuration;
using TestStack.Seleno.Configuration.WebServers;

namespace Santander.MvcCalc.FunctionalUITests
{
    public static class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        public static readonly string RootUrl;

        static BrowserHost()
        {
            //var directory = new DirectoryInfo(Environment.CurrentDirectory);

            //while (directory.GetFiles("*.sln").Length == 0)
            //{
            //    directory = directory.Parent;
            //}

            //var a = directory.FullName;
            //Instance.Run("Axpo.Price.Web", 12345);

            Instance.Run(
    configure => configure
         .WithRemoteWebDriver(
               () => new FirefoxDriver(
                new FirefoxBinary(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe"),
                new FirefoxProfile(),
                TimeSpan.FromSeconds(180)))
         .UsingLoggerFactory(new ConsoleFactory())
         .WithWebServer(new InternetWebServer("http://axpo-test-env.cloudapp.net"))
         .WithRouteConfig(RouteConfig.RegisterRoutes));

            //Instance.Run("Axpo.Price.Web", 12345,
            //   x => x.WithRouteConfig(RouteConfig.RegisterRoutes).WithRemoteWebDriver(BrowserFactory.Chrome));

            //Instance.Run("Axpo.Price", 9999, x => x.WithRouteConfig(RouteConfig.RegisterRoutes));

            RootUrl = Instance.Application.Browser.Url;
        }
    }
}
