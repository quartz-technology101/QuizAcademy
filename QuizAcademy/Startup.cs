using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizAcademy.Startup))]
namespace QuizAcademy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
