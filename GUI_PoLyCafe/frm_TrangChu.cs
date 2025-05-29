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
            nhanVienToolStripMenuItem.Visible = false;
            thongKeToolStripMenuItem.Visible = false;
            
        }

        private void Checkpermission()
        {
            if (AuthUtil.IsLogin())
            {
                nhanVienToolStripMenuItem.Visible = true;
                sanPhamToolStripMenuItem.Visible = true;
                phieuToolStripMenuItem.Visible = true;
                theLuuDongToolStripMenuItem.Visible = true;
                thongKeToolStripMenuItem.Visible = true;
                heThongToolStripMenuItem.Visible = true;
                if (AuthUtil.user.VaiTro == false)
                {
                    VaiTroNhanVien();
                }

            }
            else
            {
                heThongToolStripMenuItem.Visible=true;
                nhanVienToolStripMenuItem.Visible=false;
                sanPhamToolStripMenuItem.Visible = false;
                phieuToolStripMenuItem.Visible=false;
                theLuuDongToolStripMenuItem.Visible=false;
                thongKeToolStripMenuItem.Visible=false;
                heThongToolStripMenuItem .Visible=false;

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
    }
}
