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
    public partial class frmMenu : Form
    {
        private Form activeForm;
        private bool isthoat = true;
        private string tenTK;
        private string matkhau;
        private string Quyen;

        public frmMenu()
        {
            InitializeComponent();
        }
        public frmMenu(string tenTk,string matkhau,string Quyen)
        {
            InitializeComponent();
            this.tenTK = tenTk;
            this.matkhau = matkhau;
            this.Quyen = Quyen;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (Quyen == "User")
            {
                btnQLTK.Visible = false;
            }
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isthoat)
                Application.Exit();
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnview.Controls.Add(childForm);
            this.pnview.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLTK());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLKT());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLKV());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLTTThuePhong());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLPC());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLPT());
        }
    }
}
