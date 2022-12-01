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
using QLPhongTro.BUS;

namespace QLPhongTro.GUI
{
    public partial class frmQLPC : Form
    {
        public frmQLPC()
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

        public void TT_PC()
        {
            DataTable dt = new DataTable();
            dt = PCDAO.TTPC();
            int sodong = dt.Rows.Count;
            for(int i = 0; i < sodong; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaDSChi"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TongTien"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayChi"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaPhong"].ToString());
            }
        }

        private void frmQLPC_Load(object sender, EventArgs e)
        {
            TT_Combobox();
            TT_PC();
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            txtmapchi.Text = lvds.SelectedItems[0].SubItems[0].Text;
            txttien.Text= lvds.SelectedItems[0].SubItems[1].Text;
            dtpngaychi.Text= lvds.SelectedItems[0].SubItems[2].Text;
            DataTable dt = new DataTable();
            dt = PCDAO.Tenphong_maphong(lvds.SelectedItems[0].SubItems[3].Text);
            cbphong.Text = dt.Rows[0][0].ToString();

            DataTable dtpc = new DataTable();
            PCDTO pc = new PCDTO();
            pc.Madschi = lvds.SelectedItems[0].SubItems[0].Text;
            dt = PCDAO.TTNPC();
            lvtt.Items.Clear();
            int sodong = dt.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                lvtt.Items.Add(dt.Rows[i][3].ToString());
                lvtt.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NhapPCDTO pc = new NhapPCDTO();
            pc.Madschi = txtmapchi.Text;
            PCBUS.XoaPC(pc);
            lvds.Items.Clear();
            TT_PC();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            NhapPCDTO pc = new NhapPCDTO();
            pc.Madschi = txtmapchi.Text;
            pc.Sotien = int.Parse(txttien.Text);
            pc.Ngaychi = dtpngaychi.Value.ToString("MM/dd/yyyy");
            pc.Maphong = cbphong.SelectedValue.ToString();
            PCBUS.CapNhatPC(pc);
            lvds.Items.Clear();
            TT_PC();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            NhapPC pc = new NhapPC();
            pc.ShowDialog();
        }
    }
}
