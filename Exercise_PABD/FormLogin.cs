using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_PABD
{
    public partial class Login : Form
    {
        readonly string Uname = "Moccachino";
        readonly string pwd = "181920";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tboxUname.Text == Uname && tboxPwd.Text == pwd)
            {
                new MenuUtama().Show();
                this.Hide();
            }
            else if(cbox.Checked)
            {
                new MenuUtama().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pastikan Username dan Password Anda Sudah Benar!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
