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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace DBMSL_ProjectA
{
    public partial class ProjectsReport : Form
    {
        private ProjectsReport()
        {
            InitializeComponent();
        }
        private static ProjectsReport Instance = null;
        public static ProjectsReport GetInstance()
        {
            if (Instance == null)
            {
                ProjectsReport new_Instance = new ProjectsReport();
                return new_Instance;

            }
            return Instance;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageProjects manageProjects = ManageProjects.GetInstance();
            manageProjects.Show();
            this.Hide();
        }
        static string stringToCenter = "hello";
        static int stringToCenterLength = stringToCenter.Length;
        static int totalLength = 500;

        string centeredString = stringToCenter.PadLeft((totalLength - stringToCenterLength) / 2);
        private string PDF_Write = "";

        private void ProjectsReport_Load(object sender, EventArgs e)
        {
            DatabaseConnection.start();
            gvReport.Rows.Clear();
            gvReport.Refresh();

            List<ProjectReport> reports = new List<ProjectReport>();
            List<string> ProjectIds = new List<string>();

            bool IsConnnected = DatabaseConnection.start();

            DatabaseConnection.createStatement("select Id from Project");
            SqlDataReader reader = DatabaseConnection.getData();
            while (reader.Read())
            {
                ProjectIds.Add(reader["Id"].ToString());
                MessageBox.Show(reader["Id"].ToString());

            }
            foreach (string project_id in ProjectIds)
            {
                ProjectReport report = new ProjectReport();
                List<string> members = new List<string>();
                DatabaseConnection.createStatement("select * from Project join GroupProject on Project.Id = GroupProject.ProjectID join GroupStudent on GroupProject.GroupId = GroupStudent.GroupId join Student on GroupStudent.StudentId = Student.Id where Project.Id = " + project_id);
                SqlDataReader reader3 = DatabaseConnection.getData();
                if (reader3.Read())
                {
                    report.Title = reader3["Title"].ToString();
                }
                while (reader3.Read())
                {
                    members.Add ( reader3["RegistrationNo"].ToString());
                }

                // Adding Members accrording to number of group members
                if (members.Count == 1)
                {
                    report.Member1 = members[0];
                }
                if (members.Count == 2)
                {
                    report.Member1 = members[0];
                    report.Member2 = members[1];
                }
                if (members.Count == 3)
                {
                    report.Member1 = members[0];
                    report.Member2 = members[1];
                    report.Member3 = members[2];
                }
                if (members.Count == 3)
                {
                    report.Member1 = members[0];
                    report.Member2 = members[1];
                    report.Member3 = members[2];
                    report.Member4 = members[3];
                }


                DatabaseConnection.createStatement("select * from Project join ProjectAdvisor on Project.Id = ProjectAdvisor.ProjectId join Advisor on ProjectAdvisor.AdvisorId = Advisor.Id join Person on Advisor.Id = Person.Id where Project.Id = " + project_id);
                SqlDataReader reader4 = DatabaseConnection.getData();
                while (reader4.Read())
                {
                    string role = reader4["AdvisorRole"].ToString();
                    if (role == "11")
                    {
                        report.MainAdvisor = reader4["FirstName"].ToString() + " " + reader4["LastName"].ToString();
                    }
                    if (role == "12")
                    {
                        report.CoAdvisor = reader4["FirstName"].ToString() + " " + reader4["LastName"].ToString();
                    }
                    if (role == "14")
                    {
                        report.MainAdvisor = reader4["FirstName"].ToString() + " " + reader4["LastName"].ToString();
                    }
                }

                if (report.Title != null)
                {
                    reports.Add(report);
                }

            }
            var bindingSource = new BindingSource();
            bindingSource.DataSource = reports;
            gvReport.DataSource = bindingSource;





        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4.Rotate());
                try
                {
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();
                    document.Add(new iTextSharp.text.Paragraph(centeredString));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    document.Close();
                }
            }

        }
    }
   
}
