using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLPhongTro.DTO;

namespace QLPhongTro.DAO
{
    class KTDAO
    {
        public static DataTable TimKT(KTDTO kt)
        {
            string sql = "select * from KhachTro where MaKT like '%"+kt.Makt+"%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable MaKT_Max()
        {
            string sql = "select top 1 MaKT from KhachTro order by MaKT desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTPhong()
        {
            string sql = "select *from PhongTro";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TPhongtheoMaPhong(string maphong)
        {
            string sql = "select TenPhong from PhongTro where MaPhong='"+maphong+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTKT()
        {
            string sql = "select * from KhachTro";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void GhiKT(KTDTO kt)
        {
            string sql = "Insert into KhachTro([MaKT],[TenKT],[CMND],[SDT],[DiaChi],[MaPhong]) values ('"+kt.Makt+"',N'"+kt.Tenkt+"','"+kt.Cmnd+"','"+kt.Sdt+"',N'"+kt.Diachi+"','"+kt.Maphong+"')";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaKT(KTDTO kt)
        {
            string sql = "delete from KhachTro where MaKT='"+kt.Makt+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhatKT(KTDTO kt)
        {
            string sql = "update KhachTro set TenKT=N'"+kt.Tenkt+"',CMND='"+kt.Cmnd+"',SDT='"+kt.Sdt+"',DiaChi=N'"+kt.Diachi+"',MaPhong='"+kt.Maphong+"' where MaKT='"+kt.Makt+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
