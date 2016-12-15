using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    interface ICustomerSearchPresenter
    {
        void performClickSearch(string keyword);
        void searchResult(IEnumerable<Customer> result);

        void sortIdColumn();

        void sortNameColumn();

        void sortAddressColumn();

        void sortPhoneColumn();

        void sortGenderColumn();
    }
}
