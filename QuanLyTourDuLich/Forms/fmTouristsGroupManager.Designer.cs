namespace QuanLyTourDuLich.Forms
{
    partial class fmTouristsGroupManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTouristsGroupManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._filterBs = new System.Windows.Forms.BindingSource(this.components);
            this._tourGroupBs = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this._tourBs = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCSDL = new System.Windows.Forms.Button();
            this._tourGroupDgv = new System.Windows.Forms.DataGridView();
            this.controlCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sttCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._groupNameTb = new System.Windows.Forms.TextBox();
            this._returnDateDtp = new System.Windows.Forms.DateTimePicker();
            this._departDateDtp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._tourCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._filterBs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tourGroupBs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tourBs)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tourGroupDgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "clipboard.png");
            this.imageList1.Images.SetKeyName(1, "clipboard (1).png");
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnExit2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1258, 632);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý đoàn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(516, 589);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Copyright © UIT 2016";
            // 
            // btnExit2
            // 
            this.btnExit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit2.ForeColor = System.Drawing.Color.White;
            this.btnExit2.Location = new System.Drawing.Point(1134, 581);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(116, 43);
            this.btnExit2.TabIndex = 24;
            this.btnExit2.Text = "Thoát";
            this.btnExit2.UseVisualStyleBackColor = false;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.btnCSDL);
            this.groupBox2.Controls.Add(this._tourGroupDgv);
            this.groupBox2.Controls.Add(this._groupNameTb);
            this.groupBox2.Controls.Add(this._returnDateDtp);
            this.groupBox2.Controls.Add(this._departDateDtp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this._tourCb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1238, 443);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // btnCSDL
            // 
            this.btnCSDL.AutoSize = true;
            this.btnCSDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCSDL.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.add_circular_outlined_button;
            this.btnCSDL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCSDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCSDL.Location = new System.Drawing.Point(1014, 22);
            this.btnCSDL.Name = "btnCSDL";
            this.btnCSDL.Size = new System.Drawing.Size(110, 74);
            this.btnCSDL.TabIndex = 37;
            this.btnCSDL.UseVisualStyleBackColor = false;
            this.btnCSDL.Click += new System.EventHandler(this.btnCSDL_Click);
            // 
            // _tourGroupDgv
            // 
            this._tourGroupDgv.AllowUserToAddRows = false;
            this._tourGroupDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this._tourGroupDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._tourGroupDgv.AutoGenerateColumns = false;
            this._tourGroupDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this._tourGroupDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._tourGroupDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.controlCol,
            this.sttCol,
            this.idCol,
            this.nameCol,
            this.departDateCol,
            this.returnDateCol});
            this._tourGroupDgv.DataSource = this._filterBs;
            this._tourGroupDgv.Location = new System.Drawing.Point(41, 137);
            this._tourGroupDgv.Name = "_tourGroupDgv";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this._tourGroupDgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._tourGroupDgv.RowTemplate.Height = 24;
            this._tourGroupDgv.Size = new System.Drawing.Size(951, 262);
            this._tourGroupDgv.TabIndex = 36;
            this._tourGroupDgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this._tourGroupDgv_CellFormatting);
            // 
            // controlCol
            // 
            this.controlCol.HeaderText = "";
            this.controlCol.Name = "controlCol";
            this.controlCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.controlCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // sttCol
            // 
            this.sttCol.HeaderText = "STT";
            this.sttCol.Name = "sttCol";
            this.sttCol.ReadOnly = true;
            // 
            // idCol
            // 
            this.idCol.DataPropertyName = "id";
            this.idCol.HeaderText = "Mã đoàn";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            // 
            // nameCol
            // 
            this.nameCol.DataPropertyName = "name";
            this.nameCol.HeaderText = "Tên đoàn";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // departDateCol
            // 
            this.departDateCol.DataPropertyName = "depart_date";
            this.departDateCol.HeaderText = "Ngày khởi hành";
            this.departDateCol.Name = "departDateCol";
            this.departDateCol.ReadOnly = true;
            // 
            // returnDateCol
            // 
            this.returnDateCol.DataPropertyName = "return_date";
            this.returnDateCol.HeaderText = "Ngày trở về";
            this.returnDateCol.Name = "returnDateCol";
            this.returnDateCol.ReadOnly = true;
            // 
            // _groupNameTb
            // 
            this._groupNameTb.Location = new System.Drawing.Point(157, 70);
            this._groupNameTb.Name = "_groupNameTb";
            this._groupNameTb.Size = new System.Drawing.Size(270, 28);
            this._groupNameTb.TabIndex = 35;
            // 
            // _returnDateDtp
            // 
            this._returnDateDtp.Location = new System.Drawing.Point(749, 69);
            this._returnDateDtp.Name = "_returnDateDtp";
            this._returnDateDtp.Size = new System.Drawing.Size(243, 28);
            this._returnDateDtp.TabIndex = 27;
            // 
            // _departDateDtp
            // 
            this._departDateDtp.Location = new System.Drawing.Point(749, 22);
            this._departDateDtp.Name = "_departDateDtp";
            this._departDateDtp.Size = new System.Drawing.Size(243, 28);
            this._departDateDtp.TabIndex = 26;
            this._departDateDtp.ValueChanged += new System.EventHandler(this._departDateDtp_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(601, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ngày quay về";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(601, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ngày khởi hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(37, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tên đoàn";
            // 
            // _tourCb
            // 
            this._tourCb.DataSource = this._tourBs;
            this._tourCb.DisplayMember = "id";
            this._tourCb.FormattingEnabled = true;
            this._tourCb.Location = new System.Drawing.Point(157, 24);
            this._tourCb.Name = "_tourCb";
            this._tourCb.Size = new System.Drawing.Size(270, 30);
            this._tourCb.TabIndex = 18;
            this._tourCb.ValueMember = "id";
            this._tourCb.SelectedIndexChanged += new System.EventHandler(this._tourCb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(80, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tour";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBack2);
            this.panel2.Location = new System.Drawing.Point(12, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 84);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(195, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 51);
            this.label2.TabIndex = 9;
            this.label2.Text = "TẠO MỚI ĐOÀN";
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.Green;
            this.btnBack2.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.back_left_arrow_circular_button_outline;
            this.btnBack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.ForeColor = System.Drawing.Color.Green;
            this.btnBack2.Location = new System.Drawing.Point(10, 7);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(64, 64);
            this.btnBack2.TabIndex = 11;
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(-4, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 678);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1258, 632);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Danh sách đoàn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.rubbish_bin;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteBtn.Location = new System.Drawing.Point(1014, 325);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(110, 74);
            this.deleteBtn.TabIndex = 38;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // fmTouristsGroupManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "fmTouristsGroupManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmTouristsGroupManager";
            this.Load += new System.EventHandler(this.fmTouristsGroupManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this._filterBs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tourGroupBs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tourBs)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tourGroupDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource _tourGroupBs;
        private System.Windows.Forms.BindingSource _filterBs;
        private System.Windows.Forms.BindingSource _tourBs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _groupNameTb;
        private System.Windows.Forms.DateTimePicker _returnDateDtp;
        private System.Windows.Forms.DateTimePicker _departDateDtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _tourCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnCSDL;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controlCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn departDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateCol;
        private System.Windows.Forms.DataGridView _tourGroupDgv;
        private System.Windows.Forms.Button deleteBtn;
    }
}