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
using UTIL_PoLyCafe;

namespace GUI_PoLyCafe
{
    public partial class frm_DonHang : Form
    {
        private bool isLoadingTheLuuDongData = true;
        public frm_DonHang()
        {
            InitializeComponent();
        }
        private void ClearForm(string msThe)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaPhieu.Clear();
            cobNhanVien.Enabled = true;
            dtpNgayTao.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdoDXT.Enabled = true;
            rdoDTT.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
           rdoDXT.Checked = true;
        }
        private void LoadNhanVien()
        {
            try
            {
                BUSNhanVien busNhanVien = new BUSNhanVien();
                List<NhanVien> dsLoai = busNhanVien.GetNhanVienList();
                if (AuthUtil.user.VaiTro)
                {
                    dsLoai.Insert(0, new NhanVien() { MaNhanVien = string.Empty, HoTen = string.Format("--Vui lòng chọn nhân viên--") });
                }
                else
                {
                    dsLoai = dsLoai.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                    cobNhanVien.Enabled = false;
                }
                cobNhanVien.DataSource = dsLoai;
                cobNhanVien.ValueMember = "MaNhanVien";
                cobNhanVien.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTheLuuDong()
        {
            BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
            List<TheLuuDong> lst = busTheLuuDong.GetTheLuuDong();
            lst.Insert(0, new TheLuuDong() { MaThe = string.Empty, ChuSoHuu = string.Format("--Tất Cả--") });
            cobMaThe.DataSource = lst;
            cobMaThe.ValueMember = "MaThe";
            cobMaThe.DisplayMember = "ChuSoHuu";
            isLoadingTheLuuDongData = false;
        }
        

        private void LoadDanhSachPhieu(string maThe)
        {
            BUS_PhieuBanHang busPhieuBanHang = new BUS_PhieuBanHang();
            List<PhieuBanHang> lst = busPhieuBanHang.GetListPhieuBanHang(maThe);
            if (!AuthUtil.user.VaiTro)
            {
                lst = lst.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                cobNhanVien.Enabled = false;
            }
            drvDanhSachPBH.DataSource = lst;


            DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn();
            buttonColumn.Name = "ThanhToan";
            buttonColumn.HeaderText = "Thanh Toán";
            //buttonColumn.Text = "Thanh Toán";
            //buttonColumn.UseColumnTextForButtonValue = true; // Hiển thị văn bản lên nút
            buttonColumn.DefaultCellStyle.BackColor = Color.LightBlue;
            buttonColumn.DefaultCellStyle.ForeColor = Color.DarkBlue;

            buttonColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            if (!drvDanhSachPBH.Columns.Contains("ThanhToan"))
            {
                drvDanhSachPBH.Columns.Add(buttonColumn);
            }
            drvDanhSachPBH.Columns["ThanhToan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            drvDanhSachPBH.RowTemplate.Height = 50;

            drvDanhSachPBH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frm_DonHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieu("");
            LoadNhanVien();
            LoadTheLuuDong();
        }

        private void drvDanhSachPBH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPhieu = drvDanhSachPBH.Rows[e.RowIndex].Cells["MaPhieu"].Value.ToString();
            string maThe = drvDanhSachPBH.Rows[e.RowIndex].Cells["MaThe"].Value.ToString();
            string maNV = drvDanhSachPBH.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
            PhieuBanHang phieu = (PhieuBanHang)drvDanhSachPBH.CurrentRow.DataBoundItem;
            TheLuuDong the = new TheLuuDong();
            NhanVien nv = new NhanVien();
            foreach (TheLuuDong item in cobMaThe.Items)
            {
                if (item.MaThe == maThe)
                {
                    the = item;
                    break;
                }
            }

            foreach (NhanVien item in cobNhanVien.Items)
            {
                if (item.MaNhanVien == maNV)
                {
                    nv = item;
                    break;
                }
            }
            frm_ChiTietPhieu frmChiTiet = new frm_ChiTietPhieu(the, phieu, nv);
            frmChiTiet.ShowDialog();
        }

        private void drvDanhSachPBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isLoadingTheLuuDongData = true;
            DataGridViewRow row = drvDanhSachPBH.Rows[e.RowIndex];
            cobMaThe.SelectedValue = row.Cells["MaThe"].Value.ToString();
            cobNhanVien.SelectedValue = row.Cells["MaNhanVien"].Value.ToString();
            dtpNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
            txtMaPhieu.Text = row.Cells["MaPhieu"].Value.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai)
            {
                rdoDTT.Checked = true;
                rdoDTT.Enabled = false;
                rdoDXT.Enabled = false;
                cobNhanVien.Enabled = false;
                dtpNgayTao.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
            else
            {
                rdoDTT.Checked = false;
                rdoDTT.Enabled = true;
                rdoDXT.Enabled = true;
                cobNhanVien.Enabled = true;
                rdoDXT.Checked = true;
                rdoDXT.Enabled = true;
                dtpNgayTao.Enabled = true;
                // Bật nút "Sửa"
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maThe = cobMaThe.SelectedValue?.ToString();
            string maNhanVien = cobNhanVien.SelectedValue?.ToString();
            DateTime ngayTao = dtpNgayTao.Value;

            bool trangThai;
            if (rdoDXT.Checked)
            {
                trangThai = false;
            }
            else
            {
                trangThai = true;
            }
            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu bán hàng.");
                return;
            }

            PhieuBanHang theLuuDong = new PhieuBanHang
            {
                MaThe = maThe,
                MaNhanVien = maNhanVien,
                NgayTao = ngayTao,
                TrangThai = trangThai
            };
            BUS_PhieuBanHang bus = new BUS_PhieuBanHang();
            string result = bus.InsertPhieuBanHang(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm(maThe);
                LoadTheLuuDong();
                LoadNhanVien();
                LoadDanhSachPhieu("");
                cobMaThe.SelectedValue = maThe;
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maThe = cobMaThe.SelectedValue?.ToString();
            string maPhieu = txtMaPhieu.Text;
            string maNhanVien = cobNhanVien.SelectedValue?.ToString();
            DateTime ngayTao = dtpNgayTao.Value;

            bool trangThai;
            if (rdoDXT.Checked)
            {
                trangThai = false;
            }
            else


            {
                trangThai = true;
            }
            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu bán hàng.");
                return;
            }

            PhieuBanHang theLuuDong = new PhieuBanHang
            {
                MaPhieu = maPhieu,
                MaThe = maThe,
                MaNhanVien = maNhanVien,
                NgayTao = ngayTao,
                TrangThai = trangThai
            };
            BUS_PhieuBanHang bus = new BUS_PhieuBanHang();
            string result = bus.UpdatePhieuBanHang(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm(maThe);
                LoadTheLuuDong();
                LoadNhanVien();
                LoadDanhSachPhieu("");
                cobMaThe.SelectedValue = maThe;
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            string maThe = cobMaThe.SelectedValue?.ToString();
            string chuSoHuu = cobMaThe.Text;
            if (string.IsNullOrEmpty(maPhieu))
            {
                if (drvDanhSachPBH.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = drvDanhSachPBH.SelectedRows[0];
                    maPhieu = selectedRow.Cells["MaPhieu"].Value.ToString();
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin phiếu bán hàng cần xóa xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu bán hàng {maPhieu} - {chuSoHuu}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUS_PhieuBanHang bus = new BUS_PhieuBanHang();
                string kq = bus.DeletePhieuBanHang(maPhieu);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin phiếu bán hàng {maPhieu} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(maThe);
                    LoadTheLuuDong();
                    LoadNhanVien();
                    LoadDanhSachPhieu("");

                    cobMaThe.SelectedValue = maThe;
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm("");
            LoadTheLuuDong();
            LoadNhanVien();
            LoadDanhSachPhieu("");
        }
    }
}
