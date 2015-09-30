using System;
using System.Collections.Generic;
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
            UserViewModel userViewModel = GetUserByLogin(HttpContext.User.Identity.Name);
            //var identity = HttpContext.UserViewModel.Identity;
            return View(userViewModel);
        }

        
        private static UserViewModel GetUserByLogin(string login)
        {
            using (
                var userContext = new PrincipalContext(
                    ContextType.Domain, ConfigurationWrapper.GetAdDomain(), ConfigurationWrapper.GetAdLogin(),
                    ConfigurationWrapper.GetAdPassword()))
            {
                using (UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(userContext, login))
                {
                    if (userPrincipal != null)
                    {
                        var requests = new List<MarkRequestViewModel>();
                        requests.Add(new MarkRequestViewModel(){Author = "df", Date = DateTime.Now, Employee = "Empl"});
                        requests.Add(new MarkRequestViewModel(){Author = "2", Date = DateTime.Now, Employee = "Empl2"});
                        return new UserViewModel
                            {
                                Email = userPrincipal.EmailAddress,
                                FullName = userPrincipal.DisplayName,
                                DomainName = userPrincipal.UserPrincipalName,
                                IsManager = userPrincipal.IsManager(),
                                Department = userPrincipal.GetDepartment(),
                                JobPosition = userPrincipal.GetJobPosition(),
                                Requests = requests
                            };
                    }
                    return null;
                }
            }
        }
    }
}