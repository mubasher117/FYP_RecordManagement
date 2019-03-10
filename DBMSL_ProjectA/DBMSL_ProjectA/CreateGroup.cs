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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        List<Student> GroupStudents = new List<Student>();

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string RegNo = txtRegistrationNo.Text;
            bool IsConnnected = DatabaseConnection.start();
            DatabaseConnection.createStatement("Select Id from Student where RegistrationNo = '" + RegNo + "'");
            SqlDataReader reader = DatabaseConnection.getData();
            string StudentId = "";
            if (reader.Read())
            {
                StudentId = reader.GetValue(reader.GetOrdinal("Id")).ToString();
                MessageBox.Show(StudentId);
            }
            DatabaseConnection.createStatement("Select * from Person where Id = " + StudentId );
            reader = DatabaseConnection.getData();
            Student student = new Student();
            student.RegistrationNo = RegNo;
            if (reader.Read())
            {
                student.FirstName =  reader.GetString(1).ToString();
                student.LastName =  reader.GetString(2).ToString();
                student.Contact = reader.GetString(3).ToString();
                student.Email = reader.GetString(4).ToString();
                student.DateOfBirth = Convert.ToDateTime(reader.GetDateTime(5));
            }
            GroupStudents.Add(student);
            gvStudents.DataSource = null;
            gvStudents.Refresh();
            foreach(Student s in GroupStudents)
            {
                gvStudents.Rows.Add(s.RegistrationNo, s.FirstName);
            }
            

        }

        private void txtCreateGroup_Click(object sender, EventArgs e)
        {

            bool IsConnnected = DatabaseConnection.start();
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DatabaseConnection.createStatement("INSERT INTO [dbo].[Group] ([Created_On]) VALUES('" + sqlFormattedDate + "')");
            DatabaseConnection.performAction();
            DatabaseConnection.createStatement("Select @@identity as id from Group");
            SqlDataReader reader = DatabaseConnection.getData();
            string id = "0";
            if (reader.Read())
            {
                id = (reader["id"].ToString());
                MessageBox.Show(id);
            }

        }
    }
}
