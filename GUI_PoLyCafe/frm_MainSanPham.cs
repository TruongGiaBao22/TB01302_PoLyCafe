using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PoLyCafe
{
    public partial class frm_MainSanPham : Form
    {
        public frm_MainSanPham()
        {
            InitializeComponent();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildFrom(new frm_QuanLySanPham());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildFrom(new frm_LoaiSanPham());
        }
    }
}
