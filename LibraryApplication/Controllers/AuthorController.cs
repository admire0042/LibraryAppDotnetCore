using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApplication.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult List()
        {
            ViewBag.Message = "List of Authors";

            List<Author> author = new List<Author>()
            {
                new Author(){Au_id = 131, Au_name = "Adeboye Enoch", Sex = "Male",Phone = "08035643658",Address = "5, Olaniyi Lane, Ikorodu.",City = "Lagos",State = "Lagos"},
                new Author(){Au_id = 132, Au_name = "Olaoluwa Adesola", Sex = "Female",Phone = "08055657656",Address = "10, Taiwo Oyeleru street, Boluwaji.",City = "Ibadan",State = "Oyo"},
                new Author(){Au_id = 133, Au_name = "Ituah Michael", Sex = "Male",Phone = "07056576876",Address = "Lane 132, Ota Road, Sango",City = "Sango",State = "Ogun"},
                new Author(){Au_id = 134, Au_name = "Balola David", Sex = "Male",Phone = "08067879659",Address = "25, ojuolape street, Lagos Bus Stop",City = "Ilorin",State = "Kwara"},
                new Author(){Au_id = 135, Au_name = "Martins Dorcas", Sex = "Female",Phone = "08022546758",Address = "45, Boluwaduro street, Bovas Road",City = "Ibadan",State = "Oyo"}

            };
            return View(author);
        }
        public IActionResult Create()
        {
            Author author = new Author()
            {
                AllState = Enum.GetValues(typeof(State)).Cast<State>().ToList(),
                AllSex = Enum.GetValues(typeof(Sex)).Cast<Sex>().ToList()
            };
            return View(author);
        }
    }
}