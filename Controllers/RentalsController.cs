using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BikeToGoRental.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult Index()
        {
            if (User.IsInRole("CanManageRentals"))

            return View("Index");

            return View("ReadOnlyIndex");
        }

        // GET: Rentals/New
        public ActionResult New()
        {
            return View();
        }
    }
}