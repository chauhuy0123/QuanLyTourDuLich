using DTO;
using QuanLyTourDuLich.Presenters;
using QuanLyTourDuLich.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTourDuLich.Forms
{
    public partial class fmTourGroupPassengers : Form, ICustomerSearchView
    {
        TourGroup _tourGroup;

        ICustomerSearchPresenter _customerPresenter;

        public fmTourGroupPassengers(TourGroup tourgroup)
        {
            InitializeComponent();

            _customerPresenter = new CustomerSearchPresenter(this);
            _tourGroup = _customerPresenter.getTourGroupById(tourgroup.id);
        }


        private void fmTourGroupPassengers_Load(object sender, EventArgs e)
        {
            _tourGroupNameLb.DataBindings.Add("Text", _tourGroup, "name");
            _tourNameLb.DataBindings.Add("Text", _tourGroup.Tour, "name");
            _departDateLb.DataBindings.Add("Text", _tourGroup, "depart_date");
            _returnDateLb.DataBindings.Add("Text", _tourGroup, "return_date");

            //this.search(_tourGroupKeywordTb.Text.Trim());
            _customerPresenter.performClickSearch(_tourGroupKeywordTb.Text.Trim());


        }

        public void updateSearchResultView(IEnumerable<Customer> searchResult)
        {
            var isChecked = (_showStateCb as CheckBox).Checked;
            if (isChecked == true)
                searchResult = searchResult.Where(customer => customer.TourGroups.Any(t => t.id == _tourGroup.id));
            _passengerBindingSource.DataSource = searchResult;
            _countLb.Text = searchResult.Count().ToString();
        }

        private void _resultGv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (_resultGv.Columns[e.ColumnIndex].HeaderText == "STT")
            {
                e.Value = e.RowIndex + 1;

                var passengers = _passengerBindingSource.DataSource as IEnumerable<Customer>;
                if (passengers.Count() <= e.RowIndex)
                    return;
                var passenger = (_passengerBindingSource.DataSource as IEnumerable<Customer>).ElementAt(e.RowIndex);
                
                if (_tourGroup.Customers.Contains(passenger, new CustomerComparer()))
                {
                    _resultGv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(51, 255, 102);
                }
                else
                {
                    _resultGv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
            if (_resultGv.Columns[e.ColumnIndex].HeaderText == "Người nước ngoài")
            {
                if (e.Value == null)
                    e.Value = false;
            }

            if (e.Value == null)
                return;
            if (_resultGv.Columns[e.ColumnIndex].HeaderText == "Giới tính")
            {
                if (e.Value != null)
                    e.Value = ((Gender)e.Value).name;
            }


        }


        private void addAllBtn_EnabledChanged(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.Enabled)
                btn.ImageIndex = 0;
            else
                btn.ImageIndex = 1;
        }

        private void _resultGv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var customer = (_passengerBindingSource.DataSource as IEnumerable<Customer>).ElementAt(e.RowIndex);
            _customerPresenter.toggleCustomerTourGroupStatus(customer, _tourGroup);
            //this.search(_tourGroupKeywordTb.Text.Trim());
            _customerPresenter.performClickSearch(_tourGroupKeywordTb.Text.Trim());
            _resultGv.ClearSelection();
        }

        private void addAllBtn_Click(object sender, EventArgs e)
        {
            var selectedCustomer = _resultGv.SelectedRows;
            int selectedIndex;
            Customer customer = null;
            foreach (var row in selectedCustomer)
            {
                selectedIndex = (row as DataGridViewBand).Index;
                customer = (_passengerBindingSource.DataSource as IEnumerable<Customer>).ElementAt(selectedIndex);
                _customerPresenter.addPassengerToTourGroup(customer, _tourGroup);
            }
            //this.search(_tourGroupKeywordTb.Text.Trim());
            _customerPresenter.performClickSearch(_tourGroupKeywordTb.Text.Trim());
            _resultGv.ClearSelection();
        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {
            var selectedCustomer = _resultGv.SelectedRows;
            
            int selectedIndex;
            Customer customer = null;
            foreach (var row in selectedCustomer)
            {
                selectedIndex = (row as DataGridViewBand).Index;
                customer = (_passengerBindingSource.DataSource as IEnumerable<Customer>).ElementAt(selectedIndex);
                _customerPresenter.removePassengerFromTourGroup(customer, _tourGroup);
            }
            //this.search(_tourGroupKeywordTb.Text.Trim());
            _customerPresenter.performClickSearch(_tourGroupKeywordTb.Text.Trim());
            _resultGv.ClearSelection();
        }

        private void _showStateCb_CheckedChanged(object sender, EventArgs e)
        {
            //this.search(_tourGroupKeywordTb.Text.Trim());
            _customerPresenter.performClickSearch(_tourGroupKeywordTb.Text.Trim());
            _resultGv.ClearSelection();

        }

        private void search(string keyword)
        {
            var isChecked = (_showStateCb as CheckBox).Checked;
            if (isChecked)
                _customerPresenter.performClickSearch(_tourGroupKeywordTb.Text.Trim(), _tourGroup.id);
            else
                _customerPresenter.performClickSearch(_tourGroupKeywordTb.Text.Trim());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _searchBtn_Click(object sender, EventArgs e)
        {
            _customerPresenter.performClickSearch(_tourGroupKeywordTb.Text.Trim());
        }

        private void _tourGroupKeywordTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            _customerPresenter.performClickSearch(_tourGroupKeywordTb.Text.Trim());
        }
    }

    public class CustomerComparer : IEqualityComparer<Customer>
    {

        public bool Equals(Customer x, Customer y)
        {
            return x.id == y.id;
        }

        public int GetHashCode(Customer obj)
        {
            return obj.id;
        }
    }
}
