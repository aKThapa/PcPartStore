using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCpartStore.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckoutNow()
        {
            return View(new Models.ShippingDetails());
        }


        [HttpPost]
        public ActionResult CheckoutNow(Models.ShippingDetails shippingDetails)
        {
            return View();
        }
    }
}