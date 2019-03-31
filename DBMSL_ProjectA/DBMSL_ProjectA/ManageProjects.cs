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
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
using iTextSharp.text;
using System.Web.UI;

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
            tabControl1.SelectedIndex = 1;
            gvStudents.Rows.Clear();
            gvStudents.Refresh();
            bool IsConnnected = DatabaseConnection.start();
            DatabaseConnection.createStatement("select * from Project");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                gvStudents.Rows.Add(reader["Id"].ToString() , reader["Title"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnProjectsReports_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Dashboard dashboard = Dashboard.GetInstance();
                dashboard.Show();
                this.Hide();

            }
            if (tabControl1.SelectedIndex == 2)
            {
                ManageStudent f = ManageStudent.GetInstance();
                f.Show();
                this.Hide();
            }
            if (tabControl1.SelectedIndex == 3)
            {
                ManageAdvisors f = ManageAdvisors.GetInstance();
                f.Show();
                this.Hide();
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            AddProject project = AddProject.GetInstance();
            project.Show();
            this.Hide();

        }

        private void btnProjectsReports_Click_1(object sender, EventArgs e)
        {
            ProjectsReport project = ProjectsReport.GetInstance();
            project.Show();
            this.Hide();

        }

        private void gvStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gvStudents.Columns[e.ColumnIndex].Name.ToString() == "Action")
            {
                Project project = new Project();
                project.Title = gvStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
                DatabaseConnection.createStatement("select Description from Project where Id = " + gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                SqlDataReader newReader = DatabaseConnection.getData();
                if (newReader.Read())
                {
                    project.Description = newReader["Description"].ToString();
                }
                project.Id = int.Parse(gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                TempData.CurrentProject = project;
                ProjectDashboard projectDashboard = ProjectDashboard.GetInstance();
                projectDashboard.Show();
                this.Hide();

            }
            if (gvStudents.Columns[e.ColumnIndex].Name.ToString() == "Action3")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DatabaseConnection.start();
                    DatabaseConnection.createStatement("Delete from ProjectAdvisor where ProjectId =" + id);
                    DatabaseConnection.performAction();
                    DatabaseConnection.createStatement("Delete from GroupProject where ProjectId =" + id);
                    DatabaseConnection.performAction();
                    DatabaseConnection.createStatement("Delete from Project where Id =" + id);
                    DatabaseConnection.performAction();

                }
            }


        }

        private void Home_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMarkSheet_Click(object sender, EventArgs e)
        {
            List<Project> Projects = new List<Project>();
            List<DateTime> Dates = new List<DateTime>();



            DatabaseConnection.createStatement("select  CONVERT(date, EvaluationDate)as EDate from GroupEvaluation  group by CONVERT(date, EvaluationDate) order by CONVERT(date, EvaluationDate) desc");
            SqlDataReader firstReader = DatabaseConnection.getData();
            while (firstReader.Read())
            {
                Dates.Add(DateTime.Parse( firstReader["EDate"].ToString()));
            }


            DatabaseConnection.createStatement("select * from Project");
            SqlDataReader dataReader = DatabaseConnection.getData();
            while (dataReader.Read())
            {
                Project project = new Project();
                project.Id = int.Parse(dataReader["Id"].ToString());
                project.Title = dataReader["Title"].ToString();
                Projects.Add(project);
            }



            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            StringBuilder sb = new StringBuilder();

            //Generate Invoice (Bill) Header.

            sb.Append("<p style=\"text-align:center; font-size: 32px; \"><b>University of Engineering and Technology, Lahore</b></p>");
            sb.Append("<p style=\"text-align:center; font-size: 20px; \"><b>CSE Department</b></p>");
            sb.Append("<p style=\"text-align:center; \"><b><u>Mark Sheet</b></u></p>");


            StringReader sr = new StringReader(sb.ToString());




            PdfPTable tbl = new PdfPTable(Dates.Count + 1);
            tbl.AddCell("Date");
            foreach (DateTime date in Dates)
            {
                tbl.AddCell(date.ToShortDateString().ToString());
            }

            List<Evaluation> evaluations = new List<Evaluation>();
            foreach(DateTime date in Dates)
            {
                string d = date.ToString("yyyy-MM-dd");
                DatabaseConnection.createStatement("Select * from GroupEvaluation join Evaluation on GroupEvaluation.EvaluationId = Evaluation.Id where CONVERT(date, GroupEvaluation.EvaluationDate) = CONVERT(date, '" + d + "')");
                SqlDataReader sqlDataReader = DatabaseConnection.getData();
                if (sqlDataReader.Read())
                {
                    Evaluation evaluation = new Evaluation();
                    evaluation.Date = d;
                    evaluation.TotalMarks = sqlDataReader["TotalMarks"].ToString();
                    evaluation.TotalWeightage = sqlDataReader["TotalWeightage"].ToString();
                    evaluations.Add(evaluation);
                }

            }

            tbl.AddCell("Total Marks");
            foreach(Evaluation eval in evaluations)
            {
                tbl.AddCell(eval.TotalMarks);
            }
            tbl.AddCell("Weightage");

            foreach (Evaluation eval in evaluations)
            {
                tbl.AddCell(eval.TotalWeightage);
            }

            foreach (Project p in Projects)
            {
                tbl.AddCell(p.Title);
                foreach (DateTime d in Dates)
                {
                    string date = d.ToString("yyyy-MM-dd");
                    DatabaseConnection.createStatement("select * from Project join GroupProject on Project.Id = GroupProject.ProjectId join GroupEvaluation on GroupProject.GroupId = GroupEvaluation.GroupId join Evaluation on GroupEvaluation.EvaluationId = Evaluation.Id where Project.Id = " + p.Id + " and CONVERT(date, GroupEvaluation.EvaluationDate) = CONVERT(date, '"+ date + "') order by GroupEvaluation.EvaluationDate");
                    SqlDataReader reader2 = DatabaseConnection.getData();
                    if (reader2.Read())
                    {
                        tbl.AddCell(reader2["ObtainedMarks"].ToString());
                    }
                    else
                    {
                        tbl.AddCell("N/A");
                    }
                }
            }





            SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4.Rotate());
                HTMLWorker htmlparser = new HTMLWorker(document);

                try
                {
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();
                    htmlparser.Parse(sr);
                    document.Add(new iTextSharp.text.Paragraph("\n Date : " + DateTime.Now.ToShortDateString() + "\n \n"));
                    document.Add(tbl);
                    document.Add(new iTextSharp.text.Paragraph("\n \n This report was generated by computer. Errors are acceptible. "));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    document.Close();
                }
                MessageBox.Show("Report saved successfully");
            }

        }

        private void lblEvaluate_Click(object sender, EventArgs e)
        {
            ProjectEvaluation evaluation = ProjectEvaluation.GetInstance();
            evaluation.Show();
            this.Hide();
        }
    }
}
