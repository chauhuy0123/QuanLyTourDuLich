namespace QuanLyTourDuLich
{
    partial class fmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSystemManager = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTouristsGroupManager = new System.Windows.Forms.Button();
            this.btnLocationManager = new System.Windows.Forms.Button();
            this.btnTourManager = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labUserAccount = new System.Windows.Forms.Label();
            this.btnSingout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pnUserAccount = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnUserAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(915, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ TOUR DU LỊCH";
            // 
            // btnSystemManager
            // 
            this.btnSystemManager.BackColor = System.Drawing.Color.Teal;
            this.btnSystemManager.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.settings;
            this.btnSystemManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSystemManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSystemManager.Location = new System.Drawing.Point(1000, 436);
            this.btnSystemManager.Name = "btnSystemManager";
            this.btnSystemManager.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSystemManager.Size = new System.Drawing.Size(349, 163);
            this.btnSystemManager.TabIndex = 7;
            this.btnSystemManager.Text = "Quản lý hệ thống";
            this.btnSystemManager.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSystemManager.UseVisualStyleBackColor = false;
            this.btnSystemManager.Click += new System.EventHandler(this.btnSystemManager_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReport.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.bar_chart;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(41, 436);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(349, 163);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Thống kê";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(1000, 267);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(349, 163);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnTouristsGroupManager
            // 
            this.btnTouristsGroupManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTouristsGroupManager.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.tourist;
            this.btnTouristsGroupManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTouristsGroupManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTouristsGroupManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTouristsGroupManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTouristsGroupManager.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTouristsGroupManager.Location = new System.Drawing.Point(528, 267);
            this.btnTouristsGroupManager.Name = "btnTouristsGroupManager";
            this.btnTouristsGroupManager.Size = new System.Drawing.Size(349, 163);
            this.btnTouristsGroupManager.TabIndex = 3;
            this.btnTouristsGroupManager.Text = "Quản lý đoàn";
            this.btnTouristsGroupManager.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTouristsGroupManager.UseVisualStyleBackColor = false;
            this.btnTouristsGroupManager.Click += new System.EventHandler(this.btnTouristsGroupManager_Click);
            // 
            // btnLocationManager
            // 
            this.btnLocationManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLocationManager.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.navigation_trajectory;
            this.btnLocationManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocationManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocationManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocationManager.Location = new System.Drawing.Point(528, 436);
            this.btnLocationManager.Name = "btnLocationManager";
            this.btnLocationManager.Size = new System.Drawing.Size(349, 163);
            this.btnLocationManager.TabIndex = 2;
            this.btnLocationManager.Text = "Quản lý địa điểm";
            this.btnLocationManager.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLocationManager.UseVisualStyleBackColor = false;
            this.btnLocationManager.Click += new System.EventHandler(this.btnLocationManager_Click);
            // 
            // btnTourManager
            // 
            this.btnTourManager.BackColor = System.Drawing.Color.Purple;
            this.btnTourManager.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.earth_pictures;
            this.btnTourManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTourManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTourManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTourManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTourManager.Location = new System.Drawing.Point(41, 267);
            this.btnTourManager.Name = "btnTourManager";
            this.btnTourManager.Size = new System.Drawing.Size(349, 163);
            this.btnTourManager.TabIndex = 1;
            this.btnTourManager.Text = "Quản lý tour";
            this.btnTourManager.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTourManager.UseVisualStyleBackColor = false;
            this.btnTourManager.Click += new System.EventHandler(this.btnTourManager_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.login;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnLogin.Location = new System.Drawing.Point(1312, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(64, 64);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 90);
            this.panel1.TabIndex = 9;
            // 
            // labUserAccount
            // 
            this.labUserAccount.AutoSize = true;
            this.labUserAccount.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold);
            this.labUserAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labUserAccount.Location = new System.Drawing.Point(3, 13);
            this.labUserAccount.Name = "labUserAccount";
            this.labUserAccount.Size = new System.Drawing.Size(148, 27);
            this.labUserAccount.TabIndex = 10;
            this.labUserAccount.Text = "UserAccount";
            // 
            // btnSingout
            // 
            this.btnSingout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSingout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSingout.Location = new System.Drawing.Point(8, 61);
            this.btnSingout.Name = "btnSingout";
            this.btnSingout.Size = new System.Drawing.Size(130, 46);
            this.btnSingout.TabIndex = 20;
            this.btnSingout.Text = "Đăng xuất";
            this.btnSingout.UseVisualStyleBackColor = false;
            this.btnSingout.Click += new System.EventHandler(this.btnSingout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangePassword.Location = new System.Drawing.Point(144, 61);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(136, 46);
            this.btnChangePassword.TabIndex = 20;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // pnUserAccount
            // 
            this.pnUserAccount.Controls.Add(this.labUserAccount);
            this.pnUserAccount.Controls.Add(this.btnSingout);
            this.pnUserAccount.Controls.Add(this.btnChangePassword);
            this.pnUserAccount.Location = new System.Drawing.Point(41, 96);
            this.pnUserAccount.Name = "pnUserAccount";
            this.pnUserAccount.Size = new System.Drawing.Size(349, 133);
            this.pnUserAccount.TabIndex = 21;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1388, 704);
            this.Controls.Add(this.pnUserAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSystemManager);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnTouristsGroupManager);
            this.Controls.Add(this.btnLocationManager);
            this.Controls.Add(this.btnTourManager);
            this.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1406, 751);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tour Du Lịch";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnUserAccount.ResumeLayout(false);
            this.pnUserAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnTourManager;
        private System.Windows.Forms.Button btnLocationManager;
        private System.Windows.Forms.Button btnTouristsGroupManager;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSystemManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labUserAccount;
        private System.Windows.Forms.Button btnSingout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel pnUserAccount;
    }
}

