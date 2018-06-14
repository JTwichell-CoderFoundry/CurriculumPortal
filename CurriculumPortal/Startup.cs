using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CurriculumPortal.Startup))]
namespace CurriculumPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
