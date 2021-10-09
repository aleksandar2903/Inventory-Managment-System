
namespace Inventory_Managment_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.formTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.productsTab = new System.Windows.Forms.TabPage();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_On_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createProductBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.salesTab = new System.Windows.Forms.TabPage();
            this.salesGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalized_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createSaleBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.purchasesTab = new System.Windows.Forms.TabPage();
            this.purchasesGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createPurchaseBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createCustomerBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.providersGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createProviderBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.categoriesTab = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.button3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sale_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formTabs.SuspendLayout();
            this.productsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.salesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).BeginInit();
            this.purchasesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGrid)).BeginInit();
            this.customersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersGrid)).BeginInit();
            this.categoriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // formTabs
            // 
            this.formTabs.Controls.Add(this.productsTab);
            this.formTabs.Controls.Add(this.salesTab);
            this.formTabs.Controls.Add(this.purchasesTab);
            this.formTabs.Controls.Add(this.customersTab);
            this.formTabs.Controls.Add(this.tabPage1);
            this.formTabs.Controls.Add(this.categoriesTab);
            this.formTabs.Depth = 0;
            this.formTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTabs.ImageList = this.imageList1;
            this.formTabs.Location = new System.Drawing.Point(3, 3);
            this.formTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.formTabs.Multiline = true;
            this.formTabs.Name = "formTabs";
            this.formTabs.SelectedIndex = 0;
            this.formTabs.Size = new System.Drawing.Size(882, 479);
            this.formTabs.TabIndex = 6;
            this.formTabs.Enter += new System.EventHandler(this.formTabs_Enter);
            // 
            // productsTab
            // 
            this.productsTab.BackColor = System.Drawing.Color.White;
            this.productsTab.Controls.Add(this.productsGrid);
            this.productsTab.Controls.Add(this.createProductBtn);
            this.productsTab.Controls.Add(this.materialLabel1);
            this.productsTab.ImageKey = "inventory (1).png";
            this.productsTab.Location = new System.Drawing.Point(4, 39);
            this.productsTab.Name = "productsTab";
            this.productsTab.Padding = new System.Windows.Forms.Padding(3);
            this.productsTab.Size = new System.Drawing.Size(874, 436);
            this.productsTab.TabIndex = 1;
            this.productsTab.Text = "Products";
            this.productsTab.Enter += new System.EventHandler(this.productsTab_Enter);
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.AllowUserToDeleteRows = false;
            this.productsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Id,
            this.Product_Name,
            this.Product_Category,
            this.Product_Price,
            this.Product_On_Stock});
            this.productsGrid.Location = new System.Drawing.Point(14, 60);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.ReadOnly = true;
            this.productsGrid.RowTemplate.Height = 25;
            this.productsGrid.Size = new System.Drawing.Size(846, 359);
            this.productsGrid.TabIndex = 3;
            this.productsGrid.DoubleClick += new System.EventHandler(this.productsGrid_DoubleClick);
            // 
            // Product_Id
            // 
            this.Product_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Id.DataPropertyName = "Id";
            this.Product_Id.HeaderText = "#";
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Name.DataPropertyName = "Name";
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Product_Category
            // 
            this.Product_Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Category.HeaderText = "Product Category";
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.ReadOnly = true;
            // 
            // Product_Price
            // 
            this.Product_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Price.HeaderText = "Price";
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.ReadOnly = true;
            // 
            // Product_On_Stock
            // 
            this.Product_On_Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_On_Stock.HeaderText = "Stock";
            this.Product_On_Stock.Name = "Product_On_Stock";
            this.Product_On_Stock.ReadOnly = true;
            // 
            // createProductBtn
            // 
            this.createProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createProductBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createProductBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createProductBtn.Depth = 0;
            this.createProductBtn.HighEmphasis = true;
            this.createProductBtn.Icon = null;
            this.createProductBtn.Location = new System.Drawing.Point(784, 10);
            this.createProductBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createProductBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createProductBtn.Name = "createProductBtn";
            this.createProductBtn.Size = new System.Drawing.Size(76, 36);
            this.createProductBtn.TabIndex = 2;
            this.createProductBtn.Text = "Create";
            this.createProductBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createProductBtn.UseAccentColor = false;
            this.createProductBtn.UseVisualStyleBackColor = true;
            this.createProductBtn.Click += new System.EventHandler(this.createProductButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(14, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(98, 29);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Products";
            // 
            // salesTab
            // 
            this.salesTab.BackColor = System.Drawing.Color.White;
            this.salesTab.Controls.Add(this.salesGrid);
            this.salesTab.Controls.Add(this.createSaleBtn);
            this.salesTab.Controls.Add(this.materialLabel5);
            this.salesTab.ForeColor = System.Drawing.Color.Black;
            this.salesTab.ImageKey = "shopping-cart.png";
            this.salesTab.Location = new System.Drawing.Point(4, 39);
            this.salesTab.Name = "salesTab";
            this.salesTab.Padding = new System.Windows.Forms.Padding(3);
            this.salesTab.Size = new System.Drawing.Size(874, 436);
            this.salesTab.TabIndex = 0;
            this.salesTab.Text = "Sales";
            this.salesTab.Enter += new System.EventHandler(this.salesTab_Enter);
            // 
            // salesGrid
            // 
            this.salesGrid.AllowUserToAddRows = false;
            this.salesGrid.AllowUserToDeleteRows = false;
            this.salesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Finalized_at});
            this.salesGrid.Location = new System.Drawing.Point(14, 64);
            this.salesGrid.Name = "salesGrid";
            this.salesGrid.ReadOnly = true;
            this.salesGrid.RowTemplate.Height = 25;
            this.salesGrid.Size = new System.Drawing.Size(846, 359);
            this.salesGrid.TabIndex = 6;
            this.salesGrid.DoubleClick += new System.EventHandler(this.salesGrid_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Paid";
            this.dataGridViewTextBoxColumn2.HeaderText = "Paid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Due";
            this.dataGridViewTextBoxColumn3.HeaderText = "Due";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Finalized_at
            // 
            this.Finalized_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Finalized_at.DataPropertyName = "FinalizedAt";
            this.Finalized_at.HeaderText = "Finalized at";
            this.Finalized_at.Name = "Finalized_at";
            this.Finalized_at.ReadOnly = true;
            // 
            // createSaleBtn
            // 
            this.createSaleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createSaleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createSaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createSaleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createSaleBtn.Depth = 0;
            this.createSaleBtn.HighEmphasis = true;
            this.createSaleBtn.Icon = null;
            this.createSaleBtn.Location = new System.Drawing.Point(784, 14);
            this.createSaleBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createSaleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createSaleBtn.Name = "createSaleBtn";
            this.createSaleBtn.Size = new System.Drawing.Size(76, 36);
            this.createSaleBtn.TabIndex = 5;
            this.createSaleBtn.Text = "Create";
            this.createSaleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createSaleBtn.UseAccentColor = false;
            this.createSaleBtn.UseVisualStyleBackColor = true;
            this.createSaleBtn.Click += new System.EventHandler(this.createSaleBtn_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel5.Location = new System.Drawing.Point(14, 21);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(59, 29);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Sales";
            // 
            // purchasesTab
            // 
            this.purchasesTab.BackColor = System.Drawing.Color.White;
            this.purchasesTab.Controls.Add(this.purchasesGrid);
            this.purchasesTab.Controls.Add(this.createPurchaseBtn);
            this.purchasesTab.Controls.Add(this.materialLabel4);
            this.purchasesTab.ImageKey = "shopping-bag.png";
            this.purchasesTab.Location = new System.Drawing.Point(4, 39);
            this.purchasesTab.Name = "purchasesTab";
            this.purchasesTab.Size = new System.Drawing.Size(874, 436);
            this.purchasesTab.TabIndex = 4;
            this.purchasesTab.Text = "Purchases";
            this.purchasesTab.Enter += new System.EventHandler(this.purchasesTab_Enter);
            // 
            // purchasesGrid
            // 
            this.purchasesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.title,
            this.dataGridViewTextBoxColumn5});
            this.purchasesGrid.Location = new System.Drawing.Point(14, 64);
            this.purchasesGrid.Name = "purchasesGrid";
            this.purchasesGrid.RowTemplate.Height = 25;
            this.purchasesGrid.Size = new System.Drawing.Size(846, 359);
            this.purchasesGrid.TabIndex = 6;
            this.purchasesGrid.DoubleClick += new System.EventHandler(this.purchasesGrid_DoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "#";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FinalizedAt";
            this.dataGridViewTextBoxColumn5.HeaderText = "Finalized at";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // createPurchaseBtn
            // 
            this.createPurchaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createPurchaseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createPurchaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPurchaseBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createPurchaseBtn.Depth = 0;
            this.createPurchaseBtn.HighEmphasis = true;
            this.createPurchaseBtn.Icon = null;
            this.createPurchaseBtn.Location = new System.Drawing.Point(784, 14);
            this.createPurchaseBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createPurchaseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createPurchaseBtn.Name = "createPurchaseBtn";
            this.createPurchaseBtn.Size = new System.Drawing.Size(76, 36);
            this.createPurchaseBtn.TabIndex = 5;
            this.createPurchaseBtn.Text = "Create";
            this.createPurchaseBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createPurchaseBtn.UseAccentColor = false;
            this.createPurchaseBtn.UseVisualStyleBackColor = true;
            this.createPurchaseBtn.Click += new System.EventHandler(this.createPurchaseBtn_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(14, 21);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(113, 29);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Purchases";
            // 
            // customersTab
            // 
            this.customersTab.BackColor = System.Drawing.Color.White;
            this.customersTab.Controls.Add(this.customersGrid);
            this.customersTab.Controls.Add(this.createCustomerBtn);
            this.customersTab.Controls.Add(this.materialLabel3);
            this.customersTab.ImageKey = "hand-shake.png";
            this.customersTab.Location = new System.Drawing.Point(4, 39);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(874, 436);
            this.customersTab.TabIndex = 3;
            this.customersTab.Text = "Customers";
            this.customersTab.Enter += new System.EventHandler(this.customersTab_Enter);
            // 
            // customersGrid
            // 
            this.customersGrid.AllowUserToAddRows = false;
            this.customersGrid.AllowUserToDeleteRows = false;
            this.customersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.name,
            this.email,
            this.phone});
            this.customersGrid.Location = new System.Drawing.Point(14, 64);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.ReadOnly = true;
            this.customersGrid.RowTemplate.Height = 25;
            this.customersGrid.Size = new System.Drawing.Size(846, 359);
            this.customersGrid.TabIndex = 6;
            this.customersGrid.DoubleClick += new System.EventHandler(this.customersGrid_DoubleClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "#";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.DataPropertyName = "Phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // createCustomerBtn
            // 
            this.createCustomerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createCustomerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCustomerBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createCustomerBtn.Depth = 0;
            this.createCustomerBtn.HighEmphasis = true;
            this.createCustomerBtn.Icon = null;
            this.createCustomerBtn.Location = new System.Drawing.Point(784, 14);
            this.createCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createCustomerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createCustomerBtn.Name = "createCustomerBtn";
            this.createCustomerBtn.Size = new System.Drawing.Size(76, 36);
            this.createCustomerBtn.TabIndex = 5;
            this.createCustomerBtn.Text = "Create";
            this.createCustomerBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createCustomerBtn.UseAccentColor = false;
            this.createCustomerBtn.UseVisualStyleBackColor = true;
            this.createCustomerBtn.Click += new System.EventHandler(this.createCustomerBtn_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(14, 21);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(118, 29);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Customers";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.providersGrid);
            this.tabPage1.Controls.Add(this.createProviderBtn);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.ImageKey = "delivery-truck.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 436);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Providers";
            // 
            // providersGrid
            // 
            this.providersGrid.AllowUserToAddRows = false;
            this.providersGrid.AllowUserToDeleteRows = false;
            this.providersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.providersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.providersGrid.Location = new System.Drawing.Point(14, 57);
            this.providersGrid.Name = "providersGrid";
            this.providersGrid.ReadOnly = true;
            this.providersGrid.RowTemplate.Height = 25;
            this.providersGrid.Size = new System.Drawing.Size(846, 359);
            this.providersGrid.TabIndex = 9;
            this.providersGrid.DoubleClick += new System.EventHandler(this.providersGrid_DoubleClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "#";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn9.HeaderText = "Email";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn10.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CreatedAt";
            this.dataGridViewTextBoxColumn11.HeaderText = "Created at";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // createProviderBtn
            // 
            this.createProviderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createProviderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createProviderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createProviderBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createProviderBtn.Depth = 0;
            this.createProviderBtn.HighEmphasis = true;
            this.createProviderBtn.Icon = null;
            this.createProviderBtn.Location = new System.Drawing.Point(784, 7);
            this.createProviderBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createProviderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createProviderBtn.Name = "createProviderBtn";
            this.createProviderBtn.Size = new System.Drawing.Size(76, 36);
            this.createProviderBtn.TabIndex = 8;
            this.createProviderBtn.Text = "Create";
            this.createProviderBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createProviderBtn.UseAccentColor = false;
            this.createProviderBtn.UseVisualStyleBackColor = true;
            this.createProviderBtn.Click += new System.EventHandler(this.createProviderBtn_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.Location = new System.Drawing.Point(14, 14);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(103, 29);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "Providers";
            // 
            // categoriesTab
            // 
            this.categoriesTab.BackColor = System.Drawing.Color.White;
            this.categoriesTab.Controls.Add(this.materialLabel2);
            this.categoriesTab.Controls.Add(this.button1);
            this.categoriesTab.Controls.Add(this.button3);
            this.categoriesTab.Controls.Add(this.materialButton3);
            this.categoriesTab.Controls.Add(this.textBox1);
            this.categoriesTab.Controls.Add(this.dataGridView1);
            this.categoriesTab.ImageKey = "choose.png";
            this.categoriesTab.Location = new System.Drawing.Point(4, 39);
            this.categoriesTab.Name = "categoriesTab";
            this.categoriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesTab.Size = new System.Drawing.Size(874, 436);
            this.categoriesTab.TabIndex = 2;
            this.categoriesTab.Text = "Categories";
            this.categoriesTab.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(19, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 29);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Categories";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button1.Depth = 0;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(310, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button3.Depth = 0;
            this.button3.Enabled = false;
            this.button3.HighEmphasis = true;
            this.button3.Icon = null;
            this.button3.Location = new System.Drawing.Point(782, 64);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button3.MouseState = MaterialSkin.MouseState.HOVER;
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button3.UseAccentColor = true;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(403, 64);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(66, 36);
            this.materialButton3.TabIndex = 9;
            this.materialButton3.Text = "Clear";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Depth = 0;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Hint = "Category Name";
            this.textBox1.LeadingIcon = null;
            this.textBox1.Location = new System.Drawing.Point(17, 50);
            this.textBox1.MaxLength = 50;
            this.textBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 50);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "";
            this.textBox1.TrailingIcon = null;
            this.textBox1.UseAccent = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Category_Name,
            this.Created_at});
            this.dataGridView1.Location = new System.Drawing.Point(17, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(838, 303);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Category_Name
            // 
            this.Category_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category_Name.DataPropertyName = "Name";
            this.Category_Name.HeaderText = "Category Name";
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.ReadOnly = true;
            // 
            // Created_at
            // 
            this.Created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Created_at.DataPropertyName = "CreatedAt";
            this.Created_at.HeaderText = "Created at";
            this.Created_at.Name = "Created_at";
            this.Created_at.ReadOnly = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "shopping-cart.png");
            this.imageList1.Images.SetKeyName(1, "inventory (1).png");
            this.imageList1.Images.SetKeyName(2, "hand-shake.png");
            this.imageList1.Images.SetKeyName(3, "shopping-bag.png");
            this.imageList1.Images.SetKeyName(4, "choose.png");
            this.imageList1.Images.SetKeyName(5, "delivery-truck.png");
            // 
            // sale_id
            // 
            this.sale_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sale_id.DataPropertyName = "Id";
            this.sale_id.HeaderText = "#";
            this.sale_id.Name = "sale_id";
            // 
            // paid
            // 
            this.paid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paid.DataPropertyName = "Paid";
            this.paid.HeaderText = "Paid";
            this.paid.Name = "paid";
            // 
            // due
            // 
            this.due.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.due.DataPropertyName = "Due";
            this.due.HeaderText = "Due";
            this.due.Name = "due";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 485);
            this.Controls.Add(this.formTabs);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.formTabs;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formTabs.ResumeLayout(false);
            this.productsTab.ResumeLayout(false);
            this.productsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.salesTab.ResumeLayout(false);
            this.salesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).EndInit();
            this.purchasesTab.ResumeLayout(false);
            this.purchasesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGrid)).EndInit();
            this.customersTab.ResumeLayout(false);
            this.customersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersGrid)).EndInit();
            this.categoriesTab.ResumeLayout(false);
            this.categoriesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl formTabs;
        private System.Windows.Forms.TabPage productsTab;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton createProductBtn;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.TabPage categoriesTab;
        private System.Windows.Forms.TabPage salesTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_at;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialButton button3;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialTextBox textBox1;
        private System.Windows.Forms.TabPage purchasesTab;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.DataGridView salesGrid;
        private MaterialSkin.Controls.MaterialButton createSaleBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView purchasesGrid;
        private MaterialSkin.Controls.MaterialButton createPurchaseBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DataGridView customersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private MaterialSkin.Controls.MaterialButton createCustomerBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView providersGrid;
        private MaterialSkin.Controls.MaterialButton createProviderBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finalized_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn due;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_On_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

