using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cgaFinaldotNet.Startup))]
namespace cgaFinaldotNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
