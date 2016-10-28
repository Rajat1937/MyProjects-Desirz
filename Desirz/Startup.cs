using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Desirz.Startup))]
namespace Desirz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
