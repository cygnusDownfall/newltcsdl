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
    class TKBUS
    {
        public static void GhiTK(TKDTO tk)
        {
            try
            {
                TKDAO.GhiTK(tk);
            }
            catch
            {
                MessageBox.Show("Ghi tài khoản không thành công!");
            }
        }
        public static void XoaTK(TKDTO tk)
        {
            if(MessageBox.Show("Bạn có muốn xóa tài khoản này!","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    TKDAO.XoaTK(tk);
                }
                catch
                {
                    MessageBox.Show("Xóa tài khoản không thành công!");
                }
            }
        }
        public static void CapnhatTK(TKDTO tk)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật tài khoản này!", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    TKDAO.CapNhatTK(tk);
                }
                catch
                {
                    MessageBox.Show("Cập nhật tài khoản không thành công!");
                }
            }
        }
    }
}
