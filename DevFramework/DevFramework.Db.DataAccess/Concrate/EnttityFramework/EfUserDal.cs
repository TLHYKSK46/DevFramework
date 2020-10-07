using DevFramework.Core.EntityFramework;
using DevFramework.Db.DataAccess.Abstract;
using DevFramework.Db.Entities;
using DevFramework.Db.Entities.ComlexType;
using DevFramework.Db.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.DataAccess.Concrate
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
      
    }
}
