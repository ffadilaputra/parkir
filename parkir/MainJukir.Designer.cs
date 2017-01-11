namespace BAL
{
    partial class Parkiran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parkiran));
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkirKeluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkirMasukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kendaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.merekKendaraanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataJukirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahJukirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataJukirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lnkSettings = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parkirKeluarToolStripMenuItem,
            this.parkirMasukToolStripMenuItem});
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(62, 51);
            this.kategoriToolStripMenuItem.Text = "Parkiran";
            this.kategoriToolStripMenuItem.Click += new System.EventHandler(this.kategoriToolStripMenuItem_Click);
            // 
            // parkirKeluarToolStripMenuItem
            // 
            this.parkirKeluarToolStripMenuItem.Name = "parkirKeluarToolStripMenuItem";
            this.parkirKeluarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.parkirKeluarToolStripMenuItem.Text = "Parkir Keluar";
            this.parkirKeluarToolStripMenuItem.Click += new System.EventHandler(this.parkirKeluarToolStripMenuItem_Click);
            // 
            // parkirMasukToolStripMenuItem
            // 
            this.parkirMasukToolStripMenuItem.Name = "parkirMasukToolStripMenuItem";
            this.parkirMasukToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.parkirMasukToolStripMenuItem.Text = "Parkir Masuk";
            this.parkirMasukToolStripMenuItem.Click += new System.EventHandler(this.parkirMasukToolStripMenuItem_Click);
            // 
            // kendaranToolStripMenuItem
            // 
            this.kendaranToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriToolStripMenuItem1,
            this.kustomerToolStripMenuItem,
            this.agamaToolStripMenuItem,
            this.merekKendaraanToolStripMenuItem});
            this.kendaranToolStripMenuItem.Name = "kendaranToolStripMenuItem";
            this.kendaranToolStripMenuItem.Size = new System.Drawing.Size(55, 51);
            this.kendaranToolStripMenuItem.Text = "Master";
            // 
            // kategoriToolStripMenuItem1
            // 
            this.kategoriToolStripMenuItem1.Name = "kategoriToolStripMenuItem1";
            this.kategoriToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.kategoriToolStripMenuItem1.Text = "Kategori";
            this.kategoriToolStripMenuItem1.Click += new System.EventHandler(this.kategoriToolStripMenuItem1_Click);
            // 
            // kustomerToolStripMenuItem
            // 
            this.kustomerToolStripMenuItem.Name = "kustomerToolStripMenuItem";
            this.kustomerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kustomerToolStripMenuItem.Text = "Kustomer";
            this.kustomerToolStripMenuItem.Click += new System.EventHandler(this.kustomerToolStripMenuItem_Click);
            // 
            // agamaToolStripMenuItem
            // 
            this.agamaToolStripMenuItem.Name = "agamaToolStripMenuItem";
            this.agamaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.agamaToolStripMenuItem.Text = "Agama";
            this.agamaToolStripMenuItem.Click += new System.EventHandler(this.agamaToolStripMenuItem_Click);
            // 
            // merekKendaraanToolStripMenuItem
            // 
            this.merekKendaraanToolStripMenuItem.Name = "merekKendaraanToolStripMenuItem";
            this.merekKendaraanToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.merekKendaraanToolStripMenuItem.Text = "Merek Kendaraan";
            this.merekKendaraanToolStripMenuItem.Click += new System.EventHandler(this.merekKendaraanToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriToolStripMenuItem,
            this.kendaranToolStripMenuItem,
            this.dataJukirToolStripMenuItem,
            this.profilToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 5);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(750, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dataJukirToolStripMenuItem
            // 
            this.dataJukirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahJukirToolStripMenuItem,
            this.dataJukirToolStripMenuItem1});
            this.dataJukirToolStripMenuItem.Name = "dataJukirToolStripMenuItem";
            this.dataJukirToolStripMenuItem.Size = new System.Drawing.Size(70, 51);
            this.dataJukirToolStripMenuItem.Text = "Data Jukir";
            this.dataJukirToolStripMenuItem.Click += new System.EventHandler(this.dataJukirToolStripMenuItem_Click);
            // 
            // tambahJukirToolStripMenuItem
            // 
            this.tambahJukirToolStripMenuItem.Name = "tambahJukirToolStripMenuItem";
            this.tambahJukirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tambahJukirToolStripMenuItem.Text = "Tambah Jukir";
            this.tambahJukirToolStripMenuItem.Click += new System.EventHandler(this.tambahJukirToolStripMenuItem_Click);
            // 
            // dataJukirToolStripMenuItem1
            // 
            this.dataJukirToolStripMenuItem1.Name = "dataJukirToolStripMenuItem1";
            this.dataJukirToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dataJukirToolStripMenuItem1.Text = "Data Jukir";
            this.dataJukirToolStripMenuItem1.Click += new System.EventHandler(this.dataJukirToolStripMenuItem1_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem1,
            this.keluarToolStripMenuItem});
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(47, 51);
            this.profilToolStripMenuItem.Text = "Akun";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem1
            // 
            this.profilToolStripMenuItem1.Name = "profilToolStripMenuItem1";
            this.profilToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.profilToolStripMenuItem1.Text = "Profil";
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 51);
            this.toolStripMenuItem1.Text = " ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // lnkSettings
            // 
            this.lnkSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSettings.Image = ((System.Drawing.Image)(resources.GetObject("lnkSettings.Image")));
            this.lnkSettings.ImageSize = 32;
            this.lnkSettings.Location = new System.Drawing.Point(20, 138);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkSettings.NoFocusImage")));
            this.lnkSettings.Size = new System.Drawing.Size(43, 51);
            this.lnkSettings.TabIndex = 2;
            this.lnkSettings.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroTabControl1.Location = new System.Drawing.Point(570, 118);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(200, 358);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(192, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parkir Masuk";
            this.tabPage1.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(192, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parkir Keluar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::parkir.Properties.Resources.parking;
            this.pictureBox1.Location = new System.Drawing.Point(23, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Parkiran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::parkir.Properties.Resources.parking;
            this.BackImagePadding = new System.Windows.Forms.Padding(200);
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(790, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lnkSettings);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Parkiran";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Parking Apps";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kendaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agamaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private MetroFramework.Controls.MetroLink lnkSettings;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem parkirKeluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkirMasukToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem dataJukirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahJukirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataJukirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem merekKendaraanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
    }
}

