using BuilderWebSite.Services.WebSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuilderWebSite.Controllers
{
    public class OurServiceController : BaseController
    {
        private readonly OurService _ourService;

        public OurServiceController(
            OurService ourServices
            )
        {
            _ourService = ourServices;
        }

        // GET: OurService
        public ActionResult Index()
        {
            var model = _ourService.GetOurServicesListIQueryable().ToList();
            return View(model);
        } public ActionResult ServiceDetail(int id)
        {
            var model = _ourService.GetOurServiceDetail(id);
            return View(model);
        }
    }
}