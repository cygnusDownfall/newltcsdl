using System;
using QLPhongTro.DAO;
using QLPhongTro.BUS;
using System.Windows.Forms;
using System.Data;

namespace QLPhongTro.GUI
{
    public partial class frmQLKV : Form
    {
        public frmQLKV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grthem.Visible= true;
            grthem.Text = "Thêm khu vực:";
            string old = KVBUS.kv_max();
            mkv.Text = "KV" +( Convert.ToInt32(old.Substring(2))+1);
        }
        string createMaKVMoi()
        {
            
            return "";
        }

        private void addsubmit_Click(object sender, EventArgs e)
        {
            if (grthem.Text == "Thêm khu vực:")
                them(mkv.Text, tkv.Text);
            else KVBUS.sua(mkv.Text, tkv.Text);

            loadkhuvuc();
            loadphongthuockv(listBox1.SelectedValue.ToString());

        }
        void them(string makv,string tenkv)
        {
           KVBUS.them(makv,tenkv);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mkv.Text = "";
            tkv.Text = "";
            grthem.Visible = false;
        }

        private void frmQLKV_Load(object sender, EventArgs e)
        {
            loadkhuvuc();
        }
        void loadkhuvuc()
        {
            DataTable tb=KVBUS.TTkhuvuc(); 
            listBox1.DataSource= tb;
            listBox1.ValueMember = "MaKV";
            listBox1.DisplayMember= "TenKV";
        }
        void loadphongthuockv(string makv)
        {
            DataTable tb =KVBUS.TTPTthuocKV(makv);
            listView1.Items.Clear();
            for(int i=0,n=tb.Rows.Count;i<n;i++)
            {
                listView1.Items.Add(tb.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(tb.Rows[i][1].ToString());
                listView1.Items[i].SubItems.Add(tb.Rows[i][2].ToString());
                listView1.Items[i].SubItems.Add(tb.Rows[i][5].ToString());
                listView1.Items[i].SubItems.Add(tb.Rows[i][4].ToString());
            }
                

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s=listBox1.SelectedValue.ToString();
            loadphongthuockv(s);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            grthem.Visible = true;
            grthem.Text = "Sửa thông tin khu vực:";
            mkv.Text = listBox1.SelectedValue.ToString();
            tkv.Text= listBox1.Text;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KVBUS.xoa(listBox1.SelectedValue.ToString());
            loadkhuvuc();
        }
    }
}
