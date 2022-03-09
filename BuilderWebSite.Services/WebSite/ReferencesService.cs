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
    public class ReferencesService
    {
        private readonly BuilderWebSiteEntities _context;

        public ReferencesService(BuilderWebSiteEntities context)
        {
            _context = context;
        }

        public IQueryable<ReferencesViewModel> _getReferencesListIQueryable(Expression<Func<Data.References, bool>> expr)
        {
            return from s in _context.References.AsExpandable().Where(expr)
                   select new ReferencesViewModel
                   {
                       FileName = s.FileName,
                       Active = (bool)s.Active,
                   };
        }

        public IQueryable<ReferencesViewModel> GetReferencesListIQueryable()
        {
            var predicate = PredicateBuilder.New<References>(true);
            predicate.And(x => (bool)x.Active);
            return _getReferencesListIQueryable(predicate);
        }

    }
}
