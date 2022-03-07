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

        public HomeController(SliderService sliderService)
        {
            _sliderService = sliderService;
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