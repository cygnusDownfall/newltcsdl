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
        public static void XoaPC(NhapPCDTO pc)
        {
            if(MessageBox.Show("Bạn có muốn xóa phiếu chi này!","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PCDAO.XoaPC(pc);
                    PCDAO.XoaDSPC(pc);
                }
                catch
                {
                    MessageBox.Show("Xóa phiếu chi không thành công!");
                }
            }
        }
        public static void CapNhatPC(NhapPCDTO pc)
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
