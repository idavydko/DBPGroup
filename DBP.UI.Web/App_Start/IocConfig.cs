
using Autofac;
using DBP.Infrastructure.Core.DependencyManagement;
using DBP.Infrastructure.Core.IocRegistration;

namespace DBP.UI.Web.App_Start
{
    public class IocConfig
    {
        public static ILifetimeScope InitializeContainer()
        {
            var builder = new ContainerBuilder();

            //registre modules
            builder.RegisterModule(new BaseServiceModule());
            builder.RegisterModule(new BaseRepositoryModule());
            builder.RegisterModule(new BaseValidatorModule());

            var container = builder.Build();

            return AutofacRequestLifetimeHttpModule.GetLifetimeScope(container);
        }
    }
}