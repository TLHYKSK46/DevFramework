using DevFramework.Core.DataAccess;
using DevFramework.Core.EntityFramework;
using DevFramework.Db.Business.Abstract;
using DevFramework.Db.Business.Concrete.Managers;
using DevFramework.Db.DataAccess.Abstract;
using DevFramework.Db.DataAccess.Concrate;
using Ninject.Modules;
using System.Data.Entity;

namespace DevFramework.Db.Business.DependecyResolvers.Ninject
{
    public  class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductServis>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<System.Data.Entity.DbContext>().To<NorthwindContext>();
            
        }
    }
}
