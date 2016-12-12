using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    class CustomerSearchEngine : ISearchAble<DTO.Customer>
    {
        IEnumerable<DTO.Customer> _entry;

        public CustomerSearchEngine(IEnumerable<DTO.Customer> entry)
        {
            _entry = entry;
        }

        public IEnumerable<DTO.Customer> Search(string keyword)
        {
            List<DTO.Customer> rt = new List<DTO.Customer>();
            rt.AddRange(searchByName(keyword));
            rt.AddRange(searchByAddress(keyword));
            rt.AddRange(searchByPhone(keyword));
            rt = new List<DTO.Customer>(rt.Distinct());
            return rt;
        }

        private IEnumerable<DTO.Customer> searchByName(string keyword)
        {

            System.Text.RegularExpressions.Regex g = new System.Text.RegularExpressions.Regex(
                keyword, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            
            return _entry.Where(customer => g.IsMatch(customer.name));
        }

        private IEnumerable<DTO.Customer>  searchByAddress(string keyword)
        {
            System.Text.RegularExpressions.Regex g = new System.Text.RegularExpressions.Regex(
                keyword, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            return _entry.Where(customer => g.IsMatch(customer.address));
        }

        private IEnumerable<DTO.Customer> searchByPhone(string keyword)
        {
            System.Text.RegularExpressions.Regex g = new System.Text.RegularExpressions.Regex(
                keyword, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            return _entry.Where(customer => g.IsMatch(customer.phone));
        }
    }

}
