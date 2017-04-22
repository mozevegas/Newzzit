using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Newzzit.Startup))]
namespace Newzzit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
