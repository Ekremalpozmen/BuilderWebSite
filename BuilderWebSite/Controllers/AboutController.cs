using BuilderWebSite.Services.WebSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuilderWebSite.Controllers
{
    public class AboutController : Controller
    {
        private readonly AboutService _aboutService;

        public AboutController(AboutService aboutService)
        {
            _aboutService = aboutService;
        }

        // GET: About
        public ActionResult Index()
        {
            var model = _aboutService.GetAboutViewModel();
            return View(model);
        }
    }
}