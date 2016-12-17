using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
namespace BusinessEntity.SearchEngine
{
    class TourSiteSearchEngine :ISearchAble<TourSite>
    {
        private IEnumerable<TourSite> _toursite;
        private TourSiteBUS _toursiteBus;
        public TourSiteSearchEngine()
        {
            _toursiteBus = new TourSiteBUS();
            _toursite = _toursiteBus.getEntries();
        }
        public IEnumerable<TourSite> Search(string keyword)
        {
            List<TourSite> rt = new List<TourSite>();
            rt.AddRange(searchByName(keyword));
            rt = new List<TourSite>(rt.Distinct());
            return rt;
        }

        private IEnumerable<TourSite> searchByName(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _toursite.Where(tour => regex.IsMatch(tour.name));
        }
    }
}
