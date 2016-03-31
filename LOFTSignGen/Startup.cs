using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LOFTSignGen.Startup))]
namespace LOFTSignGen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
