using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VOCE_TEVA_Asthma_Single_Page_Website.Startup))]
namespace VOCE_TEVA_Asthma_Single_Page_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
