
namespace Inventory_Managment_System
{
    partial class SaleForm
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
            this.submitSale = new MaterialSkin.Controls.MaterialButton();
            this.customersCbx = new MaterialSkin.Controls.MaterialComboBox();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_On_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsCbx = new MaterialSkin.Controls.MaterialComboBox();
            this.payTbx = new MaterialSkin.Controls.MaterialTextBox();
            this.discauntTbx = new MaterialSkin.Controls.MaterialTextBox();
            this.totalBillLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // submitSale
            // 
            this.submitSale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitSale.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitSale.Depth = 0;
            this.submitSale.HighEmphasis = true;
            this.submitSale.Icon = null;
            this.submitSale.Location = new System.Drawing.Point(51, 391);
            this.submitSale.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitSale.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitSale.Name = "submitSale";
            this.submitSale.Size = new System.Drawing.Size(75, 36);
            this.submitSale.TabIndex = 0;
            this.submitSale.Text = "Submit";
            this.submitSale.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitSale.UseAccentColor = false;
            this.submitSale.UseVisualStyleBackColor = true;
            this.submitSale.Click += new System.EventHandler(this.submitSale_Click);
            // 
            // customersCbx
            // 
            this.customersCbx.AutoResize = false;
            this.customersCbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customersCbx.Depth = 0;
            this.customersCbx.DisplayMember = "Name";
            this.customersCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.customersCbx.DropDownHeight = 174;
            this.customersCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersCbx.DropDownWidth = 121;
            this.customersCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.customersCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customersCbx.FormattingEnabled = true;
            this.customersCbx.Hint = "Select Category";
            this.customersCbx.IntegralHeight = false;
            this.customersCbx.ItemHeight = 43;
            this.customersCbx.Location = new System.Drawing.Point(20, 89);
            this.customersCbx.MaxDropDownItems = 4;
            this.customersCbx.MouseState = MaterialSkin.MouseState.OUT;
            this.customersCbx.Name = "customersCbx";
            this.customersCbx.Size = new System.Drawing.Size(287, 49);
            this.customersCbx.StartIndex = 0;
            this.customersCbx.TabIndex = 1;
            this.customersCbx.UseAccent = false;
            this.customersCbx.ValueMember = "Id";
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.Product_Name,
            this.Product_Price,
            this.product_quantity,
            this.Product_On_Stock});
            this.productsGrid.Location = new System.Drawing.Point(426, 89);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowTemplate.Height = 25;
            this.productsGrid.Size = new System.Drawing.Size(629, 259);
            this.productsGrid.TabIndex = 3;
            this.productsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGrid_CellValueChanged);
            // 
            // product_id
            // 
            this.product_id.HeaderText = "#";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Name.HeaderText = "Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Product_Price
            // 
            this.Product_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Price.HeaderText = "Price";
            this.Product_Price.Name = "Product_Price";
            // 
            // product_quantity
            // 
            this.product_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_quantity.HeaderText = "Quantity";
            this.product_quantity.Name = "product_quantity";
            // 
            // Product_On_Stock
            // 
            this.Product_On_Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_On_Stock.HeaderText = "On Stock (Unit)";
            this.Product_On_Stock.Name = "Product_On_Stock";
            this.Product_On_Stock.ReadOnly = true;
            // 
            // productsCbx
            // 
            this.productsCbx.AutoResize = false;
            this.productsCbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productsCbx.Depth = 0;
            this.productsCbx.DisplayMember = "Name";
            this.productsCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.productsCbx.DropDownHeight = 174;
            this.productsCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productsCbx.DropDownWidth = 121;
            this.productsCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.productsCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.productsCbx.FormattingEnabled = true;
            this.productsCbx.Hint = "Select Product";
            this.productsCbx.IntegralHeight = false;
            this.productsCbx.ItemHeight = 43;
            this.productsCbx.Location = new System.Drawing.Point(20, 155);
            this.productsCbx.MaxDropDownItems = 4;
            this.productsCbx.MouseState = MaterialSkin.MouseState.OUT;
            this.productsCbx.Name = "productsCbx";
            this.productsCbx.Size = new System.Drawing.Size(287, 49);
            this.productsCbx.StartIndex = 0;
            this.productsCbx.TabIndex = 4;
            this.productsCbx.UseAccent = false;
            this.productsCbx.ValueMember = "Id";
            this.productsCbx.SelectedIndexChanged += new System.EventHandler(this.productsCbx_SelectedIndexChanged);
            // 
            // payTbx
            // 
            this.payTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payTbx.Depth = 0;
            this.payTbx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.payTbx.Hint = "Amount";
            this.payTbx.LeadingIcon = null;
            this.payTbx.Location = new System.Drawing.Point(20, 226);
            this.payTbx.MaxLength = 50;
            this.payTbx.MouseState = MaterialSkin.MouseState.OUT;
            this.payTbx.Multiline = false;
            this.payTbx.Name = "payTbx";
            this.payTbx.Size = new System.Drawing.Size(287, 50);
            this.payTbx.TabIndex = 5;
            this.payTbx.Text = "0";
            this.payTbx.TrailingIcon = null;
            this.payTbx.UseAccent = false;
            // 
            // discauntTbx
            // 
            this.discauntTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discauntTbx.Depth = 0;
            this.discauntTbx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.discauntTbx.Hint = "Discount";
            this.discauntTbx.LeadingIcon = null;
            this.discauntTbx.Location = new System.Drawing.Point(20, 298);
            this.discauntTbx.MaxLength = 50;
            this.discauntTbx.MouseState = MaterialSkin.MouseState.OUT;
            this.discauntTbx.Multiline = false;
            this.discauntTbx.Name = "discauntTbx";
            this.discauntTbx.Size = new System.Drawing.Size(287, 50);
            this.discauntTbx.TabIndex = 6;
            this.discauntTbx.Text = "0";
            this.discauntTbx.TrailingIcon = null;
            this.discauntTbx.UseAccent = false;
            this.discauntTbx.TextChanged += new System.EventHandler(this.discauntTbx_TextChanged);
            // 
            // totalBillLbl
            // 
            this.totalBillLbl.AutoSize = true;
            this.totalBillLbl.Depth = 0;
            this.totalBillLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.totalBillLbl.Location = new System.Drawing.Point(695, 402);
            this.totalBillLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalBillLbl.Name = "totalBillLbl";
            this.totalBillLbl.Size = new System.Drawing.Size(10, 19);
            this.totalBillLbl.TabIndex = 7;
            this.totalBillLbl.Text = "0";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(556, 401);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(98, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Total Amount";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(149, 391);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(66, 36);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Clear";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 485);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.totalBillLbl);
            this.Controls.Add(this.discauntTbx);
            this.Controls.Add(this.payTbx);
            this.Controls.Add(this.productsCbx);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.customersCbx);
            this.Controls.Add(this.submitSale);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton submitSale;
        private MaterialSkin.Controls.MaterialComboBox customersCbx;
        private System.Windows.Forms.DataGridView productsGrid;
        private MaterialSkin.Controls.MaterialComboBox productsCbx;
        private MaterialSkin.Controls.MaterialTextBox payTbx;
        private MaterialSkin.Controls.MaterialTextBox discauntTbx;
        private MaterialSkin.Controls.MaterialLabel totalBillLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_On_Stock;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}