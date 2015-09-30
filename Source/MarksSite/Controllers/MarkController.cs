using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MarksSite.Models;

namespace MarksSite.Controllers
{
    public class MarkController : Controller
    {
        //
        // GET: /MarkViewModel/

        public ActionResult AddNewMark(int forWhom)
        {
            var authorUser = (UserViewModel) Session["CurrentUser"];
            var mark = new MarkEditModel
                {
                    From = authorUser.FullName,
                    To = "Кому оценили",
                    ToId = forWhom
                };
            return View(mark);
        }

        public ActionResult List(int userId)
        {
            string toName = "Кого оценили";
            var details = new MarkDetailsViewModel
                {
                    Cooperation = new MarkPropertyViewModel
                        {
                            Value = MarkType.ExceedsExpectations,
                            Comment = "sf"
                        },
                    Discipline = new MarkPropertyViewModel
                        {
                            Value = MarkType.ExceedsExpectations
                        },
                    Growth = new MarkPropertyViewModel
                        {
                            Value = MarkType.ExceedsExpectations
                        },
                    Productivity = new MarkPropertyViewModel
                        {
                            Value = MarkType.ExceedsExpectations
                        },
                    Quality = new MarkPropertyViewModel
                        {
                            Value = MarkType.ExceedsExpectations
                        },
                    Skills = new MarkPropertyViewModel
                        {
                            Value = MarkType.ExceedsExpectations
                        },
                    Initiative = new MarkPropertyViewModel
                        {
                            Value = MarkType.ExceedsExpectations
                        }
                };
            var mark = new MarkViewModel
                {
                    From = "Кто оценил",
                    To = toName,
                    Date = DateTime.Today,
                    MarkDetails = details
                };
            var list = new List<MarkViewModel>();
            list.Add(mark);
            return View(list);
        }

        [HttpPost]
        public void SaveMark(MarkEditModel model)
        {
            var authorUser = (UserViewModel) Session["CurrentUser"];
            //model.Date = DateTime.Today;
        }
    }
}