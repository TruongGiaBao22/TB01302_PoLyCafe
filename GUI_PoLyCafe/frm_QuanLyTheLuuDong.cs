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
            btnXoa.Enabled = false;

            txtMaThe.Text = string.Empty; // Xóa nội dung dù đang khóa

            txtCSH.Clear();
            rdoDHD.Checked = true;
        }

        private void frm_QuanLyTheLuuDong_Load(object sender, EventArgs e)
        {
            LoadTheLuuDong();
            rdoDHD.Checked = true;
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


            drvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            drvDanhSach.ColumnHeadersHeight = 40;
            drvDanhSach.RowTemplate.Height = 40;
        }



        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtCSH.Text.Trim();

            bool trangThai;

            if (rdoDHD.Checked)
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

        private void btnXoa_Click_1(object sender, EventArgs e)
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtCSH.Text.Trim();

            bool trangThai;

            if (rdoDHD.Checked)
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

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            ClearForm();
            LoadTheLuuDong();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            if (!string.IsNullOrWhiteSpace(key))
            {
                SearchInAllCells(key);
            }
            ClearForm();
        }
        private void SearchInAllCells(string keyword)
        {
            foreach (DataGridViewRow row in drvDanhSach.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyword.ToLower()))
                    {

                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
        }

        private void drvDanhSach_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = drvDanhSach.Rows[e.RowIndex];

                // Fill TextBox
                txtMaThe.Text = row.Cells["MaThe"].Value?.ToString();
                txtCSH.Text = row.Cells["ChuSoHuu"].Value?.ToString();

                // Xử lý trạng thái (dạng bool: True/False)
                object cellValue = row.Cells["TrangThai"].Value;

                if (cellValue is bool trangThai)
                {
                    rdoDHD.Checked = trangThai;
                    rdoKHD.Checked = !trangThai;
                }
                else
                {
                    // Trường hợp fallback nếu kiểu dữ liệu không phải bool
                    string strTrangThai = cellValue?.ToString()?.Trim().ToLower();

                    if (strTrangThai == "đang hoạt động")
                        rdoDHD.Checked = true;
                    else if (strTrangThai == "không hoạt động")
                        rdoKHD.Checked = true;
                }

                // Cập nhật trạng thái nút
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaThe.Enabled = false;
            }
        }
    }
}