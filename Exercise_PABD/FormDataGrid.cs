﻿using System;
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
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void FormDataGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new MenuUtama().Show();
            this.Hide();
        }
    }
}
