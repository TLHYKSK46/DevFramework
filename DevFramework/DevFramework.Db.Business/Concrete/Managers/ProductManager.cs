using DevFramework.Db.Business.Abstract;
using DevFramework.Db.Business.FluentRules.FluentValidation;
using DevFramework.Db.DataAccess.Abstract;
using DevFramework.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Aspects.Postsharp;
namespace DevFramework.Db.Business.Concrete.Managers
{
  public  class ProductManager : IProductServis
    {
        private IProductDal _productDal;

      

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Add(Product product)
        {
            //ValidatorTool.FluentValidate(new MakaleValidatior(),makale);//FLUENT VALİdation bu şekilde de kullanılır ama bu solid e uymuyor onda attirbute olrak yazdık
            return _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p=>p.ProductID==id);
        }
    }
}
