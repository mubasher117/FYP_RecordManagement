namespace DBMSL_ProjectA
{
    partial class ManageProjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Projects = new System.Windows.Forms.TabPage();
            this.btnMarkSheet = new System.Windows.Forms.Button();
            this.btnProjectsReports = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Students = new System.Windows.Forms.TabPage();
            this.Advisors = new System.Windows.Forms.TabPage();
            this.Groups = new System.Windows.Forms.TabPage();
            this.lblEvaluate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Projects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.Projects);
            this.tabControl1.Controls.Add(this.Students);
            this.tabControl1.Controls.Add(this.Advisors);
            this.tabControl1.Controls.Add(this.Groups);
            this.tabControl1.Location = new System.Drawing.Point(57, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 530);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // Home
            // 
            this.Home.AccessibleName = "tabHome";
            this.Home.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(813, 501);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Projects
            // 
            this.Projects.AccessibleName = "tabProject";
            this.Projects.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Projects.Controls.Add(this.lblEvaluate);
            this.Projects.Controls.Add(this.btnMarkSheet);
            this.Projects.Controls.Add(this.btnProjectsReports);
            this.Projects.Controls.Add(this.btnAddProject);
            this.Projects.Controls.Add(this.gvStudents);
            this.Projects.Location = new System.Drawing.Point(4, 25);
            this.Projects.Name = "Projects";
            this.Projects.Padding = new System.Windows.Forms.Padding(3);
            this.Projects.Size = new System.Drawing.Size(813, 501);
            this.Projects.TabIndex = 1;
            this.Projects.Text = "Projects";
            // 
            // btnMarkSheet
            // 
            this.btnMarkSheet.Location = new System.Drawing.Point(569, 149);
            this.btnMarkSheet.Name = "btnMarkSheet";
            this.btnMarkSheet.Size = new System.Drawing.Size(169, 31);
            this.btnMarkSheet.TabIndex = 14;
            this.btnMarkSheet.Text = "Mark Sheet";
            this.btnMarkSheet.UseVisualStyleBackColor = true;
            this.btnMarkSheet.Click += new System.EventHandler(this.btnMarkSheet_Click);
            // 
            // btnProjectsReports
            // 
            this.btnProjectsReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProjectsReports.Location = new System.Drawing.Point(569, 100);
            this.btnProjectsReports.Name = "btnProjectsReports";
            this.btnProjectsReports.Size = new System.Drawing.Size(169, 32);
            this.btnProjectsReports.TabIndex = 13;
            this.btnProjectsReports.Text = "See Projects Report";
            this.btnProjectsReports.UseVisualStyleBackColor = true;
            this.btnProjectsReports.Click += new System.EventHandler(this.btnProjectsReports_Click_1);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProject.Location = new System.Drawing.Point(569, 50);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(169, 32);
            this.btnAddProject.TabIndex = 12;
            this.btnAddProject.Text = "Add New Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // gvStudents
            // 
            this.gvStudents.AllowUserToAddRows = false;
            this.gvStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RegistrationNo,
            this.Action,
            this.Action2,
            this.Action3});
            this.gvStudents.Location = new System.Drawing.Point(74, 197);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.RowTemplate.Height = 24;
            this.gvStudents.Size = new System.Drawing.Size(461, 254);
            this.gvStudents.TabIndex = 11;
            this.gvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudents_CellContentClick_1);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // RegistrationNo
            // 
            this.RegistrationNo.HeaderText = "Title";
            this.RegistrationNo.MinimumWidth = 7;
            this.RegistrationNo.Name = "RegistrationNo";
            this.RegistrationNo.ReadOnly = true;
            this.RegistrationNo.Width = 120;
            // 
            // Action
            // 
            this.Action.HeaderText = "";
            this.Action.Name = "Action";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.Text = "View";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 60;
            // 
            // Action2
            // 
            this.Action2.HeaderText = "Action";
            this.Action2.Name = "Action2";
            this.Action2.Text = "Edit";
            this.Action2.UseColumnTextForButtonValue = true;
            this.Action2.Width = 60;
            // 
            // Action3
            // 
            this.Action3.HeaderText = "";
            this.Action3.Name = "Action3";
            this.Action3.Text = "Delete";
            this.Action3.UseColumnTextForButtonValue = true;
            this.Action3.Width = 60;
            // 
            // Students
            // 
            this.Students.AccessibleName = "tabStudents";
            this.Students.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Students.Location = new System.Drawing.Point(4, 25);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(3);
            this.Students.Size = new System.Drawing.Size(813, 501);
            this.Students.TabIndex = 2;
            this.Students.Text = "Students";
            // 
            // Advisors
            // 
            this.Advisors.AccessibleName = "tabAdvisors";
            this.Advisors.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Advisors.Location = new System.Drawing.Point(4, 25);
            this.Advisors.Name = "Advisors";
            this.Advisors.Size = new System.Drawing.Size(813, 501);
            this.Advisors.TabIndex = 3;
            this.Advisors.Text = "Advisors";
            // 
            // Groups
            // 
            this.Groups.AccessibleName = "Groups";
            this.Groups.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Groups.Location = new System.Drawing.Point(4, 25);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(813, 501);
            this.Groups.TabIndex = 4;
            this.Groups.Text = "Groups";
            // 
            // lblEvaluate
            // 
            this.lblEvaluate.Location = new System.Drawing.Point(569, 197);
            this.lblEvaluate.Name = "lblEvaluate";
            this.lblEvaluate.Size = new System.Drawing.Size(169, 31);
            this.lblEvaluate.TabIndex = 15;
            this.lblEvaluate.Text = "Evaluate Projects";
            this.lblEvaluate.UseVisualStyleBackColor = true;
            this.lblEvaluate.Click += new System.EventHandler(this.lblEvaluate_Click);
            // 
            // ManageProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 623);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManageProjects";
            this.Text = "ManageProjects";
            this.Load += new System.EventHandler(this.ManageProjects_Load);
            this.tabControl1.ResumeLayout(false);
            this.Projects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Projects;
        private System.Windows.Forms.TabPage Students;
        private System.Windows.Forms.TabPage Advisors;
        private System.Windows.Forms.TabPage Groups;
        private System.Windows.Forms.Button btnProjectsReports;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNo;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
        private System.Windows.Forms.DataGridViewButtonColumn Action3;
        private System.Windows.Forms.Button btnMarkSheet;
        private System.Windows.Forms.Button lblEvaluate;
    }
}