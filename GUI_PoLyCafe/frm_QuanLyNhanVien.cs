using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PoLyCafe;
using DTO_PoLyCafe;

namespace GUI_PoLyCafe
{
    public partial class frm_QuanLyNhanVien : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();

            drvDanhSachNV.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên ";
            drvDanhSachNV.Columns["HoTen"].HeaderText = "Họ Tên";
            drvDanhSachNV.Columns["Email"].HeaderText = "Email";
            drvDanhSachNV.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            drvDanhSachNV.Columns["VaiTroText"].HeaderText = "Vai Trò";
            drvDanhSachNV.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
            drvDanhSachNV.Columns["VaiTro"].Visible = false;
            drvDanhSachNV.Columns["TrangThai"].Visible = false;

            drvDanhSachNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            rdoNhanVien.Checked = true;
            rdoHoatDong.Checked= true;
        }

        public void LoadNhanVien()
        {
            BUSNhanVien busNhanVien = new BUSNhanVien();
            drvDanhSachNV.DataSource = null; // Xóa du Liệu cũ
            drvDanhSachNV.DataSource = busNhanVien.GetNhanVienList();
            drvDanhSachNV.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên ";
            drvDanhSachNV.Columns["HoTen"].HeaderText = "Họ Tên";
            drvDanhSachNV.Columns["Email"].HeaderText = "Email";
            drvDanhSachNV.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            drvDanhSachNV.Columns["VaiTroText"].HeaderText = "Vai Trò";
            drvDanhSachNV.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
            drvDanhSachNV.Columns["VaiTro"].Visible = false;
            drvDanhSachNV.Columns["TrangThai"].Visible = false;

            drvDanhSachNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            drvDanhSachNV.ColumnHeadersHeight = 40;
            drvDanhSachNV.RowTemplate.Height = 40;
        }

      
        private void ClearForm()
        {
            txtMaNV.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            rdoNhanVien.Checked = true;
        }


        

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txtMaNV.Text.Trim();
                string hoTen = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matkhau = txtMatKhau.Text.Trim();
                bool vaiTro;
                bool trangthai;

                if (rdoNhanVien.Checked)
                {
                    vaiTro = false;
                }
                else
                {
                    vaiTro = true;
                }
                if (rdoHoatDong.Checked)
                {
                    trangthai = true;
                }
                else
                {
                    trangthai = false;
                }
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matkhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                NhanVien nv = new NhanVien()
                {
                    MaNhanVien = maNV,
                    HoTen = hoTen,
                    Email = email,
                    MatKhau = matkhau,
                    VaiTro = vaiTro,
                    TrangThai = true
                };
                BUSNhanVien busNhanVien = new BUSNhanVien();
                busNhanVien.InsertNhanVien(nv);
                MessageBox.Show("Thêm nhan vien thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã nhân viên từ textbox
            string maNhanVien = txtMaNV.Text.Trim();

            // Kiểm tra nếu không có mã nhân viên
            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Gọi phương thức xóa
                    BUSNhanVien busNhanVien = new BUSNhanVien();
                    busNhanVien.DaleteNhanVien(maNhanVien);
                    ClearForm();


                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string maNV = txtMaNV.Text.Trim();
                string hoTen = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matkhau = txtMatKhau.Text.Trim();
                bool vaiTro;
                bool trangthai;

                if (rdoNhanVien.Checked)
                {
                    vaiTro = false;
                }
                else
                {
                    vaiTro = true;
                }
                if (rdoHoatDong.Checked)
                {
                    trangthai = true;
                }
                else
                {
                    trangthai = false;
                }

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matkhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3 Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = maNV,
                    HoTen = hoTen,
                    Email = email,
                    MatKhau = matkhau,
                    VaiTro = vaiTro,
                    TrangThai = true // Gửi trạng thái mặc định là active
                };

                // 4 Gọi DAL để cập nhật nhân viên trong database
                BUSNhanVien bUSNhanVien = new BUSNhanVien();
                bUSNhanVien.UpdateNhanVien(nv);
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
            ClearForm();
        }

        private void drvDanhSachNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = drvDanhSachNV.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            // Kiểm tra vai trò (nếu true là quản lý, nếu false là nhân viên)
            bool vaiTro = Convert.ToBoolean(row.Cells["VaiTro"].Value);
            if (vaiTro == false)
            {
                rdoNhanVien.Checked = true;
            }
            else
            {
                rdoQuanLy.Checked = true;
            }
            bool trangthai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangthai == true)
            {
                rdoHoatDong.Checked = true;
            }
            else
            {
                rdoKHD.Checked = true;
            }
        }
    }
}
