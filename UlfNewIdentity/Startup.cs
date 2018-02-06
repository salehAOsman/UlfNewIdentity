using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UlfNewIdentity.Startup))]
namespace UlfNewIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
