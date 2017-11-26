using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrintingSystem.Startup))]
namespace PrintingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
