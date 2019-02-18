using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamKanBan.Startup))]
namespace TeamKanBan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
