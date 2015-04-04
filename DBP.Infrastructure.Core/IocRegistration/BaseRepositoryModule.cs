using Autofac;
using DBP.Core.DAL.Pages;

namespace DBP.Infrastructure.Core.IocRegistration
{
    public class BaseRepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Register repositories
            builder.RegisterType<PageRepository>().As<IPageRepository>().InstancePerRequest();
        }
    }
}
