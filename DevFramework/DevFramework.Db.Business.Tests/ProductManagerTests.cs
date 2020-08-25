using DevFramework.Db.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DevFramework.Db.Business.Concrete.Managers;
using DevFramework.Db.Entities;
using FluentValidation;

namespace DevFramework.Db.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check() {
            Mock<IProductDal> mock = new Mock<IProductDal>();

            ProductManager productManager = new ProductManager(mock.Object);

            productManager.Add(new Product());
        
        }
    }
}
