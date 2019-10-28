using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdministradorDeSazon.Startup))]
namespace AdministradorDeSazon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
