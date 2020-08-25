using DevFramework.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.Business.Abstract
{
    public interface IProductServis
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);

    }
}
