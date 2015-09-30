using System;

namespace MarksSite.Models
{
    public class MarkPropertyViewModel
    {
        public MarkPropertyViewModel(string value, string comment)
        {
            Value = value;
            Comment = comment;
        }

        public string Value { get; set; }
        public string Comment { get; set; }
    }
}