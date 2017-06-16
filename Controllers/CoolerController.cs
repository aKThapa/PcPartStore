using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PCpartStore.Models;

namespace PCpartStore.Controllers
{
    public class CoolerController : Controller
    {
        private CoolerEntities db = new CoolerEntities();

        // GET: Cooler
        public ActionResult IndexCooler()
        {
            var coolers = from i in db.Coolers
                         select i;
            return View(coolers);
        }

        [HttpPost]
        public ActionResult AddToShoppingCart(int ID)
        {
            Cooler cooler = db.Coolers.Find(ID);
            ShoppingCart basket = new ShoppingCart();
            basket.AddItem(new Parts
            {
                Name = ((cooler.Brand) + " " + (cooler.Model) + " " + (cooler.Rad)),
                Price = (cooler.Price),
                ID = IdSetter.setId()
            });
            basket.DisplayFor(IdSetter.setId());
            IdSetter.incrementId();
            //seed++;
            return RedirectToAction("IndexCooler");
        }
    }
}