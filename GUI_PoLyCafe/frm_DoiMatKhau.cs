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
using UTIL_PoLyCafe;

namespace GUI_PoLyCafe
{
    public partial class frm_DoiMatKhau : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.user.MatKhau.Equals(txtMatKhauCu.Text)) 
            {
                MessageBox.Show("Mật Khẩu Củ Của Bạn Không Chính Xác ");
            }
            else
            {
                if (!txtMatKhauMoi.Text.Equals(txtXacNhanMatKhau.Text))
                {
                    MessageBox.Show("Mật Khẩu Của Bạn Không Đúng Với Mật Khẩu Vừa Nhập ");
                }
                else 
                {
                    AuthUtil.user.MatKhau=txtMatKhauMoi.Text;
                    if (busNhanVien.ResetMatKhau(AuthUtil.user.Email, txtMatKhauMoi.Text))
                    {
                        MessageBox.Show("Thay Đổi Mật Khẩu Thành Công ");
                    }
                    else MessageBox.Show("Đổi mật khẩu không thành công vui lòng kiểm tra lại !");
                }
            }
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            if (AuthUtil.IsLogin())
            {
                txtTaiKhoan.Text = AuthUtil.user.HoTen;
            }
        }

        private void ckbMKC_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauCu.PasswordChar = ckbMKC.Checked ? '\0' : '*';
        }

        private void ckbMKM_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = ckbMKM.Checked ? '\0' : '*';
        }

        private void ckbXNMK_CheckedChanged(object sender, EventArgs e)
        {
            txtXacNhanMatKhau.PasswordChar = ckbXNMK.Checked ? '\0' : '*';
        }
    }
}
