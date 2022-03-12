using BuilderWebSite.Data;
using BuilderWebSite.ViewModels.WebSite;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWebSite.Services.WebSite
{

    public class AboutService
    {
        private readonly BuilderWebSiteEntities _context;

        public AboutService(BuilderWebSiteEntities context)
        {
            _context = context;
        }

        public AboutViewModel GetAboutViewModel()
        {
            var model = (from a in _context.About
                         select new AboutViewModel()
                         {
                             Description = a.Description,
                             Title = a.Title,
                             FileName = a.FileName
                         }).FirstOrDefault();

            return model;
        }
    }
}
