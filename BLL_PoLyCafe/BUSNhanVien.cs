using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PoLyCafe;
using DTO_PoLyCafe;

namespace BLL_PoLyCafe
{
    public class BUSNhanVien
    {
        DALNhanVien dalNhanVIen = new DALNhanVien();

        public NhanVien DangNhap(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }    
            return dalNhanVIen.getNhanVien(username, password);
        }
    }
}
