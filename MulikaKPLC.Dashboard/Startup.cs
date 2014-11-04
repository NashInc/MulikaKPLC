using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MulikaKPLC.Dashboard.Startup))]
namespace MulikaKPLC.Dashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
