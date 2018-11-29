using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoachIT.MVC.Startup))]
namespace CoachIT.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
