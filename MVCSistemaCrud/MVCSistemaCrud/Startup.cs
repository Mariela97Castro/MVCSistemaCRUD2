using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSistemaCrud.Startup))]
namespace MVCSistemaCrud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
