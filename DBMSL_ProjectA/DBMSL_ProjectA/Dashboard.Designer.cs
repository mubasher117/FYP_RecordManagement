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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProjects
            // 
            this.btnProjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProjects.Location = new System.Drawing.Point(128, 373);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(221, 74);
            this.btnProjects.TabIndex = 0;
            this.btnProjects.Text = "Projects";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStudents.Location = new System.Drawing.Point(128, 467);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(221, 74);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGroups.Location = new System.Drawing.Point(369, 373);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(221, 74);
            this.btnGroups.TabIndex = 2;
            this.btnGroups.Text = "Groups";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdvisors
            // 
            this.btnAdvisors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdvisors.Location = new System.Drawing.Point(366, 467);
            this.btnAdvisors.Name = "btnAdvisors";
            this.btnAdvisors.Size = new System.Drawing.Size(224, 74);
            this.btnAdvisors.TabIndex = 6;
            this.btnAdvisors.Text = "Advisors";
            this.btnAdvisors.UseVisualStyleBackColor = true;
            this.btnAdvisors.Click += new System.EventHandler(this.btnAdvisors_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "FYP Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Submitted by : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "2016-CS-312";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DBMSL_ProjectA.Properties.Resources.Dashboard;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(500, 400);
            this.ClientSize = new System.Drawing.Size(751, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdvisors);
            this.Controls.Add(this.btnGroups);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnProjects);
            this.Name = "Dashboard";
            this.Text = "FYP Management System";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.Button btnAdvisors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}