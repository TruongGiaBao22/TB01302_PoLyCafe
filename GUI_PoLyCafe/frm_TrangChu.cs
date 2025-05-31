using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIL_PoLyCafe;

namespace GUI_PoLyCafe
{
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
            Checkpermission();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau doimk = new frm_DoiMatKhau();
            doimk.ShowDialog();
        }
        private Form currentFromChill;

        private void openChildFrom(Form formChild)
        {
            if (currentFromChill != null)
            {
                currentFromChill.Close();
            }
            currentFromChill = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formChild);
            pnMain.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFrom(new frm_QuanLyNhanVien());
        }

        private void quanLyTheLuuDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFrom( new frm_QuanLyTheLuuDong());
        }
        private void VaiTroNhanVien()
        {
            btnNhanVien.Visible = false;
            btnThongke.Visible = false;

        }

        private void Checkpermission()
        {
            if (AuthUtil.IsLogin())
            {
                btnNhanVien.Visible = true;
                btnSanPham.Visible = true;
                btnPhieuBanHang.Visible = true;
                btnTLD.Visible = true;
                btnThongke.Visible = true;
                btnHeThong.Visible = true;
                if (AuthUtil.user.VaiTro == false)
                {
                    VaiTroNhanVien();
                }

            }
            else
            {
                btnHeThong.Visible = true;
                btnNhanVien.Visible = false;
                btnSanPham.Visible = false;
                btnPhieuBanHang.Visible = false;
                btnTLD.Visible = false;
                btnThongke.Visible = false;
                btnHeThong.Visible = false;

            }
        }

        private void quanLySanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFrom(new frm_QuanLySanPham());
        }

        private void quanLyLoaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFrom( new frm_LoaiSanPham() );
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildFrom(new frm_QuanLyNhanVien());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            openChildFrom(new frm_MainSanPham());
        }

        private void btnTLD_Click(object sender, EventArgs e)
        {
            openChildFrom( new frm_QuanLyTheLuuDong() );
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            openChildFrom(new frm_DoiMatKhau());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildFrom(new frm_MainTrangChu());
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Hiện hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?",
                                                  "Xác nhận đăng xuất",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                frm_Login frm = new frm_Login();
                frm.ShowDialog(); // Chờ đến khi login đóng
                this.Close();     // Sau đó đóng form hiện tại
            }
        }
    }
}
