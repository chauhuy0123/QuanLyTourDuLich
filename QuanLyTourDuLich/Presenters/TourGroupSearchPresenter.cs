using BusinessEntity.SearchEngine;
using DTO;
using QuanLyTourDuLich.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    class TourGroupSearchPresenter : ITourGroupSearchPresenter
    {
        ITourGroupSearchView _view;

        private SearchEngine<TourGroup> _tourGrourSearch;
        private IEnumerable<TourGroup> _searchResult;

        private IEnumerable<Transport> _transportFilter;
        private DateTime _depart_date = DateTime.MinValue;

        private DateTime _return_date = DateTime.MaxValue;


        public TourGroupSearchPresenter(ITourGroupSearchView view)
        {
            _view = view;

            _tourGrourSearch = new SearchEngine<TourGroup>();
            
        }
        public void handleSearchClick(string keyword)
        {
            _searchResult = _tourGrourSearch.Search(keyword);
            updateFilter();
            //this.updateViewSearchResult(_searchResult);
        }

        public void updateViewSearchResult(IEnumerable<DTO.TourGroup> searchResult)
        {
            _view.updateSearchResult(searchResult);
        }


        public void filterTransport(IEnumerable<Transport> _transports)
        {
            _transportFilter = _transports;
            if (_searchResult != null && _searchResult.Count() != 0)
                updateFilter();
        }

        public void filterDate(DateTime[] _times)
        {
            _depart_date = _times[0];
            _return_date = _times[1];
            if (_searchResult != null && _searchResult.Count() != 0)
                updateFilter();
        }

        private void updateFilter()
        {
            var rs1 = filterByTransport(_transportFilter);
            var rs2 = filterByTime(_depart_date, _return_date);
            var rs = rs1.Intersect(rs2);
            this.updateViewSearchResult(rs);
        }

        private IEnumerable<TourGroup> filterByTime(DateTime _depart_date, DateTime _return_date)
        {
            if (_depart_date == DateTime.MinValue && _return_date == DateTime.MaxValue)
                return _searchResult;
            return _searchResult.Where(group => group.depart_date >= _depart_date && group.return_date <= _return_date);
        }


        private IEnumerable<TourGroup> filterByTransport(IEnumerable<Transport> transports)
        {
            if (transports == null || transports.Count() == 0)
                return _searchResult;
            var comparer = new TransportEqualityComparer();
            return _searchResult
                .Where(tourG => tourG.Transports.Intersect(transports, comparer).Count() != 0)
                .ToList();
        }


        class TransportEqualityComparer : IEqualityComparer<Transport>
        {
            public bool Equals(Transport b1, Transport b2)
            {
                if (b2 == null && b1 == null)
                    return true;
                else if (b1 == null | b2 == null)
                    return false;
                else
                    return b1.id == b2.id;
            }

            public int GetHashCode(Transport t)
            {
                return t.id.GetHashCode();
            }
        }
    }
}
