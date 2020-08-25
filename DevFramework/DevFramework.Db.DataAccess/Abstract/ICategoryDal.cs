using DevFramework.Core.DataAccess;
using DevFramework.Core.EntityFramework;
using DevFramework.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.DataAccess.Abstract
{
    public interface ICategoryDal:IEntitiyRepository<Category>
    {

    }
}
