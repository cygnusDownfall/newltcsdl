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
using QLPhongTro.GUI;

namespace QLPhongTro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            TKDTO tk = new TKDTO();
            tk.Matk = txtusername.Text.ToUpper();
            tk.Matkhau = txtpassword.Text.ToUpper();
            DataTable dt = new DataTable();
            dt = TKDAO.TK_MK(tk);
            int sodong = dt.Rows.Count;
            if (sodong == 1)
            {
                frmMenu menu = new frmMenu(dt.Rows[0][0].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác! \nVui lòng nhập lại!!!", "Thông báo");
                txtusername.Focus();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }
    }
}
