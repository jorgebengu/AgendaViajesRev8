using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgendaViajesRev8.Startup))]
namespace AgendaViajesRev8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
