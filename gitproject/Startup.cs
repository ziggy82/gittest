using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitproject.Startup))]
namespace gitproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
