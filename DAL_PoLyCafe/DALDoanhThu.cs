using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PoLyCafe;

namespace DAL_PoLyCafe
{
    public class DALDoanhThu
    {
        public List<DoanhThu> LayDoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            List<DoanhThu> list = new List<DoanhThu>();

            using (SqlConnection conn = new SqlConnection(@"Data Source=TRUONGBAO\SQLEXPRESS;Initial Catalog=PolyCafe;Integrated Security=True;"))
            {
                string query = @"
                SELECT 
                    sp.TenSanPham, 
                    SUM(ct.SoLuong * ct.DonGia) AS TongTien,
                    COUNT(DISTINCT pb.MaPhieu) AS SoPhieu
                FROM PhieuBanHang pb
                JOIN ChiTietPhieu ct ON pb.MaPhieu = ct.MaPhieu
                JOIN SanPham sp ON sp.MaSanPham = ct.MaSanPham
                WHERE pb.NgayTao BETWEEN @TuNgay AND @DenNgay
                GROUP BY sp.TenSanPham";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DoanhThu tk = new DoanhThu
                    {
                        TenSanPham = reader["TenSanPham"].ToString(),
                        TongTien = Convert.ToDecimal(reader["TongTien"]),
                        SoPhieu = Convert.ToInt32(reader["SoPhieu"])
                    };
                    list.Add(tk);
                }
                conn.Close();
            }

            return list;
        }
    }
}

