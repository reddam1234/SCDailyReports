using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCDailyReport.Startup))]
namespace SCDailyReport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
