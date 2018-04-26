using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bagisla.Startup))]
namespace Bagisla
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
