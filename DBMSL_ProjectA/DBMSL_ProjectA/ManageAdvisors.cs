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
    public partial class ManageAdvisors : Form
    {
        private ManageAdvisors()
        {
            InitializeComponent();
        }
        private static ManageAdvisors Instance = null;
        public static ManageAdvisors GetInstance()
        {
            if (Instance == null)
            {
                ManageAdvisors new_Instance = new ManageAdvisors();
                return new_Instance;

            }
            return Instance;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAdvisor addAdvisor = AddAdvisor.GetInstance();
            addAdvisor.Show();
            this.Hide();
        }

        private void ManageAdvisors_Load(object sender, EventArgs e)
        {

            gvAdvisors.Rows.Clear();
            gvAdvisors.Refresh();
            bool IsConnnected = DatabaseConnection.start();
            DatabaseConnection.createStatement("select Person.Id[id], FirstName[FName], LastName[LName], Designation[Des] from Person join Advisor on Person.Id = Advisor.Id");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                string name = reader["FName"].ToString() + " " + reader["LName"].ToString();
                string designation = "Professor";
                string inputDesignation = reader["Des"].ToString();
                if (inputDesignation == "7")
                {
                    designation = "Associate Professor";
                }
                if (inputDesignation == "8")
                {
                    designation = "Assistant Professor";
                }
                if (inputDesignation == "9")
                {
                    designation = "Lecturer";
                }
                if (inputDesignation == "10")
                {
                    designation = "Industry Professional";
                }

                gvAdvisors.Rows.Add(reader["id"].ToString(),name, designation);
            }
        }

        private void gvAdvisors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvAdvisors.Columns[e.ColumnIndex].Name.ToString() == "Action3")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = gvAdvisors.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DatabaseConnection.start();
                    DatabaseConnection.createStatement("Delete from ProjectAdvisor where AdvisorId =" + id);
                    DatabaseConnection.performAction();
                    DatabaseConnection.createStatement("Delete from Advisor where Id =" + id);
                    DatabaseConnection.performAction();
                    DatabaseConnection.createStatement("Delete from Person where Id =" + id);
                    DatabaseConnection.performAction();

                }


            }
            if (gvAdvisors.Columns[e.ColumnIndex].Name.ToString() == "Action2")
            {
                Advisor advisor = new Advisor();
                DatabaseConnection.start();
                DatabaseConnection.createStatement("select Person.Id[id], FirstName[FName], LastName[LName], Contact[Contact], Email[Email], Salary[Salary]  from Person join Advisor on Person.Id = Advisor.Id where Advisor.Id =" + gvAdvisors.Rows[e.RowIndex].Cells[0].Value.ToString());
                SqlDataReader reader = DatabaseConnection.getData();
                while (reader.Read())
                {
                    advisor.AdvisorId1 = int.Parse(reader["id"].ToString());
                    advisor.BasicDetails.FirstName = reader["FName"].ToString();
                    advisor.BasicDetails.LastName = reader["LName"].ToString();
                    advisor.BasicDetails.Contact = reader["Contact"].ToString();
                    advisor.BasicDetails.Email = reader["Email"].ToString();
                    advisor.Sallary = int.Parse(reader["Salary"].ToString());

                }
                TempData.CurrentAdvisor = advisor;
                EditAdvisor editAdvisor = new EditAdvisor();
                editAdvisor.Show();
                this.Hide();

            }
        }
    }
}
