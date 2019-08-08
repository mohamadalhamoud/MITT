using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InstituteWithRoles.Startup))]
namespace InstituteWithRoles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
