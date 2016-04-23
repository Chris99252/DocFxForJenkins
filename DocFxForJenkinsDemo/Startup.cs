using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DocFxForJenkinsDemo.Startup))]
namespace DocFxForJenkinsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
