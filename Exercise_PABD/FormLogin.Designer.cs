
namespace Exercise_PABD
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxUname = new System.Windows.Forms.TextBox();
            this.tboxPwd = new System.Windows.Forms.TextBox();
            this.cbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Clarendon BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Mahasiswa TI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Clarendon BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(244, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Clarendon BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Clarendon BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(158, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // tboxUname
            // 
            this.tboxUname.Location = new System.Drawing.Point(162, 182);
            this.tboxUname.Name = "tboxUname";
            this.tboxUname.Size = new System.Drawing.Size(290, 22);
            this.tboxUname.TabIndex = 4;
            // 
            // tboxPwd
            // 
            this.tboxPwd.Location = new System.Drawing.Point(162, 255);
            this.tboxPwd.Name = "tboxPwd";
            this.tboxPwd.PasswordChar = '*';
            this.tboxPwd.Size = new System.Drawing.Size(290, 22);
            this.tboxPwd.TabIndex = 5;
            // 
            // cbox
            // 
            this.cbox.AutoSize = true;
            this.cbox.BackColor = System.Drawing.Color.Transparent;
            this.cbox.Font = new System.Drawing.Font("Clarendon BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox.ForeColor = System.Drawing.Color.White;
            this.cbox.Location = new System.Drawing.Point(162, 299);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(150, 22);
            this.cbox.TabIndex = 6;
            this.cbox.Text = "Term Condition";
            this.cbox.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Clarendon BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(162, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Clarendon BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(349, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.tboxPwd);
            this.Controls.Add(this.tboxUname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Login";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxUname;
        private System.Windows.Forms.TextBox tboxPwd;
        private System.Windows.Forms.CheckBox cbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

