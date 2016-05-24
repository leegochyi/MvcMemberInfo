using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMemberInfo.Startup))]
namespace MvcMemberInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
