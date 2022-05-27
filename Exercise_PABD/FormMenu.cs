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
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void pboxkeluar_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new DataGrid().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new BindingNv().Show();
            this.Hide();
        }
    }
}
