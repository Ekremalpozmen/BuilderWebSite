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

    public class ContactUsService
    {
        private readonly BuilderWebSiteEntities _context;

        public ContactUsService(BuilderWebSiteEntities context)
        {
            _context = context;
        }

        public IQueryable<ContactUsViewModel> GetContactIQueryable()
        {
            return from s in _context.ContactUs.AsExpandable()
                   select new ContactUsViewModel
                   {
                       Title = s.Title,
                       Description = s.Description,
                       ButtonText = s.ButtonText
                   };
        }

    }
}
