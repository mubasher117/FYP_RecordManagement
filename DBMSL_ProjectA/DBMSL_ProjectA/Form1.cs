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
using System.Data.Sql;
using System.Collections;

namespace DBMSL_ProjectA
{
    public partial class frmRegisterStudent : Form
    {

        List<string> Values = new List<string>();
        private frmRegisterStudent()
        {
            InitializeComponent();
        }
        private static frmRegisterStudent Instance = null;
        public static frmRegisterStudent GetInstance()
        {
            if (Instance == null)
            {
                frmRegisterStudent new_Instance = new frmRegisterStudent();
                return new_Instance;

            }
            return Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAdvisor addAdvisor =  AddAdvisor.GetInstance();
            addAdvisor.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!IsAnyTextBoxEmpty())
            {
                bool IsConnnected = DatabaseConnection.start();

                bool ISValidStudent = true;

                Student student = new Student();
                try
                {
                    student.FirstName = txtFirstName.Text;
                }
                catch (ArgumentException)
                {
                    ISValidStudent = false;
                    lblFNameWarning.Visible = true;
                }
                try
                {
                    student.LastName = txtLastName.Text;
                }
                catch (ArgumentException)
                {
                    ISValidStudent = false;
                    lblLNameWarning.Visible = true;
                }
                try
                {
                    student.RegistrationNo = txtRegNo.Text;
                }
                catch (ArgumentException)
                {
                    ISValidStudent = false;
                    lblRegWarning.Visible = true;
                }
                try
                {
                    student.Email = txtEmail.Text;
                }
                catch (ArgumentException)
                {
                    ISValidStudent = false;
                    lblEmailWarning.Visible = true;
                }
                if (ISValidStudent)
                {
                    string StudentGender = "0";
                    if (cmbGender.Text == "Male")
                    {
                        StudentGender = "1";
                    }

                    string day = cmbDay.Text;
                    string month = cmbMonth.SelectedIndex.ToString();
                    string year = cmbYear.Text;
                    string studentDOB = year + " - " + month + " - " + day;

                    bool IsException = false;

                    DatabaseConnection.createStatement("select * form Student where RegistrationNo = '" + txtRegNo.Text + " '");
                    SqlDataReader r = DatabaseConnection.getData();
                    if (!r.Read())
                    {
                        IsException = true;
                        MessageBox.Show("This Registration Number already exists");
                    }

                    if (!IsException)
                    {
                        try
                        {
                            DatabaseConnection.createStatement("INSERT INTO Person ( FirstName, LastName, Contact, Email, DateOfBirth, Gender)" +
                        " VALUES('" + txtFirstName.Text + "' , '" + txtLastName.Text + "', '" + txtContactNo.Text + "', '" + txtEmail.Text + "', '" + studentDOB + "' ," + StudentGender + "); ");

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
                        
                        DatabaseConnection.createStatement("INSERT INTO Student (Id, RegistrationNo) VALUES (" + id + ", '" + txtRegNo.Text + "') ");
                        DatabaseConnection.performAction();
                        
                        if (!IsException)
                        {
                            MessageBox.Show("Student added");
                            ManageStudent manageStudent = ManageStudent.GetInstance();
                            manageStudent.Show();
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
                string.IsNullOrWhiteSpace(txtRegNo.Text) || string.IsNullOrWhiteSpace(txtContactNo.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(cmbGender.Text) ||
                cmbDay.Text == "Day" || cmbMonth.Text == "Month" || cmbYear.Text == "Year")
            {

                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    lblFNameWarning.Visible = true;
                }
                if (string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    lblLNameWarning.Visible = true;
                }
                if (string.IsNullOrWhiteSpace(txtRegNo.Text))
                {
                    lblRegWarning.Visible = true;
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
                if (cmbDay.Text == "Day" || cmbMonth.Text == "Month" || cmbYear.Text == "Year")
                {
                    lblDOBwarning.Visible = true;
                }

                return true;
            }
            return false;
        }
        private void frmRegisterStudent_Load(object sender, EventArgs e)
        {

            bool IsConnnected = DatabaseConnection.start();
            cmbDay.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageStudent m = ManageStudent.GetInstance();
            m.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateGroup c = new CreateGroup();
            c.Show();
            this.Hide();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            lblFNameWarning.Visible = false;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

            lblLNameWarning.Visible = false;
        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {
            lblRegWarning.Visible = false;
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            lblCellWarning.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmailWarning.Visible = false;
        }

        private void cmbGender_TextChanged(object sender, EventArgs e)
        {
            lblGenderWarning.Visible = false;
        }

        private void cmbDay_TextChanged(object sender, EventArgs e)
        {
            lblDOBwarning.Visible = false;
        }

        private void cmbMonth_TextChanged(object sender, EventArgs e)
        {
            lblDOBwarning.Visible = false;
        }

        private void cmbYear_TextChanged(object sender, EventArgs e)
        {
            lblDOBwarning.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            ManageStudent m = ManageStudent.GetInstance();
            m.Show();
            this.Hide();
        }
    }
}