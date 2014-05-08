using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureTestProject.Startup))]
namespace AzureTestProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
