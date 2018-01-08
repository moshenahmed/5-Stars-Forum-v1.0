using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5_Star_Forum.Startup))]
namespace _5_Star_Forum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
