using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(landingPersonal.Startup))]
namespace landingPersonal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
