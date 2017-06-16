using PCpartStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCpartStore.Controllers
{
    //Home Controller will act as the controller for the IntelCPU as
    //intel CPU will be my homepage
    public class HomeController : Controller
    {
        private IntelCPUEntities db = new IntelCPUEntities();
        

        public ActionResult Index()
        {
            var intelCPUs = from i in db.IntelCPUs
                            select i;
            return View(intelCPUs);
        }

       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult AddToShoppingCart(int ID)
        {
            IntelCPU intelCPU = db.IntelCPUs.Find(ID);
            ShoppingCart basket = new ShoppingCart();
            basket.AddItem(new Parts
            {
                Name = ("Intel Core " + (intelCPU.Core) + " " + (intelCPU.Model)),
                Price = (intelCPU.Price),
                ID = IdSetter.setId()
            });
            basket.DisplayFor(IdSetter.setId());
            IdSetter.incrementId();
            //seed++;
            return RedirectToAction("Index");
        }
    }
}