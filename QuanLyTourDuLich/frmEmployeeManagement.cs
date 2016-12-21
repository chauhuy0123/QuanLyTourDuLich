using BusinessEntity;
using DTO;
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
    public partial class frmEmployeeManagement : Form
    {
        EmployeeBUS _employeeBus;
        EmployeeRoleBUS _employeeRoleBus;

        IEnumerable<Employee> _employees;
        IEnumerable<EmployeeRole> _employeeRoles;

        public frmEmployeeManagement()
        {
            InitializeComponent();

            _employeeBus = new EmployeeBUS();
            _employeeRoleBus = new EmployeeRoleBUS();

        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            init();
            employeeRoleCb.DisplayMember = "name";
        }

        private void init()
        {
            _employees = _employeeBus.getEntries();
            _employeeRoles = _employeeRoleBus.getEntries();

            employeesBs.DataSource = _employees.ToDataTable();
            employeeRolesBs.DataSource = _employeeRoles;
        }

        private void employeeRoleCb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (employeeRoleCb.SelectedValue != null)
            {
                employeesBs.Filter = "role = " + employeeRoleCb.SelectedValue;
            }
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (employeeNameTb.Text.Length <= 0)
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (employeeNameTb.Text.Length >= 1)
            {
                Employee newEmployee = new Employee();
                newEmployee.name = employeeNameTb.Text;
                newEmployee.role = int.Parse(employeeRoleCb.SelectedValue.ToString());

                _employeeBus.add(newEmployee);

                init();
            }
        }

        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa những dòng đã chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in employeeDgv.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        _employeeBus.deleteById(int.Parse(row.Cells[2].Value.ToString()));
                    }
                }
                init();
            }
        }
    }
}
