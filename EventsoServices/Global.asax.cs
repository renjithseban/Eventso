using EventsoServices.App_Start;
using Resolver;
using System.Web.Http;

namespace EventsoServices
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Bootstrapper.Initialise();
            AutoMapperConfig.Initialise();
        }
    }
}
