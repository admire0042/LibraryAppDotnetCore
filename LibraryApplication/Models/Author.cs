using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class Author
    {
        public int Au_id { get; set; }
        public string Au_name { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public IEnumerable<Sex> AllSex { get; set; }
        public IEnumerable<State> AllState { get; set; }
    }
}
