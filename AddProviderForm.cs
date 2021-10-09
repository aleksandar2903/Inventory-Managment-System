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
    public partial class AddProviderForm : MaterialForm
    {
        private readonly IProviderService _service;
        public Models.Provider Provider { get; set; } = new Models.Provider();
        public AddProviderForm()
        {
            InitializeComponent();
            _service = new ProviderService(new Data.IMS_DataContext());

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }

        private void submitProvider_Click(object sender, EventArgs e)
        {
            Provider.Name = providerNameTxb.Text;
            Provider.Email = providerEmailTxb.Text;
            Provider.Phone = providerPhoneTxt.Text;
            Provider.CreatedAt = DateTime.Now;
            _service.AddProvider(Provider);
            this.reset();
        }
        private void reset()
        {
            Provider = new Models.Provider();
            providerPhoneTxt.Text = null;
            providerEmailTxb.Text = null;
            providerNameTxb.Text = null;
        }
    }
}
