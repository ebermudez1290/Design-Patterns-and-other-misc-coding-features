using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Design_Patters.Startup))]
namespace Design_Patters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
