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

namespace GUI_PoLyCafe
{
    public partial class frm_ThongKeSP : Form
    {
        public frm_ThongKeSP()
        {
            InitializeComponent();
        }

        private void frm_ThongKeLSP_Load(object sender, EventArgs e)
        {
            loadTKSP();
        }
        private void loadTKSP()
        {
            drvThongKe.DataSource = null; // Xóa dữ liệu cũ nếu cần
            drvThongKe.DataSource = BUS_ThongKeLSP.LayDanhSachThongKe();

            // Đổi tên cột (HeaderText)
            drvThongKe.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            drvThongKe.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            drvThongKe.Columns["GiaBan"].HeaderText = "Giá Bán";
            drvThongKe.Columns["SoLuong"].HeaderText = "Số Lượng";
            drvThongKe.Columns["TongTien"].HeaderText = "Tổng Tiền";
            drvThongKe.Columns["SoPhieu"].HeaderText = "Số Phiếu";

            // Thiết lập giao diện
            drvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            drvThongKe.ColumnHeadersHeight = 40;
            drvThongKe.RowTemplate.Height = 40;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
