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
using DTO_PoLyCafe;

namespace GUI_PoLyCafe
{
    public partial class frm_TKLoaiSP : Form
    {
        BUS_TKLoaiSP bus = new BUS_TKLoaiSP();
        BUS_LoaiSanPham busLoai = new BUS_LoaiSanPham();
        public frm_TKLoaiSP()
        {
            InitializeComponent();
        }
        private void thongke()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            List<TKLoaiSP> data = bus.GetThongKeDoanhThuTheoNgay(tuNgay, denNgay);

            // Kiểm tra dữ liệu rỗng
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chartDoanhThu.Series.Clear();
                chartDoanhThu.Titles.Clear();
                return;
            }

            chartDoanhThu.Series.Clear();
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add($"Doanh thu theo loại sản phẩm\nTừ {tuNgay:dd/MM/yyyy} đến {denNgay:dd/MM/yyyy}");

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;

            foreach (var item in data)
            {
                series.Points.AddXY(item.TenLoai, item.DoanhThu);
            }

            chartDoanhThu.Series.Add(series);
        }
        private void loadcbo()
        {
            List<LoaiSanPham> lst = busLoai.GetLoaiSanPhamList();
            lst.Insert(0, new LoaiSanPham() { MaLoai = string.Empty, TenLoai = string.Format("--Tất Cả--") });
            cobSanPham.DataSource = lst;
            cobSanPham.ValueMember = "MaLoai";
            cobSanPham .DisplayMember = "TenLoai";
        }
        private void load()
        {
            if (cobSanPham.SelectedValue != null)
            {
                string maLoai = cobSanPham.SelectedValue.ToString();
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date;

                var data = bus.GetThongKeDoanhThuTheoLoai(maLoai, tuNgay, denNgay);

                chartDoanhThu.Series.Clear();
                chartDoanhThu.ChartAreas.Clear();
                chartDoanhThu.Titles.Clear();

                ChartArea area = new ChartArea("Area1");
                chartDoanhThu.ChartAreas.Add(area);

                Series series = new Series("Doanh Thu");
                series.ChartType = SeriesChartType.Column;
                series.XValueType = ChartValueType.String;

                foreach (var item in data)
                {
                    series.Points.AddXY(item.TenLoai, item.DoanhThu);
                }

                chartDoanhThu.Series.Add(series);
                chartDoanhThu.Titles.Add("Biểu đồ doanh thu theo sản phẩm");
            }
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void frm_TKLoaiSP_Load(object sender, EventArgs e)
        {
            loadcbo();
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maLoai = cobSanPham.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(maLoai))
            {
                thongke();
            }
            else
            {
                load();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDenNgay.Value = DateTime.Now;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            chartDoanhThu.Series.Clear();
            chartDoanhThu.Titles.Clear();
        }
    }
}
