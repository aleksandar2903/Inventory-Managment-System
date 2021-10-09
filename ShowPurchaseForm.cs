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
    public partial class ShowPurchaseForm : MaterialForm
    {
        public Models.Receipt Purchase { get; set; } = new Models.Receipt();
        public ShowPurchaseForm(Models.Receipt purchase)
        {
            InitializeComponent();
            Purchase = purchase;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }
        private void ShowPurchaseForm_Load(object sender, EventArgs e)
        {
            providerLbl.Text = Purchase.Provider.Name;
            userLbl.Text = Purchase.User.Name;
            this.seedProductGrid();
        }
        private void seedProductGrid()
        {
            productsGrid.Rows.Clear();
            foreach (var product in Purchase.ReceivedProducts)
            {
                int i = productsGrid.Rows.Add();
                productsGrid.Rows[i].Cells["Product_Name"].Value = product.Product.Name;
                productsGrid.Rows[i].Cells["stock"].Value = product.Stock;
                productsGrid.Rows[i].Cells["defective_stock"].Value = product.StockDefective;
            }
        }
    }
}
