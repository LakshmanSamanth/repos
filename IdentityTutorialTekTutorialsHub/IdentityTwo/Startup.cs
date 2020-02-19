using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityTwo.Startup))]
namespace IdentityTwo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
