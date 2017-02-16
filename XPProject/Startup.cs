using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XPProject.Startup))]
namespace XPProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
