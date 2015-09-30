using System;

namespace MarksSite.Models
{
    public class MarkEditModel
    {
        public int ToId { get; set; }
        public int FromId { get; set; }        
        public string To { get; set; }
        public string From { get; set; }
        public MarkDetailsViewModel MarkDetails { get; set; }
        public DateTime Date { get; set; }
    }
}
