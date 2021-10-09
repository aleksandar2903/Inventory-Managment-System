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
    public partial class CustomerForm : MaterialForm
    {
        private readonly ICustomerService _service;
        private readonly ISaleService _saleService;
        public Models.Client Customer { get; set; } = new Models.Client();
        public CustomerForm(Models.Client customer)
        {
            InitializeComponent();

            _service = new Services.CustomerService(new IMS_DataContext());
            _saleService = new Services.SaleService(new IMS_DataContext());
            Customer = customer;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }

        private void submitCustomer_Click(object sender, EventArgs e)
        {
            if (customerNameTxb.Text != "" && customerEmailTxb.Text != "" && customerPhoneTxt.Text != "")
            {
                Customer.Name = customerNameTxb.Text;
                Customer.Email = customerEmailTxb.Text;
                Customer.Phone = customerPhoneTxt.Text;
                Customer.CreatedAt = DateTime.Now;
                _service.UpdateCustomer(Customer);
                MessageBox.Show("Customer updated");
            }
            else
            {
                MessageBox.Show("Something went wrong. Check the form.");
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            customerNameTxb.Text = Customer.Name;
            customerEmailTxb.Text = Customer.Email;
            customerPhoneTxt.Text = Customer.Phone;


            foreach (var sold in Customer.Sales)
            {
                int i = customerPurchases.Rows.Add();
                customerPurchases.Rows[i].Cells["date"].Value = sold.FinalizedAt;
                customerPurchases.Rows[i].Cells["sale_id"].Value = sold.Id;
                customerPurchases.Rows[i].Cells["paid"].Value = sold.Paid;
                customerPurchases.Rows[i].Cells["due"].Value = sold.Due;
            }
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            _service.DeleteCustomer(Customer.Id);
            this.Close();
        }

        private void customerPurchases_DoubleClick(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(customerPurchases.CurrentRow.Cells[0].Value);
            var sale = _saleService.GetSale(Id);
            using (ShowSaleForm saleForm = new ShowSaleForm(sale))
            {
                this.Enabled = false;
                this.Visible = false;
                if (saleForm.ShowDialog() == DialogResult.Cancel || saleForm.ShowDialog() == DialogResult.OK)
                {
                    this.Enabled = true;
                    this.Visible = true;
                }
            }
        }
    }
}
