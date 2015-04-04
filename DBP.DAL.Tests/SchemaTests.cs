//using Microsoft.VisualStudio.TestTools.UnitTesting;

using DBP.Core.DAL;
using NUnit.Framework;

namespace DBP.DAL.Tests
{
    //[TestClass]
    [TestFixture]
    public class SchemaTests
    {
        //[TestMethod]
        [Test]
        public void CanGenerateSchema()
        {
            var ctx = new DbpContext("DefaultConnection");
            var result = ctx.CreateDatabaseScript();
            Assert.IsNotNull(result);
        }
    }
}
