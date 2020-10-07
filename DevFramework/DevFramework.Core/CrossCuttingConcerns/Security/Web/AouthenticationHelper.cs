using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace DevFramework.Core.CrossCuttingConcerns.Security.Web
{
   public class AouthenticationHelper
    {
        public static void CreateAuthCookie(Guid id, string username,
            string email, DateTime expiration, string[] roles, bool rememberMe,
            string firsname, string lastname)
        {

            var authTicket = new FormsAuthenticationTicket(1,username,DateTime.Now,expiration,rememberMe,
                CreateAuthTags(email,roles,firsname,lastname,id));
            string encTicket = FormsAuthentication.Encrypt(authTicket);
            HttpContext.Current.Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName,encTicket));
        }

        private static string CreateAuthTags(string email, string[] roles, string firsname, string lastname, Guid id)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(email);
            stringBuilder.Append("|");
            for (int i = 0; i < roles.Length; i++)
            {
                stringBuilder.Append(roles[i]);
                if (i<roles.Length-1)
                {
                    stringBuilder.Append(",");

                }
            }
            stringBuilder.Append("|");
            stringBuilder.Append(firsname);
            stringBuilder.Append("|");
            stringBuilder.Append(lastname);
            stringBuilder.Append("|");
            stringBuilder.Append(id);
          
            return stringBuilder.ToString();



        }
    }
}
