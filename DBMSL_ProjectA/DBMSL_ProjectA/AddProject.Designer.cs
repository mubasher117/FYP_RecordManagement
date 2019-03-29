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
            this.lblTitleWarning = new System.Windows.Forms.Label();
            this.lblDescriptionWarning = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(403, 300);
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
            this.lblTitle.Location = new System.Drawing.Point(65, 133);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(65, 175);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(184, 130);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(328, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(184, 175);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(328, 87);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "";
            // 
            // lblTitleWarning
            // 
            this.lblTitleWarning.AutoSize = true;
            this.lblTitleWarning.ForeColor = System.Drawing.Color.Red;
            this.lblTitleWarning.Location = new System.Drawing.Point(201, 155);
            this.lblTitleWarning.Name = "lblTitleWarning";
            this.lblTitleWarning.Size = new System.Drawing.Size(78, 17);
            this.lblTitleWarning.TabIndex = 62;
            this.lblTitleWarning.Text = "*Enter Title";
            this.lblTitleWarning.Visible = false;
            // 
            // lblDescriptionWarning
            // 
            this.lblDescriptionWarning.AutoSize = true;
            this.lblDescriptionWarning.ForeColor = System.Drawing.Color.Red;
            this.lblDescriptionWarning.Location = new System.Drawing.Point(201, 265);
            this.lblDescriptionWarning.Name = "lblDescriptionWarning";
            this.lblDescriptionWarning.Size = new System.Drawing.Size(122, 17);
            this.lblDescriptionWarning.TabIndex = 63;
            this.lblDescriptionWarning.Text = "*Enter Description";
            this.lblDescriptionWarning.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(288, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 36);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 429);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDescriptionWarning);
            this.Controls.Add(this.lblTitleWarning);
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
        private System.Windows.Forms.Label lblTitleWarning;
        private System.Windows.Forms.Label lblDescriptionWarning;
        private System.Windows.Forms.Button btnCancel;
    }
}