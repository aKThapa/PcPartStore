using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCpartStore.Controllers
{
    public class NavbarInfoController : Controller
    {
        private Models.ShoppingCart cart = new Models.ShoppingCart();

        // GET: NavbarInfo
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Info()
        {
            return PartialView(cart);
        }
    }
}