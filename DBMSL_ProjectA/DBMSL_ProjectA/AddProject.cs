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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {

            DatabaseConnection.createStatement("INSERT INTO Project ( Title, Description)" +
            " VALUES('" + txtTitle.Text + "' , '" + txtDescription.Text + "'); ");
            DatabaseConnection.performAction();
        }
    }
}
