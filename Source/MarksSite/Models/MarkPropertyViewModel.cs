using System;

namespace MarksSite.Models
{
    public class MarkPropertyViewModel
    {
        public MarkPropertyViewModel(MarkType value, string comment)
        {
            Value = value;
            Comment = comment;
        }

        public MarkType Value { get; set; }
        public string Comment { get; set; }
    }
}