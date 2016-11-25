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
        public fmMain()
        {
            InitializeComponent();
        }

        private void btnfmDangNhap_Click(object sender, EventArgs e)
        {
            fmDangNhap fm = new fmDangNhap();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnQuanLyHeThong_Click(object sender, EventArgs e)
        {
            fmQuanLyHeThong fm = new fmQuanLyHeThong();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            fmTraCuu fm = new fmTraCuu();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }
    }
}
