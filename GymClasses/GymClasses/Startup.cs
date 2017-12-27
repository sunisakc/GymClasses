using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymClasses.Startup))]
namespace GymClasses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
