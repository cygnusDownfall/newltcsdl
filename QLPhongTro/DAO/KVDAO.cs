using System;
using System.Collections.Generic;
using System.Data;
using QLPhongTro.DTO;

namespace QLPhongTro.DAO
{
    public class KVDAO
    {
        public static DataTable TTkhuvuc()
        {
            return KNCSDL.DocDuLieu("select * from KhuVuc");
        }
        public static DataTable TTPTthuocKV(string makv)
        {
            return KNCSDL.DocDuLieu("select * from PhongTro where MaKV='" + makv + "'");
        }
        public static void them(string makv,string tenkv)
        {
            KNCSDL.ThucThiTruyVan("insert into KhuVuc([MaKV],[TenKV]) values ('"+makv+"',N'"+tenkv+"')");
        }
        public static DataTable kv_max()
        {
            return KNCSDL.DocDuLieu("select top 1 MaKV from KhuVuc order by MaKV desc");
        }
        public static void xoa(string makv)
        {
            KNCSDL.ThucThiTruyVan("delete from KhuVuc where MaKV='"+makv+"'");
        }
        public static void sua(string makv, string tenkv)
        {
            KNCSDL.ThucThiTruyVan("update KhuVuc set TenKV=N'"+tenkv+"' where MaKV='"+makv+"'");
        }
    }
}
