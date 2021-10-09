
namespace Inventory_Managment_System
{
    partial class AddProviderForm
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
            this.providerNameTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.providerEmailTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.providerPhoneTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.submitProvider = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(22, 114);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(168, 29);
            this.materialLabel2.TabIndex = 32;
            this.materialLabel2.Text = "Create Provider";
            // 
            // providerNameTxb
            // 
            this.providerNameTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.providerNameTxb.Depth = 0;
            this.providerNameTxb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.providerNameTxb.Hint = "Provider Name";
            this.providerNameTxb.LeadingIcon = null;
            this.providerNameTxb.Location = new System.Drawing.Point(22, 192);
            this.providerNameTxb.MaxLength = 50;
            this.providerNameTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.providerNameTxb.Multiline = false;
            this.providerNameTxb.Name = "providerNameTxb";
            this.providerNameTxb.Size = new System.Drawing.Size(370, 50);
            this.providerNameTxb.TabIndex = 27;
            this.providerNameTxb.Text = "";
            this.providerNameTxb.TrailingIcon = null;
            this.providerNameTxb.UseAccent = false;
            // 
            // providerEmailTxb
            // 
            this.providerEmailTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.providerEmailTxb.Depth = 0;
            this.providerEmailTxb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.providerEmailTxb.Hint = "Email";
            this.providerEmailTxb.LeadingIcon = null;
            this.providerEmailTxb.Location = new System.Drawing.Point(23, 258);
            this.providerEmailTxb.MaxLength = 50;
            this.providerEmailTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.providerEmailTxb.Multiline = false;
            this.providerEmailTxb.Name = "providerEmailTxb";
            this.providerEmailTxb.Size = new System.Drawing.Size(369, 50);
            this.providerEmailTxb.TabIndex = 28;
            this.providerEmailTxb.Text = "";
            this.providerEmailTxb.TrailingIcon = null;
            this.providerEmailTxb.UseAccent = false;
            // 
            // providerPhoneTxt
            // 
            this.providerPhoneTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.providerPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.providerPhoneTxt.Depth = 0;
            this.providerPhoneTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.providerPhoneTxt.Hint = "Phone";
            this.providerPhoneTxt.LeadingIcon = null;
            this.providerPhoneTxt.Location = new System.Drawing.Point(505, 192);
            this.providerPhoneTxt.MaxLength = 50;
            this.providerPhoneTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.providerPhoneTxt.Multiline = false;
            this.providerPhoneTxt.Name = "providerPhoneTxt";
            this.providerPhoneTxt.Size = new System.Drawing.Size(362, 50);
            this.providerPhoneTxt.TabIndex = 29;
            this.providerPhoneTxt.Text = "";
            this.providerPhoneTxt.TrailingIcon = null;
            this.providerPhoneTxt.UseAccent = false;
            // 
            // submitProvider
            // 
            this.submitProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitProvider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitProvider.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitProvider.Depth = 0;
            this.submitProvider.HighEmphasis = true;
            this.submitProvider.Icon = null;
            this.submitProvider.Location = new System.Drawing.Point(653, 272);
            this.submitProvider.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitProvider.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitProvider.Name = "submitProvider";
            this.submitProvider.Size = new System.Drawing.Size(75, 36);
            this.submitProvider.TabIndex = 30;
            this.submitProvider.Text = "Submit";
            this.submitProvider.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitProvider.UseAccentColor = false;
            this.submitProvider.UseVisualStyleBackColor = true;
            this.submitProvider.Click += new System.EventHandler(this.submitProvider_Click);
            // 
            // AddProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 485);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.providerNameTxb);
            this.Controls.Add(this.providerEmailTxb);
            this.Controls.Add(this.providerPhoneTxt);
            this.Controls.Add(this.submitProvider);
            this.Name = "AddProviderForm";
            this.Text = "AddProviderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox providerNameTxb;
        private MaterialSkin.Controls.MaterialTextBox providerEmailTxb;
        private MaterialSkin.Controls.MaterialTextBox providerPhoneTxt;
        private MaterialSkin.Controls.MaterialButton submitProvider;
    }
}