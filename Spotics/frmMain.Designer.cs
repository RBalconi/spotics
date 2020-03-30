namespace Spotics
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.labelTocando = new System.Windows.Forms.Label();
            this.textBoxLetra = new System.Windows.Forms.TextBox();
            this.imgConfg = new System.Windows.Forms.PictureBox();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.imgMinimized = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.switchSongOff = new XanderUI.XUISwitch();
            this.switchSongOn = new XanderUI.XUISwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgCloseConfg = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbSizeFont = new Spotics.CustomComboBox();
            this.dragControl1 = new Spotics.DragControl();
            this.dragControl2 = new Spotics.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimized)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseConfg)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTocando
            // 
            this.labelTocando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTocando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.labelTocando.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTocando.ForeColor = System.Drawing.Color.White;
            this.labelTocando.Location = new System.Drawing.Point(12, 8);
            this.labelTocando.Name = "labelTocando";
            this.labelTocando.Size = new System.Drawing.Size(477, 22);
            this.labelTocando.TabIndex = 1;
            // 
            // textBoxLetra
            // 
            this.textBoxLetra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLetra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxLetra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxLetra.ForeColor = System.Drawing.Color.White;
            this.textBoxLetra.Location = new System.Drawing.Point(21, 48);
            this.textBoxLetra.Multiline = true;
            this.textBoxLetra.Name = "textBoxLetra";
            this.textBoxLetra.ReadOnly = true;
            this.textBoxLetra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLetra.Size = new System.Drawing.Size(567, 635);
            this.textBoxLetra.TabIndex = 3;
            // 
            // imgConfg
            // 
            this.imgConfg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgConfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.imgConfg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgConfg.BackgroundImage")));
            this.imgConfg.Location = new System.Drawing.Point(530, 8);
            this.imgConfg.Name = "imgConfg";
            this.imgConfg.Size = new System.Drawing.Size(16, 16);
            this.imgConfg.TabIndex = 10;
            this.imgConfg.TabStop = false;
            this.imgConfg.Click += new System.EventHandler(this.imgConfg_Click);
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.imgClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgClose.BackgroundImage")));
            this.imgClose.Location = new System.Drawing.Point(574, 8);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(16, 16);
            this.imgClose.TabIndex = 11;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // imgMinimized
            // 
            this.imgMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.imgMinimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgMinimized.BackgroundImage")));
            this.imgMinimized.Location = new System.Drawing.Point(552, 8);
            this.imgMinimized.Name = "imgMinimized";
            this.imgMinimized.Size = new System.Drawing.Size(16, 16);
            this.imgMinimized.TabIndex = 13;
            this.imgMinimized.TabStop = false;
            this.imgMinimized.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.panelConfig);
            this.panel1.Controls.Add(this.textBoxLetra);
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 705);
            this.panel1.TabIndex = 15;
            // 
            // panelConfig
            // 
            this.panelConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelConfig.Controls.Add(this.switchSongOff);
            this.panelConfig.Controls.Add(this.switchSongOn);
            this.panelConfig.Controls.Add(this.label4);
            this.panelConfig.Controls.Add(this.panel4);
            this.panelConfig.Controls.Add(this.label6);
            this.panelConfig.Controls.Add(this.label5);
            this.panelConfig.Controls.Add(this.cbSizeFont);
            this.panelConfig.Controls.Add(this.label3);
            this.panelConfig.Controls.Add(this.label2);
            this.panelConfig.Controls.Add(this.imgCloseConfg);
            this.panelConfig.Controls.Add(this.panel3);
            this.panelConfig.Location = new System.Drawing.Point(111, 153);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(397, 274);
            this.panelConfig.TabIndex = 4;
            // 
            // switchSongOff
            // 
            this.switchSongOff.BackColor = System.Drawing.Color.Transparent;
            this.switchSongOff.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.switchSongOff.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.switchSongOff.Location = new System.Drawing.Point(328, 219);
            this.switchSongOff.Margin = new System.Windows.Forms.Padding(3, 3, 3, 56);
            this.switchSongOff.Name = "switchSongOff";
            this.switchSongOff.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.switchSongOff.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(217)))), ((int)(((byte)(100)))));
            this.switchSongOff.Size = new System.Drawing.Size(60, 30);
            this.switchSongOff.SwitchState = XanderUI.XUISwitch.State.Off;
            this.switchSongOff.SwitchStyle = XanderUI.XUISwitch.Style.iOS;
            this.switchSongOff.TabIndex = 27;
            this.switchSongOff.Text = "xuiSwitch1";
            this.switchSongOff.SwitchStateChanged += new System.EventHandler(this.switchSongOff_SwitchStateChanged);
            // 
            // switchSongOn
            // 
            this.switchSongOn.BackColor = System.Drawing.Color.Transparent;
            this.switchSongOn.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.switchSongOn.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.switchSongOn.Location = new System.Drawing.Point(328, 219);
            this.switchSongOn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 56);
            this.switchSongOn.Name = "switchSongOn";
            this.switchSongOn.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.switchSongOn.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(217)))), ((int)(((byte)(100)))));
            this.switchSongOn.Size = new System.Drawing.Size(60, 30);
            this.switchSongOn.SwitchState = XanderUI.XUISwitch.State.On;
            this.switchSongOn.SwitchStyle = XanderUI.XUISwitch.Style.iOS;
            this.switchSongOn.TabIndex = 26;
            this.switchSongOn.Text = "xuiSwitch1";
            this.switchSongOn.SwitchStateChanged += new System.EventHandler(this.switchSong_SwitchStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Música";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel4.Location = new System.Drawing.Point(23, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 1);
            this.panel4.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.label6.Location = new System.Drawing.Point(22, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Atualizar músicas automaticamente.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Fonte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.label3.Location = new System.Drawing.Point(20, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tamanho da fonte das músicas.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Configurações";
            // 
            // imgCloseConfg
            // 
            this.imgCloseConfg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCloseConfg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgCloseConfg.BackgroundImage")));
            this.imgCloseConfg.Location = new System.Drawing.Point(372, 9);
            this.imgCloseConfg.Name = "imgCloseConfg";
            this.imgCloseConfg.Size = new System.Drawing.Size(16, 16);
            this.imgCloseConfg.TabIndex = 12;
            this.imgCloseConfg.TabStop = false;
            this.imgCloseConfg.Click += new System.EventHandler(this.imgCloseConfg_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel3.Location = new System.Drawing.Point(23, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 1);
            this.panel3.TabIndex = 19;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.imgMinimized);
            this.panelHeader.Controls.Add(this.imgConfg);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 33);
            this.panelHeader.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(12, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 654);
            this.panel2.TabIndex = 16;
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cbSizeFont
            // 
            this.cbSizeFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbSizeFont.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbSizeFont.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cbSizeFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSizeFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSizeFont.ForeColor = System.Drawing.Color.White;
            this.cbSizeFont.FormattingEnabled = true;
            this.cbSizeFont.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24"});
            this.cbSizeFont.Location = new System.Drawing.Point(271, 126);
            this.cbSizeFont.Name = "cbSizeFont";
            this.cbSizeFont.Size = new System.Drawing.Size(117, 24);
            this.cbSizeFont.TabIndex = 15;
            this.cbSizeFont.SelectedValueChanged += new System.EventHandler(this.cbSizeFont_SelectedValueChanged);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelHeader;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.labelTocando;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 705);
            this.Controls.Add(this.imgClose);
            this.Controls.Add(this.labelTocando);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spotics";
            ((System.ComponentModel.ISupportInitialize)(this.imgConfg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimized)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseConfg)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTocando;
        private System.Windows.Forms.TextBox textBoxLetra;
        private System.Windows.Forms.PictureBox imgConfg;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.PictureBox imgMinimized;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgCloseConfg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private CustomComboBox cbSizeFont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelHeader;
        private XanderUI.XUISwitch switchSongOn;
        private System.Windows.Forms.Timer timer;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUISwitch switchSongOff;
    }
}

