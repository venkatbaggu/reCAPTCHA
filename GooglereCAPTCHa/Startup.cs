using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GooglereCAPTCHa.Startup))]
namespace GooglereCAPTCHa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
