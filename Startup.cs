using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4200Team4.Startup))]
namespace MIS4200Team4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
