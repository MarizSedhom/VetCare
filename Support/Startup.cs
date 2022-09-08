using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Support.Startup))]
namespace Support
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
