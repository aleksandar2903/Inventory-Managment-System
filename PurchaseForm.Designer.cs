
namespace Inventory_Managment_System
{
    partial class PurchaseForm
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
            this.productsCbx = new MaterialSkin.Controls.MaterialComboBox();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.providerCbx = new MaterialSkin.Controls.MaterialComboBox();
            this.submitPurchase = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.clearBtn = new MaterialSkin.Controls.MaterialButton();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_defective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.SuspendLayout();
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
            this.productsCbx.Location = new System.Drawing.Point(20, 240);
            this.productsCbx.MaxDropDownItems = 4;
            this.productsCbx.MouseState = MaterialSkin.MouseState.OUT;
            this.productsCbx.Name = "productsCbx";
            this.productsCbx.Size = new System.Drawing.Size(287, 49);
            this.productsCbx.StartIndex = 0;
            this.productsCbx.TabIndex = 12;
            this.productsCbx.UseAccent = false;
            this.productsCbx.ValueMember = "Id";
            this.productsCbx.SelectedIndexChanged += new System.EventHandler(this.productsCbx_SelectedIndexChanged);
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.name,
            this.price,
            this.stock,
            this.stock_defective});
            this.productsGrid.Location = new System.Drawing.Point(380, 111);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowTemplate.Height = 25;
            this.productsGrid.Size = new System.Drawing.Size(487, 356);
            this.productsGrid.TabIndex = 11;
            // 
            // providerCbx
            // 
            this.providerCbx.AutoResize = false;
            this.providerCbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.providerCbx.Depth = 0;
            this.providerCbx.DisplayMember = "Name";
            this.providerCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.providerCbx.DropDownHeight = 174;
            this.providerCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerCbx.DropDownWidth = 121;
            this.providerCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.providerCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.providerCbx.FormattingEnabled = true;
            this.providerCbx.Hint = "Select Provider";
            this.providerCbx.IntegralHeight = false;
            this.providerCbx.ItemHeight = 43;
            this.providerCbx.Location = new System.Drawing.Point(20, 174);
            this.providerCbx.MaxDropDownItems = 4;
            this.providerCbx.MouseState = MaterialSkin.MouseState.OUT;
            this.providerCbx.Name = "providerCbx";
            this.providerCbx.Size = new System.Drawing.Size(287, 49);
            this.providerCbx.StartIndex = 0;
            this.providerCbx.TabIndex = 10;
            this.providerCbx.UseAccent = false;
            this.providerCbx.ValueMember = "Id";
            // 
            // submitPurchase
            // 
            this.submitPurchase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitPurchase.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitPurchase.Depth = 0;
            this.submitPurchase.HighEmphasis = true;
            this.submitPurchase.Icon = null;
            this.submitPurchase.Location = new System.Drawing.Point(61, 323);
            this.submitPurchase.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitPurchase.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitPurchase.Name = "submitPurchase";
            this.submitPurchase.Size = new System.Drawing.Size(75, 36);
            this.submitPurchase.TabIndex = 9;
            this.submitPurchase.Text = "Submit";
            this.submitPurchase.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitPurchase.UseAccentColor = false;
            this.submitPurchase.UseVisualStyleBackColor = true;
            this.submitPurchase.Click += new System.EventHandler(this.submitPurchase_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Title";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(20, 111);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(287, 50);
            this.materialTextBox1.TabIndex = 13;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearBtn.Depth = 0;
            this.clearBtn.HighEmphasis = true;
            this.clearBtn.Icon = null;
            this.clearBtn.Location = new System.Drawing.Point(176, 323);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(66, 36);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearBtn.UseAccentColor = true;
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "#";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            // 
            // stock_defective
            // 
            this.stock_defective.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_defective.HeaderText = "Defective Stock";
            this.stock_defective.Name = "stock_defective";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 485);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.productsCbx);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.providerCbx);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.submitPurchase);
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox productsCbx;
        private System.Windows.Forms.DataGridView productsGrid;
        private MaterialSkin.Controls.MaterialComboBox providerCbx;
        private MaterialSkin.Controls.MaterialButton submitPurchase;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton clearBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_defective;
    }
}