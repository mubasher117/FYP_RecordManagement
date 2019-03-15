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
    public partial class ProjectEvaluation : Form
    {
        private ProjectEvaluation()
        {
            InitializeComponent();
        }
        private static ProjectEvaluation Instance = null;
        public static ProjectEvaluation GetInstance()
        {
            if (Instance == null)
            {
                ProjectEvaluation new_Instance = new ProjectEvaluation();
                return new_Instance;

            }
            return Instance;
        }
        private void ProjectEvaluation_Load(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Now.ToShortDateString();
            gvEvaluation.Rows.Clear();
            gvEvaluation.Refresh();
            gvEvaluation.Rows.Add("Group");
            DatabaseConnection.start();
            
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            //            Name TotalMarks TotalWeightage
            DatabaseConnection.start();

        }
    }
}
