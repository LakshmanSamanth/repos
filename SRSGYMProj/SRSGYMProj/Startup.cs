using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SRSGYMProj.Startup))]
namespace SRSGYMProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
