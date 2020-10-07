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
using DevFramework.Core.Aspects.Postsharp.VaidationAspects;
using DevFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using DevFramework.Core.Aspects.Postsharp.CacheAspects;
using DevFramework.Core.CrossCuttingConcerns.Loging.Log4Net.Loggers;
using DevFramework.Core.Aspects.Postsharp.LogAspects;

namespace DevFramework.Db.Business.Concrete.Managers
{
    [LogAspect(typeof(DatabaseLogger))]
    public  class ProductManager : IProductServis
    {
        private IProductDal _productDal;


     
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProductValidatior))]
        [CacheRemoveAspect(typeof(MemoryCachManager))]
        //[LogAspect(typeof(FileLogger))]
        //[LogAspect(typeof(DatabaseLogger))]//log yapma veritabanı
        public Product Add(Product product)
        {
            //ValidatorTool.FluentValidate(new MakaleValidatior(),makale);//FLUENT VALİdation bu şekilde de kullanılır ama bu solid e uymuyor onda attirbute olrak yazdık
            return _productDal.Add(product);
        }
        [CacheAspect(typeof(MemoryCachManager))]
        //[LogAspect(typeof(FileLogger))]//log yapma dosya
        //[LogAspect(typeof(DatabaseLogger))]//log yapma veritabanı
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p=>p.ProductID==id);
        }
        //transection tek metod da birden fazla işlem yapmaya yarıyor
        public void TransectionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            _productDal.Update(product2);
        }
    }
}
