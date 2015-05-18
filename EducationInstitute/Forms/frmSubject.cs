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
using System.Collections;
using System.IO;
using System.Web;
using EducationInstitute.PublicClasses;
using EducationInstitute.DialogBoxes;

namespace EducationInstitute.Forms
{
    public partial class frmSubject : Form
    {
        #region Public Properties
        DBConnection obj;
        PopulateData populateData;
        DeleteData deleteData;
        SqlDataReader rs = null;
        int newData = 0;
        String oldSubjectId = null;
        String newSubjectId = null;

        #endregion

        #region Constructors

        public frmSubject()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSubjectData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearSpace(this);
            GetNextSubjectId();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            dlgSearch dlgSearchSubjectDetails = new dlgSearch("sp_Search_SubjectData", "SubjectId", "SubjectName", "unused", "Search Subject Details");

            if (dlgSearchSubjectDetails.ShowDialog() == DialogResult.OK)
            {
                this.rs = dlgSearchSubjectDetails.rs;

                if (rs.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(rs);
                    dgvSubjectDetails.DataSource = dt;
                    rs.Close();
                }
                else
                {
                   MessageBox.Show("No data found!", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
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
            dgvSubjectDetails.DataSource = populateData.PopulateDetails("sp_Select_SubjectData", obj.sqlConnection, rs);
        }

        private void DeleteSubjectData()
        {
            deleteData = new PublicClasses.DeleteData();
            deleteData.DeleteDetails("sp_Delete_SubjectData", obj.sqlConnection, "@Subject_Id",  txtSubjectId.Text.ToString());
            MessageBox.Show(Properties.Resources.deleteSubject, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateData();
        }

        private void SaveData()
        {
           SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;

            if (txtSubjectId.Text == "" || txtSubjectName.Text == "")
            {
                MessageBox.Show(Properties.Resources.dataFieldMissing, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (newData == 1)
                {
                    cmd.CommandText = "sp_Insert_SubjectData";
                    MessageBox.Show(Properties.Resources.insertSubject, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    cmd.CommandText = "sp_Update_SubjectData";
                    MessageBox.Show(Properties.Resources.updateSubject, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Subject_Id", txtSubjectId.Text.ToString());
                cmd.Parameters.AddWithValue("@Subject_Name", txtSubjectName.Text.ToString());

                cmd.ExecuteNonQuery();
                PopulateData();
            }
        }

        #endregion

        #region Data grid view Actions

        private void dgvSubjectDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSubjectDetails.SelectedRows.Count == 1)
            {
                txtSubjectId.Text = dgvSubjectDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtSubjectName.Text = dgvSubjectDetails.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        #endregion

        #region Get Next Subject Id

        private void GetNextSubjectId()
        {
            SqlCommand command = new SqlCommand("sp_SelectAll_SubjectData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
            {
                oldSubjectId = rs[0].ToString();
            }
            if (!rs.NextResult())
            {
                if (oldSubjectId != null)
                {
                    newSubjectId = Regex.Replace(oldSubjectId, "\\d+",
                      m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));
                }
                else 
                {
                    newSubjectId = "S0001";
                }
                txtSubjectId.Text = newSubjectId;
            }
            rs.Close();
        }

        #endregion

        #region Clear Spaces

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

        #endregion

        #region Shortcut keys

        private void dgvSubjectDetails_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                PopulateData();
            }
            else if (e.KeyCode == Keys.F3)
            {
                ClearSpace(this);
                GetNextSubjectId();
                newData = 1;
            }
            else if (e.KeyCode == Keys.F4)
            {
                SaveData();
            }
            else if (e.KeyCode == Keys.F5)
            {
                ClearSpace(this);
            }
            else if (e.KeyCode == Keys.F6)
            {
                DeleteSubjectData();
            }
            else
            {
                MessageBox.Show("No Function");
            }
        }

        #endregion

       

    }
}
