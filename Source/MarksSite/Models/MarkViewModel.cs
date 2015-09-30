using System;

namespace MarksSite.Models
{
    public class MarkViewModel
    {
        public string To { get; set; }
        public string From { get; set; }
        public MarkDetailsViewModel MarkDetails { get; set; }
        public DateTime Date { get; set; }
    }
}
