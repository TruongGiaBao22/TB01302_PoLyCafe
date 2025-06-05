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
        public List<DoanhThu> GetDoanhThuTheoSanPham()
        {
            List<DoanhThu> list = new List<DoanhThu>();
            string query = @"
    SELECT sp.TenSanPham, SUM(ct.SoLuong * ct.DonGia) AS TongTien
    FROM PhieuBanHang pb
    JOIN ChiTietPhieu ct ON pb.MaPhieu = ct.MaPhieu
    JOIN SanPham sp ON sp.MaSanPham = ct.MaSanPham
    GROUP BY sp.TenSanPham
    ORDER BY SUM(ct.SoLuong * ct.DonGia) DESC";

            using (SqlConnection conn = new SqlConnection(DBUtil.connString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new DoanhThu
                    {
                        TenSanPham = reader["TenSanPham"].ToString(),
                        TongTien = Convert.ToDecimal(reader["TongTien"])
                    });
                }
            }

            return list;
        }
    }
}

