using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Santander.MvcCalc.Startup))]
namespace Santander.MvcCalc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
