
using Autofac;
using DBP.Core.BL.Services.Page;

namespace DBP.Infrastructure.Core.IocRegistration
{
    public class BaseServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Register services
            builder.RegisterType<PageService>().As<IPageService>().InstancePerRequest();
        }
    }
}
