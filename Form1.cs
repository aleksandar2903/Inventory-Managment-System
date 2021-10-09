using Inventory_Managment_System.Data;
using Inventory_Managment_System.Models;
using Inventory_Managment_System.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class Form1 : MaterialForm
    {
        private readonly IProductCategory _service;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly IProviderService _providerService;
        private readonly ISaleService _saleService;
        private readonly IPurchaseService _purchaseService;
        public Models.ProductCategory productCategory { get; set; } = new Models.ProductCategory();
        public Form1()
        {
            InitializeComponent();
            _service = new Services.ProductCategory(new IMS_DataContext());
            _productService = new Services.ProductService(new IMS_DataContext());
            _customerService = new Services.CustomerService(new IMS_DataContext());
            _providerService = new Services.ProviderService(new IMS_DataContext());
            _saleService = new Services.SaleService(new IMS_DataContext());
            _purchaseService = new Services.PurchaseService(new IMS_DataContext());
            this.dataGridView1.AutoGenerateColumns = false;
            this.productsGrid.AutoGenerateColumns = false;
            this.purchasesGrid.AutoGenerateColumns = false;
            this.customersGrid.AutoGenerateColumns = false;
            this.salesGrid.AutoGenerateColumns = false;
            this.providersGrid.AutoGenerateColumns = false;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                productCategory.Name = textBox1.Text;
                if (productCategory.Id == 0)
                {
                    productCategory.CreatedAt = DateTime.Now;
                    _service.AddProductCategory(productCategory);
                }
                else
                {
                    _service.UpdateProductCategory(productCategory);
                }
                this.reset();
            }
            else
            {
                MessageBox.Show("Enter category name");
            }
        }
        private void seedGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _service.GetCategories();
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            productCategory.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            productCategory.CreatedAt = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            button1.Text = "Update";
            button3.Enabled = true;
        }
        private void reset()
        {
            productCategory.Id = 0;
            textBox1.Clear();
            button1.Text = "Create";
            button3.Enabled = false;
            this.seedGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _service.DeleteProductCategory(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            this.reset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Login login = new Login())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    this.seedGrid();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void createProductButton_Click(object sender, EventArgs e)
        {
            using (AddProductForm pform = new AddProductForm())
            {
                this.Enabled = false;
                this.Visible = false;
                if (pform.ShowDialog() == DialogResult.Cancel)
                {
                    this.Enabled = true;
                    this.Visible = true;
                }
            }
        }
        private void seedProductGrid()
        {
            productsGrid.Rows.Clear();
            foreach (var product in _productService.GetProducts())
            {
                int i = productsGrid.Rows.Add();
                productsGrid.Rows[i].Cells["Product_Id"].Value = product.Id;
                productsGrid.Rows[i].Cells["Product_Name"].Value = product.Name;
                productsGrid.Rows[i].Cells["Product_Category"].Value = product.ProductCategory.Name;
                productsGrid.Rows[i].Cells["Product_On_Stock"].Value = product.Stock;
                productsGrid.Rows[i].Cells["Product_Price"].Value = product.Price;
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            this.seedGrid();
        }

        private void productsTab_Enter(object sender, EventArgs e)
        {
            this.seedProductGrid();
        }

        private void productsGrid_DoubleClick(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(productsGrid.CurrentRow.Cells["Product_Id"].Value);
            var product = _productService.GetProduct(Id);
            using (ProductForm pform = new ProductForm(product))
            {
                this.Enabled = false;
                this.Visible = false;
                if (pform.ShowDialog() == DialogResult.Cancel)
                {
                    this.seedProductGrid();
                    this.Enabled = true;
                    this.Visible = true;
                }
            }
        }

        private void createCustomerBtn_Click(object sender, EventArgs e)
        {
            using (AddCustomerForm customerForm = new AddCustomerForm())
            {
                this.Enabled = false;
                this.Visible = false;
                if (customerForm.ShowDialog() == DialogResult.Cancel || customerForm.ShowDialog() == DialogResult.OK)
                {
                    this.seedCustomersGrid();
                    this.Enabled = true;
                    this.Visible = true;
                }
            }
        }

        private void seedCustomersGrid()
        {
            customersGrid.DataSource = _customerService.GetCustomers();
        }

        private void createSaleBtn_Click(object sender, EventArgs e)
        {
            using (SaleForm saleForm = new SaleForm())
            {
                this.Enabled = false;
                this.Visible = false;
                if (saleForm.ShowDialog() == DialogResult.Cancel || saleForm.ShowDialog() == DialogResult.OK)
                {
                    this.seedSalesGrid();
                    this.Enabled = true;
                    this.Visible = true;
                }
            }
        }

        private void seedSalesGrid()
        {
            salesGrid.DataSource = null;
            salesGrid.DataSource = _saleService.GetSales();

        }

        private void salesTab_Enter(object sender, EventArgs e)
        {
            this.seedSalesGrid();
        }

        private void salesGrid_DoubleClick(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(salesGrid.CurrentRow.Cells[0].Value);
            var sale = _saleService.GetSale(Id);
            using (ShowSaleForm showSaleForm = new ShowSaleForm(sale))
            {
                this.Enabled = false;
                this.Visible = false;
                if (showSaleForm.ShowDialog() == DialogResult.Cancel || showSaleForm.ShowDialog() == DialogResult.OK)
                {
                    this.seedSalesGrid();
                    this.Enabled = true;
                    this.Visible = true;
                }
            }
        }

        private void createProviderBtn_Click(object sender, EventArgs e)
        {
            using (AddProviderForm providerForm = new AddProviderForm())
            {
                this.Enabled = false;
                this.Visible = false;
                if (providerForm.ShowDialog() == DialogResult.Cancel || providerForm.ShowDialog() == DialogResult.OK)
                {
                    this.seedProviderGrid();
                    this.Enabled = true;
                    this.Visible = true;
                }
            }
        }

        private void seedProviderGrid()
        {
            providersGrid.DataSource = _providerService.GetProviders();
        }

        private void createPurchaseBtn_Click(object sender, EventArgs e)
        {
            using (PurchaseForm purchaseForm = new PurchaseForm())
            {
                this.Enabled = false;
                this.Visible = false;
                if (purchaseForm.ShowDialog() == DialogResult.Cancel || purchaseForm.ShowDialog() == DialogResult.OK)
                {
                    this.seedPurchaserGrid();
                    this.Enabled = true;
                    this.Visible = true;
                }
            }
        }

        private void seedPurchaserGrid()
        {
            purchasesGrid.DataSource = _purchaseService.GetPurchases();
        }

        private void customersTab_Enter(object sender, EventArgs e)
        {
            this.seedCustomersGrid();
        }

        private void formTabs_Enter(object sender, EventArgs e)
        {
            this.seedProviderGrid();
        }

        private void purchasesTab_Enter(object sender, EventArgs e)
        {
            this.seedPurchaserGrid();
        }

        private void customersGrid_DoubleClick(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(customersGrid.CurrentRow.Cells[0].Value);
            var customer = _customerService.GetCustomer(Id);
            using (CustomerForm customerForm = new CustomerForm(customer))
            {
                this.Enabled = false;
                this.Visible = false;
                if (customerForm.ShowDialog() == DialogResult.Cancel || customerForm.ShowDialog() == DialogResult.OK)
                {
                    this.seedCustomersGrid();
                    this.Enabled = true;
                    this.Visible = true;
                }
            }
        }

        private void providersGrid_DoubleClick(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(providersGrid.CurrentRow.Cells[0].Value);
            var provider = _providerService.GetProvider(Id);
            using (ProviderForm providerForm = new ProviderForm(provider))
            {
                this.Enabled = false;
                this.Visible = false;
                if (providerForm.ShowDialog() == DialogResult.Cancel || providerForm.ShowDialog() == DialogResult.OK)
                {
                    this.seedProviderGrid();
                    this.Enabled = true;
                    this.Visible = true;
                }
            }
        }

        private void purchasesGrid_DoubleClick(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(purchasesGrid.CurrentRow.Cells[0].Value);
            var purchase = _purchaseService.GetPurchase(Id);
            using (ShowPurchaseForm purchaseerForm = new ShowPurchaseForm(purchase))
            {
                this.Enabled = false;
                this.Visible = false;
                if (purchaseerForm.ShowDialog() == DialogResult.Cancel || purchaseerForm.ShowDialog() == DialogResult.OK)
                {
                    this.Enabled = true;
                    this.Visible = true;
                }
            }
        }
    }
}
