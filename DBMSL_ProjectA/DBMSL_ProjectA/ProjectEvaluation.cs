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
            lblCurrentDate.Text = DateTime.Now.ToShortDateString();
            gvEvaluation.Rows.Clear();
            gvEvaluation.Refresh();
            gvEvaluation.Rows.Add("Group");
            DatabaseConnection.start();

            DatabaseConnection.createStatement("Select * from GroupStudent join Student on GroupStudent.StudentId = Student.Id where GroupStudent.GroupId = " + TempData.CurrentGroupId.ToString());
            SqlDataReader newReader = DatabaseConnection.getData();
            while (newReader.Read())
            {
                gvEvaluation.Rows.Add(newReader["RegistrationNo"]);
            }
            
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            DatabaseConnection.start();
            DatabaseConnection.createStatement("Insert into Evaluation ( Name, TotalMarks, TotalWeightage) "+
                "Values ('Group', " +  gvEvaluation.Rows[0].Cells[1].Value.ToString() + ", " + gvEvaluation.Rows[0].Cells[2].Value.ToString()+ ")" );
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
            "VALUES (" + TempData.CurrentGroupId.ToString()+ ", " + id + ", " + gvEvaluation.Rows[0].Cells[3].Value.ToString() + ", '" + sqlFormattedDate +"') ");
            DatabaseConnection.performAction();


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
    }
}
