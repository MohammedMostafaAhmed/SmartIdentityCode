using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartIdentity.Startup))]
namespace SmartIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
