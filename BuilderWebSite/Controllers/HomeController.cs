using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuilderWebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SliderPartial()
        {
            return PartialView("~/Views/Home/SliderPartial.cshtml");

        }

        public ActionResult OurServices()
        {
            return PartialView("~/Views/Home/OurServicesPartial.cshtml");

        }

        public ActionResult ContactUs()
        {
            return PartialView("~/Views/Home/ContactUsPartial.cshtml");

        }

        public ActionResult RecentProjects()
        {
            return PartialView("~/Views/Home/RecentProjectsPartial.cshtml");

        }

        public ActionResult OurClients()
        {
            return PartialView("~/Views/Home/OurClientsPartial.cshtml");

        }
    }
}