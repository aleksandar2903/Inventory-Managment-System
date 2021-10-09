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
    public partial class PurchaseForm : MaterialForm
    {
        private readonly IProductService _productService;
        private readonly IProviderService _providerService;
        private readonly IPurchaseService _purchaseService;

        public Models.Receipt Purchase { get; set; } = new Models.Receipt();
        public PurchaseForm()
        {
            InitializeComponent();
            _productService = new Services.ProductService(new IMS_DataContext());
            _providerService = new Services.ProviderService(new IMS_DataContext());
            _purchaseService = new Services.PurchaseService(new IMS_DataContext());


            productsCbx.DataSource = _productService.GetProducts();
            providerCbx.DataSource = _providerService.GetProviders();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }

        private void productsCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = _productService.GetProduct(Int32.Parse(productsCbx.SelectedValue.ToString()));
            this.addProduct(product);
        }
        private void addProduct(Models.Product product)
        {
            bool exist = false;
            if (productsGrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in productsGrid.Rows)
                {
                    if (Int32.Parse(row.Cells["product_id"].Value.ToString()) == product.Id)
                    {
                        exist = true;
                    }
                }
                if (!exist)
                {
                    productsGrid.Rows.Add(product.Id, product.Name, product.Price, 1, 0);
                }
            }
            else
            {
                productsGrid.Rows.Add(product.Id, product.Name, product.Price, 1, 0);
            }
        }

        private void submitPurchase_Click(object sender, EventArgs e)
        {
            if (productsGrid.Rows.Count > 0)
            {
                Purchase.ReceivedProducts = new List<Models.ReceivedProduct>();
                Purchase.ProviderId = Int32.Parse(providerCbx.SelectedValue.ToString());
                Purchase.UserId = 1;
                Purchase.Title = materialTextBox1.Text;
                Purchase.FinalizedAt = DateTime.Now;
                foreach (DataGridViewRow row in productsGrid.Rows)
                {
                    if (Int32.Parse(row.Cells["stock"].Value.ToString()) > 0 && Int32.Parse(row.Cells["stock_defective"].Value.ToString())>=0)
                    {
                        Purchase.ReceivedProducts.Add(new Models.ReceivedProduct
                        {
                            ProductId = Int32.Parse(row.Cells["product_id"].Value.ToString()),
                            Stock = Int32.Parse(row.Cells["stock"].Value.ToString()),
                            StockDefective = Int32.Parse(row.Cells["stock_defective"].Value.ToString())
                        });
                    }
                }
                foreach (DataGridViewRow row in productsGrid.Rows)
                {
                    var product = _productService.GetProduct(Int32.Parse(row.Cells["product_id"].Value.ToString()));
                    product.Stock += Int32.Parse(row.Cells["stock"].Value.ToString());
                    product.StockDefective += Int32.Parse(row.Cells["stock_defective"].Value.ToString());
                    _productService.UpdateProduct(product);
                }
                _purchaseService.AddPurchase(Purchase);
                MessageBox.Show("Success");
                this.reset();
            }
            else
            {
                MessageBox.Show("Add products");
            }
        }
        private void reset()
        {
            productsGrid.Rows.Clear();
            Purchase = new Models.Receipt();
            materialTextBox1.Text = null;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.reset();
        }
    }
}
