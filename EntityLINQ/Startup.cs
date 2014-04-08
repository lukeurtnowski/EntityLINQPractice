using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityLINQ.Startup))]
namespace EntityLINQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
