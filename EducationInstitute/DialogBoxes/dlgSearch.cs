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
using EducationInstitute.PublicClasses;

namespace EducationInstitute.DialogBoxes
{
    public partial class dlgSearch : Form
    {
        String storedProc = null;
        String parameter1 = null;
        String parameter2 = null;
        String parameter3 = null;

        SqlConnection sqlConnection = new SqlConnection();
        DBConnection obj;
       public SqlDataReader rs;
       

        public dlgSearch(String storedProc, String parameter1, String parameter2, String parameter3, String title)
        {
            InitializeComponent();
            DbConnectionMethod();
            btnSearch.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            this.storedProc = storedProc;
            this.parameter1 = parameter1;
            this.parameter2 = parameter2;
            this.parameter3 = parameter3;
            this.Text = title;
            label1.Text = parameter1;
            label2.Text = parameter2;
            label3.Text = parameter3;
            if (this.parameter3 == "unused")
            {
                label3.Visible = false;
                textBox3.Visible = false;
            }

        }

        private void DbConnectionMethod()
        {
            obj = new EducationInstitute.PublicClasses.DBConnection();
            obj.DbConnectionMethod();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(this.storedProc, obj.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            if (String.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                cmd.Parameters.AddWithValue("@" + this.parameter1, DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@" + this.parameter1, textBox1.Text);

            }
            if (String.IsNullOrEmpty(textBox2.Text.ToString()))
            {
                cmd.Parameters.AddWithValue("@" + this.parameter2, DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@" + this.parameter2, textBox2.Text);
            }
            if (String.IsNullOrEmpty(textBox3.Text.ToString()))
            {
                cmd.Parameters.AddWithValue("@" + this.parameter3, DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@" + this.parameter3, textBox3.Text);
            }

            rs = cmd.ExecuteReader();
        }
    }
}
