using System;
using System.Collections.Generic;
using QLPhongTro.DAO;
using QLPhongTro.DTO;
using System.Windows.Forms;
using System.Data;

namespace QLPhongTro.BUS
{
    public class KVBUS
    {
        public static DataTable TTkhuvuc()
        {
            try
            {
                return KVDAO.TTkhuvuc();
            }
            catch
            {
                MessageBox.Show("khong load duoc khu vuc!!!");
                return null;
            }
        }
        public static DataTable TTPTthuocKV(string makv)
        {
            try
            {
                return KVDAO.TTPTthuocKV(makv);
            }
            catch
            {
                MessageBox.Show("khong load duoc phong tro thuoc khu vuc nay!!!");
                return null;
            }
        }
        public static void them(string makv,string tenkv)
        {
            try
            {
                KVDAO.them(makv,tenkv);
            }
            catch
            {
                MessageBox.Show("them khu vuc khong thanh cong!!!");
                
            }
        }
        public static string kv_max()
        {
            try
            {
                return KNCSDL.DocDuLieu("select top 1 MaKV from KhuVuc order by MaKV desc").Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("them khu vuc khong thanh cong!!!");
                return null;
            }
        }
        public static void xoa(string makv)
        {
            try
            {
                if(MessageBox.Show("Ban co chac muon xoa??","Xac nhan",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    KVDAO.xoa(makv);

                }
                
            }
            catch
            {
                MessageBox.Show("xoa khu vuc khong thanh cong!!!");

            }
        }
        public static void sua(string makv, string tenkv)
        {
            try
            {
                if (MessageBox.Show("Ban co chac muon cap nhat thong tin ??", "Xac nhan", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    KVDAO.sua(makv, tenkv);

                }
            }
            catch
            {
                MessageBox.Show("sua thong tin khu vuc khong thanh cong!!!");

            }
        }
    }
           
    
}
