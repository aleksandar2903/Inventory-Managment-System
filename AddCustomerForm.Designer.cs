
namespace Inventory_Managment_System
{
    partial class AddCustomerForm
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
            this.customerNameTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.customerEmailTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.customerPhoneTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.submitCustomer = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(23, 109);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(183, 29);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Create Customer";
            // 
            // customerNameTxb
            // 
            this.customerNameTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerNameTxb.Depth = 0;
            this.customerNameTxb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerNameTxb.Hint = "Customer Name";
            this.customerNameTxb.LeadingIcon = null;
            this.customerNameTxb.Location = new System.Drawing.Point(22, 180);
            this.customerNameTxb.MaxLength = 50;
            this.customerNameTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.customerNameTxb.Multiline = false;
            this.customerNameTxb.Name = "customerNameTxb";
            this.customerNameTxb.Size = new System.Drawing.Size(370, 50);
            this.customerNameTxb.TabIndex = 18;
            this.customerNameTxb.Text = "";
            this.customerNameTxb.TrailingIcon = null;
            this.customerNameTxb.UseAccent = false;
            // 
            // customerEmailTxb
            // 
            this.customerEmailTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerEmailTxb.Depth = 0;
            this.customerEmailTxb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerEmailTxb.Hint = "Email";
            this.customerEmailTxb.LeadingIcon = null;
            this.customerEmailTxb.Location = new System.Drawing.Point(23, 246);
            this.customerEmailTxb.MaxLength = 50;
            this.customerEmailTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.customerEmailTxb.Multiline = false;
            this.customerEmailTxb.Name = "customerEmailTxb";
            this.customerEmailTxb.Size = new System.Drawing.Size(369, 50);
            this.customerEmailTxb.TabIndex = 19;
            this.customerEmailTxb.Text = "";
            this.customerEmailTxb.TrailingIcon = null;
            this.customerEmailTxb.UseAccent = false;
            // 
            // customerPhoneTxt
            // 
            this.customerPhoneTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerPhoneTxt.Depth = 0;
            this.customerPhoneTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerPhoneTxt.Hint = "Phone";
            this.customerPhoneTxt.LeadingIcon = null;
            this.customerPhoneTxt.Location = new System.Drawing.Point(505, 180);
            this.customerPhoneTxt.MaxLength = 50;
            this.customerPhoneTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.customerPhoneTxt.Multiline = false;
            this.customerPhoneTxt.Name = "customerPhoneTxt";
            this.customerPhoneTxt.Size = new System.Drawing.Size(362, 50);
            this.customerPhoneTxt.TabIndex = 22;
            this.customerPhoneTxt.Text = "";
            this.customerPhoneTxt.TrailingIcon = null;
            this.customerPhoneTxt.UseAccent = false;
            // 
            // submitCustomer
            // 
            this.submitCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitCustomer.Depth = 0;
            this.submitCustomer.HighEmphasis = true;
            this.submitCustomer.Icon = null;
            this.submitCustomer.Location = new System.Drawing.Point(653, 260);
            this.submitCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitCustomer.Name = "submitCustomer";
            this.submitCustomer.Size = new System.Drawing.Size(75, 36);
            this.submitCustomer.TabIndex = 24;
            this.submitCustomer.Text = "Submit";
            this.submitCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitCustomer.UseAccentColor = false;
            this.submitCustomer.UseVisualStyleBackColor = true;
            this.submitCustomer.Click += new System.EventHandler(this.submitCustomer_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 485);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.customerNameTxb);
            this.Controls.Add(this.customerEmailTxb);
            this.Controls.Add(this.customerPhoneTxt);
            this.Controls.Add(this.submitCustomer);
            this.Name = "AddCustomerForm";
            this.Text = "Create Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox customerNameTxb;
        private MaterialSkin.Controls.MaterialTextBox customerEmailTxb;
        private MaterialSkin.Controls.MaterialTextBox customerPhoneTxt;
        private MaterialSkin.Controls.MaterialButton submitCustomer;
    }
}