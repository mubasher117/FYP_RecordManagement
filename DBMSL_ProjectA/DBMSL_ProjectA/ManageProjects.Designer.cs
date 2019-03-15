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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action3 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            this.SuspendLayout();
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
            this.Id,
            this.RegistrationNo,
            this.Action,
            this.Action2,
            this.Action3});
            this.gvStudents.Location = new System.Drawing.Point(8, 175);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.RowTemplate.Height = 24;
            this.gvStudents.Size = new System.Drawing.Size(461, 254);
            this.gvStudents.TabIndex = 2;
            this.gvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudents_CellContentClick);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(527, 78);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(108, 24);
            this.btnAddProject.TabIndex = 3;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.button1_Click);
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
            // ManageProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 605);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.gvStudents);
            this.Name = "ManageProjects";
            this.Text = "ManageProjects";
            this.Load += new System.EventHandler(this.ManageProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNo;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
        private System.Windows.Forms.DataGridViewButtonColumn Action3;
    }
}