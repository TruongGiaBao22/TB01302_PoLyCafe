using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PoLyCafe;
using DTO_PoLyCafe;

namespace BLL_PoLyCafe
{
    public class BUSTheLuuDong
    {
        DAL_TheLuuDong dalTheLuuDong = new DAL_TheLuuDong();
        public List<TheLuuDong> GetTheLuuDong()
        {
            return dalTheLuuDong.selectAll();
        }


        public string InsertTheLuuDong(TheLuuDong tld)
        {
            try
            {
                tld.MaThe = dalTheLuuDong.generateMaTheLuuDong();
                if (string.IsNullOrEmpty(tld.MaThe))
                {
                    return "Mã thẻ lưu động không hợp lệ.";
                }

                dalTheLuuDong.insertTheLuuDong(tld);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateTheLuuDong(TheLuuDong mathe1)
        {
            try
            {
                if (string.IsNullOrEmpty(mathe1.MaThe))
                {
                    return "Mã thẻ lưu động không hợp lệ.";
                }

                dalTheLuuDong.updateTheLuuDong(mathe1);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteTheLuuDong(string mathe2)
        {
            try
            {
                if (string.IsNullOrEmpty(mathe2))
                {
                    return "Mã thẻ lưu động không hợp lệ.";
                }

                dalTheLuuDong.deleteTheLuuDong(mathe2);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
