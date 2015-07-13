using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindProject.MvcWebUI.Startup))]
namespace NorthwindProject.MvcWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
