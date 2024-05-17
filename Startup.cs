using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vada.Startup))]
namespace Vada
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
