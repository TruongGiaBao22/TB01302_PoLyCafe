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
        BUSDoanhThu busDoanhThu = new BUSDoanhThu();
        public frm_DoanhThu()
        {
            InitializeComponent();
        }


        private void LoadBieuDo(DateTime tuNgay, DateTime denNgay)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            var danhSach = busDoanhThu.LayDoanhThuTheoNgay(tuNgay, denNgay);

            if (danhSach.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            chart1.Titles.Add("Thống kê doanh thu theo sản phẩm");

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                ToolTip = "#VALX: #VAL{#,##0} VNĐ"
            };

            foreach (var item in danhSach)
            {
                DataPoint point = new DataPoint();
                point.AxisLabel = item.TenSanPham;
                point.LegendText = item.TenSanPham;
                point.YValues = new double[] { (double)item.TongTien };

                // Hiển thị nhãn bên ngoài với đường chỉ
                point.Label = $"{item.TenSanPham}\n{item.TongTien:#,##0} VNĐ\n{item.SoPhieu} phiếu bán ra";
                point.LabelForeColor = Color.Black;
                point.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                // CustomProperties để vẽ đường chỉ ra ngoài (callout line)
                point["PieLabelStyle"] = "Outside";
                point["PieLineColor"] = "Black";

                series.Points.Add(point);
            }

            chart1.Series.Add(series);

            chart1.Legends.Clear();
            Legend legend = new Legend
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Near
            };
            chart1.Legends.Add(legend);
        }


        private void btnXCT_Click(object sender, EventArgs e)
        {
        }

       

        private void chart1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }


        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadBieuDo(tuNgay, denNgay);
        }

        private void frm_DoanhThu_Load(object sender, EventArgs e)
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
