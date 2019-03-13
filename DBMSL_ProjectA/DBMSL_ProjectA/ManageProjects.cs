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
    public partial class ManageProjects : Form
    {
        private ManageProjects()
        {
            InitializeComponent();
        }
        private static ManageProjects Instance = null;
        public static ManageProjects GetInstance()
        {
            if (Instance == null)
            {
                ManageProjects new_Instance = new ManageProjects();
                return new_Instance;

            }
            return Instance;
        }

        private void gvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageProjects_Load(object sender, EventArgs e)
        {
            gvStudents.Rows.Clear();
            gvStudents.Refresh();
            bool IsConnnected = DatabaseConnection.start();
            DatabaseConnection.createStatement("select Title from Project");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                gvStudents.Rows.Add(reader["Title"].ToString());
            }
        }
    }
}
