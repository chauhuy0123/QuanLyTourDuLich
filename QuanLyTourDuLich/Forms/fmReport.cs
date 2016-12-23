using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BusinessEntity;

namespace QuanLyTourDuLich.Forms
{
    public partial class fmReport : Form
    {
        TourBUS _tourBus;
        IEnumerable<Tour> _tourEntries;

        TourPriceBUS _tourPriceBus;
        IEnumerable<TourPrice> _tourPriceEntries;

        TourGroupBUS _tourGroupBus;
        IEnumerable<TourGroup> _tourGroupEntries;

        static string _tourGroupName;
        static string _tourName;
        static string _tourNameTab3;

        List<float> _revenueTotal; // Tổng doanh thu từ số vé đã bán
        List<float> _costTotal; //Tổng chi phí đã bó ra (chi phí khách sạn + chi phí di chuyển)

        List<float> _tourGroupTotal; //Tổng số đoàn của 1 tour
        List<float> _revenueTourTotal;
        List<float> _costTourTotal;

        List<float> _tourGroupTotalTab3;
        List<float> _revenueTourTotalTab3;
        List<float> _costTourTotalTab3;

        public fmReport()
        {
            InitializeComponent();

            _tourBus = new TourBUS();
            _tourEntries = _tourBus.getEntries();

            _tourPriceBus = new TourPriceBUS();
            _tourPriceEntries = _tourPriceBus.getEntries();

            _tourGroupBus = new TourGroupBUS();
            _tourGroupEntries = _tourGroupBus.getEntries();

            _revenueTotal = new List<float>();
            _costTotal = new List<float>();

            _tourGroupTotal = new List<float>();
            _revenueTourTotal = new List<float>();
            _costTourTotal = new List<float>();

            _tourGroupTotalTab3 = new List<float>();
            _revenueTourTotalTab3 = new List<float>();
            _costTourTotalTab3 = new List<float>();

            dateTimeCustom();
            dateTimeCustom2();
        }

        private void fmReport_Load(object sender, EventArgs e)
        {
            /*Tab Doanh số của Đoàn*/
            cbbTourGroupList_Load(); //Load danh sách các đoàn hiện có
            btnTourGroupReport.Enabled = false;
            btnTourGroupPrint.Enabled = false;

            /*Tab Doanh số của Tour*/
            cbbTourList_Load(); //Load danh sách tour
            btnTourReport.Enabled = false;
            btnTourReportPrint.Enabled = false;

            /*Tab Tình hình hoạt động của các Tour*/
            cbbTourStatusReport_Load();
            btnTourStatusReport.Enabled = false;
            btnTourStatusReportPrint.Enabled = false;
        }

        #region Tab1: Doanh số của đoàn
        /// <summary>
        /// Button back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Load các danh sách đoàn du lịch hiện có
        /// </summary>
        /// <param name="tour"></param>
        private void cbbTourGroupList_Load()
        {
            cbbTourGroupList.Items.Add("--- Chọn tất cả ---");
            foreach (var tourGroup in _tourGroupEntries)
            {
                cbbTourGroupList.Items.Add(tourGroup.name);
            }
        }

        /// <summary>
        /// Sự kiện SelectedIndexChanged của combobox danh sách đoàn du lịch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbTourGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Chọn tất cả đoàn
                if (cbbTourGroupList.SelectedIndex == 0)
                {
                    btnTourGroupReport.Enabled = true;
                }
                else
                {
                    btnTourGroupReport.Enabled = true;
                    _tourGroupName = cbbTourGroupList.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        /// <summary>
        /// Custom DateTimePicker
        /// </summary>
        public void dateTimeCustom()
        {
            try
            {
                /*<--- From month --->*/
                // Tab: Doanh số của đoàn
                dtpFromDate.Format = DateTimePickerFormat.Custom;
                dtpFromDate.CustomFormat = "MM/yyyy";
                dtpFromDate.ShowUpDown = true;
                dtpFromDate.MinDate = _tourGroupBus.getMinDepartDate();
                dtpFromDate.MaxDate = _tourGroupBus.getMaxDepartDate();
                dtpFromDate.Value = dtpFromDate.MinDate;

                /*<--- To month --->*/
                // Tab: Doanh số của đoàn
                dtpToDate.Format = DateTimePickerFormat.Custom;
                dtpToDate.CustomFormat = "MM/yyyy";
                dtpToDate.ShowUpDown = true;
                dtpToDate.MinDate = dtpFromDate.Value.Date;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện click của button Báo cáo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTourGroupReport_Click(object sender, EventArgs e)
        {
            try
            {
                bdsTourGroupReport.DataSource = null;
                _revenueTotal.Clear();
                _costTotal.Clear();

                dgvTourGroupReport.Rows.Clear();
                dgvTourGroupReport.Refresh();

                if (_tourGroupName == null && cbbTourGroupList.SelectedIndex != 0)
                {
                    MessageBox.Show("Tên đoàn chưa đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnTourGroupPrint.Enabled = false;
                }

                //Chọn tất cả đoàn
                if (cbbTourGroupList.SelectedIndex == 0)
                {
                    foreach (var tourGroup in _tourGroupEntries)
                    {
                        if (tourGroup.depart_date.Year >= dtpFromDate.Value.Year && tourGroup.depart_date.Year <= dtpToDate.Value.Year)
                        {
                            if(tourGroup.depart_date.Month >= dtpFromDate.Value.Month && tourGroup.depart_date.Month <= dtpToDate.Value.Month)
                            {
                                bdsTourGroupReport.Add(tourGroup);

                                //Tổng danh thu từ tiền vé
                                _revenueTotal.Add((float)tourGroup.Customers.Count * (float)tourGroup.Tour.TourPrice.price); 
                                
                                //Tổng chi phí (cchi phí khách sạn + chi phí di chuyển)
                                _costTotal.Add((float)tourGroup.Customers.Count * ((float)tourGroup.Tour.Destination.Hotels.Sum(hotel => hotel.price) + (float)tourGroup.Transports.Sum(t => t.price)));

                            }
                            
                        }
                    }

                }
                else
                {
                    IEnumerable<TourGroup> _temp = _tourGroupBus.getAllTourGroupByName(_tourGroupName);
                    foreach (var tourGroup in _temp)
                    {
                        if (tourGroup.depart_date.Year >= dtpFromDate.Value.Year && tourGroup.depart_date.Year <= dtpToDate.Value.Year)
                        {
                            if (tourGroup.depart_date.Month >= dtpFromDate.Value.Month && tourGroup.depart_date.Month <= dtpToDate.Value.Month)
                            {
                                bdsTourGroupReport.Add(tourGroup);

                                //Tổng doanh thu tự tiền vé
                                _revenueTotal.Add((float)tourGroup.Customers.Count * (float)tourGroup.Tour.TourPrice.price);

                                //Tổng chi phí (chi phí khách sạn + chi phí di chuyển)
                                _costTotal.Add((float)tourGroup.Customers.Count * ((float)tourGroup.Tour.Destination.Hotels.Sum(hotel => hotel.price) + (float)tourGroup.Transports.Sum(t => t.price)));

                            }
                        }
                    }
                }
                if (dgvTourGroupReport.RowCount == 0)
                {
                    btnTourGroupPrint.Enabled = false;
                }
                else
                {
                    btnTourGroupPrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dgvTourGroupReport.DataSource != null)
            {
                btnTourGroupPrint.Enabled = true;
            }
        }


        private void dgvTourGroupReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    e.Value = e.RowIndex + 1;
                }
                if (e.Value == null)
                {
                    return;
                }
                if (e.ColumnIndex == 3)
                {
                    e.Value = (e.Value as Tour).name;
                }
                if (e.ColumnIndex == 6)
                {
                    e.Value = _revenueTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 7)
                {
                    e.Value = _costTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 8)
                {
                    e.Value = _revenueTotal[e.RowIndex] - _costTotal[e.RowIndex]; //Lợi nhuận
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        #endregion

        #region Tab2: Doanh số của tour

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Load danh sách tour hiện có
        /// </summary>
        private void cbbTourList_Load()
        {
            cbbTourList.Items.Add("--- Chọn tất cả ----");
            foreach (var tour in _tourEntries)
            {
                cbbTourList.Items.Add(tour.name);
            }
        }

        /// <summary>
        /// Combobox Tour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbTourList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Chọn tất cả tour
                if (cbbTourList.SelectedIndex == 0)
                {
                    btnTourReport.Enabled = true;
                }
                else
                {
                    btnTourReport.Enabled = true;
                    _tourName = cbbTourList.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void dateTimeCustom2()
        {
            try
            {
                dtpFromDate2.Format = DateTimePickerFormat.Custom;
                dtpFromDate2.CustomFormat = "MM/yyyy";
                dtpFromDate2.ShowUpDown = true;
                dtpFromDate2.MinDate = _tourPriceBus.getMinStartDate();
                dtpFromDate2.MaxDate = _tourPriceBus.getMaxStartDate();
                dtpFromDate2.Value = dtpFromDate2.MinDate;

                dtpToDate2.Format = DateTimePickerFormat.Custom;
                dtpToDate2.CustomFormat = "MM/yyyy";
                dtpToDate2.ShowUpDown = true;
                dtpToDate2.MinDate = dtpFromDate2.Value.Date;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button Báo cáo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTourReport_Click(object sender, EventArgs e)
        {
            try
            {
                bdsTourReport.DataSource = null;
                _tourGroupTotal.Clear();
                _revenueTourTotal.Clear();
                _costTourTotal.Clear();

                dgvTourReport.Rows.Clear();
                dgvTourReport.Refresh();

                if (_tourName == null && cbbTourList.SelectedIndex != 0)
                {
                    MessageBox.Show("Tên Tour chưa đúng! Vui lòng chọn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Chọn tất cả
                if (cbbTourList.SelectedIndex == 0)
                {
                    foreach (var tour in _tourEntries)
                    {
                        if (tour.TourPrice.start_date.Year >= dtpFromDate2.Value.Year && tour.TourPrice.start_date.Year <= dtpToDate2.Value.Year)
                        {
                            if (tour.TourPrice.start_date.Month >= dtpFromDate2.Value.Month && tour.TourPrice.start_date.Month <= dtpToDate2.Value.Month)
                            {
                                bdsTourReport.Add(tour);

                                //Tổng số đoàn của 1 tour
                                _tourGroupTotal.Add(tour.TourGroups.Count);

                                //Tổng doanh thu của 1 tour từ tiền vé
                                _revenueTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * (float)tour.TourPrice.price);

                                //Tổng chi phí
                                _costTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * ((float)tour.Destination.Hotels.Sum(ht => ht.price) + (float)tour.TourGroups.Sum(tg => tg.Transports.Sum(tp => tp.price))));
                            }
                        }
                    }
                }
                else
                {
                    IEnumerable<Tour> _tourTemp = _tourBus.getAllTourByName(_tourName);
                    foreach (var tour in _tourTemp)
                    {
                        if (tour.TourPrice.start_date.Year >= dtpFromDate2.Value.Year && tour.TourPrice.start_date.Year <= dtpToDate2.Value.Year)
                        {
                            if (tour.TourPrice.start_date.Month >= dtpFromDate2.Value.Month && tour.TourPrice.start_date.Month <= dtpToDate2.Value.Month)
                            {
                                bdsTourReport.Add(tour);

                                //Tổng số đoàn của 1 tour
                                _tourGroupTotal.Add(tour.TourGroups.Count);

                                //Tổng doanh thu của 1 tour từ tiền vé
                                _revenueTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * (float)tour.TourPrice.price);

                                //Tổng chi phí
                                _costTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * ((float)tour.Destination.Hotels.Sum(ht => ht.price) + (float)tour.TourGroups.Sum(tg => tg.Transports.Sum(tp => tp.price))));
                            }
                        }
                    }
                }

                if (dgvTourReport.RowCount == 0)
                {
                    btnTourReportPrint.Enabled = false;
                }
                else
                {
                    btnTourReportPrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvTourReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    e.Value = e.RowIndex + 1;
                }
                if (e.Value == null)
                {
                    return;
                }
                if (e.ColumnIndex == 3)
                {
                    e.Value = (e.Value as TourPrice).start_date.ToShortDateString();
                }
                if (e.ColumnIndex == 4)
                {
                    e.Value = (e.Value as TourPrice).end_date.ToShortDateString();
                }
                if (e.ColumnIndex == 5)
                {
                    e.Value = _tourGroupTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 6)
                {
                    e.Value = _revenueTourTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 7)
                {
                    e.Value = _costTourTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 8)
                {
                    e.Value = _revenueTourTotal[e.RowIndex] - _costTourTotal[e.RowIndex];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        #endregion

        #region Tab 3: Tình hình hoạt động của các Tour
        private void btnBack3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTourStatusReport_Load()
        {
            cbbTourStatusReport.Items.Add("--- Chọn tất cả ---");
            foreach (var tour in _tourEntries)
            {
                cbbTourStatusReport.Items.Add(tour.name);
            }
        }

        private void cbbTourStatusReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Chọn tất cả tour
                if (cbbTourStatusReport.SelectedIndex == 0)
                {
                    btnTourStatusReport.Enabled = true;

                }
                else
                {
                    btnTourStatusReport.Enabled = true;
                    _tourNameTab3 = cbbTourStatusReport.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button báo cáo của Tab Tình hình hoạt động của các Tour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTourStatusReport_Click(object sender, EventArgs e)
        {
            try
            {
                bdsTourStatusReport.DataSource = null;

                _tourGroupTotalTab3.Clear();
                _revenueTourTotalTab3.Clear();
                _costTourTotalTab3.Clear();

                dgvTourStatusReport.Rows.Clear();
                dgvTourStatusReport.Refresh();

                if (_tourNameTab3 == null && cbbTourStatusReport.SelectedIndex != 0)
                {
                    MessageBox.Show("Tên Tour chưa đúng! Vui lòng chọn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Chọn tất cả
                if (cbbTourStatusReport.SelectedIndex == 0)
                {
                    foreach (var tour in _tourEntries)
                    {
                        bdsTourStatusReport.Add(tour);

                        _tourGroupTotalTab3.Add(tour.TourGroups.Count);

                        //Tổng doanh thu của 1 tour từ tiền vé
                        _revenueTourTotalTab3.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * (float)tour.TourPrice.price);

                        //Tổng chi phí
                        _costTourTotalTab3.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * ((float)tour.Destination.Hotels.Sum(ht => ht.price) + (float)tour.TourGroups.Sum(tg => tg.Transports.Sum(tp => tp.price))));
                    }
                }
                else
                {
                    IEnumerable<Tour> _tourStatusTemp = _tourBus.getAllTourByName(_tourNameTab3);

                    foreach (var tour in _tourStatusTemp)
                    {
                        bdsTourStatusReport.Add(tour);

                        _tourGroupTotalTab3.Add(tour.TourGroups.Count);

                        //Tổng doanh thu của 1 tour từ tiền vé
                        _revenueTourTotalTab3.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * (float)tour.TourPrice.price);

                        //Tổng chi phí
                        _costTourTotalTab3.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * ((float)tour.Destination.Hotels.Sum(ht => ht.price) + (float)tour.TourGroups.Sum(tg => tg.Transports.Sum(tp => tp.price))));
                    }
                }

                if (dgvTourStatusReport.RowCount == 0)
                {
                    btnTourStatusReportPrint.Enabled = false;
                }
                else
                {
                    btnTourStatusReportPrint.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTourStatusReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    e.Value = e.RowIndex + 1;
                }
                if (e.Value == null)
                {
                    return;
                }
                if (e.ColumnIndex == 3)
                {
                    e.Value = (e.Value as TourCategory).name;
                }
                if (e.ColumnIndex == 4)
                {
                    e.Value = (e.Value as TourPrice).start_date.ToShortDateString();
                }
                if (e.ColumnIndex == 5)
                {
                    e.Value = (e.Value as TourPrice).end_date.ToShortDateString();
                }
                if (e.ColumnIndex == 6)
                {
                    e.Value = _tourGroupTotalTab3[e.RowIndex];
                }
                if (e.ColumnIndex == 7)
                {
                    e.Value = _revenueTourTotalTab3[e.RowIndex] - _costTourTotalTab3[e.RowIndex];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        
    }
}
