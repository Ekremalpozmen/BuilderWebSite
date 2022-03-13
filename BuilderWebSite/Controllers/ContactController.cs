using BuilderWebSite.Services.WebSite;
using BuilderWebSite.ViewModels.WebSite;
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

        public ActionResult Index(string lang)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactViewModel model)
        {
            var result = _contactService.AddContactForm(model);
            return Json(new { item = "başarılı" }, JsonRequestBehavior.AllowGet);
        }
    }
}