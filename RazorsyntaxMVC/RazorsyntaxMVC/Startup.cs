using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RazorsyntaxMVC.Startup))]
namespace RazorsyntaxMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
