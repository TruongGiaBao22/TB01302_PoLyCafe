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

namespace GUI_PoLyCafe
{
    public partial class frm_DoanhThu : Form
    {
        private BUSDoanhThu bll = new BUSDoanhThu();
        public frm_DoanhThu()
        {
            InitializeComponent();
            LoadPieChart();
        }
        private void LoadPieChart()
        {
            var list = bll.LayDoanhThuTheoSanPham();

            chart1.Series.Clear();
            chart1.Series.Add("DoanhThu");
            chart1.Series["DoanhThu"].ChartType = SeriesChartType.Pie; // Đổi sang Pie Chart

            foreach (var item in list)
            {
                int pointIndex = chart1.Series["DoanhThu"].Points.AddXY(item.TenSanPham, item.TongTien);

                // Gán tên sản phẩm cho legend
                chart1.Series["DoanhThu"].Points[pointIndex].LegendText = item.TenSanPham;

                // Gán số tiền cho nhãn hiển thị trên biểu đồ
                chart1.Series["DoanhThu"].Points[pointIndex].Label = $"{item.TongTien:N0} VNĐ";

                // Đưa nhãn ra ngoài biểu đồ
                chart1.Series["DoanhThu"]["PieLabelStyle"] = "Outside";
                chart1.Series["DoanhThu"]["PieLineColor"] = "Black";
            }
            chart1.Dock = DockStyle.Fill;
            chart1.Margin = new Padding(0);
            chart1.Padding = new Padding(0);
            chart1.BackColor = Color.White;

            chart1.ChartAreas[0].Position.Auto = false;
            chart1.ChartAreas[0].Position.X = 0;
            chart1.ChartAreas[0].Position.Y = 0;
            chart1.ChartAreas[0].Position.Width = 100;
            chart1.ChartAreas[0].Position.Height = 100;
            chart1.ChartAreas[0].InnerPlotPosition.Auto = true;

        }


        private void btnXCT_Click(object sender, EventArgs e)
        {
            frm_ThongKeSP frmChiTiet = new frm_ThongKeSP();
            frmChiTiet.ShowDialog();
        }

       

        private void chart1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frm_ThongKeSP frmChiTiet = new frm_ThongKeSP();
            frmChiTiet.ShowDialog();
        }
    }
}
