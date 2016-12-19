using BusinessEntity;
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
    class CustomerSearchPresenter : ICustomerSearchPresenter
    {
        private ICustomerSearchView _view;
//        private CustomerBUS _bus;

        private SearchEngine<Customer> _customerSearch;
        private IEnumerable<Customer> _searchResult;

        public CustomerSearchPresenter(ICustomerSearchView view)
        {
            _view = view;
        //    _bus = new CustomerBUS();
            _customerSearch = new SearchEngine<Customer>();
        }

        public void performClickSearch(string keyword)
        {
            _searchResult = _customerSearch.Search(keyword);
            this.searchResult(_searchResult);
        }

        public void searchResult(IEnumerable<Customer> result)
        {
            _view.updateSearchResultView(result);
        }

        public void sortIdColumn()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Customer>((c1, c2) => c1.id - c2.id);
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            this.searchResult(query);
        }

        public void sortNameColumn()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Customer>((c1, c2) => c1.name.CompareTo(c2.name));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            this.searchResult(query);
        }

        public void sortAddressColumn()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Customer>((c1, c2) => c1.address.CompareTo(c2.address));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            this.searchResult(query);
        }

        public void sortPhoneColumn()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Customer>((c1, c2) => c1.phone.CompareTo(c2.phone));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            this.searchResult(query);
        }

        public void sortGenderColumn()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Customer>((c1, c2) => c1.gender.CompareTo(c2.gender));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            this.searchResult(query);
        }
    }
}
