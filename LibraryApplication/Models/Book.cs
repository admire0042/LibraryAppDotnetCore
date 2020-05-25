using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class Book
    {
        public int Book_id { get; set; }
        public string Book_name { get; set; }
        public decimal Price { get; set; }
        public int Au_id { get; set; }
        public int Pub_id { get; set; }
        public string Dt_of_Publish { get; set; }
    }
}
