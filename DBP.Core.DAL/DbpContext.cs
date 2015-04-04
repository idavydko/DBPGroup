using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DBP.Core.Domain.Pages;

namespace DBP.Core.DAL
{
    public class DbpContext : DbContext, IDbContext
    {
        public DbpContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<PageTemplate> PageTemplates { get; set; }

        public string CreateDatabaseScript()
        {
            return ((IObjectContextAdapter) this).ObjectContext.CreateDatabaseScript();
        }
    }
}
