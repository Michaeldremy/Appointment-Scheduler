using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class ItemController : Controller
    {

        // Using dependency injection for our controller aka passing data(database) to our controller 
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            // using IEnumerable and calling on our "Item" from our controller
            // this allows us the ability to do a foreach over our data in our cshtml files
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }
    }
}
