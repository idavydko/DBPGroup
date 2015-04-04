using System;
using DBP.Core.Domain.Pages;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Collections.Generic;
using System.Data;

namespace DBP.Core.DAL.Pages
{
    public class PageRepository : IPageRepository
    {
        private readonly IDbContext _dbpContext;

        public PageRepository(IDbContext dbpContext)
        {
            _dbpContext = dbpContext;
        }
        //public Page GetPageById(int id)
        //{
        //    var database = DatabaseFactory.CreateDatabase("DefaultConnection");

        //    var command = string.Format("SELECT * FROM Page p WHERE p.PageId = {0}", id);

        //    using(IDataReader reader = database.ExecuteReader(CommandType.Text, command)
        //    {
        //        ReadPageEntities(reader);
        //    }
        //}
        public void A()
        {
            _dbpContext.PageTemplates.Add(new PageTemplate()
                {
                    Id = Guid.NewGuid(),
                    Name = "aaaaaa",
                    Description = "AAAAAAA",
                    CreatedOn = DateTimeOffset.Now
                });
            _dbpContext.SaveChanges();
        }
        //private List<Page> ReadPageEntities(IDataReader reader)
        //{
        //    reader.GetString()
        //}
    }
}
