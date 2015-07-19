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
using EducationInstitute.DialogBoxes;
using EducationInstitute.PublicClasses;

namespace EducationInstitute.Forms
{
    public partial class frmHallDetails : Form
    { 
        #region Public Properties

        DBConnection obj;
        PopulateData populateData;
        DeleteData deleteData;
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

        #region Form Load method 

        private void frmHallDetails_Load(object sender, EventArgs e)
        {
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnExit);
        }

        #endregion

        #region Event Handlers

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData();
            label1.Enabled = true;
            label2.Enabled = true;
            dgvHallDetails.Enabled = true;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearSpace(this);
            label1.Enabled = true;
            label2.Enabled = true;
            dgvHallDetails.Enabled = true;
            txtHallName.Enabled = true;
            GetNextHallNo();
            btnSave.Enabled = true;
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
            dlgSearch dlgSearchHallDetails = new dlgSearch("sp_Search_HallData", "HallNo", "HallName","unused", "Search Hall Details");

            if (dlgSearchHallDetails.ShowDialog() == DialogResult.OK)
            {
                this.rs = dlgSearchHallDetails.rs;

                if (rs.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(rs);
                    dgvHallDetails.DataSource = dt;
                    rs.Close();
                }
                else
                {
                    MessageBox.Show("No data found!", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
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
                txtHallName.Enabled = true;
                txtHallNo.Enabled = true;
                txtHallNo.Text = dgvHallDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtHallName.Text = dgvHallDetails.SelectedRows[0].Cells[1].Value.ToString();
                btnDelete.Enabled = true;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2)
            {
                PopulateData();
            }
            else if (keyData == Keys.F3)
            {
                ClearSpace(this);
                GetNextHallNo();
                newData = 1;
            }
            else if (keyData == Keys.F4)
            {
                SaveData();
            }
            else if (keyData == Keys.F5)
            {
                ClearSpace(this);
            }
            else if (keyData == Keys.F6)
            {
                DeleteHallData();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion 

        
        #region Control Enable and Disable Methods

        private void EnableButtons(Control button)
        {
            if (button != null)
            {
                button.Enabled = true;
                EnableButtons(button.Parent);
            }
        }

        private void DisableAllControls(Control con, bool value)
        {
            foreach (Control c in con.Controls)
            {
                DisableAllControls(c, value);
            }
            con.Enabled = value;
        }

        #endregion
    }
}
