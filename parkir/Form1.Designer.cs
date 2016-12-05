namespace BAL
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jukirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kendaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jukirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kendaraanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biayaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waktuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jukirToolStripMenuItem,
            this.kategoriToolStripMenuItem,
            this.kendaranToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jukirToolStripMenuItem
            // 
            this.jukirToolStripMenuItem.Name = "jukirToolStripMenuItem";
            this.jukirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.jukirToolStripMenuItem.Text = "####";
            this.jukirToolStripMenuItem.Click += new System.EventHandler(this.jukirToolStripMenuItem_Click);
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kendaraanToolStripMenuItem,
            this.biayaToolStripMenuItem,
            this.waktuToolStripMenuItem});
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.kategoriToolStripMenuItem.Text = "Parkiran";
            this.kategoriToolStripMenuItem.Click += new System.EventHandler(this.kategoriToolStripMenuItem_Click);
            // 
            // kendaranToolStripMenuItem
            // 
            this.kendaranToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jukirToolStripMenuItem1,
            this.kategoriToolStripMenuItem1,
            this.kustomerToolStripMenuItem,
            this.agamaToolStripMenuItem});
            this.kendaranToolStripMenuItem.Name = "kendaranToolStripMenuItem";
            this.kendaranToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kendaranToolStripMenuItem.Text = "Master";
            // 
            // jukirToolStripMenuItem1
            // 
            this.jukirToolStripMenuItem1.Name = "jukirToolStripMenuItem1";
            this.jukirToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.jukirToolStripMenuItem1.Text = "Jukir";
            this.jukirToolStripMenuItem1.Click += new System.EventHandler(this.jukirToolStripMenuItem1_Click);
            // 
            // kategoriToolStripMenuItem1
            // 
            this.kategoriToolStripMenuItem1.Name = "kategoriToolStripMenuItem1";
            this.kategoriToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.kategoriToolStripMenuItem1.Text = "Kategori";
            this.kategoriToolStripMenuItem1.Click += new System.EventHandler(this.kategoriToolStripMenuItem1_Click);
            // 
            // kustomerToolStripMenuItem
            // 
            this.kustomerToolStripMenuItem.Name = "kustomerToolStripMenuItem";
            this.kustomerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kustomerToolStripMenuItem.Text = "Kustomer";
            this.kustomerToolStripMenuItem.Click += new System.EventHandler(this.kustomerToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // kendaraanToolStripMenuItem
            // 
            this.kendaraanToolStripMenuItem.Name = "kendaraanToolStripMenuItem";
            this.kendaraanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kendaraanToolStripMenuItem.Text = "Kendaraan";
            // 
            // biayaToolStripMenuItem
            // 
            this.biayaToolStripMenuItem.Name = "biayaToolStripMenuItem";
            this.biayaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.biayaToolStripMenuItem.Text = "Biaya";
            // 
            // waktuToolStripMenuItem
            // 
            this.waktuToolStripMenuItem.Name = "waktuToolStripMenuItem";
            this.waktuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.waktuToolStripMenuItem.Text = "Waktu";
            // 
            // agamaToolStripMenuItem
            // 
            this.agamaToolStripMenuItem.Name = "agamaToolStripMenuItem";
            this.agamaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agamaToolStripMenuItem.Text = "Agama";
            this.agamaToolStripMenuItem.Click += new System.EventHandler(this.agamaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 387);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jukirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kendaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kendaraanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biayaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waktuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jukirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agamaToolStripMenuItem;
    }
}

