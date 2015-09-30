using System;

namespace MarksSite.Models
{
    public class MarkEditModel
    {
        public DateTime? Date { get; set; }
        public string From { get; set; }
        public int? FromId { get; set; }
        public MarkDetailsViewModel MarkDetails { get; set; }
        public string To { get; set; }
        public int ToId { get; set; }
    }
}