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
    class KTBUS
    {
        public static void GhiKT(KTDTO kt)
        {
            try
            {
                KTDAO.GhiKT(kt);
            }
            catch
            {
                MessageBox.Show("Ghi khách trọ không thành công!");
            }
        }
        public static void XoaKT(KTDTO kt)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa khách trọ này!","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    KTDAO.XoaKT(kt);
                }
                catch
                {
                    MessageBox.Show("Xóa khách trọ không thành công!");
                }
            }
        }
        public static void CapNhatKT(KTDTO kt)
        {
            if (MessageBox.Show("Bạn có chắc muốn cập nhật khách trọ này!", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    KTDAO.CapNhatKT(kt);
                }
                catch
                {
                    MessageBox.Show("Cập nhật khách trọ không thành công!");
                }
            }
        }
    }
}
