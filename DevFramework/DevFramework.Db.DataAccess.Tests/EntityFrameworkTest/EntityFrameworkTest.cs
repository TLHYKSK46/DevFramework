using DevFramework.Db.DataAccess.Concrate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.Db.DataAccess.Tests.EntityFrameworkTest
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_return_all_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList();


            Assert.AreEqual(result.Count,result.Count);
        }
        [TestMethod]
        public void Get_all_with_parameter_return_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList(p=>p.ProductName.Contains("ab"));


            Assert.AreEqual(4, result.Count);
        }
   
    }
}
