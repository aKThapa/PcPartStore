using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PCpartStore.Models;

namespace PCpartStore.Controllers
{
    public class PSUController : Controller
    {

        private PSUEntities db = new PSUEntities();

        // GET: PSU
        public ActionResult IndexPSU()
        {
            var psus = from i in db.PowerSupplies
                       select i;
            return View(psus);
        }

        [HttpPost]
        public ActionResult AddToShoppingCart(int ID)
        {
            PowerSupply psu = db.PowerSupplies.Find(ID);
            ShoppingCart basket = new ShoppingCart();
            basket.AddItem(new Parts
            {
                Name = ((psu.Brand) + " " + (psu.Rating) + " " + (psu.Watt)),
                Price = (psu.Price),
                ID = IdSetter.setId()
            });
            basket.DisplayFor(IdSetter.setId());
            IdSetter.incrementId();
            //seed++;
            return RedirectToAction("IndexPSU");
        }


    }
}