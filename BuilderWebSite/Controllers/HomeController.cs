using BuilderWebSite.Services.WebSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuilderWebSite.Controllers
{
    public class HomeController : BaseController
    {
        private readonly SliderService _sliderService;
        private readonly OurService _ourService;

        public HomeController(SliderService sliderService, OurService ourServices)
        {
            _sliderService = sliderService;
            _ourService = ourServices;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SliderPartial()
        {
            var model = _sliderService.GetSliderListIQueryable().ToList();
            return PartialView("~/Views/Home/SliderPartial.cshtml", model);

        }

        public ActionResult OurServices()
        {
            var model = _ourService.GetOurServicesListIQueryable().ToList();
            return PartialView("~/Views/Home/OurServicesPartial.cshtml", model);

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