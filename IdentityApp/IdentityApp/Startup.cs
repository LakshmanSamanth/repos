using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityApp.Startup))]
namespace IdentityApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
