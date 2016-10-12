using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Directorio.Web.Startup))]
namespace Directorio.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
