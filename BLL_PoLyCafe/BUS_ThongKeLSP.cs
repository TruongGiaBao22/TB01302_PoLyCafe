using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PoLyCafe;
using DTO_PoLyCafe;

namespace BLL_PoLyCafe
{
    public class BUS_ThongKeLSP
    {
        public static List<ThongKeLSP> LayDanhSachThongKe()
    {
        return DAL_ThongKeLSP.GetThongKe();
    }
    }
}
