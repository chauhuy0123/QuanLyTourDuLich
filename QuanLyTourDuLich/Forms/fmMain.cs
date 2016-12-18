using QuanLyTourDuLich.Forms;
using QuanLyTourDuLich.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyTourDuLich
{
    public partial class fmMain : Form
    {
        /// <summary>
        /// Dùng để lấy loại account
        /// </summary>
        public static int _accountType = 0;

        public fmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sự kiện Load của Form Main, phân quyền ở đây
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmMain_Load(object sender, EventArgs e)
        {
            //Tài khoản: Admin
            if (_accountType == 1)
            {
                //Được dùng
                btnSystemManager.Enabled = true;

                //Ko đc dùng
                btnTourManager.Enabled = false;
                btnTouristsGroupManager.Enabled = false;
                btnLocationManager.Enabled = false;
                btnReport.Enabled = false;
                btnSearch.Enabled = false;

            }
            //Tài khoản: Giám đốc
            else if (_accountType == 2)
            {
                //Được dùng
                btnSearch.Enabled = true;

                //Ko đc dùng
                btnTourManager.Enabled = false;
                btnTouristsGroupManager.Enabled = false;
                btnLocationManager.Enabled = false;
                btnReport.Enabled = false;
                btnSystemManager.Enabled = false;
            }
            //Tài khoản: Nhân viên quản lý
            else if (_accountType == 3)
            {
                //Được dùng
                btnTourManager.Enabled = true;
                btnTouristsGroupManager.Enabled = true;
                btnLocationManager.Enabled = true;
                btnSearch.Enabled = true;

                //Ko đc dùng
                btnReport.Enabled = false;
                btnSystemManager.Enabled = false;
            }
            //Tài khoản: Nhân viên kế toán
            else if (_accountType == 4)
            {
                //Được dùng
                btnReport.Enabled = true;

                //Ko đc dùng
                btnTourManager.Enabled = false;
                btnTouristsGroupManager.Enabled = false;
                btnLocationManager.Enabled = false;
                btnSearch.Enabled = false;
                btnSystemManager.Enabled = false;
            }
            //Chưa đăng nhập
            else
            {
                //Hiện tại chưa hoàn thành nên chú thích cái đống này lại để tiện test các chức năng
                //btnTourManager.Enabled = false;
                //btnTouristsGroupManager.Enabled = false;
                //btnLocationManager.Enabled = false;
                //btnSearch.Enabled = false;
                //btnSystemManager.Enabled = false;
                //btnReport.Enabled = false;
            }
        }

        /// <summary>
        /// Form chức năng đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            fmLogin fm = new fmLogin();
            this.Hide();
            fm.ShowDialog();
            this.fmMain_Load(sender, e);
            this.Show();
        }

        /// <summary>
        /// Form chức năng Quản lý hệ thống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSystemManager_Click(object sender, EventArgs e)
        {
            fmSystemManager fm = new fmSystemManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            fmSearch fm = new fmSearch();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnKetNoiCSDL_Click(object sender, EventArgs e)
        {
            fmConnectDatabase fm = new fmConnectDatabase();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        //
        //Button: Quản lý đoàn / btnTouristsGroupManager
        //
        private void btnTouristsGroupManager_Click(object sender, EventArgs e)
        {
            frmTourGroupManager fm = new frmTourGroupManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnLocationManager_Click(object sender, EventArgs e)
        {
            fmLocationManager fm = new fmLocationManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnTourManager_Click(object sender, EventArgs e)
        {
            fmTourManager fm = new fmTourManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        
    }
}
