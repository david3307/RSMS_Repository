using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcShell1.Startup))]
namespace MvcShell1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
