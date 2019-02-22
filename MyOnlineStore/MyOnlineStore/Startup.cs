using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyOnlineStore.Startup))]
namespace MyOnlineStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
