using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Tienda.Startup))]
namespace Tienda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
