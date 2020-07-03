namespace InventoryManagement
{
    partial class addEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addEmployee));
            this.lblEmpName = new System.Windows.Forms.Label();
            this.tbEmpName = new System.Windows.Forms.TextBox();
            this.tbEmpRank = new System.Windows.Forms.TextBox();
            this.lblEmpSalary = new System.Windows.Forms.Label();
            this.tbEmpSal = new System.Windows.Forms.TextBox();
            this.lblEmpRank = new System.Windows.Forms.Label();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddEmpGeneral = new System.Windows.Forms.Label();
            this.lblPersonalEmpInfo = new System.Windows.Forms.Label();
            this.lblEmpAddress = new System.Windows.Forms.Label();
            this.lblEmpDOB = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblEmpNID = new System.Windows.Forms.Label();
            this.lblEmpJoinning = new System.Windows.Forms.Label();
            this.tbEmpAddress = new System.Windows.Forms.TextBox();
            this.tbEmpNID = new System.Windows.Forms.TextBox();
            this.lblEmpContactNO = new System.Windows.Forms.Label();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.tbEmpPhone = new System.Windows.Forms.TextBox();
            this.tbEmpMail = new System.Windows.Forms.TextBox();
            this.dtpJoin = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnCancelEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(16, 109);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(53, 21);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "NAME";
            this.lblEmpName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbEmpName
            // 
            this.tbEmpName.Location = new System.Drawing.Point(129, 111);
            this.tbEmpName.Name = "tbEmpName";
            this.tbEmpName.Size = new System.Drawing.Size(153, 20);
            this.tbEmpName.TabIndex = 1;
            this.tbEmpName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbEmpRank
            // 
            this.tbEmpRank.Location = new System.Drawing.Point(129, 188);
            this.tbEmpRank.Name = "tbEmpRank";
            this.tbEmpRank.Size = new System.Drawing.Size(153, 20);
            this.tbEmpRank.TabIndex = 5;
            // 
            // lblEmpSalary
            // 
            this.lblEmpSalary.AutoSize = true;
            this.lblEmpSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpSalary.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSalary.Location = new System.Drawing.Point(16, 151);
            this.lblEmpSalary.Name = "lblEmpSalary";
            this.lblEmpSalary.Size = new System.Drawing.Size(66, 21);
            this.lblEmpSalary.TabIndex = 4;
            this.lblEmpSalary.Text = "SALARY";
            // 
            // tbEmpSal
            // 
            this.tbEmpSal.Location = new System.Drawing.Point(129, 151);
            this.tbEmpSal.Name = "tbEmpSal";
            this.tbEmpSal.Size = new System.Drawing.Size(153, 20);
            this.tbEmpSal.TabIndex = 7;
            // 
            // lblEmpRank
            // 
            this.lblEmpRank.AutoSize = true;
            this.lblEmpRank.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpRank.Location = new System.Drawing.Point(16, 188);
            this.lblEmpRank.Name = "lblEmpRank";
            this.lblEmpRank.Size = new System.Drawing.Size(106, 21);
            this.lblEmpRank.TabIndex = 6;
            this.lblEmpRank.Text = "DESIGNATION";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.Lime;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(178, 399);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(166, 52);
            this.btnAddEmp.TabIndex = 8;
            this.btnAddEmp.Text = "ADD EMPLOYEE";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(786, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblAddEmpGeneral
            // 
            this.lblAddEmpGeneral.AutoSize = true;
            this.lblAddEmpGeneral.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmpGeneral.Location = new System.Drawing.Point(27, 40);
            this.lblAddEmpGeneral.Name = "lblAddEmpGeneral";
            this.lblAddEmpGeneral.Size = new System.Drawing.Size(264, 34);
            this.lblAddEmpGeneral.TabIndex = 10;
            this.lblAddEmpGeneral.Text = "General Informations";
            // 
            // lblPersonalEmpInfo
            // 
            this.lblPersonalEmpInfo.AutoSize = true;
            this.lblPersonalEmpInfo.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalEmpInfo.Location = new System.Drawing.Point(310, 40);
            this.lblPersonalEmpInfo.Name = "lblPersonalEmpInfo";
            this.lblPersonalEmpInfo.Size = new System.Drawing.Size(276, 34);
            this.lblPersonalEmpInfo.TabIndex = 11;
            this.lblPersonalEmpInfo.Text = "Personal Informations";
            // 
            // lblEmpAddress
            // 
            this.lblEmpAddress.AutoSize = true;
            this.lblEmpAddress.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpAddress.Location = new System.Drawing.Point(312, 111);
            this.lblEmpAddress.Name = "lblEmpAddress";
            this.lblEmpAddress.Size = new System.Drawing.Size(69, 21);
            this.lblEmpAddress.TabIndex = 12;
            this.lblEmpAddress.Text = "Address";
            this.lblEmpAddress.Click += new System.EventHandler(this.lblPresentAddress_Click);
            // 
            // lblEmpDOB
            // 
            this.lblEmpDOB.AutoSize = true;
            this.lblEmpDOB.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDOB.Location = new System.Drawing.Point(312, 232);
            this.lblEmpDOB.Name = "lblEmpDOB";
            this.lblEmpDOB.Size = new System.Drawing.Size(102, 21);
            this.lblEmpDOB.TabIndex = 12;
            this.lblEmpDOB.Text = "Date Of Birth";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(386, 339);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 21);
            this.lblError.TabIndex = 13;
            // 
            // lblEmpNID
            // 
            this.lblEmpNID.AutoSize = true;
            this.lblEmpNID.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNID.Location = new System.Drawing.Point(312, 151);
            this.lblEmpNID.Name = "lblEmpNID";
            this.lblEmpNID.Size = new System.Drawing.Size(35, 21);
            this.lblEmpNID.TabIndex = 14;
            this.lblEmpNID.Text = "NID";
            // 
            // lblEmpJoinning
            // 
            this.lblEmpJoinning.AutoSize = true;
            this.lblEmpJoinning.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpJoinning.Location = new System.Drawing.Point(16, 225);
            this.lblEmpJoinning.Name = "lblEmpJoinning";
            this.lblEmpJoinning.Size = new System.Drawing.Size(107, 21);
            this.lblEmpJoinning.TabIndex = 15;
            this.lblEmpJoinning.Text = "JOINING DATE";
            // 
            // tbEmpAddress
            // 
            this.tbEmpAddress.Location = new System.Drawing.Point(420, 113);
            this.tbEmpAddress.Name = "tbEmpAddress";
            this.tbEmpAddress.Size = new System.Drawing.Size(197, 20);
            this.tbEmpAddress.TabIndex = 1;
            this.tbEmpAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbEmpNID
            // 
            this.tbEmpNID.Location = new System.Drawing.Point(420, 153);
            this.tbEmpNID.Name = "tbEmpNID";
            this.tbEmpNID.Size = new System.Drawing.Size(197, 20);
            this.tbEmpNID.TabIndex = 1;
            this.tbEmpNID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEmpContactNO
            // 
            this.lblEmpContactNO.AutoSize = true;
            this.lblEmpContactNO.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpContactNO.Location = new System.Drawing.Point(16, 262);
            this.lblEmpContactNO.Name = "lblEmpContactNO";
            this.lblEmpContactNO.Size = new System.Drawing.Size(100, 21);
            this.lblEmpContactNO.TabIndex = 17;
            this.lblEmpContactNO.Text = "CONTACT NO";
            this.lblEmpContactNO.Click += new System.EventHandler(this.lblEmpContactNo_Click);
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpEmail.Location = new System.Drawing.Point(16, 301);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(60, 21);
            this.lblEmpEmail.TabIndex = 18;
            this.lblEmpEmail.Text = "E-MAIL";
            // 
            // tbEmpPhone
            // 
            this.tbEmpPhone.Location = new System.Drawing.Point(129, 262);
            this.tbEmpPhone.Name = "tbEmpPhone";
            this.tbEmpPhone.Size = new System.Drawing.Size(153, 20);
            this.tbEmpPhone.TabIndex = 19;
            // 
            // tbEmpMail
            // 
            this.tbEmpMail.Location = new System.Drawing.Point(129, 301);
            this.tbEmpMail.Name = "tbEmpMail";
            this.tbEmpMail.Size = new System.Drawing.Size(153, 20);
            this.tbEmpMail.TabIndex = 20;
            // 
            // dtpJoin
            // 
            this.dtpJoin.Location = new System.Drawing.Point(129, 232);
            this.dtpJoin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpJoin.Name = "dtpJoin";
            this.dtpJoin.Size = new System.Drawing.Size(151, 20);
            this.dtpJoin.TabIndex = 21;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(420, 232);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(151, 20);
            this.dtpDOB.TabIndex = 22;
            // 
            // btnCancelEmp
            // 
            this.btnCancelEmp.BackColor = System.Drawing.Color.Red;
            this.btnCancelEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEmp.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEmp.Location = new System.Drawing.Point(368, 399);
            this.btnCancelEmp.Name = "btnCancelEmp";
            this.btnCancelEmp.Size = new System.Drawing.Size(166, 52);
            this.btnCancelEmp.TabIndex = 23;
            this.btnCancelEmp.Text = "Cancel";
            this.btnCancelEmp.UseVisualStyleBackColor = false;
            this.btnCancelEmp.Click += new System.EventHandler(this.btnCancelEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Gender";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(420, 193);
            this.cbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(92, 21);
            this.cbGender.TabIndex = 25;
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelEmp);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.dtpJoin);
            this.Controls.Add(this.tbEmpMail);
            this.Controls.Add(this.tbEmpPhone);
            this.Controls.Add(this.lblEmpEmail);
            this.Controls.Add(this.lblEmpContactNO);
            this.Controls.Add(this.lblEmpJoinning);
            this.Controls.Add(this.lblEmpNID);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblEmpDOB);
            this.Controls.Add(this.lblEmpAddress);
            this.Controls.Add(this.lblPersonalEmpInfo);
            this.Controls.Add(this.lblAddEmpGeneral);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.tbEmpSal);
            this.Controls.Add(this.lblEmpRank);
            this.Controls.Add(this.tbEmpRank);
            this.Controls.Add(this.lblEmpSalary);
            this.Controls.Add(this.tbEmpNID);
            this.Controls.Add(this.tbEmpAddress);
            this.Controls.Add(this.tbEmpName);
            this.Controls.Add(this.lblEmpName);
            this.Name = "addEmployee";
            this.Size = new System.Drawing.Size(701, 488);
            this.Load += new System.EventHandler(this.addEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox tbEmpName;
        private System.Windows.Forms.TextBox tbEmpRank;
        private System.Windows.Forms.Label lblEmpSalary;
        private System.Windows.Forms.TextBox tbEmpSal;
        private System.Windows.Forms.Label lblEmpRank;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddEmpGeneral;
        private System.Windows.Forms.Label lblPersonalEmpInfo;
        private System.Windows.Forms.Label lblEmpAddress;
        private System.Windows.Forms.Label lblEmpDOB;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblEmpNID;
        private System.Windows.Forms.Label lblEmpJoinning;
        private System.Windows.Forms.TextBox tbEmpAddress;
        private System.Windows.Forms.TextBox tbEmpNID;
        private System.Windows.Forms.Label lblEmpContactNO;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.TextBox tbEmpPhone;
        private System.Windows.Forms.TextBox tbEmpMail;
        private System.Windows.Forms.DateTimePicker dtpJoin;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnCancelEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGender;
    }
}
