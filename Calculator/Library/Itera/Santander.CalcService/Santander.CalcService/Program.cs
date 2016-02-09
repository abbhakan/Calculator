using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using Topshelf;
using Santander.CalcService;

namespace Santander.CalcService
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.ConfigureAndWatch(new FileInfo(".\\log4net.config"));

            HostFactory.Run(x =>
            {
                x.Service<CalcService>(s =>
                {
                    s.ConstructUsing(name => new CalcService());
                    s.WhenStarted(tc =>
                    {
                        XmlConfigurator.ConfigureAndWatch(new FileInfo(".\\log4net.config"));
                        tc.Start();

                    });
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("Sample Topshelf Host");
                x.SetDisplayName("CalcService");
                x.SetServiceName("CalcService");
            });
        }
    }
}
