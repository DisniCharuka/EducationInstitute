using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationInstitute.PublicClasses;
using System.Data;
using System.Data.SqlClient;

namespace EducationInstitute.Forms
{
    public partial class MDImain : Form
    {
        private int childFormNumber = 0;
        DBConnection obj;

        public MDImain()
        {
            InitializeComponent();
            DBConnectionMethod();
            WindowState = FormWindowState.Maximized;
        }

        private void DBConnectionMethod()
        {
            obj = new EducationInstitute.PublicClasses.DBConnection();
            obj.DbConnectionMethod();
            
        }


        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentRegistration frmStudentRegistration = new frmStudentRegistration();
            frmStudentRegistration.Show();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentPayments frmStudentPayments = new frmStudentPayments();
            frmStudentPayments.Show();
        }

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLectureSchedule frmLectureSchedule = new frmLectureSchedule();
            frmLectureSchedule.Show();
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeDetails frmEmployeeDetails = new frmEmployeeDetails();
            frmEmployeeDetails.Show();
        }

        private void paymentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPaymentsDetails frmPaymentsDetails = new frmPaymentsDetails();
            frmPaymentsDetails.Show();
        }

        private void hallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHallDetails frmHallDetails = new frmHallDetails();
            frmHallDetails.Show();
        }

        private void tutorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTutorialDetails frmTutorialDetails = new frmTutorialDetails();
            frmTutorialDetails.Show();
        }

        private void lectureScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLectureSchedule frmLectureSchedule = new frmLectureSchedule();
            frmLectureSchedule.Show();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubject frmSubject = new frmSubject();
            frmSubject.Show();
        }

        private void systemUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemUser frmSystemUser = new frmSystemUser();
            frmSystemUser.Show();
        }
    }
}
