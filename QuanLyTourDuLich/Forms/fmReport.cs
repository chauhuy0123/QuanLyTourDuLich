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

        TourGroupFeeBUS _tourGroupFeeBus;
        IEnumerable<TourGroupFee> _tourGroupFeeEntries;

        DestinationBUS _destinationBus;
        IEnumerable<Destination> _destinationEntries;

        HotelBUS _hotelBus;
        IEnumerable<Hotel> _hotelEntries;

        TransportBUS _transportBus;
        IEnumerable<Transport> _transportEntries;

        static string _tourGroupName;
        static int _year;
        static int _month;

        List<decimal> _ticketPriceTotal;
        List<decimal> _costTotal;

        public fmReport()
        {
            InitializeComponent();

            _tourBus = new TourBUS();
            _tourEntries = _tourBus.getEntries();

            _tourPriceBus = new TourPriceBUS();

            _tourGroupBus = new TourGroupBUS();

            _tourGroupFeeBus = new TourGroupFeeBUS();

            _destinationBus = new DestinationBUS();

            _hotelBus = new HotelBUS();

            _transportBus = new TransportBUS();

            btnTourGroupReport.Enabled = false;
            btnTourGroupPrint.Enabled = false;
        }

        private void fmReport_Load(object sender, EventArgs e)
        {
            cbbTourList_Load();
            cbbYear_Load();
            cbbMonth_Load();
        }

        #region Tab Doanh số của một đoàn
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
        /// Load danh sách các tour hiện có vào combobox Tour
        /// </summary>
        private void cbbTourList_Load()
        {
            foreach (var tour in _tourEntries)
            {
                cbbTourList.Items.Add(tour.name);
            }
        }

        /// <summary>
        /// Sự kiện SelectedIndexChanged của combobox Danh sách tour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbTourList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTourGroupList.Items.Clear();
            foreach (var tour in _tourEntries)
            {
                if (cbbTourList.SelectedItem.ToString() == tour.name)
                {
                    cbbTourGroupList_Load(tour);
                }
            }

            if (cbbYear.SelectedIndex != -1 && cbbMonth.SelectedIndex != -1 && cbbTourList.SelectedIndex != -1 && cbbTourGroupList.SelectedIndex != -1)
            {
                btnTourGroupReport.Enabled = true;
            }
            else
            {
                btnTourGroupReport.Enabled = false;
            }
        }

        /// <summary>
        /// Load các danh sách đoàn du lịch theo tour đã chọn
        /// </summary>
        /// <param name="tour"></param>
        private void cbbTourGroupList_Load(Tour tour)
        {
            _tourGroupEntries = _tourGroupBus.getTourGroupByTour(tour);
            cbbTourGroupList.Items.Add("Chọn tất cả");
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
            _tourGroupName = cbbTourGroupList.SelectedItem.ToString();

            if (cbbYear.SelectedIndex != -1 && cbbMonth.SelectedIndex != -1 && cbbTourList.SelectedIndex != -1 && cbbTourGroupList.SelectedIndex != -1)
            {
                btnTourGroupReport.Enabled = true;
            }
            else
            {
                btnTourGroupReport.Enabled = false;
            }
        }

        /// <summary>
        /// Load danh sách các năm của các đoàn du lịch
        /// </summary>
        private void cbbYear_Load()
        {
            DateTime _min = new DateTime();
            DateTime _max = new DateTime();

            _min = _tourGroupBus.getMinDepartDate();
            _max = _tourGroupBus.getMaxReturnDate();

            for (int i = _min.Year; i <= _max.Year; i++)
            {
                cbbYear.Items.Add(i);
            }
        }

        /// <summary>
        /// Sự kiện SelectedIndexChanged của combobox năm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            _year = Int32.Parse(cbbYear.SelectedItem.ToString().Trim());

            if (cbbYear.SelectedIndex != -1 && cbbMonth.SelectedIndex != -1 && cbbTourList.SelectedIndex != -1 && cbbTourGroupList.SelectedIndex != -1)
            {
                btnTourGroupReport.Enabled = true;
            }
            else
            {
                btnTourGroupReport.Enabled = false;
            }
        }

        /// <summary>
        /// Danh sách các tháng trong năm
        /// </summary>
        private void cbbMonth_Load()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbbMonth.Items.Add("Tháng " + i);
            }
        }

        /// <summary>
        /// Sự kiện SelectedIndexChanged của combobox tháng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            _month = cbbMonth.SelectedIndex + 1;

            if (cbbYear.SelectedIndex != -1 && cbbMonth.SelectedIndex != -1 && cbbTourList.SelectedIndex != -1 && cbbTourGroupList.SelectedIndex != -1)
            {
                btnTourGroupReport.Enabled = true;
            }
            else
            {
                btnTourGroupReport.Enabled = false;
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

                dgvTourGroupReport.Rows.Clear();
                dgvTourGroupReport.Refresh();

                Tour _tourTemp = new Tour();
                TourPrice _tourPriceTemp = new TourPrice();
                TourGroupFee _tgfTemp = new TourGroupFee();
                Destination _desTemp = new Destination();
                Hotel _hotelTemp = new Hotel();

                _ticketPriceTotal = new List<decimal>();
                _costTotal = new List<decimal>();

                if (cbbTourGroupList.SelectedIndex == 0)
                {
                    foreach (var tourGroup in _tourGroupEntries)
                    {
                        if (tourGroup.depart_date.Year <= _year)
                        {
                            if (tourGroup.depart_date.Month <= _month)
                            {
                                bdsTourGroupReport.Add(tourGroup);
                                _tourTemp = _tourBus.getCustomerById(tourGroup.tour_id); // Lấy thông tin Tour
                                _tourPriceTemp = _tourPriceBus.getCustomerById(_tourTemp.tour_price_id); //Lấy thông tin TourPrice
                                _ticketPriceTotal.Add((tourGroup.Customers.Count) * _tourPriceTemp.price); //Tổng giá vé = (Tổng số người * giá tour)

                                //_tgfTemp = _tourGroupFeeBus.getTourGroupFeeByTG(tourGroup); //Lấy TourGroupFee
                                _desTemp = _destinationBus.getCustomerById(_tourTemp.destination_id); //Lấy điểm đến
                                _hotelTemp = _hotelBus.getHotelByDesId(_desTemp); // Lấy thông tin của Hotel

                                //Tính tổng chi phí
                                _tgfTemp.hotel_fee = (double)((tourGroup.Customers.Count) * _hotelTemp.price); // Chi phí khách sạn
                                _tgfTemp.transport_fee = (double)((tourGroup.Customers.Count) * tourGroup.Transports.Sum(t => t.price)); //Chi phí transport
                                //_tgfTemp.tourgroup_id = tourGroup.id;

                                _costTotal.Add((decimal)(_tgfTemp.hotel_fee + _tgfTemp.transport_fee));

                            }
                        }
                    }

                }
                else
                {
                    IEnumerable<TourGroup> _temp = _tourGroupBus.getAllTourGroupByName(_tourGroupName);
                    foreach (var tourGroup in _temp)
                    {
                        if (tourGroup.depart_date.Year <= _year)
                        {
                            if (tourGroup.depart_date.Month <= _month)
                            {
                                bdsTourGroupReport.Add(tourGroup);

                                _tourTemp = _tourBus.getCustomerById(tourGroup.tour_id); // Lấy thông tin Tour
                                _tourPriceTemp = _tourPriceBus.getCustomerById(_tourTemp.tour_price_id); //Lấy thông tin TourPrice
                                _ticketPriceTotal.Add((tourGroup.Customers.Count) * _tourPriceTemp.price); //Tổng giá vé = (Tổng số người * giá tour)

                                //Tính tổng chi phí
                                _tgfTemp.hotel_fee = (double)((tourGroup.Customers.Count) * _hotelTemp.price); // Chi phí khách sạn
                                _tgfTemp.transport_fee = (double)((tourGroup.Customers.Count) * tourGroup.Transports.Sum(t => t.price)); //Chi phí transport
                                //_tgfTemp.tourgroup_id = tourGroup.id;

                                _costTotal.Add((decimal)(_tgfTemp.hotel_fee + _tgfTemp.transport_fee));
                            }
                        }
                    }
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
                if (e.ColumnIndex == 5)
                {
                    e.Value = _ticketPriceTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 6)
                {
                    e.Value = _costTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 7)
                {
                    e.Value = _ticketPriceTotal[e.RowIndex] - _costTotal[e.RowIndex];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
            




        #endregion


    }
}
