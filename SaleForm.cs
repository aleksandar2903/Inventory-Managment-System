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
    public partial class SaleForm : MaterialForm
    {
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly ISaleService _saleService;

        public Models.Sale Sale { get; set; } = new Models.Sale();
        public SaleForm()
        {
            InitializeComponent();
            _productService = new Services.ProductService(new IMS_DataContext());
            _customerService = new Services.CustomerService(new IMS_DataContext());
            _saleService = new Services.SaleService(new IMS_DataContext());


            productsCbx.DataSource = _productService.GetProducts();
            customersCbx.DataSource = _customerService.GetCustomers();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }

        private void productsCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = _productService.GetProduct(Int32.Parse(productsCbx.SelectedValue.ToString()));
            this.addProduct(product);
            this.totalBill();
        }

        private void submitSale_Click(object sender, EventArgs e)
        {
            if (productsGrid.Rows.Count > 0)
            {
                bool check = false;
                Sale.SoldProducts = new List<Models.SoldProduct>();
                decimal totalPrice = 0;
                foreach (DataGridViewRow row in productsGrid.Rows)
                {
                    if (Int32.Parse(row.Cells["product_quantity"].Value.ToString()) <= Int32.Parse(row.Cells["Product_On_Stock"].Value.ToString()))
                    {
                        Sale.SoldProducts.Add(new Models.SoldProduct
                        {
                            Price = Decimal.Parse(row.Cells["Product_Price"].Value.ToString()),
                            ProductId = Int32.Parse(row.Cells["product_id"].Value.ToString()),
                            Qty = Int32.Parse(row.Cells["product_quantity"].Value.ToString()),
                            TotalAmount = Int32.Parse(row.Cells["product_quantity"].Value.ToString()) * Decimal.Parse(row.Cells["Product_Price"].Value.ToString()),
                            CreatedAt = DateTime.Now,
                        });
                    }
                    else
                    {
                        check = true;
                    }
                    totalPrice += (Decimal.Parse(row.Cells["Product_Price"].Value.ToString()) * Int32.Parse(row.Cells["product_quantity"].Value.ToString()));
                }
                if (!check && Decimal.Parse(totalBillLbl.Text) <= Decimal.Parse(payTbx.Text))
                {
                    foreach (DataGridViewRow row in productsGrid.Rows)
                    {
                        var product = _productService.GetProduct(Int32.Parse(row.Cells["product_id"].Value.ToString()));
                        product.Stock -= Int32.Parse(row.Cells["product_quantity"].Value.ToString());
                        _productService.UpdateProduct(product);
                    }
                    Sale.ClientId = Int32.Parse(customersCbx.SelectedValue.ToString());
                    Sale.UserId = 1;
                    Sale.TotalAmount = Decimal.Parse(totalBillLbl.Text);
                    Sale.Paid = Decimal.Parse(payTbx.Text.ToString());
                    Sale.Due = Sale.Paid - Sale.TotalAmount;
                    Sale.FinalizedAt = DateTime.Now;
                    _saleService.AddSale(Sale);
                    MessageBox.Show("Success");
                    this.reset();
                }
                else
                {
                    MessageBox.Show("Out of stock / Pay bill");
                }
            }
            else
            {
                MessageBox.Show("Add products");
            }
        }

        private void reset()
        {
            productsGrid.Rows.Clear();
            Sale = new Models.Sale();
            totalBillLbl.Text = "0";
            payTbx.Text = "0";
            discauntTbx.Text = "0";
        }

        private void productsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.totalBill();
        }
        private void totalBill(int discount = 0)
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in productsGrid.Rows)
            {
                totalPrice += (Decimal.Parse(row.Cells["Product_Price"].Value.ToString()) * Int32.Parse(row.Cells["product_quantity"].Value.ToString()));
            }
            totalBillLbl.Text = (totalPrice -= totalPrice * discount / 100).ToString();
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
                    productsGrid.Rows.Add(product.Id, product.Name, product.Price, 1, product.Stock);
                }
            }
            else
            {
                productsGrid.Rows.Add(product.Id, product.Name, product.Price, 1, product.Stock);
            }
        }

        private void discauntTbx_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(discauntTbx.Text.ToString())>=0)
                this.totalBill(Int32.Parse(discauntTbx.Text.ToString()));
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.reset();
        }
    }
}
