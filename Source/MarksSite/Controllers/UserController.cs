using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MarksDal;
using MarksSite.Models;

namespace MarksSite.Controllers
{
    public class UserController : Controller
    {
        private static readonly Repository repository = new Repository();
        
        public ActionResult List(int userId)
        {
            IEnumerable<User> users =
                repository.GetUsers().Where(x => x.Id != userId && !string.IsNullOrWhiteSpace(x.FirstName));
            List<UserViewModel> userViewModels = users.Select(x => new UserViewModel
                {
                    Id = x.Id,
                    Email = string.Empty,
                    FullName = x.FirstName,
                    DomainName = string.Empty,
                    IsManager = (bool) x.IsManager,
                    Department = string.Empty,
                    JobPosition = string.Empty,
                }).ToList();

            return View(userViewModels);
        }
    }
}