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
    public partial class Dashboard : Form
    {
        private Dashboard()
        {
            InitializeComponent();
        }
        private static Dashboard Instance = null;
        public static Dashboard GetInstance()
        {
            if (Instance == null)
            {
                Dashboard new_Instance = new Dashboard();
                return new_Instance;

            }
            return Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageProjects manageProjects = ManageProjects.GetInstance();
            manageProjects.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageStudent m = ManageStudent.GetInstance();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdvisors_Click(object sender, EventArgs e)
        {

        }
    }
}
