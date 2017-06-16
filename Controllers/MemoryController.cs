using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PCpartStore.Models;

namespace PCpartStore.Controllers
{
    public class MemoryController : Controller
    {
        private MemoryEntities db = new MemoryEntities();

        // GET: Memory
        public ActionResult IndexMemory()
        {
            var memories = from m in db.Memories
                           select m;
            return View(memories);
        }

        [HttpPost]
        public ActionResult AddToShoppingCart(int ID)
        {
            Memory ram = db.Memories.Find(ID);
            ShoppingCart basket = new ShoppingCart();
            basket.AddItem(new Parts
            {
                Name = ((ram.Brand)+ " " + (ram.DDR) + " " + (ram.Capacity) + " " + (ram.Speed)),
                Price = (ram.Price),
                ID = IdSetter.setId()
            });
            basket.DisplayFor(IdSetter.setId());
            IdSetter.incrementId();
            //seed++;
            return RedirectToAction("IndexMemory");
        }
    }
}