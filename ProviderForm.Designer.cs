
namespace Inventory_Managment_System
{
    partial class ProviderForm
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
            this.deleteProviderBtn = new MaterialSkin.Controls.MaterialButton();
            this.submitProviderBtn = new MaterialSkin.Controls.MaterialButton();
            this.providerPhoneTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.providerEmailTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.providerNameTxb = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // deleteProviderBtn
            // 
            this.deleteProviderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProviderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteProviderBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteProviderBtn.Depth = 0;
            this.deleteProviderBtn.HighEmphasis = true;
            this.deleteProviderBtn.Icon = null;
            this.deleteProviderBtn.Location = new System.Drawing.Point(784, 118);
            this.deleteProviderBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteProviderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteProviderBtn.Name = "deleteProviderBtn";
            this.deleteProviderBtn.Size = new System.Drawing.Size(73, 36);
            this.deleteProviderBtn.TabIndex = 37;
            this.deleteProviderBtn.Text = "Delete";
            this.deleteProviderBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteProviderBtn.UseAccentColor = true;
            this.deleteProviderBtn.UseVisualStyleBackColor = true;
            this.deleteProviderBtn.Click += new System.EventHandler(this.deleteProviderBtn_Click);
            // 
            // submitProviderBtn
            // 
            this.submitProviderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitProviderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitProviderBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitProviderBtn.Depth = 0;
            this.submitProviderBtn.HighEmphasis = true;
            this.submitProviderBtn.Icon = null;
            this.submitProviderBtn.Location = new System.Drawing.Point(649, 330);
            this.submitProviderBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitProviderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitProviderBtn.Name = "submitProviderBtn";
            this.submitProviderBtn.Size = new System.Drawing.Size(75, 36);
            this.submitProviderBtn.TabIndex = 36;
            this.submitProviderBtn.Text = "Submit";
            this.submitProviderBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitProviderBtn.UseAccentColor = false;
            this.submitProviderBtn.UseVisualStyleBackColor = true;
            this.submitProviderBtn.Click += new System.EventHandler(this.submitProviderBtn_Click);
            // 
            // providerPhoneTxt
            // 
            this.providerPhoneTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.providerPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.providerPhoneTxt.Depth = 0;
            this.providerPhoneTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.providerPhoneTxt.Hint = "Phone";
            this.providerPhoneTxt.LeadingIcon = null;
            this.providerPhoneTxt.Location = new System.Drawing.Point(495, 236);
            this.providerPhoneTxt.MaxLength = 50;
            this.providerPhoneTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.providerPhoneTxt.Multiline = false;
            this.providerPhoneTxt.Name = "providerPhoneTxt";
            this.providerPhoneTxt.Size = new System.Drawing.Size(362, 50);
            this.providerPhoneTxt.TabIndex = 35;
            this.providerPhoneTxt.Text = "";
            this.providerPhoneTxt.TrailingIcon = null;
            this.providerPhoneTxt.UseAccent = false;
            // 
            // providerEmailTxb
            // 
            this.providerEmailTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.providerEmailTxb.Depth = 0;
            this.providerEmailTxb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.providerEmailTxb.Hint = "Email";
            this.providerEmailTxb.LeadingIcon = null;
            this.providerEmailTxb.Location = new System.Drawing.Point(32, 316);
            this.providerEmailTxb.MaxLength = 50;
            this.providerEmailTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.providerEmailTxb.Multiline = false;
            this.providerEmailTxb.Name = "providerEmailTxb";
            this.providerEmailTxb.Size = new System.Drawing.Size(369, 50);
            this.providerEmailTxb.TabIndex = 34;
            this.providerEmailTxb.Text = "";
            this.providerEmailTxb.TrailingIcon = null;
            this.providerEmailTxb.UseAccent = false;
            // 
            // providerNameTxb
            // 
            this.providerNameTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.providerNameTxb.Depth = 0;
            this.providerNameTxb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.providerNameTxb.Hint = "Provider Name";
            this.providerNameTxb.LeadingIcon = null;
            this.providerNameTxb.Location = new System.Drawing.Point(32, 236);
            this.providerNameTxb.MaxLength = 50;
            this.providerNameTxb.MouseState = MaterialSkin.MouseState.OUT;
            this.providerNameTxb.Multiline = false;
            this.providerNameTxb.Name = "providerNameTxb";
            this.providerNameTxb.Size = new System.Drawing.Size(370, 50);
            this.providerNameTxb.TabIndex = 33;
            this.providerNameTxb.Text = "";
            this.providerNameTxb.TrailingIcon = null;
            this.providerNameTxb.UseAccent = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(32, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(139, 29);
            this.materialLabel2.TabIndex = 32;
            this.materialLabel2.Text = "Edit Provider";
            // 
            // ProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 485);
            this.Controls.Add(this.deleteProviderBtn);
            this.Controls.Add(this.submitProviderBtn);
            this.Controls.Add(this.providerPhoneTxt);
            this.Controls.Add(this.providerEmailTxb);
            this.Controls.Add(this.providerNameTxb);
            this.Controls.Add(this.materialLabel2);
            this.Name = "ProviderForm";
            this.Text = "ProviderForm";
            this.Load += new System.EventHandler(this.ProviderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton deleteProviderBtn;
        private MaterialSkin.Controls.MaterialButton submitProviderBtn;
        private MaterialSkin.Controls.MaterialTextBox providerPhoneTxt;
        private MaterialSkin.Controls.MaterialTextBox providerEmailTxb;
        private MaterialSkin.Controls.MaterialTextBox providerNameTxb;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}