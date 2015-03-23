using System;
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

namespace EducationInstitute.Forms
{
    public partial class frmHallDetails : Form
    { 
        #region Public Properties

        EducationInstitute.PublicClasses.DBConnection obj;
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

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        private void PopulateData()
        {
            SqlCommand command = new SqlCommand("sp_Select_HallData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvHallDetails.DataSource = dt;
            rs.Close();
        }

        private void SaveData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            if (newData == 1)
            {
                cmd.CommandText = "sp_Insert_HallData";
            }
            else
            {
                cmd.CommandText = "sp_Update_HallData";
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Hall_No", txtHallNo.Text.ToString());
            cmd.Parameters.AddWithValue("@Hall_Name", txtHallName.Text.ToString());

            cmd.ExecuteNonQuery();
            PopulateData();

        }

        private void DeleteHallData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Delete_HallData";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Hall_No", txtHallNo.Text.ToString());

            cmd.ExecuteNonQuery();
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
                newHallNo = Regex.Replace(oldHallNo, "\\d+",
                  m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));
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


    }
}
