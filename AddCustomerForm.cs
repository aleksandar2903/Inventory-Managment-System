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
    public partial class AddCustomerForm : MaterialForm
    {
        private readonly ICustomerService _service;
        public Models.Client Customer { get; set; } = new Models.Client();
        public AddCustomerForm()
        {
            InitializeComponent();
            _service = new CustomerService(new Data.IMS_DataContext());

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
                _service.AddCustomer(Customer);
                MessageBox.Show("Customer created");
                this.reset();
            }
            else
            {
                MessageBox.Show("Something went wrong. Check the form.");
            }
        }

        private void reset()
        {
            customerNameTxb.Clear();
            customerEmailTxb.Clear();
            customerPhoneTxt.Clear();
        }
    }
}
