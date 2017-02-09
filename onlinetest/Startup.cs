using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onlinetest.Startup))]
namespace onlinetest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
