using System.Web.Mvc;
using System.Web.Routing;
using Autofac.Integration.Mvc;
using DBP.UI.Framework.Mvc;
using DBP.UI.Web.App_Start;

namespace DBP.UI.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //initialize IoC
            var container = IocConfig.InitializeContainer();

            //set dependency resolver
            var dependencyResolver = new DbpDependencyResolver(container);
            DependencyResolver.SetResolver(dependencyResolver);//new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
