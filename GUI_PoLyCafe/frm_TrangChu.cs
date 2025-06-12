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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        



        

        






        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            openChildFrom(new frm_MainTrangChu());
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            openChildFrom(new frm_QuanLyNhanVien());
        }

        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            openChildFrom(new frm_MainSanPham());
        }

        private void btnTLD_Click_1(object sender, EventArgs e)
        {
            openChildFrom(new frm_QuanLyTheLuuDong());
        }

        private void btnHeThong_Click_1(object sender, EventArgs e)
        {
            openChildFrom(new frm_MainHeThong());
        }

        private void btnThongke_Click_1(object sender, EventArgs e)
        {
            openChildFrom(new frn_MainThongke());
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

        private void btnPhieuBanHang_Click(object sender, EventArgs e)
        {
            openChildFrom(new frm_DonHang());
        }
    }
}
