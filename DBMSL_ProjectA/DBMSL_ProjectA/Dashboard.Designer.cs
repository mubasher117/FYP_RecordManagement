namespace DBMSL_ProjectA
{
    partial class Dashboard
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
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.btnAdvisors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProjects
            // 
            this.btnProjects.Location = new System.Drawing.Point(81, 299);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(221, 74);
            this.btnProjects.TabIndex = 0;
            this.btnProjects.Text = "Projects";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(81, 393);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(221, 74);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Location = new System.Drawing.Point(319, 299);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(221, 74);
            this.btnGroups.TabIndex = 2;
            this.btnGroups.Text = "Groups";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdvisors
            // 
            this.btnAdvisors.Location = new System.Drawing.Point(319, 393);
            this.btnAdvisors.Name = "btnAdvisors";
            this.btnAdvisors.Size = new System.Drawing.Size(224, 74);
            this.btnAdvisors.TabIndex = 6;
            this.btnAdvisors.Text = "Advisors";
            this.btnAdvisors.UseVisualStyleBackColor = true;
            this.btnAdvisors.Click += new System.EventHandler(this.btnAdvisors_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 533);
            this.Controls.Add(this.btnAdvisors);
            this.Controls.Add(this.btnGroups);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnProjects);
            this.Name = "Dashboard";
            this.Text = "FYP Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.Button btnAdvisors;
    }
}