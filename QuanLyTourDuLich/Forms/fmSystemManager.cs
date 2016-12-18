using BusinessEntity;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTourDuLich.GUI
{
    public partial class fmSystemManager : Form
    {
        AccountBUS _accountBus;
        IEnumerable<Account> _accountEntries;

        AccountTypeBUS _accountTypeBus;
        IEnumerable<AccountType> _accountTypeEntries;

        string _value;

        public fmSystemManager()
        {
            InitializeComponent();

            _accountBus = new AccountBUS();
            _accountEntries = _accountBus.getEntries();

            _accountTypeBus = new AccountTypeBUS();
            _accountTypeEntries = _accountTypeBus.getEntries();
        }

        /// <summary>
        /// Sự kiện Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmSystemManager_Load(object sender, EventArgs e)
        {
            bdsAccountList.DataSource = _accountEntries;

            txbUsername.Clear();
            txbPassword.Clear();
            txbRePassword.Clear();
            cbbAccountType.SelectedIndex = -1;

            labUsername.Hide();
            labPassword.Hide();
            labRePassword.Hide();
            labAccountType.Hide();
            btnAddAccount.Enabled = false;
        }
        private void btnTroLai2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTroLai1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Tab Quản lý tài khoản
        /// <summary>
        /// Sự kiện TextChanged của textbox Tên tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            if(txbUsername.Text == String.Empty)
            {
                labUsername.Text = "Tên tài khoản không được để trống";
                labUsername.ForeColor = Color.Red;
                labUsername.Show();
            }
            else if(txbUsername.Text.Length < 5)
            {
                labUsername.Text = "Tên tài khoản phải có ít nhất 5 ký tự";
                labUsername.ForeColor = Color.Red;
                labUsername.Show();
            }
            else if (txbUsername.Text.Length > 50)
            {
                labUsername.Text = "Tên tài khoản không được quá 50 ký tự";
                labUsername.ForeColor = Color.Red;
                labUsername.Show();
            }
            else if (isInvalid(txbUsername.Text) == false)
            {
                labUsername.Text = "Tên tài khoản không được chứa ký tự đặc biệt";
                labUsername.ForeColor = Color.Red;
                labUsername.Show();
            }
            else if (_accountBus.isExistUsername(txbUsername.Text) == true)
            {
                labUsername.Text = "Tên tài khoản đã tồn tại";
                labUsername.ForeColor = Color.Red;
                labUsername.Show();
            }
            else
            {
                labUsername.Text = "Tên tài khoản hợp lệ";
                labUsername.ForeColor = Color.Green;
                labUsername.Show();
            }

            if ((labUsername.ForeColor == Color.Green && labPassword.ForeColor == Color.Green && labRePassword.ForeColor == Color.Green && labAccountType.ForeColor == Color.Green) == true)
            {
                btnAddAccount.Enabled = true;
            }
            else
            {
                btnAddAccount.Enabled = false;
            }
        }

        /// <summary>
        /// Sự kiện TextChanged của textbox Password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            if(txbPassword.Text == String.Empty)
            {
                labPassword.Text = "Mật khẩu không được để trống";
                labPassword.ForeColor = Color.Red;
                labPassword.Show();
            }
            else if(txbPassword.Text.Length < 5)
            {
                labPassword.Text = "Mật khẩu phải có ít nhất 5 ký tự";
                labPassword.ForeColor = Color.Red;
                labPassword.Show();
            }
            else if(txbPassword.Text.Length > 50)
            {
                labPassword.Text = "Mật khẩu không quá 50 ký tự";
                labPassword.ForeColor = Color.Red;
                labPassword.Show();
            }
            else if(isInvalid(txbPassword.Text) == false)
            {
                labPassword.Text = "Mật khẩu không được chứa ký tự đặc biệt";
                labPassword.ForeColor = Color.Red;
                labPassword.Show();
            }
            else
            {
                labPassword.Text = "Mật khẩu hợp lệ";
                labPassword.ForeColor = Color.Green;
                labPassword.Show();
            }

            if ((labUsername.ForeColor == Color.Green && labPassword.ForeColor == Color.Green && labRePassword.ForeColor == Color.Green && labAccountType.ForeColor == Color.Green) == true)
            {
                btnAddAccount.Enabled = true;
            }
            else
            {
                btnAddAccount.Enabled = false;
            }
        }

        /// <summary>
        /// Sự kiện TextChanged của textbox Nhập lại mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbRePassword_TextChanged(object sender, EventArgs e)
        {
            if(txbRePassword.Text == String.Empty)
            {
                labRePassword.Text = "Vui lòng nhập lại mật khẩu";
                labRePassword.ForeColor = Color.Red;
                labRePassword.Show();
            }
            else if(txbRePassword.Text != txbPassword.Text)
            {
                labRePassword.Text = "Mật khẩu chưa trùng khớp";
                labRePassword.ForeColor = Color.Red;
                labRePassword.Show();
            }
            else
            {
                labRePassword.Text = "Mật khẩu trùng khớp";
                labRePassword.ForeColor = Color.Green;
                labRePassword.Show();
            }

            if ((labUsername.ForeColor == Color.Green && labPassword.ForeColor == Color.Green && labRePassword.ForeColor == Color.Green && labAccountType.ForeColor == Color.Green) == true)
            {
                btnAddAccount.Enabled = true;
            }
            else
            {
                btnAddAccount.Enabled = false;
            }
        }

        /// <summary>
        /// Sự kiện SelectedChanged của combobox Loại tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbAccountType.SelectedIndex == -1)
            {
                labAccountType.Text = "Vui lòng chọn loại tài khoản";
                labAccountType.ForeColor = Color.Red;
                labAccountType.Show();
            }
            else
            {
                labAccountType.ForeColor = Color.Green;
                labAccountType.Hide();
            }
            
            if ((labUsername.ForeColor == Color.Green && labPassword.ForeColor == Color.Green && labRePassword.ForeColor == Color.Green && labAccountType.ForeColor == Color.Green) == true)
            {
                btnAddAccount.Enabled = true;
            }
            else
            {
                btnAddAccount.Enabled = false;
            }
        }

        /// <summary>
        /// Sự kiện Click của button Thêm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                // thêm 1 tài khoản vào CSDL
                Account _acc = new Account();
                _acc.username = txbUsername.Text;
                _acc.password = getMD5(txbPassword.Text);
                _acc.account_type = cbbAccountType.SelectedIndex + 1;
                _accountBus.add(_acc);
           
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fmSystemManager_Load(sender, e);
                dgvAccountList.DataSource = _accountBus.getEntries();
                dgvAccountList.Refresh();
                this.Cursor = Cursors.Default;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm không thành công!\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Sự kiện Cell  Formatting của DataGridView danh sách tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAccountList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
            if (e.Value == null)
            {
                return;
            }
            if(e.ColumnIndex == 2)
            {
                if (e.Value != null)
                    e.Value = ((AccountType)e.Value).name;
            }
        }
        
        /// <summary>
        /// Sự kiện Cell click của datadridview "Danh sách tài khoản"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAccountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _value = dgvAccountList.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        /// <summary>
        /// Sự kiện Click của button Xóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                _accountBus.deleteByObj(_value);
                MessageBox.Show("Xóa thành công tài khoản: " + _value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fmSystemManager_Load(sender, e);
                dgvAccountList.DataSource = _accountBus.getEntries();
                dgvAccountList.Refresh();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công!\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Kiểm tra ký tự có thuộc bảng chữ cái và không ký tự hợp lệ
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool isInvalid(string str)
        {
            Regex _regex = new Regex(@"^[a-zA-Z0-9@_]{5,50}$");
            return _regex.IsMatch(str);

        }

        /// <summary>
        /// Mã hóa 1 chuỗi theo chuẩn MD5
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string getMD5(string str)
        {
            MD5 _md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            _md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(str));

            //get hash result after compute it
            byte[] result = _md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }





        #endregion

        
    }
}
