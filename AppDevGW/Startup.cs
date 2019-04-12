using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppDevGW.Startup))]
namespace AppDevGW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
