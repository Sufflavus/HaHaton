using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarksSite.Models;

namespace MarksSite.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {
            var user = new User() {Name = "Daniel Depho"};

            return View(user);
        }

    }
}
