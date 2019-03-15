using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSL_ProjectA
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = TempData.CurrentStudent.FirstName;
            txtLastName.Text = TempData.CurrentStudent.LastName;
            txtContactNo.Text = TempData.CurrentStudent.Contact;
            txtEmail.Text = TempData.CurrentStudent.Email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseConnection.createStatement("update Person set FirstName = '" + txtFirstName.Text + "' , LastName = '" + txtLastName.Text + "', Contact = '" + txtContactNo.Text + "', Email = '" + txtEmail.Text + "'" +
                " where Id = " + TempData.CurrentStudent.PersonId);
            DatabaseConnection.performAction();
            MessageBox.Show("Changes are saved");
            ManageStudent manageStudent = ManageStudent.GetInstance();
            manageStudent.Show();
            this.Hide();
            
        }
    }
}
