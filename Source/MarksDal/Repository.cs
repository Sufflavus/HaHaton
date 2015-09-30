using System.Collections.Generic;
using System.Linq;

namespace MarksDal
{
    public class Repository
    {
        private readonly ContextDataContext context = new ContextDataContext();

        public void AddMarkRequest(IEnumerable<MarkRequest> markRequests)
        {
            context.MarkRequests.InsertAllOnSubmit(markRequests);
        }

        public void AddMarks(IEnumerable<Mark> marks)
        {
            context.Marks.InsertAllOnSubmit(marks);
        }

        public void AddUsers(IEnumerable<User> users)
        {
            context.Users.InsertAllOnSubmit(users);
        }

        public void CreateDatabase()
        {
            if (!context.DatabaseExists())
            {
                context.CreateDatabase();
            }
        }

        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public void Save()
        {
            context.SubmitChanges();
        }
    }
}