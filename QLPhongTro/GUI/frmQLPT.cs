using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongTro.DTO;
using QLPhongTro.DAO;
using QLPhongTro.BUS;

namespace QLPhongTro.GUI
{
    public partial class frmQLPT : Form
    {
        public frmQLPT()
        {
            InitializeComponent();
        }
        public void TTLST()
        {
            DataTable dt = new DataTable();
            dt = PTDAO.TTPT();
            lstds.DataSource = dt;
            lstds.ValueMember = "MaPhong";
            lstds.DisplayMember = "TenPhong";
        }
        public void TTKV()
        {
            DataTable dt = new DataTable();
            dt = PTDAO.TTKV();
            cbkv.DataSource = dt;
            cbkv.ValueMember = "MaKV";
            cbkv.DisplayMember = "TenKV";
        }
        public void TTNTB()
        {
            DataTable dt = new DataTable();
            dt = PTDAO.TTNTB();
            cbnhomtb.DataSource = dt;
            cbnhomtb.ValueMember = "MaNhomTB";
            cbnhomtb.DisplayMember = "TenNhom";
        }

        private void frmQLPT_Load(object sender, EventArgs e)
        {
            TTLST();
            TTKV();
            TTNTB();
            cbtrangthai.Items.Add("Trống");
            cbtrangthai.Items.Add("Trống 1 người");
            cbtrangthai.Items.Add("Trống 2 người");
            cbtrangthai.Items.Add("Đầy");
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txtmaphong.Text = lvlist.SelectedItems[0].SubItems[0].Text;
            txttenphong.Text= lvlist.SelectedItems[0].SubItems[1].Text;
            txtgia.Text= lvlist.SelectedItems[0].SubItems[2].Text;
            DataTable dt = new DataTable();
            dt = PTDAO.Tenkvtheomakv(lvlist.SelectedItems[0].SubItems[3].Text);
            cbkv.Text = dt.Rows[0][0].ToString();
            numsl.Value = int.Parse(lvlist.SelectedItems[0].SubItems[4].Text);
            cbtrangthai.Text= lvlist.SelectedItems[0].SubItems[5].Text;
            dt = PTDAO.Tenntbtheomantb(lvlist.SelectedItems[0].SubItems[6].Text);
            cbnhomtb.Text = dt.Rows[0][0].ToString();
        }

        private void lstds_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PTDAO.TTCTPT(lstds.SelectedValue.ToString());
            lvlist.Items.Clear();
            int sodong = dt.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                lvlist.Items.Add(dt.Rows[i]["MaPhong"].ToString());
                lvlist.Items[i].SubItems.Add(dt.Rows[i]["TenPhong"].ToString());
                lvlist.Items[i].SubItems.Add(dt.Rows[i]["Gia"].ToString());
                lvlist.Items[i].SubItems.Add(dt.Rows[i]["MaKV"].ToString());
                lvlist.Items[i].SubItems.Add(dt.Rows[i]["SLKT"].ToString());
                lvlist.Items[i].SubItems.Add(dt.Rows[i]["TrangThai"].ToString());
                lvlist.Items[i].SubItems.Add(dt.Rows[i]["MaNhomTB"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PTDAO.maphong_max();
            string maphong = dt.Rows[0][0].ToString();
            txtmaphong.Text = (int.Parse(maphong)+1).ToString();
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            PTDTO pt = new PTDTO();
            pt.Maphong = txtmaphong.Text;
            pt.Tenphong = txttenphong.Text;
            pt.Gia = int.Parse(txtgia.Text);
            pt.Slkt = int.Parse(numsl.Value.ToString());
            pt.Makv = cbkv.SelectedValue.ToString();
            pt.Manhomtb = cbnhomtb.SelectedValue.ToString();
            pt.Trangthai = cbtrangthai.SelectedItem.ToString();
            PTBUS.GhiPt(pt);
            TTLST();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            PTDTO pt = new PTDTO();
            pt.Maphong = txtmaphong.Text;
            PTBUS.XoaPT(pt);
            TTLST();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            PTDTO pt = new PTDTO();
            pt.Maphong = txtmaphong.Text;
            pt.Tenphong = txttenphong.Text;
            pt.Gia = int.Parse(txtgia.Text);
            pt.Slkt = int.Parse(numsl.Value.ToString());
            pt.Makv = cbkv.SelectedValue.ToString();
            pt.Manhomtb = cbnhomtb.SelectedValue.ToString();
            pt.Trangthai = cbtrangthai.SelectedItem.ToString();
            PTBUS.CapNhatPT(pt);
            TTLST();
        }
    }
}
