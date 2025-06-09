using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PoLyCafe;
using DTO_PoLyCafe;

namespace BLL_PoLyCafe
{
    public class BUS_TKNhanVien
    {
        private DAL_TKNhanVIen dal = new DAL_TKNhanVIen();

        public List<TKNhanVien> LayDuLieuThongKeTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return dal.LayThongKeSoPhieuTheoNhanVienTheoNgay(tuNgay, denNgay);
        }
    }
}
