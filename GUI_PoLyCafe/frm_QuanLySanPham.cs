using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PoLyCafe;
using DTO_PoLyCafe;

namespace GUI_PoLyCafe
{
    public partial class frm_QuanLySanPham : Form
    {
        public frm_QuanLySanPham()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtTenSP.Clear();
            txtMaSP.Clear();
            txtGia.Clear();
            txtTimKiem.Clear();
            rdoDHD.Checked = true;
            
        }

        private void LoatLSP()
        {
            try
            {
                BUS_LoaiSanPham bUSLoaiSanPham = new BUS_LoaiSanPham();
                List<LoaiSanPham> dsLoai = bUSLoaiSanPham.GetLoaiSanPhamList();
                cobLoaiSP.DataSource = dsLoai;
                cobLoaiSP.ValueMember = "MaLoai";
                cobLoaiSP.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoatDSSP()
        {
            BUS_SanPham bUSSanPham = new BUS_SanPham();
            drvDanhSachSP.DataSource = null;
            List<SanPham> lstSP = bUSSanPham.GetSanPhamList();
            drvDanhSachSP.DataSource = lstSP;
            drvDanhSachSP.Columns["MaSanPham"].HeaderText = "Mã SP";
            drvDanhSachSP.Columns["TenSanPham"].HeaderText = "Tên SP";
            drvDanhSachSP.Columns["DonGia"].HeaderText = "Đơn Giá";
            drvDanhSachSP.Columns["MaLoai"].HeaderText = "Mã Loại";
            drvDanhSachSP.Columns["HinhAnh"].HeaderText = "Hình Ảnh";
            drvDanhSachSP.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
            drvDanhSachSP.Columns["TrangThai"].Visible = false;


            drvDanhSachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            drvDanhSachSP.ColumnHeadersHeight = 40;
            drvDanhSachSP.RowTemplate.Height = 40;
        }

        private void frm_QuanLySanPham_Load(object sender, EventArgs e)
        {
            LoatDSSP();
            LoatLSP();
            ClearForm();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSP.Text.Trim();
                string donGiaText = txtGia.Text.Trim();
                string maLoai = cobLoaiSP.SelectedValue?.ToString();
                bool trangThai = rdoDHD.Checked;
                if (rdoDHD.Checked)
                {
                    trangThai = true;
                }
                else
                {
                    trangThai = false;
                }
                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = ""
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BUS_SanPham busSanPham = new BUS_SanPham();
                busSanPham.InsertSanPham(sp);

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới form sau khi thêm
                ClearForm();
                LoatDSSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string tenSP = string.Empty;
            string hinhAnh = string.Empty;

            if (string.IsNullOrEmpty(maSP))
            {
                if (drvDanhSachSP.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = drvDanhSachSP.SelectedRows[0];
                    maSP = selectedRow.Cells["MaSanPham"].Value.ToString();
                    tenSP = selectedRow.Cells["TenSanPham"].Value.ToString();
                    hinhAnh = selectedRow.Cells["HinhAnh"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                tenSP = txtTenSP.Text.Trim();
            }

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {maSP} - {tenSP}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUS_SanPham bus = new BUS_SanPham();
                string kq = bus.DeleteSanPham(maSP);

                if (string.IsNullOrEmpty(kq))
                {

                    MessageBox.Show($"Xóa thông tin sản phẩm {maSP} - {tenSP} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoatDSSP();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSP.Text.Trim();
                string donGiaText = txtGia.Text.Trim();
                string maLoai = cobLoaiSP.SelectedValue?.ToString();
                bool trangThai = rdoDHD.Checked;
                string maSP = txtMaSP.Text.Trim();
                if (rdoDHD.Checked)
                {
                    trangThai = true;
                }
                else
                {
                    trangThai = false;
                }
                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BUS_SanPham bUSSanPham = new BUS_SanPham();
                string result = bUSSanPham.UpdateSanPham(sp);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    ClearForm();
                    LoatDSSP();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoatDSSP();
            LoatLSP();
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void drvDanhSachSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = drvDanhSachSP.Rows[e.RowIndex];
            txtMaSP.Text = row.Cells["MaSanPham"].Value.ToString();
            txtTenSP.Text = row.Cells["TenSanPham"].Value.ToString();
            txtGia.Text = row.Cells["DonGia"].Value.ToString();
            cobLoaiSP.SelectedValue = row.Cells["MaLoai"].Value.ToString();
            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (rdoDHD.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            // Bật nút "Sửa"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
