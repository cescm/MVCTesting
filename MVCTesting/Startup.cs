using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTesting.Startup))]
namespace MVCTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
