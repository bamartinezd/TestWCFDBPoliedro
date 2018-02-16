using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWCFDBPoliedro.GUI.MvcFront.Startup))]
namespace TestWCFDBPoliedro.GUI.MvcFront
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
