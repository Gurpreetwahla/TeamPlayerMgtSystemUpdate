using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamPlayerMgtSystemUpdate.Startup))]
namespace TeamPlayerMgtSystemUpdate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
