
namespace Inventory_Managment_System
{
    partial class AddProductForm
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.productNameTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.productDescriptionTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.productStockTbx = new MaterialSkin.Controls.MaterialTextBox();
            this.productDefectiveStockTbx = new MaterialSkin.Controls.MaterialTextBox();
            this.productPriceTbx = new MaterialSkin.Controls.MaterialTextBox();
            this.submitProduct = new MaterialSkin.Controls.MaterialButton();
            this.categoriesBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(32, 115);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(163, 29);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "Create Product";
            // 
            // productNameTxb
            // 
            this.productNameTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productNameTxb.Depth = 0;
            this.productNameTxb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productNameTxb.Hint = "Product Name";
            this.productNameTxb.LeadingIcon = null;
            this.productNameTxb.Location = new System.Drawing.Point(31, 186);
            this.productNameTxb.MaxLength = 50;
            this.productNameTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.productNameTxb.Multiline = false;
            this.productNameTxb.Name = "productNameTxb";
            this.productNameTxb.Size = new System.Drawing.Size(370, 50);
            this.productNameTxb.TabIndex = 18;
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
            this.productDescriptionTxb.Location = new System.Drawing.Point(32, 252);
            this.productDescriptionTxb.MaxLength = 50;
            this.productDescriptionTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.productDescriptionTxb.Multiline = false;
            this.productDescriptionTxb.Name = "productDescriptionTxb";
            this.productDescriptionTxb.Size = new System.Drawing.Size(369, 50);
            this.productDescriptionTxb.TabIndex = 19;
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
            this.productStockTbx.Location = new System.Drawing.Point(32, 319);
            this.productStockTbx.MaxLength = 50;
            this.productStockTbx.MouseState = MaterialSkin.MouseState.OUT;
            this.productStockTbx.Multiline = false;
            this.productStockTbx.Name = "productStockTbx";
            this.productStockTbx.Size = new System.Drawing.Size(152, 50);
            this.productStockTbx.TabIndex = 20;
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
            this.productDefectiveStockTbx.Location = new System.Drawing.Point(233, 319);
            this.productDefectiveStockTbx.MaxLength = 50;
            this.productDefectiveStockTbx.MouseState = MaterialSkin.MouseState.OUT;
            this.productDefectiveStockTbx.Multiline = false;
            this.productDefectiveStockTbx.Name = "productDefectiveStockTbx";
            this.productDefectiveStockTbx.Size = new System.Drawing.Size(168, 50);
            this.productDefectiveStockTbx.TabIndex = 21;
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
            this.productPriceTbx.Location = new System.Drawing.Point(496, 186);
            this.productPriceTbx.MaxLength = 50;
            this.productPriceTbx.MouseState = MaterialSkin.MouseState.OUT;
            this.productPriceTbx.Multiline = false;
            this.productPriceTbx.Name = "productPriceTbx";
            this.productPriceTbx.Size = new System.Drawing.Size(362, 50);
            this.productPriceTbx.TabIndex = 22;
            this.productPriceTbx.Text = "";
            this.productPriceTbx.TrailingIcon = null;
            this.productPriceTbx.UseAccent = false;
            // 
            // submitProduct
            // 
            this.submitProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitProduct.Depth = 0;
            this.submitProduct.HighEmphasis = true;
            this.submitProduct.Icon = null;
            this.submitProduct.Location = new System.Drawing.Point(644, 333);
            this.submitProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitProduct.Name = "submitProduct";
            this.submitProduct.Size = new System.Drawing.Size(75, 36);
            this.submitProduct.TabIndex = 24;
            this.submitProduct.Text = "Submit";
            this.submitProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitProduct.UseAccentColor = false;
            this.submitProduct.UseVisualStyleBackColor = true;
            this.submitProduct.Click += new System.EventHandler(this.submitProduct_Click);
            // 
            // categoriesBox
            // 
            this.categoriesBox.AutoResize = false;
            this.categoriesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoriesBox.Depth = 0;
            this.categoriesBox.DisplayMember = "Name";
            this.categoriesBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.categoriesBox.DropDownHeight = 174;
            this.categoriesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriesBox.DropDownWidth = 121;
            this.categoriesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.categoriesBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.categoriesBox.FormattingEnabled = true;
            this.categoriesBox.IntegralHeight = false;
            this.categoriesBox.ItemHeight = 43;
            this.categoriesBox.Location = new System.Drawing.Point(496, 251);
            this.categoriesBox.MaxDropDownItems = 4;
            this.categoriesBox.MouseState = MaterialSkin.MouseState.OUT;
            this.categoriesBox.Name = "categoriesBox";
            this.categoriesBox.Size = new System.Drawing.Size(362, 49);
            this.categoriesBox.StartIndex = 0;
            this.categoriesBox.TabIndex = 26;
            this.categoriesBox.ValueMember = "Id";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 485);
            this.Controls.Add(this.categoriesBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.productNameTxb);
            this.Controls.Add(this.productDescriptionTxb);
            this.Controls.Add(this.productStockTbx);
            this.Controls.Add(this.productDefectiveStockTbx);
            this.Controls.Add(this.productPriceTbx);
            this.Controls.Add(this.submitProduct);
            this.MinimumSize = new System.Drawing.Size(888, 485);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox productNameTxb;
        private MaterialSkin.Controls.MaterialTextBox productDescriptionTxb;
        private MaterialSkin.Controls.MaterialTextBox productStockTbx;
        private MaterialSkin.Controls.MaterialTextBox productDefectiveStockTbx;
        private MaterialSkin.Controls.MaterialTextBox productPriceTbx;
        private MaterialSkin.Controls.MaterialButton submitProduct;
        private MaterialSkin.Controls.MaterialComboBox categoriesBox;
    }
}