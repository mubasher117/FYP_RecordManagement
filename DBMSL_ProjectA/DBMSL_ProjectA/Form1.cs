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
    public partial class Form1 : Form
    {

        List<string> Values = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DatabaseConnection.createStatement("INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender)" + 
            "VALUES('Mushi', 'Ahmad', '031342431147', 'mushi.ahmad1101@gmail.com', 1998 - 9 - 30, 1); ");
            DatabaseConnection.performAction();
            
            /* SqlDataReader reader = DatabaseConnection.getData();
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

            }*/
            
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
            
            
        }

    }
}
