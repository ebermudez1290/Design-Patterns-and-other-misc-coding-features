using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Learning_project.Startup))]
namespace Learning_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
