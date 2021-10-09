using Inventory_Managment_System.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class Login : MaterialForm
    {
        private readonly IMS_DataContext _context;
        public Login()
        {
            InitializeComponent();
            _context = new IMS_DataContext();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public string EncodePassword(string originalPassword)
        {
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            return BitConverter.ToString(encodedBytes);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            var user = _context.Users.FirstOrDefault(u => u.Email == textBox1.Text);
            if (user != null)
            {
                if (user.Password == EncodePassword(textBox2.Text))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password is incorrect.");
                }
            }
            else
            {
                MessageBox.Show("User doesn't exist.");
            }
            button1.Enabled = true;
        }
    }
}
