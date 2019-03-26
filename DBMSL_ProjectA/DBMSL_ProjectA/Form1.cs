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
            /*
            DatabaseConnection.createStatement("INSERT INTO Person ( FirstName, LastName, Contact, Email, DateOfBirth, Gender)" + 
            "VALUES('Mushi', 'Ahmad', '031342431147', 'mushi.ahmad1101@gmail.com', 1998 - 9 - 30, 1); ");
            DatabaseConnection.performAction();
            
             SqlDataReader reader = DatabaseConnection.getData();
            textBox1.Text = "Result";
            while (reader.Read())
            {
                Values.Add(reader["Value"].ToString());
            }
            DatabaseConnection.close();
            foreach (string s in Values)
            {
                richTextBox1.Text += s;
                richTextBox1.Text += "\n";

            }
            
            DatabaseConnection.createStatement("Select @@identity as id from Person");
            SqlDataReader reader = DatabaseConnection.getData();
            string id = "0";
            while (reader.Read())
            {
               id = (reader["id"].ToString());
            }
            MessageBox.Show(id);
            
            DatabaseConnection.createStatement("INSERT INTO Student (Id, RegistrationNo) VALUES( "+ id +",'2016-CS-312') ");
            DatabaseConnection.performAction();
            
            */
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
            bool IsConnnected = DatabaseConnection.start();
            if (IsConnnected)
            {
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Error");

            }

            Student student = new Student();
            try
            {
                student.FirstName = txtFirstName.Text;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Enter First Name");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Name should be alphabets only");
            }
            string StudentGender = "0";
            if ( cmbGender.Text == "Male")
            {
                StudentGender = "1";
            }

            string day = cmbDay.Text;
            string month = cmbMonth.SelectedIndex.ToString();
            string year = cmbYear.Text;
            string studentDOB = year + " - " + month + " - " + day;
            
            
            DatabaseConnection.createStatement("INSERT INTO Person ( FirstName, LastName, Contact, Email, DateOfBirth, Gender)" +
            " VALUES('" + txtFirstName.Text + "' , '" + txtLastName.Text + "', '" + txtContactNo.Text + "', '"+ txtEmail.Text+ "', '"+studentDOB+"' ," + StudentGender+"); ");
            DatabaseConnection.performAction();
            
            DatabaseConnection.createStatement("Select @@identity as id from Person");
            SqlDataReader reader = DatabaseConnection.getData();
            string id = "0";
            while (reader.Read())
            {
                id = (reader["id"].ToString());
            }

            DatabaseConnection.createStatement("INSERT INTO Student (Id, RegistrationNo) VALUES ("+id+", '"+txtRegNo.Text+"') ");
            DatabaseConnection.performAction();
            MessageBox.Show("Student added");
            ManageStudent manageStudent = ManageStudent.GetInstance();
            manageStudent.Show();
            this.Hide();

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
    }
}