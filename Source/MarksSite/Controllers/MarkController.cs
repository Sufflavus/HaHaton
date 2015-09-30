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
                Cooperation = new MarkPropertyViewModel(MarkType.ExceedsExpectations, ""),
                Discipline = new MarkPropertyViewModel(MarkType.ExceedsExpectations, ""),
                Growth = new MarkPropertyViewModel(MarkType.ExceedsExpectations, ""),
                Productivity = new MarkPropertyViewModel(MarkType.ExceedsExpectations, ""),
                Quality = new MarkPropertyViewModel(MarkType.ExceedsExpectations, ""),
                Skills = new MarkPropertyViewModel(MarkType.ExceedsExpectations, ""),
                Initiative = new MarkPropertyViewModel(MarkType.ExceedsExpectations, "")
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

        public ActionResult AddNewMark(int forWhom)
        {
            var authorUser = (UserViewModel)Session["CurrentUser"];
            var mark = new MarkEditModel()
            {
                From = authorUser.FullName,                
                To = "Кому оценили",
                ToId = forWhom
            };
            return View(mark);
        }

        [HttpPost]
        public void SaveMark(MarkEditModel model)
        {
            var authorUser = (UserViewModel)Session["CurrentUser"];
            model.Date = DateTime.Today;
        }

    }
}
