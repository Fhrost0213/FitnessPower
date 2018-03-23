using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FitnessPower.MobileAppService.Startup))]

namespace FitnessPower.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}