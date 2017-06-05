using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(smartaction_web.Startup))]
namespace smartaction_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
