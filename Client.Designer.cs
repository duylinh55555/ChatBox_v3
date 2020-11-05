namespace ChatBox_v3
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.khungHienThi = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.khungUserName = new System.Windows.Forms.RichTextBox();
            this.khungNoiDung = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.insertButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bDelChat = new System.Windows.Forms.ToolStripButton();
            this.loadingBar = new System.Windows.Forms.ToolStripProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timerPro = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pSymbol = new System.Windows.Forms.Panel();
            this.bWow = new System.Windows.Forms.Button();
            this.bSmile_2 = new System.Windows.Forms.Button();
            this.bHuh = new System.Windows.Forms.Button();
            this.bCry = new System.Windows.Forms.Button();
            this.bSad = new System.Windows.Forms.Button();
            this.bHaha_2 = new System.Windows.Forms.Button();
            this.bDead = new System.Windows.Forms.Button();
            this.bHah_3 = new System.Windows.Forms.Button();
            this.bLove = new System.Windows.Forms.Button();
            this.bBlink = new System.Windows.Forms.Button();
            this.bBlaBla = new System.Windows.Forms.Button();
            this.bConfuse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numConnect = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.pSymbol.SuspendLayout();
            this.SuspendLayout();
            // 
            // khungHienThi
            // 
            this.khungHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khungHienThi.Location = new System.Drawing.Point(219, 95);
            this.khungHienThi.Name = "khungHienThi";
            this.khungHienThi.Size = new System.Drawing.Size(652, 527);
            this.khungHienThi.TabIndex = 2;
            this.khungHienThi.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // khungUserName
            // 
            this.khungUserName.Location = new System.Drawing.Point(219, 28);
            this.khungUserName.Name = "khungUserName";
            this.khungUserName.Size = new System.Drawing.Size(553, 45);
            this.khungUserName.TabIndex = 1;
            this.khungUserName.Text = "";
            // 
            // khungNoiDung
            // 
            this.khungNoiDung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khungNoiDung.Location = new System.Drawing.Point(219, 671);
            this.khungNoiDung.Name = "khungNoiDung";
            this.khungNoiDung.Size = new System.Drawing.Size(565, 110);
            this.khungNoiDung.TabIndex = 2;
            this.khungNoiDung.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Transparent;
            this.sendButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendButton.BackgroundImage")));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendButton.Location = new System.Drawing.Point(790, 691);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(73, 74);
            this.sendButton.TabIndex = 3;
            this.sendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.connectButton.Location = new System.Drawing.Point(778, 28);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(93, 45);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Đổi tên";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertButton,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.bDelChat,
            this.loadingBar});
            this.toolStrip1.Location = new System.Drawing.Point(219, 625);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(644, 43);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // insertButton
            // 
            this.insertButton.AutoSize = false;
            this.insertButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insertButton.BackgroundImage")));
            this.insertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insertButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(40, 40);
            this.insertButton.Text = "toolStripButton1";
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(117, 40);
            this.toolStripButton1.Text = "Xóa lịch sử chat";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // bDelChat
            // 
            this.bDelChat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bDelChat.Image = ((System.Drawing.Image)(resources.GetObject("bDelChat.Image")));
            this.bDelChat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bDelChat.Name = "bDelChat";
            this.bDelChat.Size = new System.Drawing.Size(29, 40);
            this.bDelChat.Text = "toolStripButton1";
            this.bDelChat.Click += new System.EventHandler(this.bDelChat_Click);
            // 
            // loadingBar
            // 
            this.loadingBar.AutoSize = false;
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(150, 25);
            this.loadingBar.Step = 5;
            this.loadingBar.ToolTipText = "ỷgt";
            this.loadingBar.Visible = false;
            // 
            // timerPro
            // 
            this.timerPro.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.timerPro.AnimationSpeed = 500;
            this.timerPro.BackColor = System.Drawing.Color.Transparent;
            this.timerPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timerPro.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timerPro.InnerMargin = 2;
            this.timerPro.InnerWidth = -1;
            this.timerPro.Location = new System.Drawing.Point(-2, 23);
            this.timerPro.MarqueeAnimationSpeed = 2000;
            this.timerPro.Name = "timerPro";
            this.timerPro.OuterColor = System.Drawing.Color.Gray;
            this.timerPro.OuterMargin = -25;
            this.timerPro.OuterWidth = 26;
            this.timerPro.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.timerPro.ProgressWidth = 25;
            this.timerPro.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerPro.Size = new System.Drawing.Size(215, 212);
            this.timerPro.StartAngle = 270;
            this.timerPro.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.timerPro.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.timerPro.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.timerPro.SubscriptText = "";
            this.timerPro.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.timerPro.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.timerPro.SuperscriptText = "";
            this.timerPro.TabIndex = 6;
            this.timerPro.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.timerPro.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pSymbol
            // 
            this.pSymbol.Controls.Add(this.bWow);
            this.pSymbol.Controls.Add(this.bSmile_2);
            this.pSymbol.Controls.Add(this.bHuh);
            this.pSymbol.Controls.Add(this.bCry);
            this.pSymbol.Controls.Add(this.bSad);
            this.pSymbol.Controls.Add(this.bHaha_2);
            this.pSymbol.Controls.Add(this.bDead);
            this.pSymbol.Controls.Add(this.bHah_3);
            this.pSymbol.Controls.Add(this.bLove);
            this.pSymbol.Controls.Add(this.bBlink);
            this.pSymbol.Controls.Add(this.bBlaBla);
            this.pSymbol.Controls.Add(this.bConfuse);
            this.pSymbol.Location = new System.Drawing.Point(272, 454);
            this.pSymbol.Name = "pSymbol";
            this.pSymbol.Size = new System.Drawing.Size(210, 168);
            this.pSymbol.TabIndex = 7;
            this.pSymbol.Visible = false;
            this.pSymbol.MouseLeave += new System.EventHandler(this.pSymbol_MouseLeave);
            // 
            // bWow
            // 
            this.bWow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bWow.BackgroundImage")));
            this.bWow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bWow.Location = new System.Drawing.Point(156, 0);
            this.bWow.Name = "bWow";
            this.bWow.Size = new System.Drawing.Size(55, 59);
            this.bWow.TabIndex = 15;
            this.bWow.UseVisualStyleBackColor = true;
            this.bWow.Click += new System.EventHandler(this.bWow_Click);
            // 
            // bSmile_2
            // 
            this.bSmile_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSmile_2.BackgroundImage")));
            this.bSmile_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSmile_2.Location = new System.Drawing.Point(156, 57);
            this.bSmile_2.Name = "bSmile_2";
            this.bSmile_2.Size = new System.Drawing.Size(55, 59);
            this.bSmile_2.TabIndex = 14;
            this.bSmile_2.UseVisualStyleBackColor = true;
            this.bSmile_2.Click += new System.EventHandler(this.bSmile_2_Click);
            // 
            // bHuh
            // 
            this.bHuh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bHuh.BackgroundImage")));
            this.bHuh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bHuh.Location = new System.Drawing.Point(156, 113);
            this.bHuh.Name = "bHuh";
            this.bHuh.Size = new System.Drawing.Size(55, 59);
            this.bHuh.TabIndex = 13;
            this.bHuh.UseVisualStyleBackColor = true;
            this.bHuh.Click += new System.EventHandler(this.bHuh_Click);
            // 
            // bCry
            // 
            this.bCry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCry.BackgroundImage")));
            this.bCry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCry.Location = new System.Drawing.Point(52, 0);
            this.bCry.Name = "bCry";
            this.bCry.Size = new System.Drawing.Size(55, 59);
            this.bCry.TabIndex = 12;
            this.bCry.UseVisualStyleBackColor = true;
            this.bCry.Click += new System.EventHandler(this.bCry_Click);
            // 
            // bSad
            // 
            this.bSad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSad.BackgroundImage")));
            this.bSad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSad.Location = new System.Drawing.Point(104, 0);
            this.bSad.Name = "bSad";
            this.bSad.Size = new System.Drawing.Size(55, 59);
            this.bSad.TabIndex = 11;
            this.bSad.UseVisualStyleBackColor = true;
            this.bSad.Click += new System.EventHandler(this.bSad_Click);
            // 
            // bHaha_2
            // 
            this.bHaha_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bHaha_2.BackgroundImage")));
            this.bHaha_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bHaha_2.Location = new System.Drawing.Point(104, 57);
            this.bHaha_2.Name = "bHaha_2";
            this.bHaha_2.Size = new System.Drawing.Size(55, 59);
            this.bHaha_2.TabIndex = 10;
            this.bHaha_2.UseVisualStyleBackColor = true;
            this.bHaha_2.Click += new System.EventHandler(this.bHaha_2_Click);
            // 
            // bDead
            // 
            this.bDead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDead.BackgroundImage")));
            this.bDead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDead.Location = new System.Drawing.Point(52, 57);
            this.bDead.Name = "bDead";
            this.bDead.Size = new System.Drawing.Size(55, 59);
            this.bDead.TabIndex = 9;
            this.bDead.UseVisualStyleBackColor = true;
            this.bDead.Click += new System.EventHandler(this.bDead_Click);
            // 
            // bHah_3
            // 
            this.bHah_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bHah_3.BackgroundImage")));
            this.bHah_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bHah_3.Location = new System.Drawing.Point(52, 113);
            this.bHah_3.Name = "bHah_3";
            this.bHah_3.Size = new System.Drawing.Size(55, 59);
            this.bHah_3.TabIndex = 8;
            this.bHah_3.UseVisualStyleBackColor = true;
            this.bHah_3.Click += new System.EventHandler(this.bHah_3_Click);
            // 
            // bLove
            // 
            this.bLove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bLove.BackgroundImage")));
            this.bLove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLove.Location = new System.Drawing.Point(104, 113);
            this.bLove.Name = "bLove";
            this.bLove.Size = new System.Drawing.Size(55, 59);
            this.bLove.TabIndex = 7;
            this.bLove.UseVisualStyleBackColor = true;
            this.bLove.Click += new System.EventHandler(this.bLove_Click);
            // 
            // bBlink
            // 
            this.bBlink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBlink.BackgroundImage")));
            this.bBlink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBlink.Location = new System.Drawing.Point(0, 113);
            this.bBlink.Name = "bBlink";
            this.bBlink.Size = new System.Drawing.Size(55, 59);
            this.bBlink.TabIndex = 6;
            this.bBlink.UseVisualStyleBackColor = true;
            this.bBlink.Click += new System.EventHandler(this.bBlink_Click);
            // 
            // bBlaBla
            // 
            this.bBlaBla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBlaBla.BackgroundImage")));
            this.bBlaBla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBlaBla.Location = new System.Drawing.Point(0, 57);
            this.bBlaBla.Name = "bBlaBla";
            this.bBlaBla.Size = new System.Drawing.Size(55, 59);
            this.bBlaBla.TabIndex = 5;
            this.bBlaBla.UseVisualStyleBackColor = true;
            this.bBlaBla.Click += new System.EventHandler(this.bBlaBla_Click);
            // 
            // bConfuse
            // 
            this.bConfuse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bConfuse.BackgroundImage")));
            this.bConfuse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bConfuse.Location = new System.Drawing.Point(0, 0);
            this.bConfuse.Name = "bConfuse";
            this.bConfuse.Size = new System.Drawing.Size(55, 59);
            this.bConfuse.TabIndex = 0;
            this.bConfuse.UseVisualStyleBackColor = true;
            this.bConfuse.Click += new System.EventHandler(this.bConfuse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numConnect
            // 
            this.numConnect.BackColor = System.Drawing.Color.Transparent;
            this.numConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numConnect.Location = new System.Drawing.Point(13, 256);
            this.numConnect.Name = "numConnect";
            this.numConnect.Size = new System.Drawing.Size(190, 18);
            this.numConnect.TabIndex = 10;
            this.numConnect.Text = "Người online";
            // 
            // Client
            // 
            this.AcceptButton = this.sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 793);
            this.Controls.Add(this.numConnect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pSymbol);
            this.Controls.Add(this.timerPro);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.khungNoiDung);
            this.Controls.Add(this.khungUserName);
            this.Controls.Add(this.khungHienThi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pSymbol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox khungHienThi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox khungUserName;
        private System.Windows.Forms.RichTextBox khungNoiDung;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton insertButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripProgressBar loadingBar;
        private CircularProgressBar.CircularProgressBar timerPro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton bDelChat;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel pSymbol;
        private System.Windows.Forms.Button bConfuse;
        private System.Windows.Forms.Button bBlink;
        private System.Windows.Forms.Button bBlaBla;
        private System.Windows.Forms.Button bWow;
        private System.Windows.Forms.Button bSmile_2;
        private System.Windows.Forms.Button bHuh;
        private System.Windows.Forms.Button bCry;
        private System.Windows.Forms.Button bSad;
        private System.Windows.Forms.Button bHaha_2;
        private System.Windows.Forms.Button bDead;
        private System.Windows.Forms.Button bHah_3;
        private System.Windows.Forms.Button bLove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label numConnect;
    }
}

