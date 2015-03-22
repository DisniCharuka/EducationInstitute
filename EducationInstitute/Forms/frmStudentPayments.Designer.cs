namespace EducationInstitute.Forms
{
    partial class frmStudentPayments
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.dtpPaymentTime = new System.Windows.Forms.DateTimePicker();
            this.dgvLecture = new System.Windows.Forms.DataGridView();
            this.colSubject = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colLecturer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colClass = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMedium = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentsPayments = new System.Windows.Forms.DataGridView();
            this.colPaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayStuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaySubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayLecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayMedium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 211);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 120;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 119;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 118;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 69);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 117;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 116;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 156);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 115;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 114;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(12, 40);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 113;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Payment Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "Student Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "Student Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 124;
            this.label4.Text = "Payment at:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 125;
            this.label5.Text = "Lecture:";
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Location = new System.Drawing.Point(109, 27);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentId.TabIndex = 126;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(223, 27);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 20);
            this.txtStudentId.TabIndex = 127;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(340, 27);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(232, 20);
            this.txtStudentName.TabIndex = 128;
            // 
            // dtpPaymentTime
            // 
            this.dtpPaymentTime.Location = new System.Drawing.Point(587, 27);
            this.dtpPaymentTime.Name = "dtpPaymentTime";
            this.dtpPaymentTime.Size = new System.Drawing.Size(170, 20);
            this.dtpPaymentTime.TabIndex = 129;
            // 
            // dgvLecture
            // 
            this.dgvLecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubject,
            this.colLecturer,
            this.colClass,
            this.colMedium,
            this.colAmount});
            this.dgvLecture.Location = new System.Drawing.Point(109, 69);
            this.dgvLecture.Name = "dgvLecture";
            this.dgvLecture.Size = new System.Drawing.Size(648, 165);
            this.dgvLecture.TabIndex = 130;
            // 
            // colSubject
            // 
            this.colSubject.HeaderText = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSubject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colLecturer
            // 
            this.colLecturer.HeaderText = "Lecturer";
            this.colLecturer.Name = "colLecturer";
            this.colLecturer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLecturer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colClass
            // 
            this.colClass.HeaderText = "Class";
            this.colClass.Name = "colClass";
            // 
            // colMedium
            // 
            this.colMedium.HeaderText = "Medium";
            this.colMedium.Name = "colMedium";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            // 
            // dgvStudentsPayments
            // 
            this.dgvStudentsPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaymentId,
            this.colPayStudentId,
            this.colPayStuName,
            this.colPaymentTime,
            this.colPaySubject,
            this.colPayLecturer,
            this.colPayClass,
            this.colPayMedium,
            this.colPayAmount});
            this.dgvStudentsPayments.Location = new System.Drawing.Point(12, 240);
            this.dgvStudentsPayments.Name = "dgvStudentsPayments";
            this.dgvStudentsPayments.Size = new System.Drawing.Size(867, 211);
            this.dgvStudentsPayments.TabIndex = 131;
            // 
            // colPaymentId
            // 
            this.colPaymentId.HeaderText = "Payment Id";
            this.colPaymentId.Name = "colPaymentId";
            // 
            // colPayStudentId
            // 
            this.colPayStudentId.HeaderText = "Student Id";
            this.colPayStudentId.Name = "colPayStudentId";
            // 
            // colPayStuName
            // 
            this.colPayStuName.HeaderText = "Name";
            this.colPayStuName.Name = "colPayStuName";
            // 
            // colPaymentTime
            // 
            this.colPaymentTime.HeaderText = "Payment At";
            this.colPaymentTime.Name = "colPaymentTime";
            // 
            // colPaySubject
            // 
            this.colPaySubject.HeaderText = "Subject";
            this.colPaySubject.Name = "colPaySubject";
            // 
            // colPayLecturer
            // 
            this.colPayLecturer.HeaderText = "Lecturer";
            this.colPayLecturer.Name = "colPayLecturer";
            // 
            // colPayClass
            // 
            this.colPayClass.HeaderText = "Class";
            this.colPayClass.Name = "colPayClass";
            // 
            // colPayMedium
            // 
            this.colPayMedium.HeaderText = "Medium";
            this.colPayMedium.Name = "colPayMedium";
            // 
            // colPayAmount
            // 
            this.colPayAmount.HeaderText = "Amount";
            this.colPayAmount.Name = "colPayAmount";
            // 
            // frmStudentPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 463);
            this.Controls.Add(this.dgvStudentsPayments);
            this.Controls.Add(this.dgvLecture);
            this.Controls.Add(this.dtpPaymentTime);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtPaymentId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPopulate);
            this.Name = "frmStudentPayments";
            this.Text = "frmStudentPayments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.DateTimePicker dtpPaymentTime;
        private System.Windows.Forms.DataGridView dgvLecture;
        private System.Windows.Forms.DataGridViewComboBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLecturer;
        private System.Windows.Forms.DataGridViewComboBoxColumn colClass;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMedium;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridView dgvStudentsPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayStuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaySubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayLecturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayMedium;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayAmount;
    }
}