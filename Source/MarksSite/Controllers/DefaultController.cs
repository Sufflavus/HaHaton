using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Web.Mvc;
using MarksSite.Extensions;
using MarksSite.Models;
using MarksDal;
using System.Linq;

namespace MarksSite.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/                
        private static Repository repository = new Repository();

        public ActionResult Index()
        {
            UserViewModel userViewModel = GetUserByLogin(HttpContext.User.Identity.Name);
            Session["CurrentUser"] = userViewModel;
            //var identity = HttpContext.UserViewModel.Identity;
            return View(userViewModel);
        }

        
        private static UserViewModel GetUserByLogin(string login)
        {                                    
            var user = repository.GetUserByActivedirectoryId(login);
            var requests = GetRequestsForUser(user).ToList();

            return new UserViewModel
                {
                    Id = user.Id,
                    Email = string.Empty,
                    FullName = user.FirstName,
                    DomainName = string.Empty,
                    IsManager = (bool)user.IsManager,
                    Department = string.Empty,
                    JobPosition = string.Empty,
                    Requests = requests
                };
        }

        private static IEnumerable<MarkRequestViewModel> GetRequestsForUser(User user)
        {
            foreach (var mark in user.Marks)
            {
                yield return new MarkRequestViewModel() { Author = mark.From.FirstName, Date = mark.DateTime, Employee = mark.To.FirstName };
            }
        }
    }
}