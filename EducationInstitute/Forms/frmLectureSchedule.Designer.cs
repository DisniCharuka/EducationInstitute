namespace EducationInstitute.Forms
{
    partial class frmLectureSchedule
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLecturerNo = new System.Windows.Forms.TextBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLecturer = new System.Windows.Forms.ComboBox();
            this.chkTheory = new System.Windows.Forms.CheckBox();
            this.chkRevision = new System.Windows.Forms.CheckBox();
            this.rbnSinhala = new System.Windows.Forms.RadioButton();
            this.rbnEnglish = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbHall = new System.Windows.Forms.ComboBox();
            this.dgvLectureSchedule = new System.Windows.Forms.DataGridView();
            this.colLectureNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectureSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecture No:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 104;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 103;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 102;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 101;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 158);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 99;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 98;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(12, 42);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 97;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Class:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(793, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Medium:";
            // 
            // txtLecturerNo
            // 
            this.txtLecturerNo.Location = new System.Drawing.Point(110, 30);
            this.txtLecturerNo.Name = "txtLecturerNo";
            this.txtLecturerNo.Size = new System.Drawing.Size(114, 20);
            this.txtLecturerNo.TabIndex = 108;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(239, 29);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(185, 21);
            this.cmbSubject.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Lecturer:";
            // 
            // cmbLecturer
            // 
            this.cmbLecturer.FormattingEnabled = true;
            this.cmbLecturer.Location = new System.Drawing.Point(436, 29);
            this.cmbLecturer.Name = "cmbLecturer";
            this.cmbLecturer.Size = new System.Drawing.Size(190, 21);
            this.cmbLecturer.TabIndex = 111;
            // 
            // chkTheory
            // 
            this.chkTheory.AutoSize = true;
            this.chkTheory.Location = new System.Drawing.Point(642, 32);
            this.chkTheory.Name = "chkTheory";
            this.chkTheory.Size = new System.Drawing.Size(59, 17);
            this.chkTheory.TabIndex = 112;
            this.chkTheory.Text = "Theory";
            this.chkTheory.UseVisualStyleBackColor = true;
            // 
            // chkRevision
            // 
            this.chkRevision.AutoSize = true;
            this.chkRevision.Location = new System.Drawing.Point(707, 32);
            this.chkRevision.Name = "chkRevision";
            this.chkRevision.Size = new System.Drawing.Size(67, 17);
            this.chkRevision.TabIndex = 113;
            this.chkRevision.Text = "Revision";
            this.chkRevision.UseVisualStyleBackColor = true;
            // 
            // rbnSinhala
            // 
            this.rbnSinhala.AutoSize = true;
            this.rbnSinhala.Location = new System.Drawing.Point(796, 31);
            this.rbnSinhala.Name = "rbnSinhala";
            this.rbnSinhala.Size = new System.Drawing.Size(60, 17);
            this.rbnSinhala.TabIndex = 114;
            this.rbnSinhala.TabStop = true;
            this.rbnSinhala.Text = "Sinhala";
            this.rbnSinhala.UseVisualStyleBackColor = true;
            // 
            // rbnEnglish
            // 
            this.rbnEnglish.AutoSize = true;
            this.rbnEnglish.Location = new System.Drawing.Point(872, 30);
            this.rbnEnglish.Name = "rbnEnglish";
            this.rbnEnglish.Size = new System.Drawing.Size(59, 17);
            this.rbnEnglish.TabIndex = 115;
            this.rbnEnglish.TabStop = true;
            this.rbnEnglish.Text = "English";
            this.rbnEnglish.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 116;
            this.label6.Text = "Year:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(110, 80);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(114, 20);
            this.txtYear.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(639, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 119;
            this.label8.Text = "Hall:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 120;
            this.label9.Text = "Day:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 121;
            this.label7.Text = "Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 122;
            this.label10.Text = "From";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(538, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 123;
            this.label11.Text = "To";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(470, 80);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(65, 20);
            this.txtStartTime.TabIndex = 124;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(564, 80);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(62, 20);
            this.txtEndTime.TabIndex = 125;
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(239, 80);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(185, 21);
            this.cmbDay.TabIndex = 126;
            // 
            // cmbHall
            // 
            this.cmbHall.FormattingEnabled = true;
            this.cmbHall.Location = new System.Drawing.Point(642, 80);
            this.cmbHall.Name = "cmbHall";
            this.cmbHall.Size = new System.Drawing.Size(121, 21);
            this.cmbHall.TabIndex = 127;
            // 
            // dgvLectureSchedule
            // 
            this.dgvLectureSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLectureSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLectureNo,
            this.colSubject,
            this.colLecturer,
            this.colClass,
            this.colMedium,
            this.colYear,
            this.colDay,
            this.colStartTime,
            this.colEndTime,
            this.colHall});
            this.dgvLectureSchedule.Location = new System.Drawing.Point(12, 242);
            this.dgvLectureSchedule.Name = "dgvLectureSchedule";
            this.dgvLectureSchedule.Size = new System.Drawing.Size(968, 212);
            this.dgvLectureSchedule.TabIndex = 128;
            // 
            // colLectureNo
            // 
            this.colLectureNo.HeaderText = "Lecture No";
            this.colLectureNo.Name = "colLectureNo";
            // 
            // colSubject
            // 
            this.colSubject.HeaderText = "Subject";
            this.colSubject.Name = "colSubject";
            // 
            // colLecturer
            // 
            this.colLecturer.HeaderText = "Lecturer";
            this.colLecturer.Name = "colLecturer";
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
            // colYear
            // 
            this.colYear.HeaderText = "Year";
            this.colYear.Name = "colYear";
            // 
            // colDay
            // 
            this.colDay.HeaderText = "Day";
            this.colDay.Name = "colDay";
            // 
            // colStartTime
            // 
            this.colStartTime.HeaderText = "Start Time";
            this.colStartTime.Name = "colStartTime";
            // 
            // colEndTime
            // 
            this.colEndTime.HeaderText = "End Time";
            this.colEndTime.Name = "colEndTime";
            // 
            // colHall
            // 
            this.colHall.HeaderText = "Hall";
            this.colHall.Name = "colHall";
            // 
            // frmLectureSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 466);
            this.Controls.Add(this.dgvLectureSchedule);
            this.Controls.Add(this.cmbHall);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbnEnglish);
            this.Controls.Add(this.rbnSinhala);
            this.Controls.Add(this.chkRevision);
            this.Controls.Add(this.chkTheory);
            this.Controls.Add(this.cmbLecturer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.txtLecturerNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.label1);
            this.Name = "frmLectureSchedule";
            this.Text = "frmLectureSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectureSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLecturerNo;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLecturer;
        private System.Windows.Forms.CheckBox chkTheory;
        private System.Windows.Forms.CheckBox chkRevision;
        private System.Windows.Forms.RadioButton rbnSinhala;
        private System.Windows.Forms.RadioButton rbnEnglish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbHall;
        private System.Windows.Forms.DataGridView dgvLectureSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLectureNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLecturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedium;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHall;
    }
}