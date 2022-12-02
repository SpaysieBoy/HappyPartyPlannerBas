using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HappyPartyPlannerBas.Startup))]
namespace HappyPartyPlannerBas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
