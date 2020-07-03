namespace InventoryManagement
{
    partial class edit_product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_product));
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.lblProductWarrenty = new System.Windows.Forms.Label();
            this.txtProductWarrenty = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(212, 366);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 21);
            this.lblError.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(288, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 36);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.Location = new System.Drawing.Point(35, 402);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(147, 36);
            this.btnEditProduct.TabIndex = 19;
            this.btnEditProduct.Text = "EDIT PRODUCT";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // lblProductWarrenty
            // 
            this.lblProductWarrenty.AutoSize = true;
            this.lblProductWarrenty.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductWarrenty.Location = new System.Drawing.Point(32, 318);
            this.lblProductWarrenty.Name = "lblProductWarrenty";
            this.lblProductWarrenty.Size = new System.Drawing.Size(137, 21);
            this.lblProductWarrenty.TabIndex = 18;
            this.lblProductWarrenty.Text = "Product Warranty";
            // 
            // txtProductWarrenty
            // 
            this.txtProductWarrenty.Location = new System.Drawing.Point(208, 320);
            this.txtProductWarrenty.Multiline = true;
            this.txtProductWarrenty.Name = "txtProductWarrenty";
            this.txtProductWarrenty.Size = new System.Drawing.Size(200, 33);
            this.txtProductWarrenty.TabIndex = 17;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(208, 264);
            this.txtProductQuantity.Multiline = true;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(200, 35);
            this.txtProductQuantity.TabIndex = 12;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(208, 205);
            this.txtProductPrice.Multiline = true;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(200, 35);
            this.txtProductPrice.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(206, 18);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 33);
            this.txtName.TabIndex = 14;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.Location = new System.Drawing.Point(32, 262);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(131, 21);
            this.lblProductQuantity.TabIndex = 7;
            this.lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(32, 203);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(108, 21);
            this.lblProductPrice.TabIndex = 8;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.Location = new System.Drawing.Point(32, 143);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(136, 21);
            this.lblProductCategory.TabIndex = 9;
            this.lblProductCategory.Text = "Product Category";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductBrand.Location = new System.Drawing.Point(32, 80);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(114, 21);
            this.lblProductBrand.TabIndex = 10;
            this.lblProductBrand.Text = "Product Brand";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(32, 15);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(112, 21);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "Product Name";
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(208, 143);
            this.cbCat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(200, 21);
            this.cbCat.TabIndex = 22;
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(206, 79);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(202, 21);
            this.cbBrand.TabIndex = 23;
            // 
            // edit_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.lblProductWarrenty);
            this.Controls.Add(this.txtProductWarrenty);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.lblProductBrand);
            this.Controls.Add(this.lblProductName);
            this.Name = "edit_product";
            this.Size = new System.Drawing.Size(701, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Label lblProductWarrenty;
        private System.Windows.Forms.TextBox txtProductWarrenty;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductName;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.ComboBox cbBrand;
    }
}
