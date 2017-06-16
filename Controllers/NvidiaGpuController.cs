using PCpartStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCpartStore.Controllers
{
    public class NvidiaGpuController : Controller
    {
        private NvidiaGPUEntities db = new NvidiaGPUEntities();
        
        public ActionResult IndexNvidia()
        {
            var nvidiaGpus = from i in db.NvidiaGPUs
                             select i;
            return View(nvidiaGpus);
        }

        [HttpPost]
        public ActionResult AddToShoppingCart(int ID)
        {
            NvidiaGPU nvidiaGPU = db.NvidiaGPUs.Find(ID);
            ShoppingCart basket = new ShoppingCart();
            basket.AddItem(new Parts
            {
                Name = ("NVIDIA GeForce GTX " + (nvidiaGPU.Model) + " " + (nvidiaGPU.Memory)),
                Price = (nvidiaGPU.Price),
                ID = IdSetter.setId()
            });
            basket.DisplayFor(IdSetter.setId());
            IdSetter.incrementId();
            //seed++;
            return RedirectToAction("IndexNvidia");
        }
    }
}