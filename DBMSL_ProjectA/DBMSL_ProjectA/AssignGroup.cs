using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSL_ProjectA
{
    public partial class AssignGroup : Form
    {
        private AssignGroup()
        {
            InitializeComponent();
        }
        private static AssignGroup Instance = null;
        public static AssignGroup GetInstance()
        {
            if (Instance == null)
            {
                AssignGroup new_Instance = new AssignGroup();
                return new_Instance;

            }
            return Instance;
        }
        private void AssignGroup_Load(object sender, EventArgs e)
        {
            DatabaseConnection.start();
            gvStudents.Rows.Clear();
            gvStudents.Refresh();

            List<string> groupIds = new List<string>();

            bool IsConnnected = DatabaseConnection.start();

            DatabaseConnection.createStatement("select Id from [Group]");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                groupIds.Add(reader["Id"].ToString());
            }
            
            foreach (string group in groupIds)
            {
                List<string> groupMembers = new List<string>();
                DatabaseConnection.createStatement("select Student.RegistrationNo[reg] from GroupStudent join Student on GroupStudent.StudentId = Student.Id where GroupId = " + group );
                SqlDataReader reader2 = DatabaseConnection.getData();
                while (reader2.Read())
                {
                    groupMembers.Add(reader2["reg"].ToString());
                }
                if (groupMembers.Count != 0)
                {
                    DataGridViewRow row = (DataGridViewRow)gvStudents.Rows[0].Clone();
                    row.Cells[0].Value = group;
                    int i = 1;
                    foreach (string member in groupMembers)
                    {
                        row.Cells[i].Value = member;
                        ++i;
                    }
                    gvStudents.Rows.Add(row);

                }
               
                
            }

        }

        private void gvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvStudents.Columns[e.ColumnIndex].Name.ToString() == "Assign")
            {
                bool IsAlready = false;
                DatabaseConnection.createStatement("select ProjectId from GroupProject where GroupId = " + gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                SqlDataReader newReader = DatabaseConnection.getData();
                if (newReader.Read())
                {
                    IsAlready = true;
                }
                if (IsAlready)
                {
                    MessageBox.Show("This group is already assigned");
                }
                else
                {
                    string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    DatabaseConnection.start();
                    DatabaseConnection.createStatement("Insert into GroupProject (ProjectId, GroupId, AssignmentDate)" +
                        " Values (" + TempData.CurrentProject.Id + ", " + gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString() + ", '" +
                        sqlFormattedDate + "')");
                    DatabaseConnection.performAction();

                    DatabaseConnection.createStatement("Update GroupStudent set Status = 4 where GroupId = " + gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                    DatabaseConnection.performAction();

                    ProjectDashboard projectDashboard = ProjectDashboard.GetInstance();
                    projectDashboard.Show();
                    this.Hide();
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProjectDashboard projectDashboard = ProjectDashboard.GetInstance();
            projectDashboard.Show();
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ProjectDashboard projectDashboard = ProjectDashboard.GetInstance();
            projectDashboard.Show();
            this.Hide();
        }
    }
}
