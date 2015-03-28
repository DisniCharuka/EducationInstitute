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
using System.IO;
using System.Web;

namespace EducationInstitute.Forms
{
    public partial class frmHallDetails : Form
    { 
        #region Public Properties

        EducationInstitute.PublicClasses.DBConnection obj;
        EducationInstitute.PublicClasses.PopulateData populateData;
        EducationInstitute.PublicClasses.DeleteData deleteData;
        SqlDataReader rs = null;
        int newData = 0;
        String oldHallNo = null;
        String newHallNo;

        #endregion

        #region Constructors

        public frmHallDetails()
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearSpace(this);
            GetNextHallNo();
            newData = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSpace(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteHallData();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchHallData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        private void PopulateData()
        {
            populateData = new PublicClasses.PopulateData();
            dgvHallDetails.DataSource = populateData.PopulateDetails("sp_Select_HallData", obj.sqlConnection, rs);
          
        }


        private void SearchHallData()
        {
            SqlCommand cmd = new SqlCommand("sp_Search_HallData", obj.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HallNo", txtHallNo.Text);
            DataTable dt = new DataTable();
            rs = cmd.ExecuteReader();
            dt.Load(rs);
            dgvHallDetails.DataSource = dt;
            rs.Close();
        }

        private void SaveData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;

            if (txtHallNo.Text == "" || txtHallName.Text == "")
            {
                MessageBox.Show(Properties.Resources.dataFieldMissing, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (newData == 1)
                {
                    cmd.CommandText = "sp_Insert_HallData";
                    MessageBox.Show(Properties.Resources.insertHallDetail, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    cmd.CommandText = "sp_Update_HallData";
                    MessageBox.Show(Properties.Resources.updatedHallDetail, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Hall_No", txtHallNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Hall_Name", txtHallName.Text.ToString());

                cmd.ExecuteNonQuery();
                PopulateData();
           }

        }

        private void DeleteHallData()
        {
            deleteData = new PublicClasses.DeleteData();
            deleteData.DeleteDetails("sp_Delete_HallData", obj.sqlConnection, "@Hall_No", txtHallNo.Text.ToString());
            MessageBox.Show(Properties.Resources.deleteHallDetails, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateData();
        }
        #endregion

        #region Data grid view Actions

        private void dgvHallDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHallDetails.SelectedRows.Count == 1)
            {
                txtHallNo.Text = dgvHallDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtHallName.Text = dgvHallDetails.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        #endregion

        #region Get Next Hall No

        private void GetNextHallNo()
        {
            SqlCommand command = new SqlCommand("sp_SelectAll_HallData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
            {
                oldHallNo = rs[0].ToString();
            }
            if (!rs.NextResult())
            {
                if (oldHallNo != null)
                {
                    newHallNo = Regex.Replace(oldHallNo, "\\d+",
                      m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));
                }
                else
                {
                    newHallNo = "H0001";
                }
                    txtHallNo.Text = newHallNo;
            }
            rs.Close();
         
        }
        #endregion

        #region Clear Space method

        public static void ClearSpace(Control control)
        {
           foreach (Control c in control.Controls)
             {
                    if (c is TextBox)
                        ((TextBox)c).Clear();
                    else
                        ClearSpace(c);
             }
         }

        #endregion

        #region Shortcut keys
        
        private void frmHallDetails_KeyUp(object sender, KeyEventArgs e)
        {
         if (e.KeyCode == Keys.F2)
            {
                PopulateData();
            }
         else if (e.KeyCode == Keys.F3)
         {
             ClearSpace(this);
             GetNextHallNo();
             newData = 1;
         }
         else if (e.KeyCode == Keys.F4)
         {
             SaveData();
         }
         else if(e.KeyCode == Keys.F5)
         {
             ClearSpace(this);
         }
         else if (e.KeyCode == Keys.F6)
         {
             DeleteHallData();
         }
         else
         {
             MessageBox.Show("No Function");
         }

        }
        #endregion 

    }
}
