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
        public List<UserRoleItem> GetUserRoles(User user)
        {
            //dbo.UserRoles
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from ur in context.UsersRoles
                             join r in context.Roles
                             on ur.UserId equals user.Id
                             where ur.UserId == user.Id
                             select new UserRoleItem { RoleName = r.Name };
                return result.ToList();
            }
        }
    }
}
