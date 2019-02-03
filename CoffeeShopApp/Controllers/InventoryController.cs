
using CoffeeShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Logic.ItemProcessor;


namespace CoffeeShopApp.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            ViewBag.Message = "Inventory";

            var data = LoadItems();
            List<Items> items = new List<Items>();
            foreach (var row in data)
            {
                items.Add(new Items
                {
                    Name = row.Name,
                    Description = row.Description,
                    Quantity = row.Quantity,
                    Price = row.Price
                });
            
            }

            return View(items);
        }
    }
}