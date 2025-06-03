namespace GUI_PoLyCafe
{
    partial class frm_TrangChu
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPhieuBanHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongke = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnHeThong = new Guna.UI2.WinForms.Guna2Button();
            this.btnTLD = new Guna.UI2.WinForms.Guna2Button();
            this.btnSanPham = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMain.Controls.Add(this.guna2PictureBox1);
            this.pnMain.Location = new System.Drawing.Point(0, 62);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1114, 648);
            this.pnMain.TabIndex = 1;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::GUI_PoLyCafe.Properties.Resources.Screenshot_2025_05_31_141245_removebg_preview;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1108, 645);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Controls.Add(this.btnPhieuBanHang);
            this.guna2Panel1.Controls.Add(this.btnThongke);
            this.guna2Panel1.Controls.Add(this.btnDangXuat);
            this.guna2Panel1.Controls.Add(this.btnHeThong);
            this.guna2Panel1.Controls.Add(this.btnTLD);
            this.guna2Panel1.Controls.Add(this.btnSanPham);
            this.guna2Panel1.Controls.Add(this.btnNhanVien);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1114, 64);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnPhieuBanHang
            // 
            this.btnPhieuBanHang.BorderColor = System.Drawing.Color.Bisque;
            this.btnPhieuBanHang.BorderRadius = 10;
            this.btnPhieuBanHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhieuBanHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhieuBanHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhieuBanHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhieuBanHang.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPhieuBanHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPhieuBanHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPhieuBanHang.ForeColor = System.Drawing.Color.White;
            this.btnPhieuBanHang.Image = global::GUI_PoLyCafe.Properties.Resources.bill;
            this.btnPhieuBanHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhieuBanHang.Location = new System.Drawing.Point(826, 0);
            this.btnPhieuBanHang.Name = "btnPhieuBanHang";
            this.btnPhieuBanHang.Size = new System.Drawing.Size(169, 64);
            this.btnPhieuBanHang.TabIndex = 7;
            this.btnPhieuBanHang.Text = "Phiếu Bán Hàng ";
            this.btnPhieuBanHang.Click += new System.EventHandler(this.btnPhieuBanHang_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BorderColor = System.Drawing.Color.Bisque;
            this.btnThongke.BorderRadius = 10;
            this.btnThongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongke.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThongke.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThongke.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.Image = global::GUI_PoLyCafe.Properties.Resources.graph;
            this.btnThongke.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongke.Location = new System.Drawing.Point(995, 0);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(119, 64);
            this.btnThongke.TabIndex = 6;
            this.btnThongke.Text = "Thống Kê";
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BorderColor = System.Drawing.Color.Bisque;
            this.btnDangXuat.BorderRadius = 10;
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDangXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = global::GUI_PoLyCafe.Properties.Resources.exit;
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.Location = new System.Drawing.Point(663, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(126, 64);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.BorderColor = System.Drawing.Color.Bisque;
            this.btnHeThong.BorderRadius = 10;
            this.btnHeThong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHeThong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHeThong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHeThong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHeThong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHeThong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHeThong.ForeColor = System.Drawing.Color.White;
            this.btnHeThong.Image = global::GUI_PoLyCafe.Properties.Resources.settings;
            this.btnHeThong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHeThong.Location = new System.Drawing.Point(537, 0);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(126, 64);
            this.btnHeThong.TabIndex = 4;
            this.btnHeThong.Text = "Hệ Thống";
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnTLD
            // 
            this.btnTLD.BorderColor = System.Drawing.Color.Bisque;
            this.btnTLD.BorderRadius = 10;
            this.btnTLD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTLD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTLD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTLD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTLD.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTLD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTLD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTLD.ForeColor = System.Drawing.Color.White;
            this.btnTLD.Image = global::GUI_PoLyCafe.Properties.Resources.credit;
            this.btnTLD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTLD.Location = new System.Drawing.Point(378, 0);
            this.btnTLD.Name = "btnTLD";
            this.btnTLD.Size = new System.Drawing.Size(159, 64);
            this.btnTLD.TabIndex = 3;
            this.btnTLD.Text = "Thẻ Lưu Động";
            this.btnTLD.Click += new System.EventHandler(this.btnTLD_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BorderColor = System.Drawing.Color.Bisque;
            this.btnSanPham.BorderRadius = 10;
            this.btnSanPham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSanPham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSanPham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Image = global::GUI_PoLyCafe.Properties.Resources.checklist__1_;
            this.btnSanPham.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSanPham.Location = new System.Drawing.Point(252, 0);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(126, 64);
            this.btnSanPham.TabIndex = 2;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BorderColor = System.Drawing.Color.Bisque;
            this.btnNhanVien.BorderRadius = 10;
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = global::GUI_PoLyCafe.Properties.Resources.team;
            this.btnNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.Location = new System.Drawing.Point(126, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(126, 64);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân Viên ";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Bisque;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::GUI_PoLyCafe.Properties.Resources.house;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(126, 64);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Trang Chủ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 711);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnMain);
            this.Name = "frm_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnHeThong;
        private Guna.UI2.WinForms.Guna2Button btnTLD;
        private Guna.UI2.WinForms.Guna2Button btnSanPham;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnThongke;
        private Guna.UI2.WinForms.Guna2Button btnPhieuBanHang;
    }
}