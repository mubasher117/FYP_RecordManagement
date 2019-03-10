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
    public partial class AddAdvisor : Form
    {
        private AddAdvisor()
        {
            InitializeComponent();
        }
        private static AddAdvisor Instance = null;
        public static AddAdvisor GetInstance()
        {
            if (Instance == null)
            {
                AddAdvisor new_Instance = new AddAdvisor();
                return new_Instance;

            }
            return Instance;
        }
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AddAdvisor_Load(object sender, EventArgs e)
        {
            cmbDay.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            bool IsConnnected = DatabaseConnection.start();

            string StudentGender = "0";
            if (cmbGender.Text == "Male")
            {
                StudentGender = "1";
            }

            string day = cmbDay.Text;
            string month = cmbMonth.SelectedIndex.ToString();
            string year = cmbYear.Text;
            string advisorDOB = year + " - " + month + " - " + day;

            DatabaseConnection.createStatement("INSERT INTO Person ( FirstName, LastName, Contact, Email, DateOfBirth, Gender)" +
            " VALUES('" + txtFirstName.Text + "' , '" + txtLastName.Text + "', '" + txtContactNo.Text + "', '" + txtEmail.Text + "', " + advisorDOB + "," + StudentGender + "); ");
            DatabaseConnection.performAction();

            DatabaseConnection.createStatement("Select @@identity as id from Person");
            SqlDataReader reader = DatabaseConnection.getData();
            string id = "0";
            while (reader.Read())
            {
                id = (reader["id"].ToString());
            }
            string advisorDesignation = "6";
            if (cmbDesignation.SelectedIndex == 1)
            {
                advisorDesignation = "7";
            }
            if (cmbDesignation.SelectedIndex == 2)
            {
                advisorDesignation = "8";
            }
            if (cmbDesignation.SelectedIndex == 3)
            {
                advisorDesignation = "9";
            }
            if (cmbDesignation.SelectedIndex == 4)
            {
                advisorDesignation = "10";
            }

            DatabaseConnection.createStatement("INSERT INTO Advisor (Id, Designation, Salary) VALUES (" + id + ","+advisorDesignation+","+ txtSalary.Text+") ");
            DatabaseConnection.performAction();


        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
