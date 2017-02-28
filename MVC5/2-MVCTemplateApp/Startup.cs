using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2_MVCTemplateApp.Startup))]
namespace _2_MVCTemplateApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
