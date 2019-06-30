using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wine.Startup))]
namespace Wine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
