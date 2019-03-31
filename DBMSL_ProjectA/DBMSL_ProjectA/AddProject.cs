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

namespace DBMSL_ProjectA
{
    public partial class AddProject : Form
    {
        private AddProject()
        {
            InitializeComponent();
        }
        private static AddProject Instance = null;
        public static AddProject GetInstance()
        {
            if (Instance == null)
            {
                AddProject new_Instance = new AddProject();
                return new_Instance;

            }
            return Instance;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ) {
                lblTitleWarning.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                lblDescriptionWarning.Visible = true;
            }
            else
            {
                DatabaseConnection.createStatement("INSERT INTO Project ( Title, Description)" +
                " VALUES('" + txtTitle.Text + "' , '" + txtDescription.Text + "') ");
                DatabaseConnection.performAction();
                Project project = new Project();
                project.Title = txtTitle.Text;

                DatabaseConnection.createStatement("Select @@identity as id from Project");
                SqlDataReader reader = DatabaseConnection.getData();
                while (reader.Read())
                {
                    project.Id = int.Parse(reader["id"].ToString());
                }
                TempData.CurrentProject = project;
                ProjectDashboard dashboard = ProjectDashboard.GetInstance();
                dashboard.Show();
                this.Hide();
            }
        }

        private void AddProject_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            ManageProjects project = ManageProjects.GetInstance();
            project.Show();
            this.Hide();
        }
    }
}
