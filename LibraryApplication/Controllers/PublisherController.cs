using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApplication.Controllers
{
    public class PublisherController : Controller
    {
        public IActionResult List()
        {
            ViewBag.Message = "List of Publishers";

            List<Publisher> publishers = new List<Publisher>()
            {
                new Publisher(){Pub_id = 121, Pub_name = "Babatunde John", Phone = "08056438657",Address = "25, Johnson Avenue",City = "Umuaya", State = "Abia"},
                new Publisher(){Pub_id = 122, Pub_name = "Adegoroye Bolanle", Phone = "08066765845",Address = "25, Ogunroye street, Onaolapo Bus Stop",City = "Ilorin",State = "Kwara"},
                new Publisher(){Pub_id = 123, Pub_name = "Michael Okosun", Phone = "09064534646",Address = "5,gbadamosi road,gbanglada area", City = "Abuja",State = "FCT"},
                new Publisher(){Pub_id = 124, Pub_name = "Oguntola Peter", Phone = "08135647589",Address = "56, Ojutelegan street", City = "Ibadan",State = "Oyo"},
                new Publisher(){Pub_id = 125, Pub_name = "David Johnson", Phone = "08055658675",Address = "Police quarter, Ogbodo lane",City = "Lagos",State = "Lagos"}
            };
            return View(publishers);
        }
        public IActionResult Create()
        {
            Publisher publisher = new Publisher()
            {
                AllCountries = Enum.GetValues(typeof(Country)).Cast<Country>().ToList(),
                AllStates = Enum.GetValues(typeof(State)).Cast<State>().ToList()
            };
            return View(publisher);
        }
    }
}