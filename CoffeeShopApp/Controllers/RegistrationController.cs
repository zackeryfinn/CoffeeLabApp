using CoffeeShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopApp.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Registration()
        {
            return View();
        }

  
       
        [HttpPost]
        public  ActionResult Register(Patrons model)
        {
            if (ModelState.IsValid)
            {
               
                ViewBag.Name = Request["FirstName"];
                return View(model);
            }
            else
            {
                return View();
            }
        }
    }
}