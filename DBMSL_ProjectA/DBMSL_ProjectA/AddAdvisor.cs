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
            if (!IsAnyTextBoxEmpty())
            {
                bool IsConnnected = DatabaseConnection.start();
                bool ISValidAdvisor = true;

                Student student = new Student();
                Advisor advisor = new Advisor();
                try
                {
                    student.FirstName = txtFirstName.Text;
                }
                catch (ArgumentException)
                {
                    ISValidAdvisor = false;
                    lblFNameWarning.Visible = true;
                }
                try
                {
                    student.LastName = txtLastName.Text;
                }
                catch (ArgumentException)
                {
                    ISValidAdvisor = false;
                    lblLNameWarning.Visible = true;
                }
                try
                {
                    student.Email = txtEmail.Text;
                }
                catch (ArgumentException)
                {
                    ISValidAdvisor = false;
                    lblEmailWarning.Visible = true;
                }

                if (ISValidAdvisor)
                {
                    string StudentGender = "2";
                    if (cmbGender.Text == "Male")
                    {
                        StudentGender = "1";
                    }
                    string day = cmbDay.Text;
                    string month = cmbMonth.SelectedIndex.ToString();
                    string year = cmbYear.Text;
                    string advisorDOB = year + " - " + month + " - " + day;
                    bool IsException = false;
                    if (!IsException)
                    {
                        try
                        {
                            DatabaseConnection.createStatement("INSERT INTO Person ( FirstName, LastName, Contact, Email, DateOfBirth, Gender)" +
                    " VALUES('" + txtFirstName.Text + "' , '" + txtLastName.Text + "', '" + txtContactNo.Text + "', '" + txtEmail.Text + "', '" + advisorDOB + "'," + StudentGender + "); ");
                    DatabaseConnection.performAction();
                        }
                        catch (SqlException)
                        {
                            IsException = true;
                            lblDOBwarning.Visible = true;
                        }
                    }
                    if (!IsException)
                    {
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

                        DatabaseConnection.createStatement("INSERT INTO Advisor (Id, Designation, Salary) VALUES (" + id + "," + advisorDesignation + "," + txtSalary.Text + ") ");
                        DatabaseConnection.performAction();
                        if (!IsException)
                        {
                            MessageBox.Show("Advisor added");
                            ManageAdvisors manageAdvisors = ManageAdvisors.GetInstance();
                            manageAdvisors.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
        private bool IsAnyTextBoxEmpty()
        {
            if (
                string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(cmbDesignation.Text) || string.IsNullOrWhiteSpace(txtContactNo.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(cmbGender.Text) ||
                cmbDay.Text == "Day" || cmbMonth.Text == "Month" || cmbYear.Text == "Year" || string.IsNullOrWhiteSpace(txtSalary.Text) )
            {

                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    lblFNameWarning.Visible = true;
                }
                if (string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    lblLNameWarning.Visible = true;
                }
                if (string.IsNullOrWhiteSpace(cmbDesignation.Text))
                {
                    lblDesgWarning.Visible = true;
                }
                if (string.IsNullOrWhiteSpace(txtContactNo.Text))
                {
                    lblCellWarning.Visible = true;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    lblEmailWarning.Visible = true;
                }
                if (string.IsNullOrWhiteSpace(cmbGender.Text))
                {
                    lblGenderWarning.Visible = true;
                }
                if (string.IsNullOrWhiteSpace(txtSalary.Text))
                {
                    lblSalaryWarning.Visible = true;
                }

                if (cmbDay.Text == "Day" || cmbMonth.Text == "Month" || cmbYear.Text == "Year")
                {
                    lblDOBwarning.Visible = true;
                }

                return true;
            }
            return false;
        }
        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            lblFNameWarning.Visible = false;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lblLNameWarning.Visible = false;
        }

        private void cmbDesignation_TextChanged(object sender, EventArgs e)
        {
            lblDesgWarning.Visible = false;
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            lblCellWarning.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmailWarning.Visible = false;
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGenderWarning.Visible = false;
        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDOBwarning.Visible = false;
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDOBwarning.Visible = false;
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDOBwarning.Visible = false;
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            lblDOBwarning.Visible = false;
        }
    }
}
