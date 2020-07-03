namespace InventoryManagement
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.gvEmp = new System.Windows.Forms.DataGridView();
            this.lblEmpList = new System.Windows.Forms.Label();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnDelEmp = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRefreshEmp = new System.Windows.Forms.Button();
            this.lblErrorEmp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // gvEmp
            // 
            this.gvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmp.Location = new System.Drawing.Point(0, 29);
            this.gvEmp.Name = "gvEmp";
            this.gvEmp.Size = new System.Drawing.Size(377, 425);
            this.gvEmp.TabIndex = 1;
            this.gvEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEmp_CellContentClick);
            // 
            // lblEmpList
            // 
            this.lblEmpList.AutoSize = true;
            this.lblEmpList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpList.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpList.Location = new System.Drawing.Point(3, 5);
            this.lblEmpList.Name = "lblEmpList";
            this.lblEmpList.Size = new System.Drawing.Size(109, 21);
            this.lblEmpList.TabIndex = 2;
            this.lblEmpList.Text = "Employee List";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(383, 163);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(295, 54);
            this.btnAddEmp.TabIndex = 3;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelEmp.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelEmp.Location = new System.Drawing.Point(383, 214);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.Size = new System.Drawing.Size(295, 48);
            this.btnDelEmp.TabIndex = 3;
            this.btnDelEmp.Text = "Remove Employee";
            this.btnDelEmp.UseVisualStyleBackColor = true;
            this.btnDelEmp.Click += new System.EventHandler(this.btnDelEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmp.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmp.Location = new System.Drawing.Point(383, 259);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(295, 52);
            this.btnUpdateEmp.TabIndex = 3;
            this.btnUpdateEmp.Text = "Update";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmp.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmp.Location = new System.Drawing.Point(590, 89);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(88, 40);
            this.btnSearchEmp.TabIndex = 3;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 46);
            this.textBox1.TabIndex = 4;
            // 
            // btnRefreshEmp
            // 
            this.btnRefreshEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshEmp.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshEmp.Location = new System.Drawing.Point(383, 89);
            this.btnRefreshEmp.Name = "btnRefreshEmp";
            this.btnRefreshEmp.Size = new System.Drawing.Size(201, 40);
            this.btnRefreshEmp.TabIndex = 5;
            this.btnRefreshEmp.Text = "Refresh";
            this.btnRefreshEmp.UseVisualStyleBackColor = true;
            this.btnRefreshEmp.Click += new System.EventHandler(this.btnRefreshEmp_Click);
            // 
            // lblErrorEmp
            // 
            this.lblErrorEmp.AutoSize = true;
            this.lblErrorEmp.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmp.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmp.Location = new System.Drawing.Point(392, 366);
            this.lblErrorEmp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorEmp.Name = "lblErrorEmp";
            this.lblErrorEmp.Size = new System.Drawing.Size(0, 18);
            this.lblErrorEmp.TabIndex = 6;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblErrorEmp);
            this.Controls.Add(this.btnRefreshEmp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.btnDelEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.lblEmpList);
            this.Controls.Add(this.gvEmp);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(701, 456);
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvEmp;
        private System.Windows.Forms.Label lblEmpList;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnDelEmp;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRefreshEmp;
        private System.Windows.Forms.Label lblErrorEmp;
    }
}
