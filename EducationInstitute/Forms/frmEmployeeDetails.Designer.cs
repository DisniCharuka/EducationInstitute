namespace EducationInstitute.Forms
{
    partial class frmEmployeeDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmpNic = new System.Windows.Forms.TextBox();
            this.txtEmpFirstName = new System.Windows.Forms.TextBox();
            this.txtEmpLastName = new System.Windows.Forms.TextBox();
            this.txtEmpAddress1 = new System.Windows.Forms.TextBox();
            this.txtEmpAddress2 = new System.Windows.Forms.TextBox();
            this.txtEmpAddress3 = new System.Windows.Forms.TextBox();
            this.txtEmpContactNo = new System.Windows.Forms.TextBox();
            this.dtpEmpDob = new System.Windows.Forms.DateTimePicker();
            this.dgvEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpNic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpAddress1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpAddress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpAddress3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(686, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date Of Birth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "NIC:";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(106, 23);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeId.TabIndex = 9;
            // 
            // txtEmpNic
            // 
            this.txtEmpNic.Location = new System.Drawing.Point(214, 23);
            this.txtEmpNic.Name = "txtEmpNic";
            this.txtEmpNic.Size = new System.Drawing.Size(126, 20);
            this.txtEmpNic.TabIndex = 10;
            // 
            // txtEmpFirstName
            // 
            this.txtEmpFirstName.Location = new System.Drawing.Point(347, 23);
            this.txtEmpFirstName.Name = "txtEmpFirstName";
            this.txtEmpFirstName.Size = new System.Drawing.Size(158, 20);
            this.txtEmpFirstName.TabIndex = 11;
            // 
            // txtEmpLastName
            // 
            this.txtEmpLastName.Location = new System.Drawing.Point(511, 23);
            this.txtEmpLastName.Name = "txtEmpLastName";
            this.txtEmpLastName.Size = new System.Drawing.Size(172, 20);
            this.txtEmpLastName.TabIndex = 12;
            // 
            // txtEmpAddress1
            // 
            this.txtEmpAddress1.Location = new System.Drawing.Point(106, 71);
            this.txtEmpAddress1.Name = "txtEmpAddress1";
            this.txtEmpAddress1.Size = new System.Drawing.Size(234, 20);
            this.txtEmpAddress1.TabIndex = 13;
            // 
            // txtEmpAddress2
            // 
            this.txtEmpAddress2.Location = new System.Drawing.Point(348, 71);
            this.txtEmpAddress2.Name = "txtEmpAddress2";
            this.txtEmpAddress2.Size = new System.Drawing.Size(157, 20);
            this.txtEmpAddress2.TabIndex = 14;
            // 
            // txtEmpAddress3
            // 
            this.txtEmpAddress3.Location = new System.Drawing.Point(511, 71);
            this.txtEmpAddress3.Name = "txtEmpAddress3";
            this.txtEmpAddress3.Size = new System.Drawing.Size(172, 20);
            this.txtEmpAddress3.TabIndex = 15;
            // 
            // txtEmpContactNo
            // 
            this.txtEmpContactNo.Location = new System.Drawing.Point(689, 71);
            this.txtEmpContactNo.Name = "txtEmpContactNo";
            this.txtEmpContactNo.Size = new System.Drawing.Size(181, 20);
            this.txtEmpContactNo.TabIndex = 16;
            // 
            // dtpEmpDob
            // 
            this.dtpEmpDob.Location = new System.Drawing.Point(689, 23);
            this.dtpEmpDob.Name = "dtpEmpDob";
            this.dtpEmpDob.Size = new System.Drawing.Size(181, 20);
            this.dtpEmpDob.TabIndex = 17;
            // 
            // dgvEmployeeDetails
            // 
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeId,
            this.colEmpNic,
            this.colEmpFirstName,
            this.colEmpLastName,
            this.colEmpDob,
            this.colEmpAddress1,
            this.colEmpAddress2,
            this.colEmpAddress3,
            this.colEmpContactNo});
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(106, 97);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(764, 305);
            this.dgvEmployeeDetails.TabIndex = 18;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 223);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 136;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 135;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 134;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 81);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 133;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 132;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 168);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 131;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 130;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(12, 52);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 129;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.HeaderText = "Employee Id";
            this.colEmployeeId.Name = "colEmployeeId";
            // 
            // colEmpNic
            // 
            this.colEmpNic.HeaderText = "NIC";
            this.colEmpNic.Name = "colEmpNic";
            // 
            // colEmpFirstName
            // 
            this.colEmpFirstName.HeaderText = "First Name";
            this.colEmpFirstName.Name = "colEmpFirstName";
            // 
            // colEmpLastName
            // 
            this.colEmpLastName.HeaderText = "Last Name";
            this.colEmpLastName.Name = "colEmpLastName";
            // 
            // colEmpDob
            // 
            this.colEmpDob.HeaderText = "Date Of Birth";
            this.colEmpDob.Name = "colEmpDob";
            // 
            // colEmpAddress1
            // 
            this.colEmpAddress1.HeaderText = "Address1";
            this.colEmpAddress1.Name = "colEmpAddress1";
            // 
            // colEmpAddress2
            // 
            this.colEmpAddress2.HeaderText = "Address2";
            this.colEmpAddress2.Name = "colEmpAddress2";
            // 
            // colEmpAddress3
            // 
            this.colEmpAddress3.HeaderText = "Address3";
            this.colEmpAddress3.Name = "colEmpAddress3";
            // 
            // colEmpContactNo
            // 
            this.colEmpContactNo.HeaderText = "Contact No";
            this.colEmpContactNo.Name = "colEmpContactNo";
            // 
            // frmEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 414);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.dgvEmployeeDetails);
            this.Controls.Add(this.dtpEmpDob);
            this.Controls.Add(this.txtEmpContactNo);
            this.Controls.Add(this.txtEmpAddress3);
            this.Controls.Add(this.txtEmpAddress2);
            this.Controls.Add(this.txtEmpAddress1);
            this.Controls.Add(this.txtEmpLastName);
            this.Controls.Add(this.txtEmpFirstName);
            this.Controls.Add(this.txtEmpNic);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployeeDetails";
            this.Text = "frmEmployeeDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtEmpNic;
        private System.Windows.Forms.TextBox txtEmpFirstName;
        private System.Windows.Forms.TextBox txtEmpLastName;
        private System.Windows.Forms.TextBox txtEmpAddress1;
        private System.Windows.Forms.TextBox txtEmpAddress2;
        private System.Windows.Forms.TextBox txtEmpAddress3;
        private System.Windows.Forms.TextBox txtEmpContactNo;
        private System.Windows.Forms.DateTimePicker dtpEmpDob;
        private System.Windows.Forms.DataGridView dgvEmployeeDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpNic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpAddress1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpAddress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpAddress3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpContactNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPopulate;
    }
}