using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MarksDal;
using MarksSite.Models;

namespace MarksSite.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/                
        private static readonly Repository repository = new Repository();

        public ActionResult Index()
        {
            UserViewModel userViewModel = GetUserByLogin(HttpContext.User.Identity.Name);
            Session["CurrentUser"] = userViewModel;
            //var identity = HttpContext.UserViewModel.Identity;
            return View(userViewModel);
        }


        private static IEnumerable<MarkRequestViewModel> GetRequestsForUser(User user)
        {
            foreach (Mark mark in user.Marks)
            {
                yield return
                    new MarkRequestViewModel
                        {
                            Author = mark.From.FirstName,
                            Date = mark.DateTime,
                            Employee = mark.To.FirstName
                        };
            }
        }

        private static UserViewModel GetUserByLogin(string login)
        {
            User user = repository.GetUserByActivedirectoryId(login);
            List<MarkRequestViewModel> requests = GetRequestsForUser(user).ToList();

            return new UserViewModel
                {
                    Id = user.Id,
                    Email = string.Empty,
                    FullName = user.FirstName,
                    DomainName = string.Empty,
                    IsManager = (bool) user.IsManager,
                    Department = string.Empty,
                    JobPosition = string.Empty,
                    Requests = requests
                };
        }
    }
}