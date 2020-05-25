using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApplication.Controllers
{
    public class BookController : Controller
    {
        public IActionResult List()
        {
            ViewBag.Message = "List of Available Books";

            List<Book> book = new List<Book>()
            {
                new Book(){Book_id = 232, Book_name = "The Fortunate Boy", Price = 500m,Au_id = 131, Pub_id = 111, Dt_of_Publish = "5-10-1995"},
                new Book(){Book_id = 233, Book_name = "The Merciful God", Price = 1500m,Au_id = 132, Pub_id = 112, Dt_of_Publish = "10-02-2001"},
                new Book(){Book_id = 234, Book_name = "Who Is To Blame", Price = 800m,Au_id = 133, Pub_id = 113, Dt_of_Publish = "15-01-1998"},
                new Book(){Book_id = 235, Book_name = "Poor Dad, Rich Dad", Price = 1200m,Au_id = 134, Pub_id = 114, Dt_of_Publish = "25-10-2015"},
                new Book(){Book_id = 235, Book_name = "Treasure in the Lion's Mouth", Price = 1400m,Au_id = 135, Pub_id = 115, Dt_of_Publish = "28-03-2011"}
            };
            return View(book);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}