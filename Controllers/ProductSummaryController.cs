using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using PCpartStore.Models.ShoppingCart;
namespace PCpartStore.Controllers
{
    public class ProductSummaryController : Controller
    {
        private Models.ShoppingCart cart = new Models.ShoppingCart();
        // GET: ProductSummary
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Summary()
        {
            ViewBag.Total = cart.ComputeTotalValue();
            //Models.ShoppingCart cart = new Models.ShoppingCart();
            //return View(cart.ShoppingCartSummary());
            return View(cart.ShoppingCartSummary());
        }

        public ActionResult Delete(int ID)
        {
            cart.DeleteItem(ID);
            return RedirectToAction("Summary");
        }
    }
}