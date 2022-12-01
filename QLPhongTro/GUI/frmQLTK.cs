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
    public partial class frmQLTK : Form
    {
        public frmQLTK()
        {
            InitializeComponent();
        }

        public void TT_TK()
        {
            DataTable dt = new DataTable();
            dt = TKDAO.TTTK();
            int sodong = dt.Rows.Count;
            for(int i = 0; i < sodong; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaTK"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenTK"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MatKhau"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["Quyen"].ToString());
            }
        }

        private void frmQLTK_Load(object sender, EventArgs e)
        {
            TT_TK();
            cbquyen.Items.Add("Admin");
            cbquyen.Items.Add("User");
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            txtmatk.Text = lvds.SelectedItems[0].SubItems[0].Text;
            txttentk.Text= lvds.SelectedItems[0].SubItems[1].Text;
            txtmatkhau.Text= lvds.SelectedItems[0].SubItems[2].Text;
            cbquyen.Text= lvds.SelectedItems[0].SubItems[3].Text;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = TKDAO.MaTK_Max();
            string matk = dt.Rows[0][0].ToString();
            txtmatk.Text = (int.Parse(matk.Substring(matk.Length - 3, 3)) + 1).ToString("TK000");
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmatk.Text = "";
            txtmatkhau.Text = "";
            txttentk.Text = "";
            cbquyen.Text = "";
            txtsearch.Text = "";
            lvds.Items.Clear();
            TT_TK();
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            TKDTO tk = new TKDTO();
            tk.Matk = txtmatk.Text;
            tk.Tentk = txttentk.Text;
            tk.Matkhau = txtmatkhau.Text;
            tk.Quyen = cbquyen.SelectedItem.ToString();
            TKBUS.GhiTK(tk);
            lvds.Items.Clear();
            TT_TK();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            TKDTO tk = new TKDTO();
            tk.Matk = txtmatk.Text;
            TKBUS.XoaTK(tk);
            lvds.Items.Clear();
            TT_TK();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            TKDTO tk = new TKDTO();
            tk.Matk = txtmatk.Text;
            tk.Tentk = txttentk.Text;
            tk.Matkhau = txtmatkhau.Text;
            tk.Quyen = cbquyen.SelectedItem.ToString();
            TKBUS.CapnhatTK(tk);
            lvds.Items.Clear();
            TT_TK();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            TKDTO tk = new TKDTO();
            DataTable dt = new DataTable();
            tk.Tentk = txtsearch.Text;
            lvds.Items.Clear();
            dt = TKDAO.TimTK(tk);
            int sodong = dt.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaTK"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenTK"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MatKhau"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["Quyen"].ToString());
            }
        }
    }
}
