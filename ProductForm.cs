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
    public partial class ProductForm : MaterialForm
    {
        private readonly IProductService _service;
        public Models.Product Product { get; set; } = new Models.Product();
        public ProductForm(Models.Product product)
        {
            InitializeComponent();
            _service = new Services.ProductService(new IMS_DataContext());
            Product = product;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            productCategoriesBox.DataSource = _service.GetProductCategories();
            this.seedGrid();
            this.reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product.Name = productNameTxb.Text;
            Product.Description = productDescriptionTxb.Text;
            Product.Price = Int32.Parse(productPriceTbx.Text);
            Product.StockDefective = Int32.Parse(productDefectiveStockTbx.Text);
            Product.Stock = Int32.Parse(productStockTbx.Text);
            Product.ProductCategoryId = Int32.Parse(productCategoriesBox.SelectedValue.ToString());
            _service.AddProduct(Product);
            this.seedGrid();
            this.reset();
        }

        private void seedGrid()
        {
            dataGridView1.Rows.Clear();
            int count = 0;
            foreach (var sold in Product.SoldProducts)
            {
                count += sold.Qty;
                int i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["date"].Value = sold.CreatedAt;
                dataGridView1.Rows[i].Cells["customer"].Value = sold.Sale.Client.Name;
                dataGridView1.Rows[i].Cells["product_price"].Value = sold.Price;
                dataGridView1.Rows[i].Cells["product_qty"].Value = sold.Qty;
                dataGridView1.Rows[i].Cells["total_amount"].Value = sold.TotalAmount;
            }
            totalSoldLbl.Text = count.ToString();
            count = 0;
            foreach (var purchase in Product.ReceivedProducts)
            {
                count += purchase.Stock;
                int i = purchaseGrid.Rows.Add();
                purchaseGrid.Rows[i].Cells["purchase_date"].Value = purchase.CreatedAt;
                purchaseGrid.Rows[i].Cells["provider_name"].Value = purchase.Receipt.Provider.Name;
                purchaseGrid.Rows[i].Cells["purchase_stock"].Value = purchase.Stock;
                purchaseGrid.Rows[i].Cells["purchase_id"].Value = purchase.Id;
                purchaseGrid.Rows[i].Cells["defstock_purchase"].Value = purchase.StockDefective;
            }
            totalPurchasesLbl.Text = count.ToString();
        }

        private void reset()
        {
            productNameTxb.Text = Product.Name;
            productDefectiveStockTbx.Text = Product.StockDefective.ToString();
            productDescriptionTxb.Text = Product.Description;
            productPriceTbx.Text = Product.Price.ToString();
            productStockTbx.Text = Product.Stock.ToString();
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            _service.DeleteProduct(Product.Id);
            this.Close();
        }

        private void submitProduct_Click(object sender, EventArgs e)
        {
            if (productNameTxb.Text != "" && Decimal.Parse(productPriceTbx.Text) >= 0 && Int32.Parse(productDefectiveStockTbx.Text) >= 0 && Int32.Parse(productStockTbx.Text) >= 0 && Int32.Parse(productCategoriesBox.SelectedValue.ToString()) > 0)
            {
                Product.Name = productNameTxb.Text;
                Product.Description = productDescriptionTxb.Text;
                Product.Price = Decimal.Parse(productPriceTbx.Text);
                Product.StockDefective = Int32.Parse(productDefectiveStockTbx.Text);
                Product.Stock = Int32.Parse(productStockTbx.Text);
                Product.ProductCategoryId = Int32.Parse(productCategoriesBox.SelectedValue.ToString());
                _service.UpdateProduct(Product);
                MessageBox.Show("Product updated");
            }
            else
            {
                MessageBox.Show("Something went wrong. Check the form.");
            }
        }
    }
}
