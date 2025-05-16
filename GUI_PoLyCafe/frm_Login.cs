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

        private void btnDangNhap_Click(object sender, EventArgs e)
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
                if(nv.TrangThai == false)
                {
                    MessageBox.Show(this, "Tài Khoản Của Bạn Hiện Đang Không Hoạt Động ( Vui Lòng Liên Hệ Quản Trị Viên )");
                    return;
                }
                AuthUtil.user = nv;
                frm_DoiMatKhau main = new frm_DoiMatKhau();
                main.Show();
                this.Hide();
            }
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
