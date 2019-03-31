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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAdvisors = new System.Windows.Forms.Label();
            this.lblGroupStudents = new System.Windows.Forms.Label();
            this.lblMainAdvisor = new System.Windows.Forms.Label();
            this.lblCoAdvisor = new System.Windows.Forms.Label();
            this.lblIndustryAdvisor = new System.Windows.Forms.Label();
            this.lblMainAdvisorName = new System.Windows.Forms.Label();
            this.lblCoAdvisorName = new System.Windows.Forms.Label();
            this.lblIndustryAdvisorName = new System.Windows.Forms.Label();
            this.btnViewMainAdvisor = new System.Windows.Forms.Button();
            this.btnAddMainAdvisor = new System.Windows.Forms.Button();
            this.btnViewCoAdvisor = new System.Windows.Forms.Button();
            this.btnAddCoAdvisor = new System.Windows.Forms.Button();
            this.btnViewIndustryAdvisor = new System.Windows.Forms.Button();
            this.btnAddIndustryAdvisor = new System.Windows.Forms.Button();
            this.btnChangeGroup = new System.Windows.Forms.Button();
            this.btnEvaluation = new System.Windows.Forms.Button();
            this.btnMarksheet = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gvGroupStudents = new System.Windows.Forms.DataGridView();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(48, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 32);
            this.lblTitle.TabIndex = 17;
            // 
            // lblAdvisors
            // 
            this.lblAdvisors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvisors.AutoSize = true;
            this.lblAdvisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisors.Location = new System.Drawing.Point(87, 283);
            this.lblAdvisors.Name = "lblAdvisors";
            this.lblAdvisors.Size = new System.Drawing.Size(113, 29);
            this.lblAdvisors.TabIndex = 1;
            this.lblAdvisors.Text = "Advisors";
            // 
            // lblGroupStudents
            // 
            this.lblGroupStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroupStudents.AutoSize = true;
            this.lblGroupStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupStudents.Location = new System.Drawing.Point(87, 438);
            this.lblGroupStudents.Name = "lblGroupStudents";
            this.lblGroupStudents.Size = new System.Drawing.Size(194, 29);
            this.lblGroupStudents.TabIndex = 2;
            this.lblGroupStudents.Text = "Group Students";
            // 
            // lblMainAdvisor
            // 
            this.lblMainAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMainAdvisor.AutoSize = true;
            this.lblMainAdvisor.Location = new System.Drawing.Point(114, 323);
            this.lblMainAdvisor.Name = "lblMainAdvisor";
            this.lblMainAdvisor.Size = new System.Drawing.Size(133, 17);
            this.lblMainAdvisor.TabIndex = 4;
            this.lblMainAdvisor.Text = "Main Advisor          :";
            // 
            // lblCoAdvisor
            // 
            this.lblCoAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCoAdvisor.AutoSize = true;
            this.lblCoAdvisor.Location = new System.Drawing.Point(114, 360);
            this.lblCoAdvisor.Name = "lblCoAdvisor";
            this.lblCoAdvisor.Size = new System.Drawing.Size(133, 17);
            this.lblCoAdvisor.TabIndex = 5;
            this.lblCoAdvisor.Text = "Co-Advisor             :";
            // 
            // lblIndustryAdvisor
            // 
            this.lblIndustryAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIndustryAdvisor.AutoSize = true;
            this.lblIndustryAdvisor.Location = new System.Drawing.Point(114, 397);
            this.lblIndustryAdvisor.Name = "lblIndustryAdvisor";
            this.lblIndustryAdvisor.Size = new System.Drawing.Size(133, 17);
            this.lblIndustryAdvisor.TabIndex = 6;
            this.lblIndustryAdvisor.Text = "Industry Advisor     :";
            // 
            // lblMainAdvisorName
            // 
            this.lblMainAdvisorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMainAdvisorName.AutoSize = true;
            this.lblMainAdvisorName.ForeColor = System.Drawing.Color.Red;
            this.lblMainAdvisorName.Location = new System.Drawing.Point(289, 323);
            this.lblMainAdvisorName.Name = "lblMainAdvisorName";
            this.lblMainAdvisorName.Size = new System.Drawing.Size(100, 17);
            this.lblMainAdvisorName.TabIndex = 7;
            this.lblMainAdvisorName.Text = "Not Added Yet";
            // 
            // lblCoAdvisorName
            // 
            this.lblCoAdvisorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCoAdvisorName.AutoSize = true;
            this.lblCoAdvisorName.ForeColor = System.Drawing.Color.Red;
            this.lblCoAdvisorName.Location = new System.Drawing.Point(289, 360);
            this.lblCoAdvisorName.Name = "lblCoAdvisorName";
            this.lblCoAdvisorName.Size = new System.Drawing.Size(100, 17);
            this.lblCoAdvisorName.TabIndex = 8;
            this.lblCoAdvisorName.Text = "Not Added Yet";
            // 
            // lblIndustryAdvisorName
            // 
            this.lblIndustryAdvisorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIndustryAdvisorName.AutoSize = true;
            this.lblIndustryAdvisorName.ForeColor = System.Drawing.Color.Red;
            this.lblIndustryAdvisorName.Location = new System.Drawing.Point(289, 397);
            this.lblIndustryAdvisorName.Name = "lblIndustryAdvisorName";
            this.lblIndustryAdvisorName.Size = new System.Drawing.Size(104, 17);
            this.lblIndustryAdvisorName.TabIndex = 9;
            this.lblIndustryAdvisorName.Text = "Not Added  Yet";
            // 
            // btnViewMainAdvisor
            // 
            this.btnViewMainAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewMainAdvisor.Location = new System.Drawing.Point(576, 316);
            this.btnViewMainAdvisor.Name = "btnViewMainAdvisor";
            this.btnViewMainAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnViewMainAdvisor.TabIndex = 10;
            this.btnViewMainAdvisor.Text = "View";
            this.btnViewMainAdvisor.UseVisualStyleBackColor = true;
            this.btnViewMainAdvisor.Click += new System.EventHandler(this.btnViewMainAdvisor_Click);
            // 
            // btnAddMainAdvisor
            // 
            this.btnAddMainAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddMainAdvisor.Location = new System.Drawing.Point(669, 316);
            this.btnAddMainAdvisor.Name = "btnAddMainAdvisor";
            this.btnAddMainAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnAddMainAdvisor.TabIndex = 11;
            this.btnAddMainAdvisor.Text = "Add";
            this.btnAddMainAdvisor.UseVisualStyleBackColor = true;
            this.btnAddMainAdvisor.Click += new System.EventHandler(this.btnAddMainAdvisor_Click);
            // 
            // btnViewCoAdvisor
            // 
            this.btnViewCoAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewCoAdvisor.Location = new System.Drawing.Point(576, 353);
            this.btnViewCoAdvisor.Name = "btnViewCoAdvisor";
            this.btnViewCoAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnViewCoAdvisor.TabIndex = 12;
            this.btnViewCoAdvisor.Text = "View";
            this.btnViewCoAdvisor.UseVisualStyleBackColor = true;
            // 
            // btnAddCoAdvisor
            // 
            this.btnAddCoAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCoAdvisor.Location = new System.Drawing.Point(669, 353);
            this.btnAddCoAdvisor.Name = "btnAddCoAdvisor";
            this.btnAddCoAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnAddCoAdvisor.TabIndex = 13;
            this.btnAddCoAdvisor.Text = "Add";
            this.btnAddCoAdvisor.UseVisualStyleBackColor = true;
            this.btnAddCoAdvisor.Click += new System.EventHandler(this.btnAddCoAdvisor_Click);
            // 
            // btnViewIndustryAdvisor
            // 
            this.btnViewIndustryAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewIndustryAdvisor.Location = new System.Drawing.Point(576, 390);
            this.btnViewIndustryAdvisor.Name = "btnViewIndustryAdvisor";
            this.btnViewIndustryAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnViewIndustryAdvisor.TabIndex = 14;
            this.btnViewIndustryAdvisor.Text = "View";
            this.btnViewIndustryAdvisor.UseVisualStyleBackColor = true;
            // 
            // btnAddIndustryAdvisor
            // 
            this.btnAddIndustryAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddIndustryAdvisor.Location = new System.Drawing.Point(669, 390);
            this.btnAddIndustryAdvisor.Name = "btnAddIndustryAdvisor";
            this.btnAddIndustryAdvisor.Size = new System.Drawing.Size(77, 31);
            this.btnAddIndustryAdvisor.TabIndex = 15;
            this.btnAddIndustryAdvisor.Text = "Add";
            this.btnAddIndustryAdvisor.UseVisualStyleBackColor = true;
            this.btnAddIndustryAdvisor.Click += new System.EventHandler(this.btnAddIndustryAdvisor_Click);
            // 
            // btnChangeGroup
            // 
            this.btnChangeGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeGroup.Location = new System.Drawing.Point(620, 792);
            this.btnChangeGroup.Name = "btnChangeGroup";
            this.btnChangeGroup.Size = new System.Drawing.Size(123, 38);
            this.btnChangeGroup.TabIndex = 19;
            this.btnChangeGroup.Text = "Change Group";
            this.btnChangeGroup.UseVisualStyleBackColor = true;
            this.btnChangeGroup.Click += new System.EventHandler(this.btnChangeGroup_Click);
            // 
            // btnEvaluation
            // 
            this.btnEvaluation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEvaluation.Location = new System.Drawing.Point(809, 201);
            this.btnEvaluation.Name = "btnEvaluation";
            this.btnEvaluation.Size = new System.Drawing.Size(138, 33);
            this.btnEvaluation.TabIndex = 20;
            this.btnEvaluation.Text = "Evaluate";
            this.btnEvaluation.UseVisualStyleBackColor = true;
            this.btnEvaluation.Click += new System.EventHandler(this.btnEvaluation_Click);
            // 
            // btnMarksheet
            // 
            this.btnMarksheet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMarksheet.Location = new System.Drawing.Point(809, 148);
            this.btnMarksheet.Name = "btnMarksheet";
            this.btnMarksheet.Size = new System.Drawing.Size(138, 33);
            this.btnMarksheet.TabIndex = 22;
            this.btnMarksheet.Text = "Mark Sheet";
            this.btnMarksheet.UseVisualStyleBackColor = true;
            this.btnMarksheet.Click += new System.EventHandler(this.btnMarksheet_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(809, 97);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 32);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gvGroupStudents
            // 
            this.gvGroupStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvGroupStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegNo,
            this.Column1});
            this.gvGroupStudents.Location = new System.Drawing.Point(119, 496);
            this.gvGroupStudents.Name = "gvGroupStudents";
            this.gvGroupStudents.RowTemplate.Height = 24;
            this.gvGroupStudents.Size = new System.Drawing.Size(624, 275);
            this.gvGroupStudents.TabIndex = 24;
            // 
            // RegNo
            // 
            this.RegNo.HeaderText = "Registration No";
            this.RegNo.Name = "RegNo";
            this.RegNo.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(116, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Group Not Assigned  Yet";
            this.label1.Visible = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Location = new System.Drawing.Point(92, 102);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(654, 178);
            this.txtDesc.TabIndex = 26;
            this.txtDesc.Text = "";
            // 
            // ProjectDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(800, 600);
            this.ClientSize = new System.Drawing.Size(990, 844);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvGroupStudents);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMarksheet);
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
            this.Controls.Add(this.lblGroupStudents);
            this.Controls.Add(this.lblAdvisors);
            this.Name = "ProjectDashboard";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.ProjectDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAdvisors;
        private System.Windows.Forms.Label lblGroupStudents;
        private System.Windows.Forms.Label lblMainAdvisor;
        private System.Windows.Forms.Label lblCoAdvisor;
        private System.Windows.Forms.Label lblIndustryAdvisor;
        private System.Windows.Forms.Label lblMainAdvisorName;
        private System.Windows.Forms.Label lblCoAdvisorName;
        private System.Windows.Forms.Label lblIndustryAdvisorName;
        private System.Windows.Forms.Button btnViewMainAdvisor;
        private System.Windows.Forms.Button btnAddMainAdvisor;
        private System.Windows.Forms.Button btnViewCoAdvisor;
        private System.Windows.Forms.Button btnAddCoAdvisor;
        private System.Windows.Forms.Button btnViewIndustryAdvisor;
        private System.Windows.Forms.Button btnAddIndustryAdvisor;
        private System.Windows.Forms.Button btnChangeGroup;
        private System.Windows.Forms.Button btnEvaluation;
        private System.Windows.Forms.Button btnMarksheet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gvGroupStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDesc;
    }
}