using DevFramework.Core.CrossCuttingConcerns.Security.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevFramework.Db.MvcWebUl.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public String Login()
        {
            AouthenticationHelper.CreateAuthCookie(
                new Guid(),
                "talhayuksek",
                "talha.yuksek@yaani.com",
                DateTime.Now.AddDays(15),
                new[] { "SuperAdmin"},
                false,
                "Talha",
                "Yüksek"
                );

            return  "Kullanıcı Giriş Yaptı!";
        }
    }
}