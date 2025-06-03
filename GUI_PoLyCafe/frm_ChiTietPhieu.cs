using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PoLyCafe;
using DTO_PoLyCafe;

namespace GUI_PoLyCafe
{
    public partial class frm_ChiTietPhieu : Form
    {
        private TheLuuDong theLuuDong;
        private PhieuBanHang phieuBanHang;
        private NhanVien nhanVien;
        private List<ChiTietPhieu> lstChiTiet;
        private List<SanPham> lstSanPham;
        bool isActive = true;
        public frm_ChiTietPhieu(TheLuuDong the, PhieuBanHang phieu, NhanVien nv)
        {
            InitializeComponent();
            theLuuDong = the;
            phieuBanHang = phieu;
            nhanVien = nv;
            lstChiTiet = new List<ChiTietPhieu>();
            lstSanPham = new List<SanPham>();
            isActive = phieu.TrangThai;
        }
        private void activeTranfer()
        {
            if (isActive)
            {
                btnThemChiTiet.Enabled = false;
                btnXoaChiTiet.Enabled = false;
                txtPhanTram.Enabled = false;
            }
        }

        private void LoadInfo()
        {
            lbChuSoHuu.Text = $"{theLuuDong.MaThe} - {theLuuDong.ChuSoHuu}";
            lbMaPhieu.Text = phieuBanHang.MaPhieu;
            lbNgayLap.Text = phieuBanHang.NgayTao.ToString("dd/MM/yyyy");
        }
        private void loadSanPham()
        {
            BUS_SanPham sp = new BUS_SanPham();
            lstSanPham = sp.GetSanPhamList(1);
            drvSanPham.DataSource = lstSanPham;
            drvSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            drvSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            drvSanPham.Columns["DonGia"].HeaderText = "Đơn Gía";
            drvSanPham.Columns["HinhAnh"].HeaderText = "Hình Ảnh";

            drvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            drvSanPham.ColumnHeadersHeight = 40;
            drvSanPham.RowTemplate.Height = 40;

            drvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadChiTietPhieu(string maPhieu)
        {
            BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
            lstChiTiet = bus.GetChiTietPhieuList(maPhieu);
            drvChiTiet.DataSource = lstChiTiet;
            drvChiTiet.Columns["MaChiTiet"].Visible = false;
            drvChiTiet.Columns["MaPhieu"].Visible = false;
            drvChiTiet.Columns["MaSanPham"].Visible = false;
            drvChiTiet.Columns["TenSanPham"].HeaderText = "Sản Phẩm";
            drvChiTiet.Columns["SoLuong"].HeaderText = "Số Lượng";
            drvChiTiet.Columns["DonGia"].HeaderText = "Đơn Giá";
            drvChiTiet.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            drvChiTiet.Columns["SoLuong"].ReadOnly = false;

            drvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            drvChiTiet.ColumnHeadersHeight = 40;
            drvSanPham.RowTemplate.Height = 40;

            drvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in drvChiTiet.Columns)
            {
                col.ReadOnly = true;
            }
            drvChiTiet.Columns["SoLuong"].ReadOnly = false;
        }
        private void loadThanhToan()
        {
            txtTong.Text = "0";
            txtGiamGia.Text = "0";
            txtPhanTram.Text = "0";
            txtThanhTien.Text = "0";
            txtDichVu.Text = "0";
        }
    

        private void frm_ChiTietPhieu_Load(object sender, EventArgs e)
        {
            loadThanhToan();
            LoadInfo();
            loadSanPham();
            loadChiTietPhieu(phieuBanHang.MaPhieu);
            activeTranfer();
        }

        private void drvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isActive)
            {
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = drvSanPham.Rows[e.RowIndex];

                // Tạo đối tượng từ dữ liệu hàng
                SanPham sanPham = new SanPham
                {
                    MaSanPham = row.Cells["MaSanPham"].Value.ToString(),
                    TenSanPham = row.Cells["TenSanPham"].Value.ToString(),
                    DonGia = Convert.ToInt32(row.Cells["DonGia"].Value)
                };

                transfer(sanPham);
            }
        }
        private void transfer(SanPham sp, int soLuong = 1)
        {
            if (isActive)
            {
                return;
            }
            if (sp != null)
            {
                BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
                ChiTietPhieu existingItem = lstChiTiet.FirstOrDefault(item => item.MaSanPham == sp.MaSanPham);
                if (existingItem != null)
                {
                    existingItem.SoLuong += soLuong;
                    string result = bus.UpdateSoLuong(existingItem);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    ChiTietPhieu ct = new ChiTietPhieu()
                    {
                        MaPhieu = phieuBanHang.MaPhieu,
                        MaSanPham = sp.MaSanPham,
                        SoLuong = soLuong,
                        DonGia = sp.DonGia,
                    };
                    string result = bus.InsertChiTietPhieu(ct);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                loadChiTietPhieu(phieuBanHang.MaPhieu);

            }
        }
        private void deleteChiTiet()
        {
            if (drvChiTiet.CurrentRow != null)
            {
                string id = Convert.ToString(drvChiTiet.CurrentRow.Cells["MaChiTiet"].Value);
                string name = Convert.ToString(drvChiTiet.CurrentRow.Cells["TenSanPham"].Value);
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phầm {name}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
                    string kq = bus.DeleteChiTiet(id); ;
                    if (string.IsNullOrEmpty(kq))
                    {
                        loadChiTietPhieu(phieuBanHang.MaPhieu);
                    }
                }
            }
        }

        private void drvChiTiet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (isActive)
            {
                return;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
                ChiTietPhieu ct = lstChiTiet[e.RowIndex];
                int newQuantity;
                if (int.TryParse(drvChiTiet.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString(), out newQuantity))
                {
                    ct.SoLuong = newQuantity;
                    string result = bus.UpdateSoLuong(ct);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Đảm bảo ko lỗi khi đang edit mà chuyển ô
                    this.BeginInvoke((Action)(() =>
                    {
                        loadChiTietPhieu(phieuBanHang.MaPhieu);
                    }));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                return;
            }
            deleteChiTiet();
            TinhTongVaThanhTien();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                return;
            }
            if (drvSanPham.CurrentRow != null)
            {
                string id = Convert.ToString(drvSanPham.CurrentRow.Cells["MaSanPham"].Value);
                string ten = Convert.ToString(drvSanPham.CurrentRow.Cells["TenSanPham"].Value);
                decimal dongia = Convert.ToDecimal(drvSanPham.CurrentRow.Cells["DonGia"].Value);
                SanPham sanPham = new SanPham
                {
                    MaSanPham = id,
                    TenSanPham = ten,
                    DonGia = dongia
                };

                transfer(sanPham);
            }
            TinhTongVaThanhTien();
        }

        private void drvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TinhTongVaThanhTien()
        {
            int tongSoLuong = 0;
            decimal tongThanhTien = 0;

            foreach (DataGridViewRow row in drvChiTiet.Rows)
            {
                if (row.IsNewRow) continue;

                int soLuong = 0;
                decimal donGia = 0;

                // Kiểm tra và ép kiểu dữ liệu
                if (row.Cells["SoLuong"].Value != null)
                    int.TryParse(row.Cells["SoLuong"].Value.ToString(), out soLuong);

                if (row.Cells["DonGia"].Value != null)
                    decimal.TryParse(row.Cells["DonGia"].Value.ToString(), out donGia);

                tongSoLuong += soLuong;
                tongThanhTien += soLuong * donGia;
            }

            // Gán kết quả vào các TextBox
            txtTong.Text = tongSoLuong.ToString();
            txtThanhTien.Text = tongThanhTien.ToString("N0"); // định dạng 1,000
        }

        private void drvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TinhTongVaThanhTien();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            TinhTongVaThanhTien();
            
        }
    }
}
