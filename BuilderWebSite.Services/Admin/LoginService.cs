using BuilderWebSite.Data;
using BuilderWebSite.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWebSite.Services.Admin
{
    public class LoginService
    {
        private readonly BuilderWebSiteEntities _context;

        public LoginService(BuilderWebSiteEntities context)
        {
            _context = context;
        }
        public bool Login(LoginViewModel login)
        {
            return _context.Users.Any(x => x.UserName == login.UserName && x.Password == login.Password);
        }
    }
}
