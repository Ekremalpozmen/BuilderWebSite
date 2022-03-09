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
    public class RecentProjectsService
    {
        private readonly BuilderWebSiteEntities _context;
        public RecentProjectsService(BuilderWebSiteEntities context)
        {
            _context = context;
        }

        public IQueryable<RecentProjectsViewModel> _getRecentProjectsListIQueryable(Expression<Func<Data.RecentProjects, bool>> expr)
        {
            return from s in _context.RecentProjects.AsExpandable().Where(expr)
                   select new RecentProjectsViewModel
                   {
                       FileName = s.FileName,
                       Title = s.Title,
                       Description = s.Description,
                   };
        }


        public IQueryable<RecentProjectsViewModel> GetRecentProjectsListIQueryable()
        {
            var predicate = PredicateBuilder.New<Data.RecentProjects>(true);
            predicate.And(x => (bool)x.Active);
            return _getRecentProjectsListIQueryable(predicate);
        }
    }
}
