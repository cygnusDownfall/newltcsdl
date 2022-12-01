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
        public static DataTable TTNPC()
        {
            string sql = "select * from PhieuChi";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable PC_Max()
        {
            string sql = "select top 1 MaDSChi from DSChi order by MaDSChi desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemDSC(PCDTO pc)
        {
            string sql = "insert into DSChi([MaDSChi],[TongTien]) values ('"+pc.Madschi+"',"+pc.Tongtien+")";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void ThemPC(NhapPCDTO npc)
        {
            string sql = "insert into PhieuChi([Stt],[SoTien],[NgayChi],[Lydo],[MaPhong],[MaDSChi]) values ("+npc.Stt+","+npc.Sotien+",'"+npc.Ngaychi+"',N'"+npc.Lydo+"','"+npc.Maphong+"','"+npc.Madschi+"')";
            KNCSDL.ThucThiTruyVan(sql);
        }






        public static DataTable TTPC()
        {
            string sql = "select DSChi.MaDSChi,TongTien,NgayChi,MaPhong from DSChi,PhieuChi where DSChi.MaDSChi=PhieuChi.MaDSChi";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNPC(NhapPCDTO pc)
        {
            string sql = "select Lydo,SoTien from PhieuChi where MaDSChi='"+pc.Madschi+"'";
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
        public static DataTable Tenphong_maphong(string map)
        {
            string sql = "select TenPhong from PhongTro where MaPhong='"+map+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void XoaDSPC(NhapPCDTO pc)
        {
            string sql = "delete from DSChi where MaDSChi='"+pc.Madschi+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaPC(NhapPCDTO pc)
        {
            string sql = "delete from PhieuChi where MaDSChi='"+pc.Madschi+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void CapnhatPC(NhapPCDTO pc)
        {
            string sql = "update PhieuChi set SoTien='"+pc.Sotien+"',NgayChi='"+pc.Ngaychi+"',Lydo='"+pc.Lydo+"',MaPhong='"+pc.Maphong+"' where MaDSChi='"+pc.Madschi+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
