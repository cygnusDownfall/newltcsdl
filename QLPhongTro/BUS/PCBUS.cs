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
    class PCBUS
    {
        public static void ThemPC(PCDTO pc)
        {
            try
            {
                PCDAO.ThemPC(pc);
            }
            catch
            {
                MessageBox.Show("Thêm phiếu chi thành công!");
            }
        }
        public static void XoaPC(PCDTO pc)
        {
            if (MessageBox.Show("Bạn có muốn xóa phiếu chi này!", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PCDAO.XoaPC(pc);
                }
                catch
                {
                    MessageBox.Show("Xóa phiếu chi không thành công!");
                }
            }
        }
        public static void CapNhatPC(PCDTO pc)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật phiếu chi này!", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PCDAO.CapnhatPC(pc);
                }
                catch
                {
                    MessageBox.Show("Cập nhật phiếu chi không thành công!");
                }
            }
        }
    }
}
