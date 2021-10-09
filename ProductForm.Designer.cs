
namespace Inventory_Managment_System
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.productDetails = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.totalPurcheses = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.totalSoldLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.purchaseGrid = new System.Windows.Forms.DataGridView();
            this.editProduct = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.deleteProductBtn = new MaterialSkin.Controls.MaterialButton();
            this.productNameTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.productDescriptionTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.productStockTbx = new MaterialSkin.Controls.MaterialTextBox();
            this.productDefectiveStockTbx = new MaterialSkin.Controls.MaterialTextBox();
            this.productPriceTbx = new MaterialSkin.Controls.MaterialTextBox();
            this.productCategoriesBox = new MaterialSkin.Controls.MaterialComboBox();
            this.submitProduct = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.purchase_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provider_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defstock_purchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPurchasesLbl = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.productDetails.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrid)).BeginInit();
            this.editProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.customer,
            this.product_qty,
            this.product_price,
            this.total_amount});
            this.dataGridView1.Location = new System.Drawing.Point(17, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(394, 272);
            this.dataGridView1.TabIndex = 7;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer.HeaderText = "Customer";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // product_qty
            // 
            this.product_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_qty.HeaderText = "Quantity";
            this.product_qty.Name = "product_qty";
            this.product_qty.ReadOnly = true;
            // 
            // product_price
            // 
            this.product_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_price.HeaderText = "Price";
            this.product_price.Name = "product_price";
            this.product_price.ReadOnly = true;
            // 
            // total_amount
            // 
            this.total_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_amount.HeaderText = "Total Amount";
            this.total_amount.Name = "total_amount";
            this.total_amount.ReadOnly = true;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.productDetails);
            this.materialTabControl1.Controls.Add(this.editProduct);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(882, 479);
            this.materialTabControl1.TabIndex = 8;
            // 
            // productDetails
            // 
            this.productDetails.BackColor = System.Drawing.Color.White;
            this.productDetails.Controls.Add(this.materialCard2);
            this.productDetails.Controls.Add(this.materialCard1);
            this.productDetails.Controls.Add(this.purchaseGrid);
            this.productDetails.Controls.Add(this.dataGridView1);
            this.productDetails.ImageKey = "view-details.png";
            this.productDetails.Location = new System.Drawing.Point(4, 39);
            this.productDetails.Name = "productDetails";
            this.productDetails.Padding = new System.Windows.Forms.Padding(3);
            this.productDetails.Size = new System.Drawing.Size(874, 436);
            this.productDetails.TabIndex = 0;
            this.productDetails.Text = "Details";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.totalPurchasesLbl);
            this.materialCard2.Controls.Add(this.totalPurcheses);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(462, 45);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(394, 100);
            this.materialCard2.TabIndex = 19;
            // 
            // totalPurcheses
            // 
            this.totalPurcheses.AutoSize = true;
            this.totalPurcheses.Depth = 0;
            this.totalPurcheses.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.totalPurcheses.Location = new System.Drawing.Point(144, 11);
            this.totalPurcheses.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalPurcheses.Name = "totalPurcheses";
            this.totalPurcheses.Size = new System.Drawing.Size(116, 19);
            this.totalPurcheses.TabIndex = 0;
            this.totalPurcheses.Text = "Total Purchases";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.totalSoldLbl);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 45);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(394, 100);
            this.materialCard1.TabIndex = 18;
            // 
            // totalSoldLbl
            // 
            this.totalSoldLbl.AutoSize = true;
            this.totalSoldLbl.Depth = 0;
            this.totalSoldLbl.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.totalSoldLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.totalSoldLbl.Location = new System.Drawing.Point(161, 41);
            this.totalSoldLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalSoldLbl.Name = "totalSoldLbl";
            this.totalSoldLbl.Size = new System.Drawing.Size(1, 0);
            this.totalSoldLbl.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(135, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Total Sold";
            // 
            // purchaseGrid
            // 
            this.purchaseGrid.AllowUserToAddRows = false;
            this.purchaseGrid.AllowUserToDeleteRows = false;
            this.purchaseGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchase_id,
            this.provider_name,
            this.purchase_date,
            this.purchase_stock,
            this.defstock_purchase});
            this.purchaseGrid.Location = new System.Drawing.Point(462, 162);
            this.purchaseGrid.Name = "purchaseGrid";
            this.purchaseGrid.ReadOnly = true;
            this.purchaseGrid.RowTemplate.Height = 25;
            this.purchaseGrid.Size = new System.Drawing.Size(394, 272);
            this.purchaseGrid.TabIndex = 8;
            // 
            // editProduct
            // 
            this.editProduct.BackColor = System.Drawing.Color.White;
            this.editProduct.Controls.Add(this.materialLabel2);
            this.editProduct.Controls.Add(this.deleteProductBtn);
            this.editProduct.Controls.Add(this.productNameTxb);
            this.editProduct.Controls.Add(this.productDescriptionTxb);
            this.editProduct.Controls.Add(this.productStockTbx);
            this.editProduct.Controls.Add(this.productDefectiveStockTbx);
            this.editProduct.Controls.Add(this.productPriceTbx);
            this.editProduct.Controls.Add(this.productCategoriesBox);
            this.editProduct.Controls.Add(this.submitProduct);
            this.editProduct.ImageKey = "edit.png";
            this.editProduct.Location = new System.Drawing.Point(4, 39);
            this.editProduct.Name = "editProduct";
            this.editProduct.Padding = new System.Windows.Forms.Padding(3);
            this.editProduct.Size = new System.Drawing.Size(874, 436);
            this.editProduct.TabIndex = 1;
            this.editProduct.Text = "Edit";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(19, 37);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(134, 29);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Edit Product";
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteProductBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteProductBtn.Depth = 0;
            this.deleteProductBtn.HighEmphasis = true;
            this.deleteProductBtn.Icon = null;
            this.deleteProductBtn.Location = new System.Drawing.Point(772, 30);
            this.deleteProductBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteProductBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(73, 36);
            this.deleteProductBtn.TabIndex = 16;
            this.deleteProductBtn.Text = "Delete";
            this.deleteProductBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteProductBtn.UseAccentColor = true;
            this.deleteProductBtn.UseVisualStyleBackColor = true;
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // productNameTxb
            // 
            this.productNameTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productNameTxb.Depth = 0;
            this.productNameTxb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productNameTxb.Hint = "Product Name";
            this.productNameTxb.LeadingIcon = null;
            this.productNameTxb.Location = new System.Drawing.Point(18, 108);
            this.productNameTxb.MaxLength = 50;
            this.productNameTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.productNameTxb.Multiline = false;
            this.productNameTxb.Name = "productNameTxb";
            this.productNameTxb.Size = new System.Drawing.Size(370, 50);
            this.productNameTxb.TabIndex = 9;
            this.productNameTxb.Text = "";
            this.productNameTxb.TrailingIcon = null;
            this.productNameTxb.UseAccent = false;
            // 
            // productDescriptionTxb
            // 
            this.productDescriptionTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDescriptionTxb.Depth = 0;
            this.productDescriptionTxb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productDescriptionTxb.Hint = "Product Description";
            this.productDescriptionTxb.LeadingIcon = null;
            this.productDescriptionTxb.Location = new System.Drawing.Point(19, 174);
            this.productDescriptionTxb.MaxLength = 50;
            this.productDescriptionTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.productDescriptionTxb.Multiline = false;
            this.productDescriptionTxb.Name = "productDescriptionTxb";
            this.productDescriptionTxb.Size = new System.Drawing.Size(369, 50);
            this.productDescriptionTxb.TabIndex = 10;
            this.productDescriptionTxb.Text = "";
            this.productDescriptionTxb.TrailingIcon = null;
            this.productDescriptionTxb.UseAccent = false;
            // 
            // productStockTbx
            // 
            this.productStockTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productStockTbx.Depth = 0;
            this.productStockTbx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productStockTbx.Hint = "Stock";
            this.productStockTbx.LeadingIcon = null;
            this.productStockTbx.Location = new System.Drawing.Point(19, 241);
            this.productStockTbx.MaxLength = 50;
            this.productStockTbx.MouseState = MaterialSkin.MouseState.OUT;
            this.productStockTbx.Multiline = false;
            this.productStockTbx.Name = "productStockTbx";
            this.productStockTbx.Size = new System.Drawing.Size(152, 50);
            this.productStockTbx.TabIndex = 11;
            this.productStockTbx.Text = "";
            this.productStockTbx.TrailingIcon = null;
            this.productStockTbx.UseAccent = false;
            // 
            // productDefectiveStockTbx
            // 
            this.productDefectiveStockTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDefectiveStockTbx.Depth = 0;
            this.productDefectiveStockTbx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productDefectiveStockTbx.Hint = "Defective Stock";
            this.productDefectiveStockTbx.LeadingIcon = null;
            this.productDefectiveStockTbx.Location = new System.Drawing.Point(220, 241);
            this.productDefectiveStockTbx.MaxLength = 50;
            this.productDefectiveStockTbx.MouseState = MaterialSkin.MouseState.OUT;
            this.productDefectiveStockTbx.Multiline = false;
            this.productDefectiveStockTbx.Name = "productDefectiveStockTbx";
            this.productDefectiveStockTbx.Size = new System.Drawing.Size(168, 50);
            this.productDefectiveStockTbx.TabIndex = 12;
            this.productDefectiveStockTbx.Text = "";
            this.productDefectiveStockTbx.TrailingIcon = null;
            this.productDefectiveStockTbx.UseAccent = false;
            // 
            // productPriceTbx
            // 
            this.productPriceTbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productPriceTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productPriceTbx.Depth = 0;
            this.productPriceTbx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productPriceTbx.Hint = "Price";
            this.productPriceTbx.LeadingIcon = null;
            this.productPriceTbx.Location = new System.Drawing.Point(483, 108);
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
            this.productCategoriesBox.Location = new System.Drawing.Point(482, 178);
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
            this.submitProduct.Location = new System.Drawing.Point(631, 255);
            this.submitProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitProduct.Name = "submitProduct";
            this.submitProduct.Size = new System.Drawing.Size(75, 36);
            this.submitProduct.TabIndex = 15;
            this.submitProduct.Text = "Submit";
            this.submitProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitProduct.UseAccentColor = false;
            this.submitProduct.UseVisualStyleBackColor = true;
            this.submitProduct.Click += new System.EventHandler(this.submitProduct_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit.png");
            this.imageList1.Images.SetKeyName(1, "view-details.png");
            // 
            // purchase_id
            // 
            this.purchase_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchase_id.HeaderText = "Purchase ID";
            this.purchase_id.Name = "purchase_id";
            this.purchase_id.ReadOnly = true;
            // 
            // provider_name
            // 
            this.provider_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.provider_name.HeaderText = "Provider";
            this.provider_name.Name = "provider_name";
            this.provider_name.ReadOnly = true;
            // 
            // purchase_date
            // 
            this.purchase_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchase_date.HeaderText = "Date";
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.ReadOnly = true;
            // 
            // purchase_stock
            // 
            this.purchase_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchase_stock.HeaderText = "Stock";
            this.purchase_stock.Name = "purchase_stock";
            this.purchase_stock.ReadOnly = true;
            // 
            // defstock_purchase
            // 
            this.defstock_purchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.defstock_purchase.HeaderText = "Defective Stock";
            this.defstock_purchase.Name = "defstock_purchase";
            this.defstock_purchase.ReadOnly = true;
            // 
            // totalPurchasesLbl
            // 
            this.totalPurchasesLbl.AutoSize = true;
            this.totalPurchasesLbl.Depth = 0;
            this.totalPurchasesLbl.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.totalPurchasesLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.totalPurchasesLbl.Location = new System.Drawing.Point(197, 50);
            this.totalPurchasesLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalPurchasesLbl.Name = "totalPurchasesLbl";
            this.totalPurchasesLbl.Size = new System.Drawing.Size(1, 0);
            this.totalPurchasesLbl.TabIndex = 3;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 485);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MinimumSize = new System.Drawing.Size(888, 485);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.productDetails.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrid)).EndInit();
            this.editProduct.ResumeLayout(false);
            this.editProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage productDetails;
        private System.Windows.Forms.TabPage editProduct;
        private System.Windows.Forms.DataGridView purchaseGrid;
        private MaterialSkin.Controls.MaterialTextBox productNameTxb;
        private MaterialSkin.Controls.MaterialTextBox productDescriptionTxb;
        private MaterialSkin.Controls.MaterialTextBox productStockTbx;
        private MaterialSkin.Controls.MaterialTextBox productDefectiveStockTbx;
        private MaterialSkin.Controls.MaterialTextBox productPriceTbx;
        private MaterialSkin.Controls.MaterialComboBox productCategoriesBox;
        private MaterialSkin.Controls.MaterialButton submitProduct;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel totalPurcheses;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel totalSoldLbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton deleteProductBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn provider_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn defstock_purchase;
        private MaterialSkin.Controls.MaterialLabel totalPurchasesLbl;
    }
}