namespace MarksSite.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string DomainName { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public bool IsManager { get; set; }
        public string JobPosition { get; set; }
    }
}