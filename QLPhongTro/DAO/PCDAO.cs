using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLPhongTro.DTO;

namespace QLPhongTro.DAO
{
    class PCDAO
    {
        public static DataTable TTPC()
        {
            string sql = "select* from PhieuChi";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_Combobox()
        {
            string sql = "select * from PhongTro";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable PC_Max()
        {
            string sql = "select top 1 MaPC from PhieuChi order by MaPC desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable Tenphong_maphong(string map)
        {
            string sql = "select TenPhong from PhongTro where MaPhong='" + map + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemPC(PCDTO pc)
        {
            string sql = "insert into PhieuChi([MaPC],[SoTien],[NgayChi],[Lydo],[MaPhong]) values ('" + pc.Mapc + "'," + pc.Sotien + ",'" + pc.Ngaychi + "',N'" + pc.Lydo + "','" + pc.Maphong + "')";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaPC(PCDTO pc)
        {
            string sql = "delete from PhieuChi where MaPC='" + pc.Mapc + "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void CapnhatPC(PCDTO pc)
        {
            string sql = "update PhieuChi set SoTien='" + pc.Sotien + "',NgayChi='" + pc.Ngaychi + "',Lydo=N'" + pc.Lydo + "',MaPhong='" + pc.Maphong + "' where MaPC='" + pc.Mapc + "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
