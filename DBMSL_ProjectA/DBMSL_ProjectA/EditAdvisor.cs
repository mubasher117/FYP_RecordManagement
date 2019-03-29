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
    public partial class EditAdvisor : Form
    {
        public EditAdvisor()
        {
            InitializeComponent();
        }

        private void EditAdvisor_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = TempData.CurrentAdvisor.BasicDetails.FirstName;
            txtLastName.Text = TempData.CurrentAdvisor.BasicDetails.LastName;
            txtContactNo.Text = TempData.CurrentAdvisor.BasicDetails.Contact;
            txtEmail.Text = TempData.CurrentAdvisor.BasicDetails.Email;
            txtSallary.Text = TempData.CurrentAdvisor.Salary.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseConnection.createStatement("update Person set FirstName = '" + txtFirstName.Text + "' , LastName = '" + txtLastName.Text + "', Contact = '" + txtContactNo.Text + "', Email = '" + txtEmail.Text + "'" +
                " where Id = " + TempData.CurrentAdvisor.AdvisorId1);
            DatabaseConnection.performAction();
            DatabaseConnection.createStatement("update Advisor set Salary = " + txtSallary.Text + 
                " where Id = " + TempData.CurrentAdvisor.AdvisorId1);
            DatabaseConnection.performAction();
            MessageBox.Show("Changes are saved");
            ManageAdvisors manageAdvisor = ManageAdvisors.GetInstance();
            manageAdvisor.Show();
            this.Hide();
        }
    }
}
