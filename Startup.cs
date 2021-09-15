using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Juan_Cronje___7987___SA.Startup))]
namespace Juan_Cronje___7987___SA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
