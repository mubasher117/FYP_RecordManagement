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
    public partial class ViewStudent : Form
    {
        private ViewStudent()
        {
            InitializeComponent();
        }
        private static ViewStudent Instance = null;
        public static ViewStudent GetInstance()
        {
            if (Instance == null)
            {
                ViewStudent new_Instance = new ViewStudent();
                return new_Instance;

            }
            return Instance;
        }
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = TempData.CurrentStudent.FirstName;
            lblLastName.Text = TempData.CurrentStudent.LastName;
            lblRegistrationNo.Text = TempData.CurrentStudent.RegistrationNo;
            lblCellNo.Text = TempData.CurrentStudent.Contact;
            lblDOB.Text = TempData.CurrentStudent.DateOfBirth.ToString("dd MMMM yyyy ");
            lblEmail.Text = TempData.CurrentStudent.Email;
            lblTitle.Text = TempData.CurrentStudent.ProjectTitle;
            if (TempData.CurrentStudent.Status == 4)
            {
                lblStatus.Text = "Active";
            }
            else
            {
                lblStatus.Text = "Inactive";
            }
            if (TempData.CurrentStudent.Gender == 1)
            {
                lblGender.Text = "Male";
            }
            else
            {
                lblGender.Text = "Female";
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ManageStudent manage = ManageStudent.GetInstance();
            manage.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            ManageStudent manage = ManageStudent.GetInstance();
            manage.Show();
            this.Hide();
        }
    }
}
