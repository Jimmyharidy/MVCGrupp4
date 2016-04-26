using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Grupp4.Startup))]
namespace Grupp4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
