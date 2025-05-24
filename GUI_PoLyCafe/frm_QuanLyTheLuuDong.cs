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
    public partial class frm_QuanLyTheLuuDong : Form
    {
        public frm_QuanLyTheLuuDong()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaThe.Clear();
            txtCSH.Clear();
            chkDHD.Checked = true;
        }

        private void frm_QuanLyTheLuuDong_Load(object sender, EventArgs e)
        {
            LoadTheLuuDong();
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadTheLuuDong()
        {
            BUSTheLuuDong bustld = new BUSTheLuuDong();
            drvDanhSach.DataSource = null; // Xóa du Liệu cũ
            drvDanhSach.DataSource = bustld.GetTheLuuDong();
            drvDanhSach.Columns["MaThe"].HeaderText = "Mã Thẻ ";
            drvDanhSach.Columns["ChuSoHuu"].HeaderText = "Chủ Sỡ Hữu";
            drvDanhSach.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
            drvDanhSach.Columns["TrangThai"].Visible = false;
        }

        private void drvDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = drvDanhSach.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaThe.Text = row.Cells["MaThe"].Value.ToString();
            txtCSH.Text = row.Cells["ChuSoHuu"].Value.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            chkDHD.Checked = trangThai;

            // Bật nút "Sửa"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // Tắt chỉnh sửa mã thẻ
            txtMaThe.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtCSH.Text.Trim();

            bool trangThai;

            if (chkDHD.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }

            TheLuuDong theLuuDong = new TheLuuDong
            {
                MaThe = maThe,
                ChuSoHuu = chuSoHuu,
                TrangThai = trangThai
            };
            BUSTheLuuDong bus = new BUSTheLuuDong();
            string result = bus.InsertTheLuuDong(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadTheLuuDong();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtCSH.Text.Trim();
            if (string.IsNullOrEmpty(maThe))
            {
                if (drvDanhSach.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = drvDanhSach.SelectedRows[0];
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một thẻ lưu động để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thẻ lưu động {maThe} - {chuSoHuu}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSTheLuuDong bus = new BUSTheLuuDong();
                string kq = bus.DeleteTheLuuDong(maThe);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin thẻ lưu động {maThe} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadTheLuuDong();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtCSH.Text.Trim();

            bool trangThai;

            if (chkDHD.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }
            TheLuuDong theLuuDong = new TheLuuDong
            {
                MaThe = maThe,
                ChuSoHuu = chuSoHuu,
                TrangThai = trangThai
            };
            BUSTheLuuDong bus = new BUSTheLuuDong();
            string result = bus.UpdateTheLuuDong(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadTheLuuDong();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadTheLuuDong();
        }
    }
}
