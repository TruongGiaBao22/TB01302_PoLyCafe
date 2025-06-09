using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_PoLyCafe
{
    public partial class frn_MainThongke : Form
    {
        public frn_MainThongke()
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
        private void btnTKSP_Click(object sender, EventArgs e)
        {
            openChildFrom(new frm_DoanhThu());
        }

        private void btnTKNV_Click(object sender, EventArgs e)
        {
            openChildFrom( new frm_ThongKeNV());
        }

        private void btnTKLSP_Click(object sender, EventArgs e)
        {
            openChildFrom( new frm_TKLoaiSP());
        }
    }
}
