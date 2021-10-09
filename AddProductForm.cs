using Inventory_Managment_System.Data;
using Inventory_Managment_System.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class AddProductForm : MaterialForm
    {
        private readonly IProductService _service;
        public Models.Product Product { get; set; } = new Models.Product();
        public AddProductForm()
        {
            InitializeComponent();
            _service = new Services.ProductService(new IMS_DataContext());

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            categoriesBox.DataSource = _service.GetProductCategories();
        }

        private void reset()
        {
            productNameTxb.Text = null;
            productDefectiveStockTbx.Text = null;
            productDescriptionTxb.Text = null;
            productPriceTbx.Text = null;
            productStockTbx.Text = null;
            Product = new Models.Product();
        }

        private void submitProduct_Click(object sender, EventArgs e)
        {
            if (productNameTxb.Text != "" && Decimal.Parse(productPriceTbx.Text) >= 0 && Int32.Parse(productDefectiveStockTbx.Text) >= 0 && Int32.Parse(productStockTbx.Text) >= 0 && Int32.Parse(categoriesBox.SelectedValue.ToString()) > 0)
            {
            Product.Name = productNameTxb.Text;
            Product.Description = productDescriptionTxb.Text;
            Product.Price = Decimal.Parse(productPriceTbx.Text);
            Product.StockDefective = Int32.Parse(productDefectiveStockTbx.Text);
            Product.Stock = Int32.Parse(productStockTbx.Text);
            Product.ProductCategoryId = Int32.Parse(categoriesBox.SelectedValue.ToString());
            _service.AddProduct(Product);
            this.reset();
            MessageBox.Show("Product updated");
            }
            else
            {
                MessageBox.Show("Smoething went wrong. Check the form.");
            }
        }
    }
}
