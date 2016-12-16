using BusinessEntity;
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
    public partial class fmLocationManager : Form, ITourSiteView, IDestinationView
    {
        ITourSitePresenter _tourSitePresenter;
        IDestinationPresenter _destinationPresenter;
        public fmLocationManager()
        {
            InitializeComponent();
            _tourSitePresenter = new TourSitePresenter(this);
            _destinationPresenter = new DestinationPresenter(this);
            _citiesCbb.DataSource = BusinessEntity.VietNamCities.getAllCities();

            //_tourSitesClb.DataSource = _tourSiteBindingSource;

        }

        private void fmLocationManager_Load(object sender, EventArgs e)
        {
            _tourSitePresenter.loadAllTourSites();
            _destinationPresenter.loadAllDestinations();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void updateTourSiteView(IEnumerable<DTO.TourSite> tourSites)
        {
            _tourSiteBindingSource.DataSource = tourSites;

            // vì một lí do gì đó cài dòng mắc dịch này phải để sau cái dòng trên nó mới hiểu.
            // làm xấu code của ông
           // _tourSitesClb.DisplayMember = "name";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void _mainContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void _hotelsClb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkEnableTourSiteAddBtn();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void _tourSiteAddBtn_Click(object sender, EventArgs e)
        {
            listViewAddNewItem();
        }

        private void listViewAddNewItem()
        {
            var txt = _tourSiteNewItemTb.Text.Trim();
            _tourSitesTempLv.Items.Add(txt);
            _tourSiteNewItemTb.Clear();
        }

        private void _tourSiteNewItemTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                listViewAddNewItem();
            }
        }

        private void _tourSiteRemoveBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in _tourSitesTempLv.SelectedItems)
            {
                _tourSitesTempLv.Items.Remove(eachItem);
            }
        }

        private void _mainContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _hotelInfoTb_TextChanged(object sender, EventArgs e)
        {
            _hotelAddTb.Enabled = checkEnableAddBtn();
        }

        private bool checkEnableAddBtn()
        {
            if (String.IsNullOrEmpty(_hotelNameTb.Text.Trim()))
                return false;
            if (String.IsNullOrEmpty(_hotelAddressTb.Text.Trim()))
                return false;
            if (String.IsNullOrEmpty(_hotelPhoneTb.Text.Trim()))
                return false;
            return true;
        }

        private void _hotelAddTb_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.name = _hotelNameTb.Text.Trim();
            hotel.address = _hotelAddressTb.Text.Trim();
            hotel.phone = _hotelPhoneTb.Text.Trim();
            hotel.status = _hotelStatusTb.Text.Trim();
            _hotelBindingSource.Add(hotel);
            clearHotelInfoTb();
        }

        private void clearHotelInfoTb()
        {
            _hotelNameTb.Clear();
            _hotelAddressTb.Clear();
            _hotelPhoneTb.Clear();
            _hotelStatusTb.Clear();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Layout(object sender, LayoutEventArgs e)
        {
            _hotelAddTb.Enabled = checkEnableAddBtn();
        }

        private void _hotelGv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;
            if (e.ColumnIndex == 0)
                e.Value = e.RowIndex + 1;
        }

        private void _destinationTb_TextChanged(object sender, EventArgs e)
        {
            checkEnableSecondaryPanel();
            checkEnableAcceptBtn();
        }

        void checkEnableSecondaryPanel()
        {
            var isEnable = String.IsNullOrEmpty(_destinationTb.Text.Trim());
            _tourSitePanel.Enabled = !isEnable;
            _secondSpliter.Panel1.Enabled = !isEnable;
        }

        private void _mainContainer_Layout(object sender, LayoutEventArgs e)
        {
            checkEnableSecondaryPanel();
        }

        private void _tourSitesTempLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lv = (sender as ListView);
            _tourSiteRemoveBtn.Enabled = lv.SelectedItems.Count != 0;
        }

        private void _hotelGv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void _tourSitePanel_Layout(object sender, LayoutEventArgs e)
        {
            checkEnableTourSiteAddBtn();
        }

        private void checkEnableTourSiteAddBtn()
        {
            var enabled = !String.IsNullOrEmpty(_tourSiteNewItemTb.Text.Trim());
            _tourSiteAddBtn.Enabled = enabled;
        }

        private void _hotelGv_SelectionChanged(object sender, EventArgs e)
        {
            var selected = _hotelGv.SelectedRows.Count;
            _hotelRemoveTb.Enabled = selected != 0;
        }

        private void _hotelRemoveTb_Click(object sender, EventArgs e)
        {
            var selected = _hotelGv.SelectedRows;
            foreach (DataGridViewCell oneCell in _hotelGv.SelectedCells)
            {
                if (oneCell.Selected)
                    _hotelGv.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void _mainContainer_Panel1_Layout(object sender, LayoutEventArgs e)
        {
            checkEnableAcceptBtn();
        }

        private void checkEnableAcceptBtn()
        {
            bool isEmpty = String.IsNullOrEmpty(_destinationTb.Text.Trim());
            _acceptBtn.Enabled = !isEmpty;
        }

        private void _acceptBtn_Click(object sender, EventArgs e)
        {
            Destination destination = new Destination();
            destination.name = _destinationTb.Text.Trim();
            destination.city = (_citiesCbb.SelectedItem as BusinessEntity.VietNamCities.City).name;

            for (int i = 0; i < _tourSitesTempLv.Items.Count; i++)
			{
                TourSite toursite = new TourSite();
			    toursite.name =  _tourSitesTempLv.Items[i].Text;
                toursite.Destination = destination;
                destination.TourSites.Add(toursite);
			}

            for (int i = 0; i < _hotelBindingSource.Count; i++)
			{
			    var hotel = _hotelBindingSource.List[i] as Hotel;
                hotel.Destination = destination;
                destination.Hotels.Add(hotel);

			}

            _destinationPresenter.addDestination(destination);
        }

        public void updateDestinationView(IEnumerable<Destination> destinations)
        {
            _destinationBindingSource.DataSource = destinations;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
                e.Value = e.RowIndex + 1;
            if (e.ColumnIndex == 3)
            {
                if ((e.Value as IEnumerable<TourSite>) == null)
                    e.Value = 0;
                else
                    e.Value = (e.Value as IEnumerable<TourSite>).Count().ToString();

            }
            if (e.ColumnIndex == 4)
            {
                if ((e.Value as IEnumerable<Hotel>) == null)
                    e.Value = 0;
                else
                    e.Value = (e.Value as IEnumerable<Hotel>).Count().ToString();

            }
        }
    }
}
