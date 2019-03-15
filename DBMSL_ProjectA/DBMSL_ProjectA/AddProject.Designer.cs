namespace DBMSL_ProjectA
{
    partial class AddProject
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
            this.btnAddProject = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(414, 304);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(109, 36);
            this.btnAddProject.TabIndex = 0;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(59, 138);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(59, 178);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(178, 135);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(328, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(178, 175);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(328, 87);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "";
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 429);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddProject);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
    }
}