using BuilderWebSite.Data;
using BuilderWebSite.ViewModels.WebSite;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWebSite.Services.WebSite
{
    public class OurService
    {
        private readonly BuilderWebSiteEntities _context;

        public OurService(BuilderWebSiteEntities context)
        {
            _context = context;
        }

        public IQueryable<OurServiceViewModel> _getOurServicesListIQueryable(Expression<Func<Data.OurServices, bool>> expr)
        {
            return from s in _context.OurServices.AsExpandable().Where(expr)
                   select new OurServiceViewModel
                   {
                       Id = (int)s.Id,
                       FileName = s.FileName,
                       Title = s.Title,
                       Description = s.Description,
                   };
        }


        public IQueryable<OurServiceViewModel> GetOurServicesListIQueryable()
        {
            var predicate = PredicateBuilder.New<Data.OurServices>(true);
            predicate.And(x => (bool)x.Active);
            return _getOurServicesListIQueryable(predicate);
        }

        public OurServiceDetailViewModel GetOurServiceDetail(int id)
        {
            return (from s in _context.OurServices
                    where s.Id == id
                    select new OurServiceDetailViewModel()
                    {
                        Description = s.Description,
                        FileName = s.FileName,
                        Title = s.Title,
                        ImageList = from i in s.OurServiceImages
                                    select new ImageListViewModel()
                                    {
                                        FileName = i.FileName,
                                        Title = i.Title,
                                        Alt = i.Alt,
                                    }
                    }).FirstOrDefault();
        }
    }
}
