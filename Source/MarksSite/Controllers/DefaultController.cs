using System.DirectoryServices.AccountManagement;
using System.Web.Mvc;
using MarksSite.Extensions;
using MarksSite.Models;

namespace MarksSite.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {
            User user = GetUserByLoginOrDefault(HttpContext.User.Identity.Name);
            //var identity = HttpContext.User.Identity;
            return View(user);
        }

        /// <summary>
        ///     Получить пользователя из AD по логину.
        /// </summary>
        /// <param name="login">Логин пользователя в AD.</param>
        /// <returns>Пользователь из AD.</returns>
        private static User GetUserByLoginOrDefault(string login)
        {
            using (
                var userContext = new PrincipalContext(
                    ContextType.Domain, "infotecs-nt", "lr.knowledge.base", ",jrcnfgjx"))
            {
                using (UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(userContext, login))
                {
                    if (userPrincipal != null)
                    {
                        return new User
                            {
                                Email = userPrincipal.EmailAddress,
                                FullName = userPrincipal.DisplayName,
                                DomainName = userPrincipal.UserPrincipalName,
                                IsManager = userPrincipal.IsManager(),
                                Department = userPrincipal.GetDepartment(),
                                JobPosition = userPrincipal.GetJobPosition()
                            };
                    }
                    return null;
                }
            }
        }
    }
}