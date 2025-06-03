﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PoLyCafe;
using DTO_PoLyCafe;

namespace BLL_PoLyCafe
{
    public class BUS_PhieuBanHang
    {
        DAL_PhieuBanHang dalPhieuBanHang = new DAL_PhieuBanHang();

        public List<PhieuBanHang> GetListPhieuBanHang(string maThe)
        {
            return dalPhieuBanHang.selectAll(maThe);
        }

        public string InsertPhieuBanHang(PhieuBanHang pbh)
        {
            try
            {
                pbh.MaPhieu = dalPhieuBanHang.generateMaPhieu();
                if (string.IsNullOrEmpty(pbh.MaPhieu))
                {
                    return "Mã phiếu bán hàng không hợp lệ.";
                }

                dalPhieuBanHang.insertPhieuBanHang(pbh);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdatePhieuBanHang(PhieuBanHang pbh)
        {
            try
            {
                if (string.IsNullOrEmpty(pbh.MaPhieu))
                {
                    return "Mã phiếu không hợp lệ.";
                }

                dalPhieuBanHang.updateNhanVien(pbh);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeletePhieuBanHang(string maPhieu)
        {
            try
            {
                if (string.IsNullOrEmpty(maPhieu))
                {
                    return "Mã phiếu bán hàng không hợp lệ.";
                }

                dalPhieuBanHang.deletePhieuBanHang(maPhieu);
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
