using CoffeeShopApp.Data;
using CoffeeShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.Logic.PatronProcessor;

namespace CoffeeShopApp.Controllers
{
    public class RegistrationController : Controller
    {

        private readonly CoffeeShopContext _context = new CoffeeShopContext();


        // GET: Registration
        public ActionResult Registration()
        {
            return View();
        }

  
       
        [HttpPost]
        public  ActionResult Register(Patrons newPatron)
        {
            if (ModelState.IsValid)
            {
                CreatePatron(newPatron.FirstName, newPatron.LastName, newPatron.Email);              
                ViewBag.Name = Request["FirstName"];
                return View(newPatron);
            }
            else
            {
                ViewBag.ErrorMessage = "The information you entered was not valid";
                return View();
            }
        }
    }
}