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

        /// <summary>
        /// Lấy tên tài khoản đã đăng nhập thành công
        /// </summary>
        public static string _username = null;

        public fmMain()
        {
            InitializeComponent();

            pnUserAccount.Hide();
        }

        /// <summary>
        /// Sự kiện Load của Form Main, phân quyền ở đây
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmMain_Load(object sender, EventArgs e)
        {
            #region Phân quyền
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
            #endregion

            //Hiển thị panel UserAccount sau khi đăng nhập thành công
            if(_username != null)
            {
                labUserAccount.Text = "Xin chào, " + _username + "!";
                pnUserAccount.Show();
            }
            else
            {
                //Đăng xuất thành công
                defaultValue();
            }

            //Cheat tài khoản master để test chương trình
            if(_username != null && _username == "master")
            {
                btnTourManager.Enabled = true;
                btnTouristsGroupManager.Enabled = true;
                btnLocationManager.Enabled = true;
                btnSearch.Enabled = true;
                btnReport.Enabled = true;
                btnSystemManager.Enabled = true;
            }
        }

        /// <summary>
        /// Form chức năng đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            fmLogin fm = new fmLogin();
            this.Hide();
            this.Cursor = Cursors.Default;
            fm.ShowDialog();
            this.fmMain_Load(sender, e);
            this.Show();
        }

        /// <summary>
        /// Quản lý hệ thống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSystemManager_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            fmSystemManager fm = new fmSystemManager();
            this.Hide();
            this.Cursor = Cursors.Default;
            fm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Tra cứu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            fmTouristsGroupManager fm = new fmTouristsGroupManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Quản lý địa điểm tham quan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocationManager_Click(object sender, EventArgs e)
        {
            fmLocationManager fm = new fmLocationManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Quản lý tour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTourManager_Click(object sender, EventArgs e)
        {
            fmTourManager fm = new fmTourManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Báo cáo / Thống kê
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button Đăng xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSingout_Click(object sender, EventArgs e)
        {
            _username = null;
            pnUserAccount.Hide();
            this.fmMain_Load(sender, e);
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Button Đổi mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            fmChangePassword fm = new fmChangePassword();
            this.Hide();
            this.Cursor = Cursors.Default;
            fm.ShowDialog();
            this.Show();
        }


        private void defaultValue()
        {
            btnTourManager.Enabled = false;
            btnTouristsGroupManager.Enabled = false;
            btnLocationManager.Enabled = false;
            btnSearch.Enabled = false;
            btnSystemManager.Enabled = false;
            btnReport.Enabled = false;
        }

        
    }
}
