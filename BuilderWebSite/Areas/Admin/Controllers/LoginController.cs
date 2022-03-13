using BuilderWebSite.Services.Admin;
using BuilderWebSite.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BuilderWebSite.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private LoginService _loginservice;

        public LoginController(LoginService loginService)
        {
            _loginservice = loginService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var loginResult = _loginservice.Login(model);
                if (loginResult)
                {
                    FormsAuthentication.SetAuthCookie(model.Id.ToString(), false);
                    return RedirectToAction("Index", "Home", new { Area = "Admin" });
                }
            }
            return View(model);
        }
    }
}