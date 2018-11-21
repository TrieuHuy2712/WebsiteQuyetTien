using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DienMayWebsiteQuyetTien.Startup))]
namespace DienMayWebsiteQuyetTien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
