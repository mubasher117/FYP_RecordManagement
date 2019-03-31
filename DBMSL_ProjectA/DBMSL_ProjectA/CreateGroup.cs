using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace DBMSL_ProjectA
{
    public partial class CreateGroup : Form
    {
        public CreateGroup()
        {
            InitializeComponent();
        }
        private static CreateGroup Instance = null;
        public static CreateGroup GetInstance()
        {
            if (Instance == null)
            {
                CreateGroup new_Instance = new CreateGroup();
                return new_Instance;

            }
            return Instance;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string RegNo = cmbSelectStudent.Text;
            bool IsConnnected = DatabaseConnection.start();
            DatabaseConnection.createStatement("select * from GroupStudent join Student on GroupStudent.StudentId = Student.Id where Student.RegistrationNo = '" + RegNo + "'");
            SqlDataReader sqlDataReader = DatabaseConnection.getData();
            if (!sqlDataReader.Read())
            {
                DatabaseConnection.createStatement("Select Id from Student where RegistrationNo = '" + RegNo + "'");
                SqlDataReader reader = DatabaseConnection.getData();
                string StudentId = "";
                if (reader.Read())
                {
                    StudentId = reader.GetValue(reader.GetOrdinal("Id")).ToString();
                }

                DatabaseConnection.createStatement("Select * from Person where Id = " + StudentId);
                reader = DatabaseConnection.getData();
                Student student = new Student();
                student.RegistrationNo = RegNo;
                student.StudentId = int.Parse(StudentId);
                if (reader.Read())
                {
                    student.FirstName = reader.GetString(1).ToString();
                    student.LastName = reader.GetString(2).ToString();
                    student.Contact = reader.GetString(3).ToString();
                    student.Email = reader.GetString(4).ToString();
                    student.DateOfBirth = Convert.ToDateTime(reader.GetDateTime(5));
                }
                TempData.add_GroupStudent(student);
                gvStudents.Rows.Clear();
                gvStudents.Refresh();
                foreach (Student s in TempData.GetGroupStudents())
                {
                    gvStudents.Rows.Add(s.RegistrationNo, s.FirstName);
                }
            }
            else
            {
                MessageBox.Show("Student already a part of another group");
            }

        }

        private void txtCreateGroup_Click(object sender, EventArgs e)
        {
            if (gvStudents.RowCount != 0)
            {
                // These queries are done without the Database class.

                string conStr = "Data Source=MUSHI\\MUSHISQL;Initial Catalog=LabProjectA;Integrated Security=True; MultipleActiveResultSets=true";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (con.State == ConnectionState.Open)
            {
                string Insert = "INSERT INTO [dbo].[Group](Created_On) VALUES ('" + sqlFormattedDate + "')";
                SqlCommand cmd = new SqlCommand(Insert, con);
                cmd.ExecuteNonQuery();
            }
            
            string I = "Select @@identity as id from [Group]";
            SqlCommand cm = new SqlCommand(I, con);

            SqlDataReader reader = cm.ExecuteReader();

            string id = "0";

            if (reader.Read())
            {
                id = (reader["id"].ToString());
            }


            foreach (Student s in TempData.GetGroupStudents())
            {
                DatabaseConnection.createStatement("Insert into GroupStudent (GroupId, StudentId ,Status , AssignmentDate) " +
                    "Values (" + id + "," + s.StudentId.ToString() + ", 4 ,'" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                DatabaseConnection.performAction();
            }
            TempData.Clear_GroupStudents();
            gvStudents.Rows.Clear();
            gvStudents.Refresh();
            cmbSelectStudent.Text = "";
                MessageBox.Show("Group has been Created");

            }
            else
            {
                MessageBox.Show("Select at least one student");
            }
            

        }

        private void gvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateGroup_Load(object sender, EventArgs e)
        {
            DatabaseConnection.start();
            DatabaseConnection.createStatement("select RegistrationNo from Person join Student on Person.Id = Student.Id ");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                cmbSelectStudent.Items.Add(reader["RegistrationNO"].ToString() );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = Dashboard.GetInstance();
            dashboard.Show();
            this.Hide();
        }
    }
}
