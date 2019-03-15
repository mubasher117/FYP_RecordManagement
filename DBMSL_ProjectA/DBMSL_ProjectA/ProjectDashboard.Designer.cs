namespace DBMSL_ProjectA
{
    partial class ProjectDashboard
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
            this.lblAdvisors = new System.Windows.Forms.Label();
            this.lblGroupStudents = new System.Windows.Forms.Label();
            this.gvGroupStudents = new System.Windows.Forms.DataGridView();
            this.lblMainAdvisor = new System.Windows.Forms.Label();
            this.lblCoAdvisor = new System.Windows.Forms.Label();
            this.lblIndustryAdvisor = new System.Windows.Forms.Label();
            this.lblMainAdvisorName = new System.Windows.Forms.Label();
            this.lblCoAdvisorName = new System.Windows.Forms.Label();
            this.lblIndustryAdvisorName = new System.Windows.Forms.Label();
            this.btnViewMainAdvisor = new System.Windows.Forms.Button();
            this.btnAddMainAdvisor = new System.Windows.Forms.Button();
            this.btnAddCoAdvisor = new System.Windows.Forms.Button();
            this.btnViewCoAdvisor = new System.Windows.Forms.Button();
            this.btnAddIndustryAdvisor = new System.Windows.Forms.Button();
            this.btnViewIndustryAdvisor = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnChangeGroup = new System.Windows.Forms.Button();
            this.btnEvaluation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdvisors
            // 
            this.lblAdvisors.AutoSize = true;
            this.lblAdvisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisors.Location = new System.Drawing.Point(87, 100);
            this.lblAdvisors.Name = "lblAdvisors";
            this.lblAdvisors.Size = new System.Drawing.Size(113, 29);
            this.lblAdvisors.TabIndex = 1;
            this.lblAdvisors.Text = "Advisors";
            // 
            // lblGroupStudents
            // 
            this.lblGroupStudents.AutoSize = true;
            this.lblGroupStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupStudents.Location = new System.Drawing.Point(87, 365);
            this.lblGroupStudents.Name = "lblGroupStudents";
            this.lblGroupStudents.Size = new System.Drawing.Size(194, 29);
            this.lblGroupStudents.TabIndex = 2;
            this.lblGroupStudents.Text = "Group Students";
            // 
            // gvGroupStudents
            // 
            this.gvGroupStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupStudents.Location = new System.Drawing.Point(136, 475);
            this.gvGroupStudents.Name = "gvGroupStudents";
            this.gvGroupStudents.RowTemplate.Height = 24;
            this.gvGroupStudents.Size = new System.Drawing.Size(629, 242);
            this.gvGroupStudents.TabIndex = 3;
            // 
            // lblMainAdvisor
            // 
            this.lblMainAdvisor.AutoSize = true;
            this.lblMainAdvisor.Location = new System.Drawing.Point(109, 177);
            this.lblMainAdvisor.Name = "lblMainAdvisor";
            this.lblMainAdvisor.Size = new System.Drawing.Size(133, 17);
            this.lblMainAdvisor.TabIndex = 4;
            this.lblMainAdvisor.Text = "Main Advisor          :";
            // 
            // lblCoAdvisor
            // 
            this.lblCoAdvisor.AutoSize = true;
            this.lblCoAdvisor.Location = new System.Drawing.Point(109, 229);
            this.lblCoAdvisor.Name = "lblCoAdvisor";
            this.lblCoAdvisor.Size = new System.Drawing.Size(133, 17);
            this.lblCoAdvisor.TabIndex = 5;
            this.lblCoAdvisor.Text = "Co-Advisor             :";
            // 
            // lblIndustryAdvisor
            // 
            this.lblIndustryAdvisor.AutoSize = true;
            this.lblIndustryAdvisor.Location = new System.Drawing.Point(109, 282);
            this.lblIndustryAdvisor.Name = "lblIndustryAdvisor";
            this.lblIndustryAdvisor.Size = new System.Drawing.Size(133, 17);
            this.lblIndustryAdvisor.TabIndex = 6;
            this.lblIndustryAdvisor.Text = "Industry Advisor     :";
            // 
            // lblMainAdvisorName
            // 
            this.lblMainAdvisorName.AutoSize = true;
            this.lblMainAdvisorName.ForeColor = System.Drawing.Color.Red;
            this.lblMainAdvisorName.Location = new System.Drawing.Point(284, 177);
            this.lblMainAdvisorName.Name = "lblMainAdvisorName";
            this.lblMainAdvisorName.Size = new System.Drawing.Size(100, 17);
            this.lblMainAdvisorName.TabIndex = 7;
            this.lblMainAdvisorName.Text = "Not Added Yet";
            // 
            // lblCoAdvisorName
            // 
            this.lblCoAdvisorName.AutoSize = true;
            this.lblCoAdvisorName.ForeColor = System.Drawing.Color.Red;
            this.lblCoAdvisorName.Location = new System.Drawing.Point(284, 229);
            this.lblCoAdvisorName.Name = "lblCoAdvisorName";
            this.lblCoAdvisorName.Size = new System.Drawing.Size(100, 17);
            this.lblCoAdvisorName.TabIndex = 8;
            this.lblCoAdvisorName.Text = "Not Added Yet";
            // 
            // lblIndustryAdvisorName
            // 
            this.lblIndustryAdvisorName.AutoSize = true;
            this.lblIndustryAdvisorName.ForeColor = System.Drawing.Color.Red;
            this.lblIndustryAdvisorName.Location = new System.Drawing.Point(284, 282);
            this.lblIndustryAdvisorName.Name = "lblIndustryAdvisorName";
            this.lblIndustryAdvisorName.Size = new System.Drawing.Size(104, 17);
            this.lblIndustryAdvisorName.TabIndex = 9;
            this.lblIndustryAdvisorName.Text = "Not Added  Yet";
            // 
            // btnViewMainAdvisor
            // 
            this.btnViewMainAdvisor.Location = new System.Drawing.Point(571, 170);
            this.btnViewMainAdvisor.Name = "btnViewMainAdvisor";
            this.btnViewMainAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnViewMainAdvisor.TabIndex = 10;
            this.btnViewMainAdvisor.Text = "View";
            this.btnViewMainAdvisor.UseVisualStyleBackColor = true;
            this.btnViewMainAdvisor.Click += new System.EventHandler(this.btnViewMainAdvisor_Click);
            // 
            // btnAddMainAdvisor
            // 
            this.btnAddMainAdvisor.Location = new System.Drawing.Point(664, 170);
            this.btnAddMainAdvisor.Name = "btnAddMainAdvisor";
            this.btnAddMainAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnAddMainAdvisor.TabIndex = 11;
            this.btnAddMainAdvisor.Text = "Add";
            this.btnAddMainAdvisor.UseVisualStyleBackColor = true;
            this.btnAddMainAdvisor.Click += new System.EventHandler(this.btnAddMainAdvisor_Click);
            // 
            // btnAddCoAdvisor
            // 
            this.btnAddCoAdvisor.Location = new System.Drawing.Point(664, 215);
            this.btnAddCoAdvisor.Name = "btnAddCoAdvisor";
            this.btnAddCoAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnAddCoAdvisor.TabIndex = 13;
            this.btnAddCoAdvisor.Text = "Add";
            this.btnAddCoAdvisor.UseVisualStyleBackColor = true;
            this.btnAddCoAdvisor.Click += new System.EventHandler(this.btnAddCoAdvisor_Click);
            // 
            // btnViewCoAdvisor
            // 
            this.btnViewCoAdvisor.Location = new System.Drawing.Point(571, 215);
            this.btnViewCoAdvisor.Name = "btnViewCoAdvisor";
            this.btnViewCoAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnViewCoAdvisor.TabIndex = 12;
            this.btnViewCoAdvisor.Text = "View";
            this.btnViewCoAdvisor.UseVisualStyleBackColor = true;
            // 
            // btnAddIndustryAdvisor
            // 
            this.btnAddIndustryAdvisor.Location = new System.Drawing.Point(664, 268);
            this.btnAddIndustryAdvisor.Name = "btnAddIndustryAdvisor";
            this.btnAddIndustryAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnAddIndustryAdvisor.TabIndex = 15;
            this.btnAddIndustryAdvisor.Text = "Add";
            this.btnAddIndustryAdvisor.UseVisualStyleBackColor = true;
            this.btnAddIndustryAdvisor.Click += new System.EventHandler(this.btnAddIndustryAdvisor_Click);
            // 
            // btnViewIndustryAdvisor
            // 
            this.btnViewIndustryAdvisor.Location = new System.Drawing.Point(571, 268);
            this.btnViewIndustryAdvisor.Name = "btnViewIndustryAdvisor";
            this.btnViewIndustryAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnViewIndustryAdvisor.TabIndex = 14;
            this.btnViewIndustryAdvisor.Text = "View";
            this.btnViewIndustryAdvisor.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(48, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 32);
            this.lblTitle.TabIndex = 17;
            // 
            // btnChangeGroup
            // 
            this.btnChangeGroup.Location = new System.Drawing.Point(642, 746);
            this.btnChangeGroup.Name = "btnChangeGroup";
            this.btnChangeGroup.Size = new System.Drawing.Size(123, 38);
            this.btnChangeGroup.TabIndex = 19;
            this.btnChangeGroup.Text = "Change Group";
            this.btnChangeGroup.UseVisualStyleBackColor = true;
            // 
            // btnEvaluation
            // 
            this.btnEvaluation.Location = new System.Drawing.Point(797, 84);
            this.btnEvaluation.Name = "btnEvaluation";
            this.btnEvaluation.Size = new System.Drawing.Size(138, 33);
            this.btnEvaluation.TabIndex = 20;
            this.btnEvaluation.Text = "Evaluation";
            this.btnEvaluation.UseVisualStyleBackColor = true;
            this.btnEvaluation.Click += new System.EventHandler(this.btnEvaluation_Click);
            // 
            // ProjectDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 796);
            this.Controls.Add(this.btnEvaluation);
            this.Controls.Add(this.btnChangeGroup);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddIndustryAdvisor);
            this.Controls.Add(this.btnViewIndustryAdvisor);
            this.Controls.Add(this.btnAddCoAdvisor);
            this.Controls.Add(this.btnViewCoAdvisor);
            this.Controls.Add(this.btnAddMainAdvisor);
            this.Controls.Add(this.btnViewMainAdvisor);
            this.Controls.Add(this.lblIndustryAdvisorName);
            this.Controls.Add(this.lblCoAdvisorName);
            this.Controls.Add(this.lblMainAdvisorName);
            this.Controls.Add(this.lblIndustryAdvisor);
            this.Controls.Add(this.lblCoAdvisor);
            this.Controls.Add(this.lblMainAdvisor);
            this.Controls.Add(this.gvGroupStudents);
            this.Controls.Add(this.lblGroupStudents);
            this.Controls.Add(this.lblAdvisors);
            this.Name = "ProjectDashboard";
            this.Text = "ProjectDashboard";
            this.Load += new System.EventHandler(this.ProjectDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAdvisors;
        private System.Windows.Forms.Label lblGroupStudents;
        private System.Windows.Forms.DataGridView gvGroupStudents;
        private System.Windows.Forms.Label lblMainAdvisor;
        private System.Windows.Forms.Label lblCoAdvisor;
        private System.Windows.Forms.Label lblIndustryAdvisor;
        private System.Windows.Forms.Label lblMainAdvisorName;
        private System.Windows.Forms.Label lblCoAdvisorName;
        private System.Windows.Forms.Label lblIndustryAdvisorName;
        private System.Windows.Forms.Button btnViewMainAdvisor;
        private System.Windows.Forms.Button btnAddMainAdvisor;
        private System.Windows.Forms.Button btnAddCoAdvisor;
        private System.Windows.Forms.Button btnViewCoAdvisor;
        private System.Windows.Forms.Button btnAddIndustryAdvisor;
        private System.Windows.Forms.Button btnViewIndustryAdvisor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnChangeGroup;
        private System.Windows.Forms.Button btnEvaluation;
    }
}