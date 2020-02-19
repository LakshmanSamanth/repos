using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityTutorial.Startup))]
namespace IdentityTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
