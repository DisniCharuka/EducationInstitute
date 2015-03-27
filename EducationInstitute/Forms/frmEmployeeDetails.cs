﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections;
using System.Text;
using System.IO;
using System.Web;

namespace EducationInstitute.Forms
{
    public partial class frmEmployeeDetails : Form
    {

        #region Public Properties

        EducationInstitute.PublicClasses.DBConnection obj;
        EducationInstitute.PublicClasses.PopulateData populateData;
        EducationInstitute.PublicClasses.DeleteData deleteData;
        SqlDataReader rs = null;
        int newData = 0;
        String oldEmpId = null;
        String newEmpId = null;

        #endregion

        #region Constructors

        public frmEmployeeDetails()
        {
            InitializeComponent();
            DbConnectionMethod();
        }

        #endregion

        #region DB Connection

        private void DbConnectionMethod()
        {
            obj = new EducationInstitute.PublicClasses.DBConnection();
            obj.DbConnectionMethod();
        }

        #endregion

        #region Event Handlers

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        #endregion

        private void PopulateData()
        {
            populateData = new PublicClasses.PopulateData();
            dgvEmployeeDetails.DataSource = populateData.PopulateDetails("sp_Select_EmployeeData", obj.sqlConnection, rs);
        }

        private void SaveData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;


            if (newData == 1)
            {
                cmd.CommandText = "sp_Insert_EmployeeData";
                MessageBox.Show(Properties.Resources.insertEmployee, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                cmd.CommandText = "sp_Update_EmployeeData";
                MessageBox.Show(Properties.Resources.updatedEmployee, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Employee_Id", txtEmployeeId.Text.ToString());
            cmd.Parameters.AddWithValue("@Employee_Nic", txtEmpNic.Text.ToString());
            cmd.Parameters.AddWithValue("@Employee_FirstName", txtEmpFirstName.Text.ToString());
            cmd.Parameters.AddWithValue("@Employee_LastName", txtEmpLastName.Text.ToString());
            cmd.Parameters.AddWithValue("@Employee_Dob", dtpEmpDob.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Employee_Address1", txtEmpAddress1.Text.ToString());
            cmd.Parameters.AddWithValue("@Employee_Address2", txtEmpAddress2.Text.ToString());
            cmd.Parameters.AddWithValue("@Employee_Address3", txtEmpAddress3.Text.ToString());
            cmd.Parameters.AddWithValue("@Employee_ContactNo", txtEmpContactNo.Text.ToString());


            cmd.ExecuteNonQuery();
            PopulateData();
           

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearSpace(this);
           // GetNextEmployeeId();
            newData = 1;
        }

        private void GetNextEmployeeId()
        {
            SqlCommand command = new SqlCommand("sp_SelectAll_EmployeeData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
            {
                oldEmpId = rs[0].ToString();
            }
            if (!rs.NextResult())
            {
               
                    newEmpId = Regex.Replace(oldEmpId, "\\d+",
                      m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));
                    txtEmployeeId.Text = newEmpId;
                
            }
            rs.Close();
        }

        private void ClearSpace(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearSpace(c);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSpace(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmployeeDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployeeDetails.SelectedRows.Count == 1)
            {
                txtEmployeeId.Text = dgvEmployeeDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtEmpNic.Text = dgvEmployeeDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtEmpFirstName.Text = dgvEmployeeDetails.SelectedRows[0].Cells[2].Value.ToString();
                txtEmpLastName.Text = dgvEmployeeDetails.SelectedRows[0].Cells[3].Value.ToString();
                dtpEmpDob.Text = dgvEmployeeDetails.SelectedRows[0].Cells[4].Value.ToString();
                txtEmpAddress1.Text = dgvEmployeeDetails.SelectedRows[0].Cells[5].Value.ToString();
                txtEmpAddress2.Text = dgvEmployeeDetails.SelectedRows[0].Cells[6].Value.ToString();
                txtEmpAddress3.Text = dgvEmployeeDetails.SelectedRows[0].Cells[7].Value.ToString();
                txtEmpContactNo.Text = dgvEmployeeDetails.SelectedRows[0].Cells[8].Value.ToString();


            }
        }

       

        
    }
}
