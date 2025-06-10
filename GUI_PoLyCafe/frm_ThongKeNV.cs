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
using BLL_PoLyCafe;
using Guna.Charts.WinForms; // Đảm bảo bạn có reference này và đã cài thư viện Guna.Charts.WinForms

namespace GUI_PoLyCafe
{
    public partial class frm_ThongKeNV : Form
    {
        BUS_TKNhanVien bus = new BUS_TKNhanVien();

        public frm_ThongKeNV()
        {
            InitializeComponent();
        }

        
        private void Loadds()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1); // để lấy đến cuối ngày

            var data = bus.LayDuLieuThongKeTheoNgay(tuNgay, denNgay);

            chart1.Series.Clear();
            chart1.Series.Add("Số phiếu bán");
            chart1.Series["Số phiếu bán"].ChartType = SeriesChartType.Column;

            foreach (var item in data)
            {
                string label = $"{item.MaNhanVien} - {item.HoTen}";
                chart1.Series["Số phiếu bán"].Points.AddXY(label, item.SoPhieu);
            }

            chart1.ChartAreas[0].AxisX.Title = "Nhân viên";
            chart1.ChartAreas[0].AxisY.Title = "Số phiếu bán";
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {

            Loadds();
        }

        private void frm_ThongKeNV_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            DateTime today = DateTime.Today;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1); // Đầu tháng hiện tại
            dtpDenNgay.Value = today; // Ngày hiện tại
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDenNgay.Value = DateTime.Now;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            chart1.Series.Clear();
            chart1.Titles.Clear();
        }
    }
}
