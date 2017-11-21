using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvenanceWeb.Startup))]
namespace ProvenanceWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
