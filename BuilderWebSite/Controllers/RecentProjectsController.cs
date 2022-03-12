using BuilderWebSite.Services.WebSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuilderWebSite.Controllers
{
    public class RecentProjectsController : BaseController
    {
        private readonly RecentProjectsService _recentProjectsService;

        public RecentProjectsController(RecentProjectsService recentProjectsService)
        {
            _recentProjectsService = recentProjectsService;
        }
        // GET: RecentProjects
        public ActionResult Index()
        {
            var model = _recentProjectsService.GetRecentProjectsListIQueryable().ToList();
            return View(model);
        }
    }
}