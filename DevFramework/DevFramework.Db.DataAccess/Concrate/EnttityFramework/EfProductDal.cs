using DevFramework.Core.EntityFramework;
using DevFramework.Db.DataAccess.Abstract;
using DevFramework.Db.Entities;
using DevFramework.Db.Entities.ComlexType;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.DataAccess.Concrate
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext()) {

                var result = from p in context.Products
                             join c in context.Categories on p.CategoryID equals c.CategoryID
                             select new ProductDetail
                             {
                                 ProductId = p.ProductID,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
