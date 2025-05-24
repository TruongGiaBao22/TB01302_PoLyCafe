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
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }
            return dalNhanVIen.getNhanVien(username, password);
        }
        public bool ResetMatKhau(string email, string mk)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mk))
                {
                    return false;
                }
                dalNhanVIen.ResetMatKhau(mk, email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<NhanVien> GetNhanVienList()
        {
            return dalNhanVIen.selectAll();
        }
        public string InsertNhanVien(NhanVien nv)
        {
            try
            {
                nv.MaNhanVien = dalNhanVIen.generateMaNhanVien();
                if(string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã Nhân Viên Không Hợp lệ !";
                }
                if (dalNhanVIen.checkEmailExists(nv.Email))
                {
                    return "Email đã tồn tại !";
                }
                dalNhanVIen.insertNhanVien(nv);
                return string.Empty;

            }
            catch (Exception ex) 
            {
                return "Lỗi:"+ex.Message;
            }
        }

        public void UpdateNhanVien(NhanVien nv)
        {
            try
            {
                dalNhanVIen.updateNhanVien(nv);
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        public void DaleteNhanVien(string manv)
        {
            try
            {

                dalNhanVIen.deleteNhanVien(manv);
            }
            catch
            {
                throw;
            }
        }
    }
}
