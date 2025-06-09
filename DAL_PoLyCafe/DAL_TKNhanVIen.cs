using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PoLyCafe;

namespace DAL_PoLyCafe
{
    public class DAL_TKNhanVIen
    {
        public List<TKNhanVien> LayThongKeSoPhieuTheoNhanVienTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            List<TKNhanVien> danhSach = new List<TKNhanVien >();

            string sql = @"
                SELECT nv.MaNhanVien, nv.HoTen, COUNT(pb.MaPhieu) AS SoPhieu
                FROM NhanVien nv
                LEFT JOIN PhieuBanHang pb ON nv.MaNhanVien = pb.MaNhanVien
                WHERE pb.NgayTao BETWEEN @0 AND @1
                GROUP BY nv.MaNhanVien, nv.HoTen";

            List<object> args = new List<object> { tuNgay, denNgay };

            using (SqlDataReader reader = DBUtil.Query(sql, args))
            {
                while (reader.Read())
                {
                    danhSach.Add(new TKNhanVien
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        SoPhieu = Convert.ToInt32(reader["SoPhieu"])
                    });
                }

                reader.Close(); // Đóng reader để tránh leak kết nối
            }

            return danhSach;
        }
    }
}
