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
    public partial class frmQLKT : Form
    {
        public frmQLKT()
        {
            InitializeComponent();
        }

        public void TT_Combobox()
        {
            DataTable dt = new DataTable();
            dt = KTDAO.TTPhong();
            cbphong.DataSource = dt;
            cbphong.ValueMember = "MaPhong";
            cbphong.DisplayMember = "TenPhong";
        }

        public void TT_KT()
        {
            DataTable dt = new DataTable();
            dt = KTDAO.TTKT();
            int sodong = dt.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaKT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenKT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["CMND"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["DiaChi"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaPhong"].ToString());
            }
        }

        private void frmQLKT_Load(object sender, EventArgs e)
        {
            TT_KT();
            TT_Combobox();
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            txtmakt.Text = lvds.SelectedItems[0].SubItems[0].Text;
            txttenkt.Text= lvds.SelectedItems[0].SubItems[1].Text;
            txtcmnd.Text= lvds.SelectedItems[0].SubItems[2].Text;
            txtsdt.Text= lvds.SelectedItems[0].SubItems[3].Text;
            txtdiachi.Text= lvds.SelectedItems[0].SubItems[4].Text;
            DataTable dt = new DataTable();
            dt = KTDAO.TPhongtheoMaPhong(lvds.SelectedItems[0].SubItems[5].Text);
            cbphong.Text= dt.Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = KTDAO.MaKT_Max();
            string makt = dt.Rows[0][0].ToString();
            txtmakt.Text = (int.Parse(makt.Substring(makt.Length - 3, 3)) + 1).ToString("KT000");
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmakt.Text = "";
            txttenkt.Text = "";
            txtcmnd.Text = "";
            txtsdt.Text = "";
            txtdiachi.Text = "";
            txtsearch.Text = "";
            cbphong.Text = "";
            lvds.Items.Clear();
            TT_KT();
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            KTDTO kt = new KTDTO();
            kt.Makt = txtmakt.Text;
            kt.Tenkt = txttenkt.Text;
            kt.Cmnd = txtcmnd.Text;
            kt.Sdt = txtsdt.Text;
            kt.Diachi = txtdiachi.Text;
            kt.Maphong = cbphong.SelectedValue.ToString();
            KTBUS.GhiKT(kt);
            lvds.Items.Clear();
            TT_KT();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            KTDTO kt = new KTDTO();
            kt.Makt = txtmakt.Text;
            KTBUS.XoaKT(kt);
            lvds.Items.Clear();
            TT_KT();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            KTDTO kt = new KTDTO();
            kt.Makt = txtmakt.Text;
            kt.Tenkt = txttenkt.Text;
            kt.Cmnd = txtcmnd.Text;
            kt.Sdt = txtsdt.Text;
            kt.Diachi = txtdiachi.Text;
            kt.Maphong = cbphong.SelectedValue.ToString();
            KTBUS.CapNhatKT(kt);
            lvds.Items.Clear();
            TT_KT();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            KTDTO kt = new KTDTO();
            DataTable dt = new DataTable();
            kt.Makt = txtsearch.Text;
            lvds.Items.Clear();
            dt = KTDAO.TimKT(kt);
            int sodong = dt.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaKT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenKT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["CMND"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["DiaChi"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaPhong"].ToString());
            }
        }
    }
}
