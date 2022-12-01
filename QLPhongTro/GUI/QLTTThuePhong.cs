using QLPhongTro.BUS;
using QLPhongTro.DAO;
using QLPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.GUI
{
    public partial class QLTTThuePhong : Form
    {
        public QLTTThuePhong()
        {
            InitializeComponent();
        }

        private void QLTTThuePhong_Load(object sender, EventArgs e)
        {
            DataTable tb = PTDAO.TTPT();
            listBox1.DataSource= tb;
            listBox1.DisplayMember= "TenPhong";
            listBox1.ValueMember = "MaPhong";
            DataTable kt=KTDAO.TTKT();
            dataGridView1.DataSource= kt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txttenkt.Text = "";
            txtcmnd.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";

        }

        string createnewMaKT()
        {
            string s;
            try
            {
                 s= KTDAO.MaKT_Max().Rows[0][0].ToString();
            }
            catch
            {
                s ="KT001";
            }
           
            return "KT" + (Convert.ToInt32(s.Substring(2)) + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KTDTO kt = new KTDTO(createnewMaKT(),txttenkt.Text,txtdiachi.Text,listBox1.SelectedValue.ToString(),txtcmnd.Text,txtsdt.Text);
            KTBUS.GhiKT(kt);
            dataGridView1.DataSource = KTDAO.TTKT();
        }
    }
}
