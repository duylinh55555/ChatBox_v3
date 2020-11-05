namespace ChatBox_v3
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bkiemtra = new System.Windows.Forms.Button();
            this.bdangky = new System.Windows.Forms.Button();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.admitmk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(24, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // bkiemtra
            // 
            this.bkiemtra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bkiemtra.BackgroundImage")));
            this.bkiemtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bkiemtra.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bkiemtra.Location = new System.Drawing.Point(47, 210);
            this.bkiemtra.Name = "bkiemtra";
            this.bkiemtra.Size = new System.Drawing.Size(67, 50);
            this.bkiemtra.TabIndex = 3;
            this.bkiemtra.UseVisualStyleBackColor = true;
            this.bkiemtra.Click += new System.EventHandler(this.bkiemtra_Click);
            // 
            // bdangky
            // 
            this.bdangky.Image = ((System.Drawing.Image)(resources.GetObject("bdangky.Image")));
            this.bdangky.Location = new System.Drawing.Point(177, 210);
            this.bdangky.Name = "bdangky";
            this.bdangky.Size = new System.Drawing.Size(167, 50);
            this.bdangky.TabIndex = 4;
            this.bdangky.UseVisualStyleBackColor = true;
            this.bdangky.Click += new System.EventHandler(this.bdangky_Click);
            this.bdangky.Enter += new System.EventHandler(this.bdangky_Click);
            // 
            // taikhoan
            // 
            this.taikhoan.Location = new System.Drawing.Point(133, 85);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(211, 20);
            this.taikhoan.TabIndex = 5;
            // 
            // matkhau
            // 
            this.matkhau.Location = new System.Drawing.Point(133, 128);
            this.matkhau.Name = "matkhau";
            this.matkhau.PasswordChar = '*';
            this.matkhau.Size = new System.Drawing.Size(211, 20);
            this.matkhau.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(24, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Admit Pass";
            // 
            // admitmk
            // 
            this.admitmk.Location = new System.Drawing.Point(132, 173);
            this.admitmk.Name = "admitmk";
            this.admitmk.PasswordChar = '*';
            this.admitmk.Size = new System.Drawing.Size(212, 20);
            this.admitmk.TabIndex = 8;
            // 
            // DangKy
            // 
            this.AcceptButton = this.bdangky;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 287);
            this.Controls.Add(this.admitmk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.bdangky);
            this.Controls.Add(this.bkiemtra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangKy";
            this.Text = "Đăng Ký";
            this.Enter += new System.EventHandler(this.bdangky_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bkiemtra;
        private System.Windows.Forms.Button bdangky;
        private System.Windows.Forms.TextBox taikhoan;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox admitmk;
    }
}