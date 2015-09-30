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
            var userViewModels = GetUserViewModels(userId);

            return View(userViewModels);
        }

        public ActionResult Rate(int userId)
        {
            var userViewModels = GetUserViewModels(userId);
                return View(userViewModels);
        }
        private static List<UserViewModel> GetUserViewModels(int userId)
        {
            var users =
                repository.GetUsers().Where(x => x.Id != userId && !string.IsNullOrWhiteSpace(x.FirstName));
            var userViewModels = users.Select(x => new UserViewModel
            {
                Id = x.Id,
                Email = string.Empty,
                FullName = x.FirstName,
                DomainName = string.Empty,
                IsManager = (bool) x.IsManager,
                Department = string.Empty,
                JobPosition = string.Empty
            }).ToList();
            return userViewModels;
        }

    }
}