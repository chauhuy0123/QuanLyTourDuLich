using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    class CustomerSearchEngine : ISearchAble<DTO.Customer>
    {
        private IEnumerable<DTO.Customer> _entry;
        private CustomerBUS _bus;

        public CustomerSearchEngine()
        {
            _bus = new CustomerBUS();
            _entry = _bus.getEntries();
        }

        public IEnumerable<DTO.Customer> Search(string keyword)
        {
            List<DTO.Customer> rt = new List<DTO.Customer>();
            rt.AddRange(searchByName(keyword));
            rt.AddRange(searchByAddress(keyword));
            rt.AddRange(searchByPhone(keyword));
            rt = new List<DTO.Customer>(rt.Distinct()); // khử các phần tử trùng
            return rt;
        }

        private IEnumerable<DTO.Customer> searchByName(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(customer => regex.IsMatch(customer.name));
        }

        private IEnumerable<DTO.Customer>  searchByAddress(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(customer => regex.IsMatch(customer.address));
        }

        private IEnumerable<DTO.Customer> searchByPhone(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(customer => regex.IsMatch(customer.phone));
        }
    }

}
