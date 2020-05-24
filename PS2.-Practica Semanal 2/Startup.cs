using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PS2._Practica_Semanal_2.Startup))]
namespace PS2._Practica_Semanal_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
