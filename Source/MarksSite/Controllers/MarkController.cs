using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MarksDal;
using MarksSite.Models;
using Newtonsoft.Json;

namespace MarksSite.Controllers
{
    public class MarkController : Controller
    {
        private static readonly Repository repository = new Repository();

        public ActionResult AddNewMark(int forWhom)
        {
            var authorUser = (UserViewModel) Session["CurrentUser"];
            User toUser = repository.GetUsers().FirstOrDefault(x => x.Id == forWhom);
            var mark = new MarkEditModel
                {
                    From = authorUser.FullName,
                    To = toUser == null ? "Неизвестный пользователь" : toUser.FirstName,
                    ToId = forWhom
                };
            return View(mark);
        }

        public ActionResult List(int userId)
        {
            List<Mark> marks = repository.GetMarksByUser(userId);
            var result = new List<MarkViewModel>();
            marks.ForEach(x =>
                {
                    var mark = new MarkViewModel
                        {
                            From = x.From.FirstName,
                            To = x.To.FirstName,
                            Date = x.DateTime,
                            MarkDetails = JsonConvert.DeserializeObject<MarkDetailsViewModel>(x.Json)
                        };
                    result.Add(mark);
                });
            return View(result);
        }

        [HttpPost]
        public void SaveMark(MarkEditModel model)
        {
            var authorUser = (UserViewModel) Session["CurrentUser"];
            model.Date = DateTime.Today;
            model.FromId = authorUser.Id;

            repository.AddMarks(new List<Mark>
                {
                    new Mark
                        {
                            DateTime = model.Date.Value,
                            FromId = model.FromId.Value,
                            ToId = model.ToId,
                            Json = JsonConvert.SerializeObject(model.MarkDetails)
                        }
                });
            repository.Save();
        }
    }
}