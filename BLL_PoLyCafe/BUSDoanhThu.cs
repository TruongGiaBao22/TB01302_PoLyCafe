using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PoLyCafe;
using DTO_PoLyCafe;

namespace BLL_PoLyCafe
{
    public class BUSDoanhThu
    {
        private DALDoanhThu dal = new DALDoanhThu();

        public List<DoanhThu> LayDoanhThuTheoSanPham()
        {
            return dal.GetDoanhThuTheoSanPham();
        }
    }
}
