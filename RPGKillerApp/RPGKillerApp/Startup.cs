using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPGKillerApp.Startup))]
namespace RPGKillerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
