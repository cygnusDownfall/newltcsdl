using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLPhongTro.DTO;

namespace QLPhongTro.DAO
{
    class TKDAO
    {
        public static DataTable TimTK(TKDTO tk)
        {
            string sql = "select * from TaiKhoan where TenTK like '%"+tk.Tentk+"%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable MaTK_Max()
        {
            string sql = "select top 1 MaTK from TaiKhoan order by MaTK desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTTK()
        {
            string sql = "select *from TaiKhoan";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TK_MK(TKDTO tk)
        {
            string sql = "SELECT * FROM TaiKhoan WHERE MaTK='" + tk.Matk + "' and MatKhau='" + tk.Matkhau + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void GhiTK(TKDTO tk)
        {
            string sql = "INSERT INTO TaiKhoan([MaTK],[TenTK],[MatKhau],[Quyen])  VALUES ('"+tk.Matk+"',N'"+tk.Tentk+"','"+tk.Matkhau+"','"+tk.Quyen+"')";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaTK(TKDTO tk)
        {
            string sql = "delete from TaiKhoan where MaTK='"+tk.Matk+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhatTK(TKDTO tk)
        {
            string sql = "update TaiKhoan set TenTK='"+tk.Tentk+"',MatKhau='"+tk.Matkhau+"',Quyen='"+tk.Quyen+"' where MaTK='"+tk.Matk+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
