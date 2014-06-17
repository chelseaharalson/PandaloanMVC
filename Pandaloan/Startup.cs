using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pandaloan.Startup))]
namespace Pandaloan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
