using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PoLyCafe;
using DTO_PoLyCafe;

namespace BLL_PoLyCafe
{
    public class BUS_TKLoaiSP
    {
        private DAL_TKLoaiSP dal = new DAL_TKLoaiSP();

        //public List<DoanhThuTheoLoai> GetThongKeDoanhThu()
        //{
        //    return dal.GetDoanhThuTheoLoai();
        //}
        public List<TKLoaiSP> GetThongKeDoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return dal.GetDoanhThuTheoLoaiTheoNgay(tuNgay, denNgay);
        }
        public List<TKLoaiSP> GetThongKeDoanhThuTheoLoai(string ma, DateTime tuNgay, DateTime denNgay)
        {
            return dal.GetDoanhThuTheoLoai(ma, tuNgay, denNgay);
        }
    }
}
