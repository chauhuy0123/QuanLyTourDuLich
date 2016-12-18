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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSystemManager = new System.Windows.Forms.Button();
            this.btnKetNoiCSDL = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTouristsGroupManager = new System.Windows.Forms.Button();
            this.btnLocationManager = new System.Windows.Forms.Button();
            this.btnTourManager = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(915, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ TOUR DU LỊCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(510, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Copyright © UIT 2016";
            // 
            // btnSystemManager
            // 
            this.btnSystemManager.BackColor = System.Drawing.Color.Teal;
            this.btnSystemManager.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.settings;
            this.btnSystemManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSystemManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSystemManager.Location = new System.Drawing.Point(805, 417);
            this.btnSystemManager.Name = "btnSystemManager";
            this.btnSystemManager.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSystemManager.Size = new System.Drawing.Size(317, 156);
            this.btnSystemManager.TabIndex = 7;
            this.btnSystemManager.Text = "Quản lý hệ thống";
            this.btnSystemManager.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSystemManager.UseVisualStyleBackColor = false;
            this.btnSystemManager.Click += new System.EventHandler(this.btnSystemManager_Click);
            // 
            // btnKetNoiCSDL
            // 
            this.btnKetNoiCSDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKetNoiCSDL.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.database;
            this.btnKetNoiCSDL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKetNoiCSDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetNoiCSDL.Location = new System.Drawing.Point(1102, 12);
            this.btnKetNoiCSDL.Name = "btnKetNoiCSDL";
            this.btnKetNoiCSDL.Size = new System.Drawing.Size(64, 64);
            this.btnKetNoiCSDL.TabIndex = 6;
            this.btnKetNoiCSDL.UseVisualStyleBackColor = false;
            this.btnKetNoiCSDL.Click += new System.EventHandler(this.btnKetNoiCSDL_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReport.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.bar_chart;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(37, 417);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(317, 156);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Thống kê";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(425, 417);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(317, 156);
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
            this.btnTouristsGroupManager.Location = new System.Drawing.Point(425, 255);
            this.btnTouristsGroupManager.Name = "btnTouristsGroupManager";
            this.btnTouristsGroupManager.Size = new System.Drawing.Size(317, 156);
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
            this.btnLocationManager.Location = new System.Drawing.Point(805, 255);
            this.btnLocationManager.Name = "btnLocationManager";
            this.btnLocationManager.Size = new System.Drawing.Size(317, 156);
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
            this.btnTourManager.Location = new System.Drawing.Point(37, 255);
            this.btnTourManager.Name = "btnTourManager";
            this.btnTourManager.Size = new System.Drawing.Size(317, 156);
            this.btnTourManager.TabIndex = 1;
            this.btnTourManager.Text = "Quản lý tour";
            this.btnTourManager.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTourManager.UseVisualStyleBackColor = false;
            this.btnTourManager.Click += new System.EventHandler(this.btnTourManager_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.login;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(1186, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(64, 64);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSystemManager);
            this.Controls.Add(this.btnKetNoiCSDL);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnTouristsGroupManager);
            this.Controls.Add(this.btnLocationManager);
            this.Controls.Add(this.btnTourManager);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tour Du Lịch";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnTourManager;
        private System.Windows.Forms.Button btnLocationManager;
        private System.Windows.Forms.Button btnTouristsGroupManager;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnKetNoiCSDL;
        private System.Windows.Forms.Button btnSystemManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

