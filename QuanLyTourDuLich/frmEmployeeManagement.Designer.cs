namespace QuanLyTourDuLich
{
    partial class frmEmployeeManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employeeDgv = new System.Windows.Forms.DataGridView();
            this.controlCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBs = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.employeeNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeRoleCb = new System.Windows.Forms.ComboBox();
            this.employeeRolesBs = new System.Windows.Forms.BindingSource(this.components);
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.deleteEmployeeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRolesBs)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDgv
            // 
            this.employeeDgv.AllowUserToAddRows = false;
            this.employeeDgv.AllowUserToDeleteRows = false;
            this.employeeDgv.AllowUserToResizeColumns = false;
            this.employeeDgv.AllowUserToResizeRows = false;
            this.employeeDgv.AutoGenerateColumns = false;
            this.employeeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.controlCol,
            this.noCol,
            this.nameCol,
            this.roleCol});
            this.employeeDgv.DataSource = this.employeesBs;
            this.employeeDgv.Location = new System.Drawing.Point(15, 123);
            this.employeeDgv.Name = "employeeDgv";
            this.employeeDgv.RowTemplate.Height = 24;
            this.employeeDgv.Size = new System.Drawing.Size(990, 311);
            this.employeeDgv.TabIndex = 0;
            // 
            // controlCol
            // 
            this.controlCol.HeaderText = "";
            this.controlCol.Name = "controlCol";
            // 
            // noCol
            // 
            this.noCol.HeaderText = "STT";
            this.noCol.Name = "noCol";
            this.noCol.ReadOnly = true;
            // 
            // nameCol
            // 
            this.nameCol.DataPropertyName = "name";
            this.nameCol.HeaderText = "Tên";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // roleCol
            // 
            this.roleCol.DataPropertyName = "EmployeeRole.name";
            this.roleCol.HeaderText = "Vai trò";
            this.roleCol.Name = "roleCol";
            this.roleCol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhân viên";
            // 
            // employeeNameTb
            // 
            this.employeeNameTb.Location = new System.Drawing.Point(117, 37);
            this.employeeNameTb.Name = "employeeNameTb";
            this.employeeNameTb.Size = new System.Drawing.Size(204, 22);
            this.employeeNameTb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vai trò";
            // 
            // employeeRoleCb
            // 
            this.employeeRoleCb.DataSource = this.employeeRolesBs;
            this.employeeRoleCb.DisplayMember = "id";
            this.employeeRoleCb.FormattingEnabled = true;
            this.employeeRoleCb.Location = new System.Drawing.Point(500, 35);
            this.employeeRoleCb.Name = "employeeRoleCb";
            this.employeeRoleCb.Size = new System.Drawing.Size(204, 24);
            this.employeeRoleCb.TabIndex = 4;
            this.employeeRoleCb.ValueMember = "id";
            this.employeeRoleCb.SelectedValueChanged += new System.EventHandler(this.employeeRoleCb_SelectedValueChanged);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Location = new System.Drawing.Point(760, 36);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.addEmployeeBtn.TabIndex = 5;
            this.addEmployeeBtn.Text = "Thêm";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // deleteEmployeeBtn
            // 
            this.deleteEmployeeBtn.Location = new System.Drawing.Point(897, 446);
            this.deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            this.deleteEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteEmployeeBtn.TabIndex = 6;
            this.deleteEmployeeBtn.Text = "Xóa";
            this.deleteEmployeeBtn.UseVisualStyleBackColor = true;
            this.deleteEmployeeBtn.Click += new System.EventHandler(this.deleteEmployeeBtn_Click);
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 481);
            this.Controls.Add(this.deleteEmployeeBtn);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.employeeRoleCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeDgv);
            this.Name = "frmEmployeeManagement";
            this.Text = "frmEmployeeManagement";
            this.Load += new System.EventHandler(this.frmEmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRolesBs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDgv;
        private System.Windows.Forms.BindingSource employeesBs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox employeeRoleCb;
        private System.Windows.Forms.BindingSource employeeRolesBs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controlCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleCol;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button deleteEmployeeBtn;
    }
}