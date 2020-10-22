using DevFramework.Db.Business.Abstract;
using DevFramework.Db.DataAccess.Abstract;
using DevFramework.Db.Entities.ComlexType;
using DevFramework.Db.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.Business.Concrete.Managers
{
    public class UserManager : IUserServis
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u=>u.UserName==userName& u.Password==password);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }
    }
}
