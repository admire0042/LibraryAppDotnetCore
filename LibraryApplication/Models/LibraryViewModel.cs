using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class LibraryViewModel
    {
        public List<Author> Author = new List<Author>()
        {
             new Author(){Au_id = 131, Au_name = "Adeboye Enoch", Sex = "Male",Phone = "08035643658",Address = "5, Olaniyi Lane, Ikorodu.",City = "Lagos",State = "Lagos"},
             new Author(){Au_id = 132, Au_name = "Olaoluwa Adesola", Sex = "Female",Phone = "08055657656",Address = "10, Taiwo Oyeleru street, Boluwaji.",City = "Ibadan",State = "Oyo"},
             new Author(){Au_id = 133, Au_name = "Ituah Michael", Sex = "Male",Phone = "07056576876",Address = "Lane 132, Ota Road, Sango",City = "Sango",State = "Ogun"},
             new Author(){Au_id = 134, Au_name = "Balola David", Sex = "Male",Phone = "08067879659",Address = "25, ojuolape street, Lagos Bus Stop",City = "Ilorin",State = "Kwara"},
             new Author(){Au_id = 135, Au_name = "Martins Dorcas", Sex = "Female",Phone = "08022546758",Address = "45, Boluwaduro street, Bovas Road",City = "Ibadan",State = "Oyo"}

        };
        public List<Book> Book = new List<Book>()
        {
             new Book(){Book_id = 232, Book_name = "The Fortunate Boy", Price = 500m,Au_id = 131, Pub_id = 111, Dt_of_Publish = "5-10-1995"},
             new Book(){Book_id = 233, Book_name = "The Merciful God", Price = 1500m,Au_id = 132, Pub_id = 112, Dt_of_Publish = "10-02-2001"},
             new Book(){Book_id = 234, Book_name = "Who Is To Blame", Price = 800m,Au_id = 133, Pub_id = 113, Dt_of_Publish = "15-01-1998"},
             new Book(){Book_id = 235, Book_name = "Poor Dad, Rich Dad", Price = 1200m,Au_id = 134, Pub_id = 114, Dt_of_Publish = "25-10-2015"},
             new Book(){Book_id = 235, Book_name = "Treasure in the Lion's Mouth", Price = 1400m,Au_id = 135, Pub_id = 115, Dt_of_Publish = "28-03-2011"}
        };
        public List<Publisher> Publisher = new List<Publisher>()
        {
            new Publisher(){Pub_id = 121, Pub_name = "Babatunde John", Phone = "08056438657",Address = "25, Johnson Avenue",City = "Umuaya", State = "Abia", Country = "Nigeria"},
            new Publisher(){Pub_id = 122, Pub_name = "Adegoroye Bolanle", Phone = "08066765845",Address = "25, Ogunroye street, Onaolapo Bus Stop",City = "Ilorin",State = "Kwara", Country = "Sweeden"},
            new Publisher(){Pub_id = 123, Pub_name = "Michael Okosun", Phone = "09064534646",Address = "5,gbadamosi road,gbanglada area", City = "Abuja",State = "FCT", Country = "Nigeria"},
            new Publisher(){Pub_id = 124, Pub_name = "Oguntola Peter", Phone = "08135647589",Address = "56, Ojutelegan street", City = "Ibadan",State = "Oyo", Country = "Bulgaria"},
            new Publisher(){Pub_id = 125, Pub_name = "David Johnson", Phone = "08055658675",Address = "Police quarter, Ogbodo lane",City = "Lagos",State = "Lagos", Country = "Ghana"}
        };

    }
}
