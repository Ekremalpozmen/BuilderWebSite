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
        private readonly ContactUsService _contactUsService;

        public HomeController(SliderService sliderService, OurService ourServices, ContactUsService contactUsService)
        {
            _sliderService = sliderService;
            _ourService = ourServices;
            _contactUsService = contactUsService;
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
            var model = _contactUsService.GetContactIQueryable().FirstOrDefault();
            return PartialView("~/Views/Home/ContactUsPartial.cshtml", model);

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