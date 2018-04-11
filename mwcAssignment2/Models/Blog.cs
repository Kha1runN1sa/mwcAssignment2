using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mwcAssignment2.Models
{
    public class Blog
    {
        // This is not a complete implementation
        public int ID { get; set; } // this shouldn't be editable but auto increment.
        public string Author { get; set; }
        public string Article { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Title { get; set; }
    }
}