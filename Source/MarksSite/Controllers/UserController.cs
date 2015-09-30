using System;
using System.Linq;
using System.Web.Mvc;
using MarksDal;
using MarksSite.Models;

namespace MarksSite.Controllers
{
    public class UserController : Controller
    {
        private static readonly Repository repository = new Repository();
        //
        // GET: /User/

        public ActionResult List(int userId)
        {
            var users = repository.GetUsers().Where(x => x.Id != userId && !string.IsNullOrEmpty(x.FirstName));
            var userViewModels = users.Select(x => new UserViewModel()
            {
                Email = string.Empty,
                FullName = x.FirstName,
                DomainName = string.Empty,
                IsManager = (bool)x.IsManager,
                Department = string.Empty,
                JobPosition = string.Empty,
            }).ToList();

            return View(userViewModels);
        }
    }
}
