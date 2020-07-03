namespace InventoryManagement
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Cyan;
            this.btnInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInventory.BackgroundImage")));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Location = new System.Drawing.Point(0, 0);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(188, 67);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.Cyan;
            this.btnEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmp.BackgroundImage")));
            this.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmp.Location = new System.Drawing.Point(0, 67);
            this.btnEmp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(188, 67);
            this.btnEmp.TabIndex = 1;
            this.btnEmp.Text = "Employees";
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 371);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 67);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.btnInventory);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(188, 444);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Button btnLogout;
    }
}
