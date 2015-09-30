using System.Collections.Generic;

namespace MarksSite.Models
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            Requests = new List<MarkRequestViewModel>();
        }

        public string Department { get; set; }
        public string DomainName { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public int Id { get; set; }
        public bool IsManager { get; set; }
        public string JobPosition { get; set; }
        public List<MarkRequestViewModel> Requests { get; set; }
    }
}