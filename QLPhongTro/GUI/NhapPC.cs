using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongTro.DAO;
using QLPhongTro.DTO;

namespace QLPhongTro.GUI
{
    public partial class NhapPC : Form
    {
        public NhapPC()
        {
            InitializeComponent();
        }
        public void TT_Combobox()
        {
            DataTable dt = new DataTable();
            dt = PCDAO.TT_Combobox();
            cbphong.DataSource = dt;
            cbphong.ValueMember = "MaPhong";
            cbphong.DisplayMember = "TenPhong";
        }
        private void NhapPC_Load(object sender, EventArgs e)
        {
            TT_Combobox();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int stt = lvds.Items.Count;
            stt++;
            lvds.Items.Add(stt.ToString());
            lvds.Items[stt - 1].SubItems.Add(txttien.Text);
            lvds.Items[stt - 1].SubItems.Add(dtpngaychi.Text);
            lvds.Items[stt - 1].SubItems.Add(txtlydo.Text);
            lvds.Items[stt - 1].SubItems.Add(cbphong.Text);

            int tongtien = 0;
            for (int i = 0; i < lvds.Items.Count; i++)
            {
                tongtien += int.Parse(lvds.Items[i].SubItems[1].Text);
            }
            lbltongtien.Text = string.Format("{0:#,##0}", tongtien) + " VND";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                lvds.Items.RemoveAt(lvds.SelectedIndices[0]);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng mà bạn muốn xóa !", "Thông Báo");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                lvds.SelectedItems[0].SubItems[1].Text = txttien.Text;
                lvds.SelectedItems[0].SubItems[2].Text = dtpngaychi.Text;
                lvds.SelectedItems[0].SubItems[3].Text = txtlydo.Text;
                lvds.SelectedItems[0].SubItems[4].Text = cbphong.Text;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng sản phẩm mà bạn muốn chỉnh sửa !", "Thông Báo");
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lvds.Items.Clear();
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            txttien.Text = lvds.SelectedItems[0].SubItems[1].Text;
            dtpngaychi.Text = lvds.SelectedItems[0].SubItems[2].Text;
            txtlydo.Text = lvds.SelectedItems[0].SubItems[3].Text;
            cbphong.Text = lvds.SelectedItems[0].SubItems[4].Text;
        }

        private void btnghi_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            PCDTO pc = new PCDTO();
            dt = PCDAO.TTNPC();
            int sodong = dt.Rows.Count;
            if (sodong == 0)
            {
                pc.Madschi = "PC01";
            }
            else
            {
                dt = PCDAO.PC_Max();
                string madsc = dt.Rows[0][0].ToString();
                pc.Madschi = (int.Parse(madsc.Substring(madsc.Length - 2, 2)) + 1).ToString("PC00");
            }
            int tongtien = 0;
            for (int i = 0; i < lvds.Items.Count; i++)
            {
                tongtien += int.Parse(lvds.Items[i].SubItems[1].Text);

            }
            pc.Tongtien = tongtien;
            DateTime datenow = DateTime.Now;
            pc.Ngaychi = datenow.ToString("MM/dd/yyyy");
            PCDAO.ThemDSC(pc);

            NhapPCDTO npc = new NhapPCDTO();
            for (int i = 0; i < lvds.Items.Count; i++)
            {
                npc.Stt = int.Parse(lvds.Items[i].SubItems[0].Text);
                npc.Sotien = int.Parse(lvds.Items[i].SubItems[1].Text);
                npc.Ngaychi = lvds.Items[i].SubItems[2].Text;
                npc.Lydo = lvds.Items[i].SubItems[3].Text;
                npc.Maphong = lvds.Items[i].SubItems[4].Text;
                npc.Madschi = pc.Madschi;
                PCDAO.ThemPC(npc);
            }
            MessageBox.Show("Thêm Phiếu Chi Thành Công");
            this.Close();
        }
    }
}
