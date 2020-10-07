using DevFramework.Core.EntityFramework;
using DevFramework.Db.DataAccess.Abstract;
using DevFramework.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.DataAccess.Concrate.EnttityFramework
{
   public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
