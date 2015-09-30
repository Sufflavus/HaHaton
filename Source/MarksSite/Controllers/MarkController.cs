using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarksDal;
using MarksSite.Models;

namespace MarksSite.Controllers
{
    public class MarkController : Controller
    {
        //
        // GET: /MarkViewModel/

        public ActionResult List(int userId)
        {
            var toName = "Кого оценили";
            var details = new MarkDetailsViewModel()
            {
                Cooperation = new MarkPropertyViewModel("O", ""),
                Discipline = new MarkPropertyViewModel("O", ""),
                Growth = new MarkPropertyViewModel("O", ""),
                Productivity = new MarkPropertyViewModel("O", ""),
                Quality = new MarkPropertyViewModel("O", ""),
                Skills = new MarkPropertyViewModel("O", ""),
                Initiative = new MarkPropertyViewModel("O", "")
            };
            var mark = new MarkViewModel()
            {
                From= "Кто оценил" ,
                To=toName,
                Date = DateTime.Today,
                MarkDetails = details
            };
            var list = new List<MarkViewModel>();
            list.Add(mark);
            return View(list);
        }

    }
}
