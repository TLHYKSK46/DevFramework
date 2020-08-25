using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess;
using DevFramework.Core.EntityFramework;
using DevFramework.Db.Entities;
using DevFramework.Db.Entities.ComlexType;

namespace DevFramework.Db.DataAccess.Abstract
{

    public interface IProductDal: IEntitiyRepository<Product>
    {
        List<ProductDetail> GetProductDetails();

    }
}
