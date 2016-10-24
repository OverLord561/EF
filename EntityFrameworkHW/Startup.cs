using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityFrameworkHW.Startup))]
namespace EntityFrameworkHW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
