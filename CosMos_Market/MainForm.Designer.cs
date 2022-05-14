namespace CosMos_Market
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CategoryFormOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_OpenProductForm = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_OpenBrandForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışModülüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(923, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem,
            this.satışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CategoryFormOpen,
            this.toolStripSeparator2,
            this.TSMI_OpenBrandForm,
            this.toolStripSeparator1,
            this.TSMI_OpenProductForm});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // TSMI_CategoryFormOpen
            // 
            this.TSMI_CategoryFormOpen.Name = "TSMI_CategoryFormOpen";
            this.TSMI_CategoryFormOpen.Size = new System.Drawing.Size(180, 22);
            this.TSMI_CategoryFormOpen.Text = "Kategori İşlemleri";
            this.TSMI_CategoryFormOpen.Click += new System.EventHandler(this.TSMI_CategoryFormOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_OpenProductForm
            // 
            this.TSMI_OpenProductForm.Name = "TSMI_OpenProductForm";
            this.TSMI_OpenProductForm.Size = new System.Drawing.Size(180, 22);
            this.TSMI_OpenProductForm.Text = "Ürün İşlemleri";
            this.TSMI_OpenProductForm.Click += new System.EventHandler(this.TSMI_OpenProductForm_Click);
            // 
            // TSMI_OpenBrandForm
            // 
            this.TSMI_OpenBrandForm.Name = "TSMI_OpenBrandForm";
            this.TSMI_OpenBrandForm.Size = new System.Drawing.Size(180, 22);
            this.TSMI_OpenBrandForm.Text = "Marka İşlemleri";
            this.TSMI_OpenBrandForm.Click += new System.EventHandler(this.TSMI_OpenBrandForm_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışModülüToolStripMenuItem});
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.satışToolStripMenuItem.Text = "Satış";
            // 
            // satışModülüToolStripMenuItem
            // 
            this.satışModülüToolStripMenuItem.Name = "satışModülüToolStripMenuItem";
            this.satışModülüToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.satışModülüToolStripMenuItem.Text = "Satış Modülü";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 570);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CosMos Yönetim Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CategoryFormOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_OpenProductForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_OpenBrandForm;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışModülüToolStripMenuItem;
    }
}