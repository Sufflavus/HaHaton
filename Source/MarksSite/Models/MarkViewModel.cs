using System;

namespace MarksSite.Models
{
    public class MarkViewModel
    {
        public DateTime Date { get; set; }
        public string From { get; set; }
        public MarkDetailsViewModel MarkDetails { get; set; }
        public string To { get; set; }
    }
}