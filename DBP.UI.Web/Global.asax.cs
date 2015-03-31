using System.Web.Mvc;
using System.Web.Routing;
using DBP.UI.Web.App_Start;

namespace DBP.UI.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //
            IocConfig.InitializeContainer();

            //set dependency resolver
            var dependencyResolver = new DependencyResolver();
            DependencyResolver.SetResolver(dependencyResolver);

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
