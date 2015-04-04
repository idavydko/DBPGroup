
using Autofac;
using Autofac.Integration.Mvc;
using DBP.Core.DAL;
using DBP.Infrastructure.Core.DependencyManagement;
using DBP.Infrastructure.Core.IocRegistration;

namespace DBP.UI.Web.App_Start
{
    public class IocConfig
    {
        public static IContainer InitializeContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register object context
            builder.Register<IDbContext>(c => new DbpContext("DefaultConnection")).InstancePerRequest();

            // Register modules
            builder.RegisterModule(new BaseServiceModule());
            builder.RegisterModule(new BaseRepositoryModule());
            builder.RegisterModule(new BaseValidatorModule());
            
           return builder.Build();
        }
    }
}