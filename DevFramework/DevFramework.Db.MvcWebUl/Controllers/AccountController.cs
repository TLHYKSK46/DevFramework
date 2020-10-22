using DevFramework.Core.CrossCuttingConcerns.Security.Web;
using DevFramework.Db.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevFramework.Db.MvcWebUl.Controllers
{
    public class AccountController : Controller
    {
        IUserServis _userServis;

        public AccountController(IUserServis userServis)
        {
            _userServis = userServis;
        }

        // GET: Account
        public String Login(string userName,string password)
        {
            var user = _userServis.GetByUserNameAndPassword(userName,password);
            if (user!=null)
            {
                AouthenticationHelper.CreateAuthCookie(
                new Guid(),
                user.UserName,
                user.Email,
                DateTime.Now.AddDays(15),
                _userServis.GetUserRoles(user).Select(u=>u.RoleName).ToArray(),
                false,
                user.FirsName,
                user.LastName
                );
                return "Kullanıcı Giriş Yaptı!";
            }


            return "Kullanıcı Yok";
            
        }
    }
}