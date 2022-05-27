
namespace Exercise_PABD
{
    partial class DataGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGrid));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodiTIDataSet = new Exercise_PABD.ProdiTIDataSet();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new Exercise_PABD.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            this.nIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatMhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneMhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pboxback = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxback)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(832, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 252);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Clarendon BT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teknologi Informasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Clarendon BT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Mahasiswa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIMDataGridViewTextBoxColumn,
            this.namaMhsDataGridViewTextBoxColumn,
            this.alamatMhsDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.phoneMhsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mahasiswaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(104, 236);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1237, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 127);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSet;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // nIMDataGridViewTextBoxColumn
            // 
            this.nIMDataGridViewTextBoxColumn.DataPropertyName = "NIM";
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Clarendon BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.Crimson;
            this.nIMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle51;
            this.nIMDataGridViewTextBoxColumn.HeaderText = "No. Mahasiswa";
            this.nIMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nIMDataGridViewTextBoxColumn.Name = "nIMDataGridViewTextBoxColumn";
            // 
            // namaMhsDataGridViewTextBoxColumn
            // 
            this.namaMhsDataGridViewTextBoxColumn.DataPropertyName = "NamaMhs";
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Clarendon BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.Firebrick;
            this.namaMhsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle52;
            this.namaMhsDataGridViewTextBoxColumn.HeaderText = "Nama Mahasiswa";
            this.namaMhsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaMhsDataGridViewTextBoxColumn.Name = "namaMhsDataGridViewTextBoxColumn";
            // 
            // alamatMhsDataGridViewTextBoxColumn
            // 
            this.alamatMhsDataGridViewTextBoxColumn.DataPropertyName = "AlamatMhs";
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Clarendon BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.Color.Fuchsia;
            this.alamatMhsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle53;
            this.alamatMhsDataGridViewTextBoxColumn.HeaderText = "Alamat Mahasiswa";
            this.alamatMhsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatMhsDataGridViewTextBoxColumn.Name = "alamatMhsDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Clarendon BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.Indigo;
            this.sexDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle54;
            this.sexDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // phoneMhsDataGridViewTextBoxColumn
            // 
            this.phoneMhsDataGridViewTextBoxColumn.DataPropertyName = "PhoneMhs";
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Clarendon BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            this.phoneMhsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle55;
            this.phoneMhsDataGridViewTextBoxColumn.HeaderText = "No.Telepon";
            this.phoneMhsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneMhsDataGridViewTextBoxColumn.Name = "phoneMhsDataGridViewTextBoxColumn";
            // 
            // pboxback
            // 
            this.pboxback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxback.Image = ((System.Drawing.Image)(resources.GetObject("pboxback.Image")));
            this.pboxback.Location = new System.Drawing.Point(60, 462);
            this.pboxback.Name = "pboxback";
            this.pboxback.Size = new System.Drawing.Size(106, 54);
            this.pboxback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxback.TabIndex = 6;
            this.pboxback.TabStop = false;
            this.pboxback.Click += new System.EventHandler(this.pboxback_Click);
            // 
            // DataGrid
            // 
            this.ClientSize = new System.Drawing.Size(1431, 564);
            this.Controls.Add(this.pboxback);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(1449, 804);
            this.Name = "DataGrid";
            this.Load += new System.EventHandler(this.FormDataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatMhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneMhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pboxback;
    }
}