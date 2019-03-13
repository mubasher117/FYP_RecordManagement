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
            gvStudents.Rows.Clear();
            gvStudents.Refresh();
            bool IsConnnected = DatabaseConnection.start();
            DatabaseConnection.createStatement("select FirstName[Name], RegistrationNo[Registration No] from Person join Student on Person.Id = Student.Id");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                gvStudents.Rows.Add(reader["Registration No"].ToString(), reader["Name"].ToString());
            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmRegisterStudent frmRegisterStudent = frmRegisterStudent.GetInstance();
            frmRegisterStudent.Show();
            this.Hide();
        }
    }
}
