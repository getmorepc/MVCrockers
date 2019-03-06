using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCrockers.Startup))]
namespace MVCrockers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
