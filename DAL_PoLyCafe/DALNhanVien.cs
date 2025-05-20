using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PoLyCafe;

namespace DAL_PoLyCafe
{
    public class DALNhanVien
    {
        public NhanVien getNhanVien(string email, string password)
        {
            string sql = "SELECT * FROM NhanVien WHERE Email=@0 AND MatKhau=@1";
            List<object> thamso = new List<object>();
            thamso.Add(email);
            thamso.Add(password);
            NhanVien nv = DBUtil.Value<NhanVien>(sql,thamso);
            return nv;
        }
        public void ResetMatKhau(string matkhau, string email)
        {
            try
            {
                string sql = "UPDATE NhanVien Set MatKhau =@0 Where Email=@1";
                List<object> thamso = new List<object>();
                thamso.Add(matkhau);
                thamso.Add(email);
                DBUtil.Update(sql, thamso);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
