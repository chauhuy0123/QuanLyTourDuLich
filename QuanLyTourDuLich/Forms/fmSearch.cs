using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntity;
using BusinessEntity.SearchEngine;
using DTO;
using QuanLyTourDuLich.Views;
using QuanLyTourDuLich.Presenters;

namespace QuanLyTourDuLich.GUI
{

    public partial class fmSearch : Form, ICustomerSearchView
    {

        ICustomerSearchPresenter _presenter;
        
        public fmSearch()
        {
            InitializeComponent();
            _presenter = new CustomerSearchPresenter(this);
        }

        private void btnTroLai1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTroLai2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string keyword = _keywordTb.Text;
            _presenter.performClickSearch(keyword);
        }

        private void _resultGv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.Value != null)
                    e.Value = ((Gender) e.Value).name;
            }
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        public void updateSearchResultView(IEnumerable<Customer> searchResult)
        {
            _searchRsBindingSource.DataSource = searchResult;
        }

        private void _resultGv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
                _presenter.sortIdColumn();
            else if (e.ColumnIndex == 2)
                _presenter.sortNameColumn();
            else if (e.ColumnIndex == 3)
                _presenter.sortAddressColumn();
            else if (e.ColumnIndex == 4)
                _presenter.sortPhoneColumn();
            else if (e.ColumnIndex == 5)
                _presenter.sortGenderColumn();
        }
    }
}
