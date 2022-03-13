using BuilderWebSite.Data;
using BuilderWebSite.ViewModels.WebSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWebSite.Services.WebSite
{
    public class ContactService
    {
        private readonly BuilderWebSiteEntities _context;

        public ContactService(BuilderWebSiteEntities context)
        {
            _context = context;
        }

        public ContactViewModel AddContactForm(ContactViewModel model)
        {

            var contact = new ContactForm()
            {
                Phone = model.Phone,
                FullName = model.FullName,
                Mail = model.Email,
                Message = model.Message,
                Subject = model.Subject,
                Date = DateTime.Now
            };
            _context.ContactForm.Add(contact);
            _context.SaveChanges();
            return null;
        }
    }

}
