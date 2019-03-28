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
    public partial class Marksheet : Form
    {
        private Marksheet()
        {
            InitializeComponent();
        }
        private static Marksheet Instance = null;
        public static Marksheet GetInstance()
        {
            if (Instance == null)
            {
                Marksheet new_Instance = new Marksheet();
                return new_Instance;

            }
            return Instance;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Marksheet_Load(object sender, EventArgs e)
        {
            DatabaseConnection.createStatement("Select * from GroupStudent join Student on GroupStudent.StudentId = Student.Id where GroupId = " + TempData.CurrentGroupId);
            SqlDataReader sqlDataReader = DatabaseConnection.getData();
            int i = 4;
            while (sqlDataReader.Read())
            {
                gvMarksheet.Columns[i].HeaderText = sqlDataReader["RegistrationNo"].ToString();
                ++i;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProjectDashboard projectDashboard = ProjectDashboard.GetInstance();
            projectDashboard.Show();
            this.Hide();
        }
    }
}
