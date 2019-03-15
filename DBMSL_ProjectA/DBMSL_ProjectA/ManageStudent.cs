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
            DatabaseConnection.createStatement("select Person.Id[id], FirstName[Name], RegistrationNo[Registration No] from Person join Student on Person.Id = Student.Id");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                gvStudents.Rows.Add(reader["id"].ToString(), reader["Registration No"].ToString(), reader["Name"].ToString());
            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmRegisterStudent frmRegisterStudent = frmRegisterStudent.GetInstance();
            frmRegisterStudent.Show();
            this.Hide();
        }

        private void gvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        }
    }
}
