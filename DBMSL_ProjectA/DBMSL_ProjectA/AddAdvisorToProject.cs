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
    public partial class AddAdvisorToProject : Form
    {
        private AddAdvisorToProject()
        {
            InitializeComponent();
        }
        private static AddAdvisorToProject Instance = null;
        public static AddAdvisorToProject GetInstance()
        {
            if (Instance == null)
            {
                AddAdvisorToProject new_Instance = new AddAdvisorToProject();
                return new_Instance;

            }
            return Instance;
        }
        private void AddAdvisorToProject_Load(object sender, EventArgs e)
        {
            DatabaseConnection.start();
            DatabaseConnection.createStatement("select FirstName[FName], LastName[LName] from Person join Advisor on Person.Id = Advisor.Id ");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                cmbSelctAdvisor.Items.Add(reader["FName"].ToString() + " " + reader["LName"].ToString());
            }
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            string[] names = cmbSelctAdvisor.Text.Split(new char[] { ' ' });
            DatabaseConnection.createStatement("select Advisor.Id[id] from Person join Advisor on FirstName = '" + names[0] + "'" +
                " and LastName = '" + names[1] + "'");
            SqlDataReader reader = DatabaseConnection.getData();
            if (reader.Read())
            {
                Advisor advisor = new Advisor();
                advisor.AdvisorId1 = int.Parse(reader["id"].ToString());
                TempData.CurrentAdvisor = advisor;
            }
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
            DatabaseConnection.createStatement("Insert into ProjectAdvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate)" +
                " Values (" + TempData.CurrentAdvisor.AdvisorId1.ToString() + ", " + TempData.CurrentProject.Id + ","+
                TempData.CurrentRole.ToString() + ", '" + sqlFormattedDate + "') ");
            DatabaseConnection.performAction();
            ProjectDashboard projectDashboard = ProjectDashboard.GetInstance();
            projectDashboard.Show();
            this.Hide();

        }
    }
}
