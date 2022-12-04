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
            for (int i = 0; i < sodong; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaPC"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["SoTien"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayChi"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["Lydo"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaPhong"].ToString());
            }
        }

        private void frmQLPC_Load(object sender, EventArgs e)
        {
            TT_Combobox();
            TT_PC();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            PCDTO pc = new PCDTO();
            pc.Mapc = txtmapchi.Text;
            PCBUS.XoaPC(pc);
            lvds.Items.Clear();
            TT_PC();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            PCDTO pc = new PCDTO();
            pc.Mapc = txtmapchi.Text;
            pc.Sotien = int.Parse(txttien.Text);
            pc.Ngaychi = dtpngaychi.Value.ToString("MM/dd/yyyy");
            pc.Lydo = txtlydo.Text;
            pc.Maphong = cbphong.SelectedValue.ToString();
            PCBUS.CapNhatPC(pc);
            lvds.Items.Clear();
            TT_PC();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PCDAO.PC_Max();
            string mapc = dt.Rows[0][0].ToString();
            txtmapchi.Text = (int.Parse(mapc.Substring(mapc.Length - 1, 1)) + 1).ToString("PC00");
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmapchi.Text = "";
            txttien.Text = "";
            txtlydo.Text = "";
            dtpngaychi.Text = "";
            cbphong.Text = "";
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            PCDTO pc = new PCDTO();
            pc.Mapc = txtmapchi.Text;
            pc.Sotien = int.Parse(txttien.Text);
            pc.Ngaychi = dtpngaychi.Value.ToString("MM/dd/yyyy");
            pc.Lydo = txtlydo.Text;
            pc.Maphong = cbphong.SelectedValue.ToString();
            PCBUS.ThemPC(pc);
            lvds.Items.Clear();
            TT_PC();
        }

        private void lvds_Click_1(object sender, EventArgs e)
        {
            txtmapchi.Text = lvds.SelectedItems[0].SubItems[0].Text;
            txttien.Text = lvds.SelectedItems[0].SubItems[1].Text;
            dtpngaychi.Text = lvds.SelectedItems[0].SubItems[2].Text;
            txtlydo.Text = lvds.SelectedItems[0].SubItems[3].Text;
            DataTable dt = new DataTable();
            dt = PCDAO.Tenphong_maphong(lvds.SelectedItems[0].SubItems[4].Text);
            cbphong.Text = dt.Rows[0][0].ToString();
        }
    }
}
