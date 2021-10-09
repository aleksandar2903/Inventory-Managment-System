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
    public partial class ShowSaleForm : MaterialForm
    {
        public Models.Sale Sale { get; set; } = new Models.Sale();
        public ShowSaleForm(Models.Sale sale)
        {
            InitializeComponent();
            Sale = sale;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }

        private void ShowSaleForm_Load(object sender, EventArgs e)
        {
            customerLbl.Text = Sale.Client.Name;
            userLbl.Text = Sale.User.Name;
            totalBillLbl.Text = Sale.TotalAmount.ToString()+ "€";
            this.seedProductGrid();
        }
        private void seedProductGrid()
        {
            productsGrid.Rows.Clear();
            foreach (var product in Sale.SoldProducts)
            {
                int i = productsGrid.Rows.Add();
                productsGrid.Rows[i].Cells["Product_Name"].Value = product.Product.Name;
                productsGrid.Rows[i].Cells["total_amount"].Value = product.TotalAmount;
                productsGrid.Rows[i].Cells["product_quantity"].Value = product.Qty;
                productsGrid.Rows[i].Cells["Product_Price"].Value = product.Price;
            }
        }
    }
}
