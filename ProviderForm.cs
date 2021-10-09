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
    public partial class ProviderForm : MaterialForm
    {
        private readonly IProviderService _service;
        public Models.Provider Provider { get; set; } = new Models.Provider();
        public ProviderForm(Models.Provider provider)
        {
            InitializeComponent();

            _service = new Services.ProviderService(new IMS_DataContext());
            Provider = provider;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }

        private void submitProviderBtn_Click(object sender, EventArgs e)
        {
            if (providerNameTxb.Text != "" && providerEmailTxb.Text != "" && providerPhoneTxt.Text != "")
            {
                Provider.Name = providerNameTxb.Text;
                Provider.Email = providerEmailTxb.Text;
                Provider.Phone = providerPhoneTxt.Text;
                Provider.CreatedAt = DateTime.Now;
                _service.UpdateProvider(Provider);
                MessageBox.Show("Provider updated");
            }
            else
            {
                MessageBox.Show("Something went wrong. Check the form.");
            }
        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            providerNameTxb.Text = Provider.Name;
            providerEmailTxb.Text = Provider.Email;
            providerPhoneTxt.Text = Provider.Phone;
        }

        private void deleteProviderBtn_Click(object sender, EventArgs e)
        {
            _service.DeleteProvider(Provider.Id);
            this.Close();
        }
    }
}
