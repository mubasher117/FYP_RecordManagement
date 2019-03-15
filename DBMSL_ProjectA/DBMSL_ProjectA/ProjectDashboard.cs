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
    public partial class ProjectDashboard : Form
    {
        private ProjectDashboard()
        {
            InitializeComponent();
        }
        private static ProjectDashboard Instance = null;
        public static ProjectDashboard GetInstance()
        {
            if (Instance == null)
            {
                ProjectDashboard new_Instance = new ProjectDashboard();
                return new_Instance;

            }
            return Instance;
        }
        private void ProjectDashboard_Load(object sender, EventArgs e)
        {
            lblTitle.Text = TempData.CurrentProject.Title;
            List<Advisor> advisors = new List<Advisor>();
            DatabaseConnection.createStatement("select AdvisorId, FirstName, LastName, AdvisorRole from ProjectAdvisor join Advisor on ProjectAdvisor.AdvisorId = Advisor.Id join Person on Advisor.Id = Person.Id where ProjectAdvisor.ProjectId = " + TempData.CurrentProject.Id.ToString());
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                Advisor advisor = new Advisor();
                advisor.AdvisorId1 = int.Parse(reader["AdvisorId"].ToString());
                advisor.BasicDetails.FirstName = reader["FirstName"].ToString();
                advisor.BasicDetails.LastName = reader["LastName"].ToString();
                advisor.Role = int.Parse(reader["AdvisorRole"].ToString());
                advisors.Add(advisor);
            }
            foreach (Advisor a in advisors)
            {
                if (a.Role == 11)
                {
                    lblMainAdvisorName.Text = a.BasicDetails.FirstName + " " + a.BasicDetails.LastName;
                    btnAddMainAdvisor.Text = "Change";
                }
                if (a.Role == 12)
                {
                    lblCoAdvisorName.Text = a.BasicDetails.FirstName + " " + a.BasicDetails.LastName;
                    btnAddCoAdvisor.Text = "Change"; 
                }
                if (a.Role == 14)
                {
                    lblIndustryAdvisorName.Text = a.BasicDetails.FirstName + " " + a.BasicDetails.LastName;
                    btnAddIndustryAdvisor.Text = "Change";
                }
            }

            


        }

        private void btnAddMainAdvisor_Click(object sender, EventArgs e)
        {
            TempData.CurrentRole = 11;
            AddAdvisorToProject addAdvisorToProject = AddAdvisorToProject.GetInstance();
            addAdvisorToProject.Show();
            this.Hide();
        }

        private void btnAddCoAdvisor_Click(object sender, EventArgs e)
        {
            TempData.CurrentRole = 12;
            AddAdvisorToProject addAdvisorToProject = AddAdvisorToProject.GetInstance();
            addAdvisorToProject.Show();
            this.Hide();
        }

        private void btnAddIndustryAdvisor_Click(object sender, EventArgs e)
        {

            TempData.CurrentRole = 14;
            AddAdvisorToProject addAdvisorToProject = AddAdvisorToProject.GetInstance();
            addAdvisorToProject.Show();
            this.Hide();
        }

        private void btnViewMainAdvisor_Click(object sender, EventArgs e)
        {
        }

        private void btnEvaluation_Click(object sender, EventArgs e)
        {
            ProjectEvaluation evaluation = ProjectEvaluation.GetInstance();
            evaluation.Show();
            this.Hide();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            AssignGroup assignGroup = AssignGroup.GetInstance();
            assignGroup.Show();
            this.Hide();
        }
    }
}
