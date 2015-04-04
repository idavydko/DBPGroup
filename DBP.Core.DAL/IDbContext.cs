
using System.Data.Entity;
using DBP.Core.Domain.Pages;

namespace DBP.Core.DAL
{
    public interface IDbContext
    {
        int SaveChanges();

        DbSet<Page> Pages { get; set; }
        DbSet<PageTemplate> PageTemplates { get; set; }
    }
}
