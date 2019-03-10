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
    public partial class Evaluation : Form
    {
        private Evaluation()
        {
            InitializeComponent();
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {

        }
        private static Evaluation Instance = null;
        public static Evaluation GetInstance()
        {
            if (Instance == null)
            {
                Evaluation evaluation = new Evaluation();
                return evaluation;
            }
            return Instance;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {

        }
    }
}
