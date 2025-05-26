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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyLoaiSanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyPhieuBanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapPhieuBanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theLuuDongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTheLuuDongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeTheoNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeTheoSanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gioiThieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huongDanSuDungPhanMemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSalmon;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanVienToolStripMenuItem,
            this.sanPhamToolStripMenuItem,
            this.phieuToolStripMenuItem,
            this.theLuuDongToolStripMenuItem,
            this.thongKeToolStripMenuItem,
            this.heThongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyNhanVienToolStripMenuItem});
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.nhanVienToolStripMenuItem.Text = "Nhân Viên 👤";
            // 
            // quanLyNhanVienToolStripMenuItem
            // 
            this.quanLyNhanVienToolStripMenuItem.Name = "quanLyNhanVienToolStripMenuItem";
            this.quanLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.quanLyNhanVienToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.quanLyNhanVienToolStripMenuItem.Click += new System.EventHandler(this.quanLyNhanVienToolStripMenuItem_Click);
            // 
            // sanPhamToolStripMenuItem
            // 
            this.sanPhamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyLoaiSanPhamToolStripMenuItem,
            this.quanLySanPhamToolStripMenuItem});
            this.sanPhamToolStripMenuItem.Name = "sanPhamToolStripMenuItem";
            this.sanPhamToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.sanPhamToolStripMenuItem.Text = "Sản Phẩm 📦";
            // 
            // quanLyLoaiSanPhamToolStripMenuItem
            // 
            this.quanLyLoaiSanPhamToolStripMenuItem.Name = "quanLyLoaiSanPhamToolStripMenuItem";
            this.quanLyLoaiSanPhamToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.quanLyLoaiSanPhamToolStripMenuItem.Text = "Quản Lý Loại Sản Phẩm";
            // 
            // quanLySanPhamToolStripMenuItem
            // 
            this.quanLySanPhamToolStripMenuItem.Name = "quanLySanPhamToolStripMenuItem";
            this.quanLySanPhamToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.quanLySanPhamToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            this.quanLySanPhamToolStripMenuItem.Click += new System.EventHandler(this.quanLySanPhamToolStripMenuItem_Click);
            // 
            // phieuToolStripMenuItem
            // 
            this.phieuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyPhieuBanHangToolStripMenuItem,
            this.lapPhieuBanHangToolStripMenuItem});
            this.phieuToolStripMenuItem.Name = "phieuToolStripMenuItem";
            this.phieuToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.phieuToolStripMenuItem.Text = "Phiếu 📄";
            // 
            // quanLyPhieuBanHangToolStripMenuItem
            // 
            this.quanLyPhieuBanHangToolStripMenuItem.Name = "quanLyPhieuBanHangToolStripMenuItem";
            this.quanLyPhieuBanHangToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.quanLyPhieuBanHangToolStripMenuItem.Text = "Quản Lý Phiếu Bán Hàng";
            // 
            // lapPhieuBanHangToolStripMenuItem
            // 
            this.lapPhieuBanHangToolStripMenuItem.Name = "lapPhieuBanHangToolStripMenuItem";
            this.lapPhieuBanHangToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.lapPhieuBanHangToolStripMenuItem.Text = "Lập Phiếu Bán Hàng";
            // 
            // theLuuDongToolStripMenuItem
            // 
            this.theLuuDongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyTheLuuDongToolStripMenuItem});
            this.theLuuDongToolStripMenuItem.Name = "theLuuDongToolStripMenuItem";
            this.theLuuDongToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.theLuuDongToolStripMenuItem.Text = "Thẻ Lưu Động 🏷";
            // 
            // quanLyTheLuuDongToolStripMenuItem
            // 
            this.quanLyTheLuuDongToolStripMenuItem.Name = "quanLyTheLuuDongToolStripMenuItem";
            this.quanLyTheLuuDongToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.quanLyTheLuuDongToolStripMenuItem.Text = "Quản Lý Thẻ Lưu Động";
            this.quanLyTheLuuDongToolStripMenuItem.Click += new System.EventHandler(this.quanLyTheLuuDongToolStripMenuItem_Click);
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongKeTheoNhanVienToolStripMenuItem,
            this.thongKeTheoSanPhamToolStripMenuItem});
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.thongKeToolStripMenuItem.Text = "Thống Kê 📓";
            // 
            // thongKeTheoNhanVienToolStripMenuItem
            // 
            this.thongKeTheoNhanVienToolStripMenuItem.Name = "thongKeTheoNhanVienToolStripMenuItem";
            this.thongKeTheoNhanVienToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.thongKeTheoNhanVienToolStripMenuItem.Text = "Thống Kê Theo Nhân Viên";
            // 
            // thongKeTheoSanPhamToolStripMenuItem
            // 
            this.thongKeTheoSanPhamToolStripMenuItem.Name = "thongKeTheoSanPhamToolStripMenuItem";
            this.thongKeTheoSanPhamToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.thongKeTheoSanPhamToolStripMenuItem.Text = "Thống Kê Theo Sản Phẩm";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauToolStripMenuItem,
            this.gioiThieuToolStripMenuItem,
            this.huongDanSuDungPhanMemToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.heThongToolStripMenuItem.Text = "Hệ Thống ⚙️";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // gioiThieuToolStripMenuItem
            // 
            this.gioiThieuToolStripMenuItem.Name = "gioiThieuToolStripMenuItem";
            this.gioiThieuToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.gioiThieuToolStripMenuItem.Text = "Giới Thiệu";
            // 
            // huongDanSuDungPhanMemToolStripMenuItem
            // 
            this.huongDanSuDungPhanMemToolStripMenuItem.Name = "huongDanSuDungPhanMemToolStripMenuItem";
            this.huongDanSuDungPhanMemToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.huongDanSuDungPhanMemToolStripMenuItem.Text = "Hướng Dẫn Sử Dụng Phần Mềm";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.thoatToolStripMenuItem.Text = "Thoát";
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnMain.Location = new System.Drawing.Point(0, 32);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1114, 648);
            this.pnMain.TabIndex = 1;
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 692);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyLoaiSanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLySanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyPhieuBanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lapPhieuBanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theLuuDongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTheLuuDongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeTheoNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeTheoSanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gioiThieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huongDanSuDungPhanMemToolStripMenuItem;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
    }
}