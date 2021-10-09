
namespace Inventory_Managment_System
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.productDetails = new System.Windows.Forms.TabPage();
            this.customerPurchases = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.editProduct = new System.Windows.Forms.TabPage();
            this.deleteCustomerBtn = new MaterialSkin.Controls.MaterialButton();
            this.submitCustomer = new MaterialSkin.Controls.MaterialButton();
            this.customerPhoneTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.customerEmailTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.customerNameTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.deleteProductBtn = new MaterialSkin.Controls.MaterialButton();
            this.productPriceTbx = new MaterialSkin.Controls.MaterialTextBox();
            this.productCategoriesBox = new MaterialSkin.Controls.MaterialComboBox();
            this.submitProduct = new MaterialSkin.Controls.MaterialButton();
            this.sale_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.productDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPurchases)).BeginInit();
            this.editProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.productDetails);
            this.materialTabControl1.Controls.Add(this.editProduct);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(882, 479);
            this.materialTabControl1.TabIndex = 9;
            // 
            // productDetails
            // 
            this.productDetails.BackColor = System.Drawing.Color.White;
            this.productDetails.Controls.Add(this.customerPurchases);
            this.productDetails.Controls.Add(this.materialLabel1);
            this.productDetails.ImageKey = "view-details.png";
            this.productDetails.Location = new System.Drawing.Point(4, 24);
            this.productDetails.Name = "productDetails";
            this.productDetails.Padding = new System.Windows.Forms.Padding(3);
            this.productDetails.Size = new System.Drawing.Size(874, 451);
            this.productDetails.TabIndex = 0;
            this.productDetails.Text = "Details";
            // 
            // customerPurchases
            // 
            this.customerPurchases.AllowUserToAddRows = false;
            this.customerPurchases.AllowUserToDeleteRows = false;
            this.customerPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sale_id,
            this.date,
            this.paid,
            this.due});
            this.customerPurchases.Location = new System.Drawing.Point(17, 71);
            this.customerPurchases.Name = "customerPurchases";
            this.customerPurchases.ReadOnly = true;
            this.customerPurchases.RowTemplate.Height = 25;
            this.customerPurchases.Size = new System.Drawing.Size(835, 364);
            this.customerPurchases.TabIndex = 9;
            this.customerPurchases.DoubleClick += new System.EventHandler(this.customerPurchases_DoubleClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(17, 27);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(113, 29);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Purchases";
            // 
            // editProduct
            // 
            this.editProduct.BackColor = System.Drawing.Color.White;
            this.editProduct.Controls.Add(this.deleteCustomerBtn);
            this.editProduct.Controls.Add(this.submitCustomer);
            this.editProduct.Controls.Add(this.customerPhoneTxt);
            this.editProduct.Controls.Add(this.customerEmailTxb);
            this.editProduct.Controls.Add(this.customerNameTxb);
            this.editProduct.Controls.Add(this.materialLabel2);
            this.editProduct.Controls.Add(this.deleteProductBtn);
            this.editProduct.Controls.Add(this.productPriceTbx);
            this.editProduct.Controls.Add(this.productCategoriesBox);
            this.editProduct.Controls.Add(this.submitProduct);
            this.editProduct.ImageKey = "edit.png";
            this.editProduct.Location = new System.Drawing.Point(4, 24);
            this.editProduct.Name = "editProduct";
            this.editProduct.Padding = new System.Windows.Forms.Padding(3);
            this.editProduct.Size = new System.Drawing.Size(874, 451);
            this.editProduct.TabIndex = 1;
            this.editProduct.Text = "Edit";
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCustomerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteCustomerBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteCustomerBtn.Depth = 0;
            this.deleteCustomerBtn.HighEmphasis = true;
            this.deleteCustomerBtn.Icon = null;
            this.deleteCustomerBtn.Location = new System.Drawing.Point(774, 40);
            this.deleteCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteCustomerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(73, 36);
            this.deleteCustomerBtn.TabIndex = 31;
            this.deleteCustomerBtn.Text = "Delete";
            this.deleteCustomerBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteCustomerBtn.UseAccentColor = true;
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // submitCustomer
            // 
            this.submitCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitCustomer.Depth = 0;
            this.submitCustomer.HighEmphasis = true;
            this.submitCustomer.Icon = null;
            this.submitCustomer.Location = new System.Drawing.Point(639, 252);
            this.submitCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitCustomer.Name = "submitCustomer";
            this.submitCustomer.Size = new System.Drawing.Size(75, 36);
            this.submitCustomer.TabIndex = 30;
            this.submitCustomer.Text = "Submit";
            this.submitCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitCustomer.UseAccentColor = false;
            this.submitCustomer.UseVisualStyleBackColor = true;
            this.submitCustomer.Click += new System.EventHandler(this.submitCustomer_Click);
            // 
            // customerPhoneTxt
            // 
            this.customerPhoneTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerPhoneTxt.Depth = 0;
            this.customerPhoneTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerPhoneTxt.Hint = "Phone";
            this.customerPhoneTxt.LeadingIcon = null;
            this.customerPhoneTxt.Location = new System.Drawing.Point(485, 158);
            this.customerPhoneTxt.MaxLength = 50;
            this.customerPhoneTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.customerPhoneTxt.Multiline = false;
            this.customerPhoneTxt.Name = "customerPhoneTxt";
            this.customerPhoneTxt.Size = new System.Drawing.Size(362, 50);
            this.customerPhoneTxt.TabIndex = 29;
            this.customerPhoneTxt.Text = "";
            this.customerPhoneTxt.TrailingIcon = null;
            this.customerPhoneTxt.UseAccent = false;
            // 
            // customerEmailTxb
            // 
            this.customerEmailTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerEmailTxb.Depth = 0;
            this.customerEmailTxb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerEmailTxb.Hint = "Email";
            this.customerEmailTxb.LeadingIcon = null;
            this.customerEmailTxb.Location = new System.Drawing.Point(22, 238);
            this.customerEmailTxb.MaxLength = 50;
            this.customerEmailTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.customerEmailTxb.Multiline = false;
            this.customerEmailTxb.Name = "customerEmailTxb";
            this.customerEmailTxb.Size = new System.Drawing.Size(369, 50);
            this.customerEmailTxb.TabIndex = 28;
            this.customerEmailTxb.Text = "";
            this.customerEmailTxb.TrailingIcon = null;
            this.customerEmailTxb.UseAccent = false;
            // 
            // customerNameTxb
            // 
            this.customerNameTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerNameTxb.Depth = 0;
            this.customerNameTxb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerNameTxb.Hint = "Customer Name";
            this.customerNameTxb.LeadingIcon = null;
            this.customerNameTxb.Location = new System.Drawing.Point(22, 158);
            this.customerNameTxb.MaxLength = 50;
            this.customerNameTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.customerNameTxb.Multiline = false;
            this.customerNameTxb.Name = "customerNameTxb";
            this.customerNameTxb.Size = new System.Drawing.Size(370, 50);
            this.customerNameTxb.TabIndex = 27;
            this.customerNameTxb.Text = "";
            this.customerNameTxb.TrailingIcon = null;
            this.customerNameTxb.UseAccent = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(22, 40);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(154, 29);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Edit Customer";
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteProductBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteProductBtn.Depth = 0;
            this.deleteProductBtn.HighEmphasis = true;
            this.deleteProductBtn.Icon = null;
            this.deleteProductBtn.Location = new System.Drawing.Point(1443, 33);
            this.deleteProductBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteProductBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(73, 36);
            this.deleteProductBtn.TabIndex = 16;
            this.deleteProductBtn.Text = "Delete";
            this.deleteProductBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteProductBtn.UseAccentColor = true;
            this.deleteProductBtn.UseVisualStyleBackColor = true;
            // 
            // productPriceTbx
            // 
            this.productPriceTbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productPriceTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productPriceTbx.Depth = 0;
            this.productPriceTbx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productPriceTbx.Hint = "Price";
            this.productPriceTbx.LeadingIcon = null;
            this.productPriceTbx.Location = new System.Drawing.Point(1154, 111);
            this.productPriceTbx.MaxLength = 50;
            this.productPriceTbx.MouseState = MaterialSkin.MouseState.OUT;
            this.productPriceTbx.Multiline = false;
            this.productPriceTbx.Name = "productPriceTbx";
            this.productPriceTbx.Size = new System.Drawing.Size(362, 50);
            this.productPriceTbx.TabIndex = 13;
            this.productPriceTbx.Text = "";
            this.productPriceTbx.TrailingIcon = null;
            this.productPriceTbx.UseAccent = false;
            // 
            // productCategoriesBox
            // 
            this.productCategoriesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productCategoriesBox.AutoResize = false;
            this.productCategoriesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productCategoriesBox.Depth = 0;
            this.productCategoriesBox.DisplayMember = "Name";
            this.productCategoriesBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.productCategoriesBox.DropDownHeight = 174;
            this.productCategoriesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCategoriesBox.DropDownWidth = 121;
            this.productCategoriesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.productCategoriesBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.productCategoriesBox.FormattingEnabled = true;
            this.productCategoriesBox.IntegralHeight = false;
            this.productCategoriesBox.ItemHeight = 43;
            this.productCategoriesBox.Location = new System.Drawing.Point(1153, 181);
            this.productCategoriesBox.MaxDropDownItems = 4;
            this.productCategoriesBox.MouseState = MaterialSkin.MouseState.OUT;
            this.productCategoriesBox.Name = "productCategoriesBox";
            this.productCategoriesBox.Size = new System.Drawing.Size(363, 49);
            this.productCategoriesBox.StartIndex = 0;
            this.productCategoriesBox.TabIndex = 14;
            this.productCategoriesBox.UseAccent = false;
            this.productCategoriesBox.ValueMember = "Id";
            // 
            // submitProduct
            // 
            this.submitProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitProduct.Depth = 0;
            this.submitProduct.HighEmphasis = true;
            this.submitProduct.Icon = null;
            this.submitProduct.Location = new System.Drawing.Point(1302, 258);
            this.submitProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitProduct.Name = "submitProduct";
            this.submitProduct.Size = new System.Drawing.Size(75, 36);
            this.submitProduct.TabIndex = 15;
            this.submitProduct.Text = "Submit";
            this.submitProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitProduct.UseAccentColor = false;
            this.submitProduct.UseVisualStyleBackColor = true;
            // 
            // sale_id
            // 
            this.sale_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sale_id.DataPropertyName = "sale_id";
            this.sale_id.HeaderText = "Sale Id";
            this.sale_id.Name = "sale_id";
            this.sale_id.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Finalized At";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // paid
            // 
            this.paid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paid.DataPropertyName = "paid";
            this.paid.HeaderText = "Paid";
            this.paid.Name = "paid";
            this.paid.ReadOnly = true;
            // 
            // due
            // 
            this.due.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.due.DataPropertyName = "due";
            this.due.HeaderText = "Due";
            this.due.Name = "due";
            this.due.ReadOnly = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 485);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.Name = "CustomerForm";
            this.ShowInTaskbar = false;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.productDetails.ResumeLayout(false);
            this.productDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPurchases)).EndInit();
            this.editProduct.ResumeLayout(false);
            this.editProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage productDetails;
        private System.Windows.Forms.TabPage editProduct;
        private MaterialSkin.Controls.MaterialButton submitCustomer;
        private MaterialSkin.Controls.MaterialTextBox customerPhoneTxt;
        private MaterialSkin.Controls.MaterialTextBox customerEmailTxb;
        private MaterialSkin.Controls.MaterialTextBox customerNameTxb;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton deleteProductBtn;
        private MaterialSkin.Controls.MaterialTextBox productPriceTbx;
        private MaterialSkin.Controls.MaterialComboBox productCategoriesBox;
        private MaterialSkin.Controls.MaterialButton submitProduct;
        private MaterialSkin.Controls.MaterialButton deleteCustomerBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView customerPurchases;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn due;
    }
}