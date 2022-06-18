using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VestStore.Startup))]
namespace VestStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
