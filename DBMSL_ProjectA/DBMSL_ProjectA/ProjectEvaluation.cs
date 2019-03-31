using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSL_ProjectA
{
    public partial class ProjectEvaluation : Form
    {
        private ProjectEvaluation()
        {
            InitializeComponent();
        }
        private static ProjectEvaluation Instance = null;
        public static ProjectEvaluation GetInstance()
        {
            if (Instance == null)
            {
                ProjectEvaluation new_Instance = new ProjectEvaluation();
                return new_Instance;

            }
            return Instance;
        }
        private void ProjectEvaluation_Load(object sender, EventArgs e)
        {
            DatabaseConnection.createStatement("select Title from Project");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                cmbTitles.Items.Add(reader["Title"].ToString());
            }

            lblCurrentDate.Text = DateTime.Now.ToShortDateString();
            
            
        }


        bool ValidateForm()
        {
            bool IsAllValid = true;
            if (string.IsNullOrWhiteSpace(cmbTitles.Text))
            {
                lblTitleWarning.Visible = true;
                IsAllValid = false;
            }
            if (!Regex.IsMatch(txtTotalMarks.Text, @"^[0-9]*(?:\.[0-9]*)?$") || string.IsNullOrWhiteSpace(txtTotalMarks.Text))
            {
                lblTotalMarksWarning.Visible = true;
                IsAllValid = false;
            }
            if (!Regex.IsMatch(txtWeightage.Text, @"^[0-9]*(?:\.[0-9]*)?$") || string.IsNullOrWhiteSpace(txtWeightage.Text))
            {
                lblTotalWeightageWarning.Visible = true;
                IsAllValid = false;
            }
            if (!Regex.IsMatch(txtObtainedMarks.Text, @"^[0-9]*(?:\.[0-9]*)?$") || string.IsNullOrWhiteSpace(txtObtainedMarks.Text))
            {
                lblObtaninedMarksWarning.Visible = true;
                IsAllValid = false;
            }
            return IsAllValid;

        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DatabaseConnection.start();
                DatabaseConnection.createStatement("select GroupId from Project join GroupProject on Project.Id = GroupProject.ProjectId where Project.Title = '" + cmbTitles.Text + "' ");
                SqlDataReader dataReader = DatabaseConnection.getData();
                if (dataReader.Read())
                {
                    TempData.CurrentGroupId = int.Parse(dataReader["GroupId"].ToString());
                }
                DatabaseConnection.createStatement("Insert into Evaluation ( Name, TotalMarks, TotalWeightage) " +
                    "Values ('Group', " + txtTotalMarks.Text + ", " + txtWeightage.Text + ")");
                DatabaseConnection.performAction();

                DatabaseConnection.createStatement("Select @@identity as id from Evaluation");
                SqlDataReader reader = DatabaseConnection.getData();
                string id = "0";
                while (reader.Read())
                {
                    id = (reader["id"].ToString());
                }

                string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                DatabaseConnection.createStatement("INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) " +
                "VALUES (" + TempData.CurrentGroupId.ToString() + ", " + id + ", " + txtObtainedMarks.Text + ", '" + sqlFormattedDate + "') ");
                DatabaseConnection.performAction();
                cmbTitles.Text = "";
                lblObtainedMarks.Text = "";
                MessageBox.Show("Project Evaluated");
            }


        }

        private void gvEvaluation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            ProjectDashboard projectDashboard = ProjectDashboard.GetInstance();
            projectDashboard.Show();
            this.Hide();

        }

        private void txtTotalMarks_TextChanged(object sender, EventArgs e)
        {
            lblTotalMarksWarning.Visible = false;
        }

        private void txtWeightage_TextChanged(object sender, EventArgs e)
        {
            lblTotalWeightageWarning.Visible = false;
        }

        private void txtObtainedMarks_TextChanged(object sender, EventArgs e)
        {
            lblObtaninedMarksWarning.Visible = false;
        }

        private void cmbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitleWarning.Visible = false;
        }
    }
}
