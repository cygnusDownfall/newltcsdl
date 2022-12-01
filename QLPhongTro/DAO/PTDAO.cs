using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLPhongTro.DTO;

namespace QLPhongTro.DAO
{
    class PTDAO
    {
        public static DataTable TTPT()
        {
            string sql = "select * from PhongTro";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTKV()
        {
            string sql = "select * from KhuVuc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNTB()
        {
            string sql = "select * from NhomTB";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTCTPT(string mapt)
        {
            string sql = "select * from PhongTro where MaPhong='"+mapt+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable Tenkvtheomakv(string makv)
        {
            string sql = "select TenKV from KhuVuc where MaKV='"+makv+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable Tenntbtheomantb(string manhomtb)
        {
            string sql = "select TenNhom from NhomTB where MaNhomTB='"+manhomtb+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable maphong_max()
        {
            string sql = "select top 1 MaPhong from PhongTro order by MaPhong desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void GhiPT(PTDTO pt)
        {
            string sql = "insert into PhongTro([MaPhong],[TenPhong],[Gia],[MaKV],[SLKT],[TrangThai],[MaNhomTB]) values('"+pt.Maphong+"',N'"+pt.Tenphong+"',"+pt.Gia+",'"+pt.Makv+"',"+pt.Slkt+",N'"+pt.Trangthai+"','"+pt.Manhomtb+"')";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaPT(PTDTO pt)
        {
            string sql = "delete from PhongTro where MaPhong='"+pt.Maphong+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void UpdatePT(PTDTO pt)
        {
            string sql = "update PhongTro set TenPhong='"+pt.Tenphong+"',Gia='"+pt.Gia+"',MaKV='"+pt.Makv+"',SLKT='"+pt.Slkt+"',TrangThai=N'"+pt.Trangthai+"',MaNhomTB='"+pt.Manhomtb+"' where MaPhong='"+pt.Maphong+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
