using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MidTerm.Startup))]
namespace MidTerm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
