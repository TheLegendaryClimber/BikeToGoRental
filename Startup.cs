using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BikeToGoRental.Startup))]
namespace BikeToGoRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
