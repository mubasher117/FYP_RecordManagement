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
    public partial class ManageStudent : Form
    {
        private ManageStudent()
        {
            InitializeComponent();
        }
        private static ManageStudent Instance = null;
        public static ManageStudent GetInstance()
        {
            if (Instance == null)
            {
                ManageStudent new_Instance = new ManageStudent();
                return new_Instance;

            }
            return Instance;
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            gvStudents.Rows.Clear();
            gvStudents.Refresh();
            bool IsConnnected = DatabaseConnection.start();
            DatabaseConnection.createStatement("select Person.Id[id], FirstName[Name], RegistrationNo[Registration No] from Person join Student on Person.Id = Student.Id");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                gvStudents.Rows.Add(reader["id"].ToString(), reader["Registration No"].ToString(), reader["Name"].ToString());
            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
        }

        private void gvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            frmRegisterStudent frmRegisterStudent = frmRegisterStudent.GetInstance();
            frmRegisterStudent.Show();
            this.Hide();

        }

        private void gvStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gvStudents.Columns[e.ColumnIndex].Name.ToString() == "Action3")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DatabaseConnection.start();
                    DatabaseConnection.createStatement("Delete from GroupStudent where StudentId =" + id);
                    DatabaseConnection.performAction();
                    DatabaseConnection.createStatement("Delete from Student where Id =" + id);
                    DatabaseConnection.performAction();
                    DatabaseConnection.createStatement("Delete from Person where Id =" + id);
                    DatabaseConnection.performAction();

                }
            }
            if (gvStudents.Columns[e.ColumnIndex].Name.ToString() == "Action2")
            {
                Student student = new Student();
                DatabaseConnection.start();
                DatabaseConnection.createStatement("select Person.Id[id], FirstName[FName], LastName[LName], Contact[Contact], Email[Email] from Person join Student on Person.Id = Student.Id where Student.Id =" + gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                SqlDataReader reader = DatabaseConnection.getData();
                while (reader.Read())
                {
                    student.PersonId = int.Parse(reader["id"].ToString());
                    student.FirstName = reader["FName"].ToString();
                    student.LastName = reader["LName"].ToString();
                    student.Contact = reader["Contact"].ToString();
                    student.Email = reader["Email"].ToString();
                }
                TempData.CurrentStudent = student;
                EditStudent editStudent = new EditStudent();
                editStudent.Show();
                this.Hide();

            }
            if (gvStudents.Columns[e.ColumnIndex].Name.ToString() == "Action")
            {
                gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                DatabaseConnection.createStatement("select * from Person join Student on Person.Id = Student.Id join GroupStudent on Student.Id = GroupStudent.StudentId join GroupProject on GroupStudent.GroupId = GroupProject.GroupId join Project on GroupProject.ProjectId = Project.Id where Student.Id =" + gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                SqlDataReader dataReader = DatabaseConnection.getData();
                if (dataReader.Read())
                {
                    Student student = new Student();
                    student.FirstName = dataReader["FirstName"].ToString();
                    student.LastName = dataReader["LastName"].ToString();
                    student.Contact = dataReader["Contact"].ToString();
                    student.Email = dataReader["Email"].ToString();
                    student.DateOfBirth = DateTime.Parse(dataReader["DateOfBirth"].ToString());
                    student.Gender = int.Parse(dataReader["Gender"].ToString());
                    student.RegistrationNo = dataReader["RegistrationNo"].ToString();
                    student.Status = int.Parse(dataReader["Status"].ToString());
                    student.ProjectTitle = dataReader["Title"].ToString();
                    TempData.CurrentStudent = student;

                    ViewStudent view = ViewStudent.GetInstance();
                    this.Hide();
                    view.Show();


                }

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 0)
            {
                Dashboard dashboard = Dashboard.GetInstance();
                dashboard.Show();
                this.Hide();

            }
            if (tabControl1.SelectedIndex == 1)
            {
                ManageProjects f = ManageProjects.GetInstance();
                f.Show();
                this.Hide();
            }
            if (tabControl1.SelectedIndex == 3)
            {
                ManageAdvisors f = ManageAdvisors.GetInstance();
                f.Show();
                this.Hide();
            }
        }
    }
}