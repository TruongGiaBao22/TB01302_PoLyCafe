using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PoLyCafe
{
    public class TheLuuDong
    {
        public string MaThe {  get; set; }
        public string ChuSoHuu { get; set; }
        public bool TrangThai { get; set; }

        public string TrangThaiText => TrangThai ? "Đang Hoạt Động" : "Không Hoạt Động";
    }
}
