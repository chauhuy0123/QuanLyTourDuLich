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
using DTO;

namespace QuanLyTourDuLich.Forms
{
    public partial class fmTourManager : Form
    {
        TourBUS _tourBus;
        IEnumerable<Tour> _tour;
        TourCategoryBUS _categoryBus;
        IEnumerable<TourCategory> _category;
        DestinationBUS _destinationBus;
        IEnumerable<Destination> _destination;
        TourSiteBUS _toursiteBus;
        IEnumerable<TourSite> _toursite;
        TourPriceBUS _priceBus;
        IEnumerable<TourPrice> _price;
        DateTime _minDate;
        DateTime _maxDate;
        TourPrice tourPrice;
        bool _isAdd;
        Tour _currentTour;

        public fmTourManager()
        {
            InitializeComponent();
            postInit();
            _tourBus = new TourBUS();
            _categoryBus = new TourCategoryBUS();
            _destinationBus = new DestinationBUS();
            _toursiteBus = new TourSiteBUS();
            _priceBus = new TourPriceBUS();
            _tour = _tourBus.getEntries();
            _category = _categoryBus.getEntries();
            _destination = _destinationBus.getEntries();
            _isAdd = true;
            _currentTour = new Tour();
            _minDate = new DateTime(2000, 1, 1);
            _maxDate = new DateTime(2100, 1, 1);
            dtpStart_date.MinDate = _minDate;
            dtpStart_date.MaxDate = _maxDate;
            dtpEnd_date.MinDate = _minDate;
            dtpEnd_date.MaxDate = _maxDate;
            dtpEnd_date.Value = _maxDate;
            
        }
        private void postInit()
        {
            ((ListBox)clbTourSite).DataSource = bsTourSite;
            ((DataGridView)dgvListTour).DataSource = bsListTour;
            ((ComboBox)cbTourCategory).DataSource = bsCategory;
            ((ComboBox)cbDestination).DataSource = bsDestination;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmTourManager_Load(object sender, EventArgs e)
        {
           
            bsDestination.DataSource = _destination;
            bsCategory.DataSource = _category;
            ((ComboBox)cbTourCategory).DataSource = bsCategory;
            ((ComboBox)cbTourCategory).DisplayMember = "name";
            ((ListBox)clbTourSite).DisplayMember = "name";
            ((ListBox)clbTourSite).ValueMember = "id";
            ((ComboBox)cbDestination).DataSource = bsDestination;
            ((ComboBox)cbDestination).DisplayMember = "name";
         
            bsListTour.DataSource = _tour;
            //((DataGridView)dgvListTour).DataSource = bsListTour;
        }

        private void dgvListTour_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
            else
            {
                if (e.Value == null)
                    return;
            }
           
            if (e.ColumnIndex == 3)
            {
                e.Value = (e.Value as Destination).name;
            }
            if (e.ColumnIndex == 4)
            {
                e.Value = (e.Value as TourPrice).price.ToString().Trim();
            }
            if (e.ColumnIndex == 5)
            {
                e.Value = (e.Value as TourPrice).start_date.ToString("dd/MM/yyyy");
            }
            if (e.ColumnIndex == 6)
            {
                e.Value = (e.Value as TourCategory).name;
            }
            
        }

        
        private void addTourSite()
        {
            
        }

        private void cbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbDestination_SelectedValueChanged(object sender, EventArgs e)
        {
            var des =cbDestination.SelectedItem as Destination;
            _toursite = des.TourSites;
            bsTourSite.DataSource = _toursite;
            clbTourSite.Refresh();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            if (_isAdd)
            {
                if (tbTourName.Text.Trim() == "" || tbTourPrice.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill textbox!");
                    return;
                }
                Tour tour = new Tour();
                var category = (TourCategory)cbTourCategory.SelectedItem;
                var destination = (Destination)cbDestination.SelectedItem;
     
                tour.name = tbTourName.Text.ToString();
                tour.category_id = category.id;
                tour.destination_id = destination.id;
                if (addNewTourPrice() == null)
                {
                    return;
                }else
                    tour.TourPrice = addNewTourPrice();
                //tour.TourPrice.Tours.Add(tour);

                /*var _newtoursite = clbTourSite.CheckedItems.Cast<TourSite>();
                var b = new TourSiteBUS();
                //foreach (var site in _newtoursite)
                //{
                //    site.Tours.Add(tour);
                //    b.update(site);
                //}

                //tour.TourSites = _newtoursite.ToList();
                _tourBus.add(tour);

                var tourbus = new TourBUS();
                var t = tourbus.getCustomerById(tour.id);
                foreach (var site in _newtoursite)
                {
                    //var toursite = b.getCustomerById(site.id);
                    //toursite.Tours.Add(tour);
                    //b.update(toursite);
                    t.TourSites.Add(site);
                }
                tourbus.update(t);*/
                _tourBus.add(tour);
                updateDataGridView();
            }
            else
            {
                updateTour();
            }
        }
        private void updateTour() {
            var category =cbTourCategory.SelectedItem as TourCategory;
            var destination =cbDestination.SelectedItem as Destination;

            _currentTour.name = tbTourName.Text.ToString();
            _currentTour.category_id = category.id;
            _currentTour.destination_id = destination.id;
            _currentTour.TourPrice.price = decimal.Parse(tbTourPrice.Text.Trim());
            _currentTour.TourPrice.start_date = dtpStart_date.Value;
            _currentTour.TourPrice.end_date = dtpEnd_date.Value;
            _tourBus.update(_currentTour);
            _isAdd = true;
            btnAddTour.Text = "Add";
            updateDataGridView();
             
        }
       
        private void updateDataGridView()
        {
            // new lai cho no cap nhat lai. ma vay so no cham.
            _tourBus = new TourBUS();
            _tour = _tourBus.getEntries();
            //bsListTour.DataSource = null;
            bsListTour.DataSource = _tour;
            //((DataGridView)dgvListTour).DataSource = bsListTour;
            //dgvListTour.Refresh(); 
            tbTourName.Clear();
            tbTourPrice.Clear();
            dtpStart_date.Value = DateTime.Now;
            dtpEnd_date.Value = _maxDate;
            
        }
        private TourPrice addNewTourPrice()
        {
            DateTime start_date = dtpStart_date.Value;
            DateTime end_date = dtpEnd_date.Value;
            decimal price = 0;
            try
            {
                price = decimal.Parse(tbTourPrice.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Price must be number!");
                tbTourPrice.Clear();
                tbTourPrice.Focus();
                return null;
            }
            tourPrice = new DTO.TourPrice();
            tourPrice.price = price;
            tourPrice.start_date = start_date;
            tourPrice.end_date = end_date;
            return tourPrice;
        }
        

        private void tbTourPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSelectAll.Checked)
            {
                for (int i = 0; i < clbTourSite.Items.Count; i++)
                {
                    clbTourSite.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < clbTourSite.Items.Count; i++)
                {
                    clbTourSite.SetItemChecked(i, false);
                }
            }
            
        }

        private void dgvListTour_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _isAdd = false;
            btnAddTour.Text = "Update";
            int current_id = (int)dgvListTour.CurrentRow.Cells[1].Value;
            _currentTour = _tourBus.getCustomerById(current_id);
            tbTourName.Text = _currentTour.name;
            tbTourPrice.Text = _currentTour.TourPrice.price.ToString("0.00");
            cbTourCategory.SelectedItem = _currentTour.TourCategory;
            cbTourCategory.Text = _currentTour.TourCategory.name;
            cbDestination.SelectedItem = _currentTour.Destination;
            cbDestination.Text = _currentTour.Destination.name;
            dtpStart_date.Value = _currentTour.TourPrice.start_date;
            dtpEnd_date.Value = _currentTour.TourPrice.end_date;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentTour != null)
                _tourBus.delete(_currentTour);
            else return;
            updateDataGridView();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _isAdd = true;
            updateDataGridView();
            _currentTour = null;
            btnAddTour.Text="Add";
        }

        private void cbCatgory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var category = cbTourCategory.SelectedItem as TourCategory;
           
        }

        
    }
}
