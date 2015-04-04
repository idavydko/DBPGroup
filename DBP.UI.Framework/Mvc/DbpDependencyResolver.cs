
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Autofac;
using DBP.Infrastructure.Core.DependencyManagement;


namespace DBP.UI.Framework.Mvc
{
    public class DbpDependencyResolver : IDependencyResolver
    {
        private readonly IContainer _container;

        public IContainer Container {
            get { return _container; }
        }

        public DbpDependencyResolver(IContainer container)
        {
            _container = container;
        }

        public object GetService(Type serviceType)
        {
            return Scope().ResolveOptional(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            var type = typeof (IEnumerable<>).MakeGenericType(serviceType);
            return (IEnumerable<object>)Scope().Resolve(type);
        }

        private ILifetimeScope Scope()
        {
            try
            {
                return AutofacRequestLifetimeHttpModule.GetLifetimeScope(Container);
            }
            catch (Exception)
            {
                return Container;
            }
        }
    }
}
