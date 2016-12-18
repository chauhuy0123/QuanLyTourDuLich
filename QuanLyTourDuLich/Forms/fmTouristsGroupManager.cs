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
using System.Reflection;

namespace QuanLyTourDuLich.Forms
{
    public partial class fmTouristsGroupManager : Form
    {
        TourGroupBUS _tourGroupBus;
        IEnumerable<TourGroup> _tourGroups;

        TourBUS _tourBus;
        IEnumerable<Tour> _tours;

 
        public fmTouristsGroupManager()
        {
            InitializeComponent();

            _tourGroupBus = new TourGroupBUS();

            _tourBus = new TourBUS();

            init();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmTouristsGroupManager_Load(object sender, EventArgs e)
        {


            _tourCb.DisplayMember = "name";
            _tourCb.ValueMember = "id";

            _departDateDtp.MinDate = DateTime.Now;
            _returnDateDtp.MinDate = DateTime.Now;
        }

        private void _tourCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterBs.Filter = "tour_id = " + _tourCb.SelectedValue;
        }

        private void _tourGroupDgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.Value = e.RowIndex + 1;
            }
            if (e.ColumnIndex == 0 && e.Value != null && (Boolean)e.Value == true)
            {
                _tourGroupDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else if (e.ColumnIndex == 0 && e.Value != null)
            {
                _tourGroupDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btnCSDL_Click(object sender, EventArgs e)
        {
            if (_groupNameTb.Text.Length <= 0)
            {
                MessageBox.Show("Tên đoàn không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
      
            if (_groupNameTb.Text.Length >= 1)
            {
                TourGroup newTourGroup = new TourGroup();
                newTourGroup.name = _groupNameTb.Text;
                newTourGroup.tour_id = int.Parse(_tourCb.SelectedValue.ToString());
                newTourGroup.depart_date = _departDateDtp.Value;
                newTourGroup.return_date = _returnDateDtp.Value;

                _tourGroupBus.add(newTourGroup);

                init();
            }
        }

        private void _departDateDtp_ValueChanged(object sender, EventArgs e)
        {
            _returnDateDtp.MinDate = _departDateDtp.Value;
        }

        private void init()
        {
            _tourGroups = _tourGroupBus.getEntries();
            _tourGroupBs.DataSource = _tourGroups;
            _filterBs.DataSource = _tourGroups.ToDataTable();
            _tours = _tourBus.getEntries();
            _tourBs.DataSource = _tours;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa những dòng đã chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                foreach(DataGridViewRow row in _tourGroupDgv.Rows) {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        _tourGroupBus.deletaById(int.Parse(row.Cells[2].Value.ToString()));
                    }
                }
                init();
            }
        }
    }
}
