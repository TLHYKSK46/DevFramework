using DevFramework.Db.Entities;
using DevFramework.Db.Entities.ComlexType;
using DevFramework.Db.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.Business.Abstract
{
    public interface IUserServis
    {
        User GetByUserNameAndPassword(string userName ,string password);
        List<UserRoleItem> GetUserRoles(User user);

    }
}
