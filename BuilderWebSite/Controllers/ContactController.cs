using BuilderWebSite.Services.WebSite;
using BuilderWebSite.ViewModels.WebSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuilderWebSite.Controllers
{
    public class ContactController : BaseController
    {
        private readonly ContactService _contactService;

        public ContactController(ContactService contactService)
        {

            _contactService = contactService;

        }
        // GET: Contact
        public ActionResult Index(string lang)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ContactViewModel model, string lang)
        {
            var result = _contactService.AddContactForm(model);
            return Json(new { item = "başarılı" }, JsonRequestBehavior.AllowGet);



        }
    }
}