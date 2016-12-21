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

        TourGroupBUS _tourGroupBus;
        IEnumerable<TourGroup> _tourGroupEntries;

        static string _tourGroupName;
        static int _year;
        static int _month;

        public fmReport()
        {
            InitializeComponent();

            _tourBus = new TourBUS();
            _tourEntries = _tourBus.getEntries();

            _tourGroupBus = new TourGroupBUS();

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
            bdsTourGroupReport.DataSource = null;
            dgvTourGroupReport.Rows.Clear();
            dgvTourGroupReport.Refresh();
            if (cbbTourGroupList.SelectedIndex == 0)
            {
                foreach (var tourGroup in _tourGroupEntries)
                {
                    if (tourGroup.depart_date.Year <= _year)
                    {
                        if (tourGroup.depart_date.Month <= _month)
                        {
                            bdsTourGroupReport.Add(tourGroup);
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
                        }
                    }
                }
            }

            if (dgvTourGroupReport.DataSource != null)
            {
                btnTourGroupPrint.Enabled = true;
            }
        }


        private void dgvTourGroupReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
                e.Value = ((e.Value as TourGroup).Customers.Count * (e.Value as TourPrice).price);
            }
        }



        #endregion


    }
}
