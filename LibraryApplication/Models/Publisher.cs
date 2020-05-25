using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class Publisher
    {
        public int Pub_id { get; set; }
        public string Pub_name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public IEnumerable<State> AllStates { get; set; }
        public IEnumerable<Country> AllCountries { get; set; }
    }
}
