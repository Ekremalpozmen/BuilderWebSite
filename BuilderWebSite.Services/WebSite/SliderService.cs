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
    public class SliderService
    {
        private readonly BuilderWebSiteEntities _context;

        public SliderService(BuilderWebSiteEntities context)
        {
            _context = context;
        }

        public IQueryable<SliderViewModel> _getSliderListIQueryable(Expression<Func<Data.Sliders, bool>> expr)
        {
            return from s in _context.Sliders.AsExpandable().Where(expr)
                   select new SliderViewModel
                   {
                       FileName = s.FileName,
                       Title = s.Title,
                       Alt = s.Alt,
                       ButtonText1 = s.ButtonText1,
                       ButtonLink1 = s.ButtonLink1,
                       ButtonText2 = s.ButtonText2,
                       ButtonLink2 = s.ButtonLink2,
                       ButtonText3 = s.ButtonText3,
                       ButtonLink3 = s.ButtonLink3
                   };
        }


        public IQueryable<SliderViewModel> GetSliderListIQueryable()
        {
            var predicate = PredicateBuilder.New<Sliders>(true);
            predicate.And(x => (bool)x.Active);
            return _getSliderListIQueryable(predicate);
        }


    }
}
