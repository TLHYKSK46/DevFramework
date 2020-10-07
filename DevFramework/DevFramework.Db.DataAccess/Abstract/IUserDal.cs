using DevFramework.Core.DataAccess;
using DevFramework.Db.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.DataAccess.Abstract
{
   public interface IUserDal: IEntitiyRepository<User>
    {
    }
}
