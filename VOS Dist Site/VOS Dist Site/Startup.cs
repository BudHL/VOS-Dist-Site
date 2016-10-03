using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VOS_Dist_Site.Startup))]
namespace VOS_Dist_Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
