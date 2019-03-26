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
    public partial class ManageProjects : Form
    {
        private ManageProjects()
        {
            InitializeComponent();
        }
        private static ManageProjects Instance = null;
        public static ManageProjects GetInstance()
        {
            if (Instance == null)
            {
                ManageProjects new_Instance = new ManageProjects();
                return new_Instance;

            }
            return Instance;
        }

        private void gvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvStudents.Columns[e.ColumnIndex].Name.ToString() == "Action")
            {
                Project project = new Project();
                project.Title = gvStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
                project.Id = int.Parse(gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                TempData.CurrentProject = project;
                ProjectDashboard projectDashboard = ProjectDashboard.GetInstance();
                projectDashboard.Show();
                this.Hide();

            }
            if (gvStudents.Columns[e.ColumnIndex].Name.ToString() == "Action3")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DatabaseConnection.start();
                    DatabaseConnection.createStatement("Delete from ProjectAdvisor where ProjectId =" + id);
                    DatabaseConnection.performAction();
                    DatabaseConnection.createStatement("Delete from GroupProject where ProjectId =" + id);
                    DatabaseConnection.performAction();
                    DatabaseConnection.createStatement("Delete from Project where Id =" + id);
                    DatabaseConnection.performAction();

                }
            }
            /*
            if (gvStudents.Columns[e.ColumnIndex].Name.ToString() == "Action2")
            {
                string commandString = "UPDATE StudentInfo SET Name = '" + gvStudents.Rows[e.RowIndex].Cells[1].Value.ToString() +
                    "'  , Degree = '" + gvStudents.Rows[e.RowIndex].Cells[2].Value.ToString() + "' WHERE [Reg No] = '" + gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                SqlCommand newCommand = new SqlCommand(commandString, Active.Connection());
                newCommand.ExecuteNonQuery();
                foreach (Student st in Section.getInstance().ListOfStudents())
                {
                    if (st.RegistrationNumber == gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        st.SetName(gvStudents.Rows[e.RowIndex].Cells[1].Value.ToString());
                        st.SetDegree(gvStudents.Rows[e.RowIndex].Cells[2].Value.ToString());
                    }
                }
                ManageStudents_Load(this, null);

            }
            */
            if (gvStudents.Columns[e.ColumnIndex].Name.ToString() == "Action3")
            {
                MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNoCancel);
                    /*
                Active.LoggedStudent = new Student();
                Active.LoggedStudent.SetName(gvStudents.Rows[e.RowIndex].Cells[1].Value.ToString());
                Active.LoggedStudent.SetRegistrationNumber(gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                Active.LoggedStudent.SetDegree(gvStudents.Rows[e.RowIndex].Cells[2].Value.ToString());
                DMCGenerator.GetInstance().Show();
                this.Hide();
                */
            }

        }

        private void ManageProjects_Load(object sender, EventArgs e)
        {
            gvStudents.Rows.Clear();
            gvStudents.Refresh();
            bool IsConnnected = DatabaseConnection.start();
            DatabaseConnection.createStatement("select Id ,Title from Project");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                gvStudents.Rows.Add(reader["Id"].ToString() , reader["Title"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProject project = AddProject.GetInstance();
            project.Show();
            this.Hide();
        }

        private void btnProjectsReports_Click(object sender, EventArgs e)
        {
            ProjectsReport project = ProjectsReport.GetInstance();
            project.Show();
            this.Hide();

        }
    }
}
