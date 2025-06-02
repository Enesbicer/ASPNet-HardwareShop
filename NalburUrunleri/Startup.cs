using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NalburUrunleri.Startup))]
namespace NalburUrunleri
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
