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
        EducationInstitute.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int newData = 0;
        String oldHallNo = null;
        String newHallNo;
        public frmHallDetails()
        {
            InitializeComponent();
            DbConnectionMethod();
        }

        private void DbConnectionMethod()
        {
            obj = new EducationInstitute.PublicClasses.DBConnection();
            obj.DbConnectionMethod();

        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

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

        private void dgvHallDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHallDetails.SelectedRows.Count == 1)
            {
                txtHallNo.Text = dgvHallDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtHallName.Text = dgvHallDetails.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearSpace(this);
            GetNextHallNo();
            newData = 1;
        }

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSpace(this);
        }

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

         private void btnDelete_Click(object sender, EventArgs e)
         {
         //    [sp_Delete_HallData]
             DeleteHallData();
             //testing github for 2nd time
             //chintaka made a comment huhu
         }

         private void DeleteHallData()
         {
             
             SqlCommand command = new SqlCommand("sp_SelectAll_HallData", obj.sqlConnection);
             command.CommandType = System.Data.CommandType.StoredProcedure;

            // rs = command.ExecuteReader();
             command.CommandType = CommandType.StoredProcedure;
             command.ExecuteNonQuery();
             SaveData();
         }
    
        
    }
}
