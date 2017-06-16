using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PCpartStore.Models;

namespace PCpartStore.Controllers
{
    public class AmdCpuController : Controller
    {
        private AmdCPUEntities db = new AmdCPUEntities();

        // GET: AmdCpu
        public ActionResult IndexAmdCpu()
        {
            var amdCPUs = from i in db.AmdCPUs
                          select i;
            return View(amdCPUs);
        }

        [HttpPost]
        public ActionResult AddToShoppingCart(int ID)
        {
            AmdCPU amdCPU = db.AmdCPUs.Find(ID);
            ShoppingCart basket = new ShoppingCart();
            basket.AddItem(new Parts
            {
                Name = ("AMD " + (amdCPU.Brand) + " " + (amdCPU.Model)),
                Price = (amdCPU.Price),
                ID = IdSetter.setId()
            });
            basket.DisplayFor(IdSetter.setId());
            IdSetter.incrementId();
            //seed++;
            return RedirectToAction("IndexAmdCpu");
        }
    }
}