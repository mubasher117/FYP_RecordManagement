namespace DBMSL_ProjectA
{
    partial class ManageStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Projects = new System.Windows.Forms.TabPage();
            this.Students = new System.Windows.Forms.TabPage();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Advisors = new System.Windows.Forms.TabPage();
            this.Groups = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Students.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(41, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 491);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Home
            // 
            this.Home.AccessibleName = "tabHome";
            this.Home.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(762, 462);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // Projects
            // 
            this.Projects.AccessibleName = "tabProject";
            this.Projects.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Projects.Location = new System.Drawing.Point(4, 25);
            this.Projects.Name = "Projects";
            this.Projects.Padding = new System.Windows.Forms.Padding(3);
            this.Projects.Size = new System.Drawing.Size(762, 462);
            this.Projects.TabIndex = 1;
            this.Projects.Text = "Projects";
            // 
            // Students
            // 
            this.Students.AccessibleName = "tabStudents";
            this.Students.AutoScroll = true;
            this.Students.AutoScrollMinSize = new System.Drawing.Size(500, 0);
            this.Students.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Students.Controls.Add(this.btnAddStudent);
            this.Students.Controls.Add(this.gvStudents);
            this.Students.Location = new System.Drawing.Point(4, 25);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(3);
            this.Students.Size = new System.Drawing.Size(762, 462);
            this.Students.TabIndex = 2;
            this.Students.Text = "Students";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudent.Location = new System.Drawing.Point(592, 34);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(135, 32);
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.Text = "Add Students";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click_1);
            // 
            // gvStudents
            // 
            this.gvStudents.AllowUserToAddRows = false;
            this.gvStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.RegistrationNo,
            this.SName,
            this.Action,
            this.Action2,
            this.Action3});
            this.gvStudents.Location = new System.Drawing.Point(38, 127);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.RowTemplate.Height = 24;
            this.gvStudents.Size = new System.Drawing.Size(689, 254);
            this.gvStudents.TabIndex = 4;
            this.gvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudents_CellContentClick_1);
            // 
            // StudentId
            // 
            this.StudentId.HeaderText = "Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.Visible = false;
            // 
            // RegistrationNo
            // 
            this.RegistrationNo.HeaderText = "Reg No";
            this.RegistrationNo.MinimumWidth = 7;
            this.RegistrationNo.Name = "RegistrationNo";
            this.RegistrationNo.ReadOnly = true;
            this.RegistrationNo.Width = 120;
            // 
            // SName
            // 
            this.SName.HeaderText = "Name";
            this.SName.MinimumWidth = 10;
            this.SName.Name = "SName";
            this.SName.Width = 130;
            // 
            // Action
            // 
            this.Action.HeaderText = "";
            this.Action.Name = "Action";
            this.Action.Text = "View";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // Action2
            // 
            this.Action2.HeaderText = "";
            this.Action2.Name = "Action2";
            this.Action2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // Advisors
            // 
            this.Advisors.AccessibleName = "tabAdvisors";
            this.Advisors.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Advisors.Location = new System.Drawing.Point(4, 25);
            this.Advisors.Name = "Advisors";
            this.Advisors.Size = new System.Drawing.Size(762, 462);
            this.Advisors.TabIndex = 3;
            this.Advisors.Text = "Advisors";
            // 
            // Groups
            // 
            this.Groups.AccessibleName = "Groups";
            this.Groups.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Groups.Location = new System.Drawing.Point(4, 25);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(762, 462);
            this.Groups.TabIndex = 4;
            this.Groups.Text = "Groups";
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(600, 300);
            this.ClientSize = new System.Drawing.Size(858, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.tabControl1.ResumeLayout(false);
            this.Students.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
        private System.Windows.Forms.DataGridViewButtonColumn Action3;
    }
}