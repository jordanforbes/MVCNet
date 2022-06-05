using MVCtut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCtut.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Jordan", LastName = "Forbes", Age = 30, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Olivia", LastName = "Forbes", Age = 24, IsAlive = true });
            people.Add(new PersonModel { FirstName = "David", LastName = "Weinberger", Age = 29, IsAlive = true });

            return View(people);
        }
    }
}