namespace CosMos_Market
{
    partial class ProductForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_Stok = new System.Windows.Forms.NumericUpDown();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_fiyat = new System.Windows.Forms.TextBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_brand = new System.Windows.Forms.ComboBox();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_addCategory);
            this.groupBox1.Controls.Add(this.nud_Stok);
            this.groupBox1.Controls.Add(this.cb_brand);
            this.groupBox1.Controls.Add(this.cb_category);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_fiyat);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_barcode);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // nud_Stok
            // 
            this.nud_Stok.Location = new System.Drawing.Point(478, 45);
            this.nud_Stok.Name = "nud_Stok";
            this.nud_Stok.Size = new System.Drawing.Size(228, 20);
            this.nud_Stok.TabIndex = 5;
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(131, 71);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(229, 21);
            this.cb_category.TabIndex = 4;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(631, 97);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(631, 97);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stok";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Isim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barkod Numarası:";
            // 
            // tb_fiyat
            // 
            this.tb_fiyat.Location = new System.Drawing.Point(477, 71);
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.Size = new System.Drawing.Size(229, 20);
            this.tb_fiyat.TabIndex = 0;
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(477, 19);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(229, 20);
            this.tb_isim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // tb_barcode
            // 
            this.tb_barcode.Location = new System.Drawing.Point(131, 45);
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.Size = new System.Drawing.Size(229, 20);
            this.tb_barcode.TabIndex = 0;
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Location = new System.Drawing.Point(131, 19);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(229, 20);
            this.tb_ID.TabIndex = 0;
            // 
            // dgv_product
            // 
            this.dgv_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(12, 177);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.Size = new System.Drawing.Size(854, 311);
            this.dgv_product.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Marka:";
            // 
            // cb_brand
            // 
            this.cb_brand.FormattingEnabled = true;
            this.cb_brand.Location = new System.Drawing.Point(131, 97);
            this.cb_brand.Name = "cb_brand";
            this.cb_brand.Size = new System.Drawing.Size(229, 21);
            this.cb_brand.TabIndex = 4;
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Location = new System.Drawing.Point(366, 69);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(21, 23);
            this.btn_addCategory.TabIndex = 6;
            this.btn_addCategory.Text = "+";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 510);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_Stok;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_fiyat;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.ComboBox cb_brand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_addCategory;
    }
}