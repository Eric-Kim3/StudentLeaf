using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentLeaf.Startup))]
namespace StudentLeaf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
