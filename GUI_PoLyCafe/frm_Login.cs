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
    public partial class frm_Login : Form
    {
        BUSNhanVien  busNhanVien = new BUSNhanVien();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienThiMK.Checked ? '\0':'*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "hoa.nguyen@cafe.com";
            txtMatKhau.Text = "password1";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Nếu quên mật khẩu vui lòng liên hệ quản trị viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;

            NhanVien nv = busNhanVien.DangNhap(username, password);
            if (nv == null)
            {
                MessageBox.Show(this, "Tài Khoản Hoặc Mật Khẩu Của Bạn Không Chính Xác !");
            }
            else
            {
                if (nv.TrangThai == false)
                {
                    MessageBox.Show(this, "Tài Khoản Của Bạn Hiện Đang Không Hoạt Động ( Vui Lòng Liên Hệ Quản Trị Viên )");
                    return;
                }
                AuthUtil.user = nv;
                frm_TrangChu main = new frm_TrangChu();
                main.Show();
                this.Hide();
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi chương trình", "Thoát",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
              );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
