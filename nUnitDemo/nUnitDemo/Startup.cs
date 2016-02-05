using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nUnitDemo.Startup))]
namespace nUnitDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
