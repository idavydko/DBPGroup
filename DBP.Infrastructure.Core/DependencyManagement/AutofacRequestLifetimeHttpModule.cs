using System;
using System.Web;
using Autofac;

namespace DBP.Infrastructure.Core.DependencyManagement
{
    /// <summary>
    /// An <see cref="IHttpModule"/> and <see cref="ILifetimeScopeProvider"/> implementation 
    /// that creates a nested lifetime scope for each HTTP request.
    /// </summary>
    public class AutofacRequestLifetimeHttpModule : IHttpModule
    {
        /// <summary>
        /// Tag used to identify registrations that are scoped to the HTTP request level.
        /// </summary>
        //in the previous versions of Autofac (for MVC3) it was set to "httpRequest"
        public static readonly object HttpRequestTag = "AutofacWebRequest";

        /// <summary>
        /// Initializes a module and prepares it to handle requests.
        /// </summary>
        /// <param name="context">An <see cref="T:System.Web.HttpApplication"/> that provides access to the 
        /// methods, properties, and events common to all application objects within an ASP.NET application</param>
        public void Init(HttpApplication context)
        {
            context.EndRequest += ContextEndRequest;
        }

        /// <summary>
        /// Gets a nested lifetime scope that services can be resolved from.
        /// </summary>
        /// <param name="container">The parent container.</param>
        /// <param name="configurationAction">Action on a <see cref="ContainerBuilder"/>
        /// that adds component registations visible only in nested lifetime scopes.</param>
        /// <returns>A new or existing nested lifetime scope.</returns>
        public static ILifetimeScope GetLifetimeScope(ILifetimeScope container)
        {
            //little hack here to get dependencies when HttpContext is not available
            if (HttpContext.Current != null)
            {
                return LifetimeScope ?? (LifetimeScope = InitializeLifetimeScope(container));
            }
            else
            {
                //throw new InvalidOperationException("HttpContextNotAvailable");
                return InitializeLifetimeScope(container);
            }
        }

        static ILifetimeScope LifetimeScope
        {
            get { return (ILifetimeScope)HttpContext.Current.Items[typeof(ILifetimeScope)]; }
            set { HttpContext.Current.Items[typeof(ILifetimeScope)] = value; }
        }

        /// <summary>
        /// Disposes of the resources (other than memory) used by the module that implements <see cref="T:System.Web.IHttpModule"/>.
        /// </summary>
        public void Dispose()
        {
        }

        public static void ContextEndRequest(object sender, EventArgs e)
        {
            var lifetimeScope = LifetimeScope;
            if (lifetimeScope != null)
                lifetimeScope.Dispose();
        }

        static ILifetimeScope InitializeLifetimeScope(ILifetimeScope container)
        {
            return container.BeginLifetimeScope(HttpRequestTag);
        }
    }
}
