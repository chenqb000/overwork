using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1351300360陈前标.Startup))]
namespace _1351300360陈前标
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
