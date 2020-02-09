using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinDtoApp.Models
{
    public class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset LastEditDate { get; set; }
    }
}
