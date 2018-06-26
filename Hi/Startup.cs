using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hi.Startup))]
namespace Hi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
