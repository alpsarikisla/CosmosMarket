using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosMos_Market
{
    public partial class ProductForm : Form
    {
        DataModel dm = new DataModel();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            cb_brand.DisplayMember = "Name";
            cb_brand.ValueMember = "ID";
            cb_brand.DataSource = dm.GetBrands();
            cb_category.DisplayMember = "Name";
            cb_category.ValueMember = "ID";
            cb_category.DataSource = dm.GetCategories();
            dgv_product.DataSource = dm.GetProducts();
            dgv_product.Columns[0].HeaderText = "No";
            dgv_product.Columns[1].HeaderText = "Barkod Numarası";
            dgv_product.Columns[1].Width = 200;
            dgv_product.Columns[2].HeaderText = "İsim";
            dgv_product.Columns[3].Visible = false;
            dgv_product.Columns[4].HeaderText = "Kategori";
            dgv_product.Columns[5].Visible = false;
            dgv_product.Columns[6].HeaderText = "Marka";
            dgv_product.Columns[7].HeaderText = "Stok";
            dgv_product.Columns[8].HeaderText = "Fiyat";
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Product p = new Product()
            {
                BarcodeNo = tb_barcode.Text,
                ProductName = tb_isim.Text,
                Category_ID = Convert.ToInt32(cb_category.SelectedValue),
                Brand_ID = Convert.ToInt32(cb_brand.SelectedValue),
                Stock = Convert.ToInt32(nud_Stok.Value),
                Price = Convert.ToDecimal(tb_fiyat.Text)
            };
            int id = dm.AddProduct(p);
            if (id != -1) { MessageBox.Show($"Ürün {id} id ile başarıyla eklenmiştir", "Başarılı"); }
            else
            {
                MessageBox.Show("Ürün Eklenirken bir hata oluştu", "Başarısız");
            }

            dgv_product.DataSource = dm.GetProducts();
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            AddCategory frm = new AddCategory();
            frm.ShowDialog();
            cb_category.DataSource = dm.GetCategories();
        }
    }
}
