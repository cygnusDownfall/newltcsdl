using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhongTro.DAO;
using QLPhongTro.DTO;
using System.Windows.Forms;

namespace QLPhongTro.BUS
{
    class PTBUS
    {
        public static void GhiPt(PTDTO pt)
        {
            try
            {
                PTDAO.GhiPT(pt);
            }
            catch
            {
                MessageBox.Show("Ghi không thành công");
            }
        }
        public static void XoaPT(PTDTO pt)
        {
            if(MessageBox.Show("Bạn có muốn xóa dòng này","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PTDAO.XoaPT(pt);
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }
        public static void CapNhatPT(PTDTO pt)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật dòng này", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PTDAO.UpdatePT(pt);
                }
                catch
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }
        }
    }
}
