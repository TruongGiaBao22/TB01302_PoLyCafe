using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PoLyCafe;

namespace DAL_PoLyCafe
{
    public class DAL_ThongKeLSP
    {
        public static List<ThongKeLSP> GetThongKe()
        {
            List<ThongKeLSP> list = new List<ThongKeLSP>();
            string sql = "ThongKeLSP1";

            using (SqlCommand cmd = DBUtil.GetCommand(sql, new List<object>(), CommandType.StoredProcedure))
            {
                cmd.Connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongKeLSP item = new ThongKeLSP
                        {
                            MaSanPham = reader["MaSanPham"].ToString(),
                            TenSanPham = reader["TenSanPham"].ToString(),
                            SoLuong = Convert.ToInt32(reader["SoLuong"]),
                            GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                            TongTien = Convert.ToDecimal(reader["TongTien"]),
                            SoPhieu = Convert.ToInt32(reader["SoPhieu"])
                        };
                        list.Add(item);
                    }
                }
            }

            return list;
        }
    }
}
