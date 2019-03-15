namespace DBMSL_ProjectA
{
    partial class EditAdvisor
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSallary = new System.Windows.Forms.TextBox();
            this.lblSallary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(265, 212);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 59;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(265, 174);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(200, 22);
            this.txtContactNo.TabIndex = 58;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(265, 131);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 57;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(265, 85);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 56;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(119, 217);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 55;
            this.lblEmail.Text = "Email";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(117, 179);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(78, 17);
            this.lblContactNo.TabIndex = 54;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(119, 134);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 53;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(119, 88);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 52;
            this.lblFirstName.Text = "First Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(398, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 29);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSallary
            // 
            this.txtSallary.Location = new System.Drawing.Point(265, 249);
            this.txtSallary.Name = "txtSallary";
            this.txtSallary.Size = new System.Drawing.Size(200, 22);
            this.txtSallary.TabIndex = 61;
            // 
            // lblSallary
            // 
            this.lblSallary.AutoSize = true;
            this.lblSallary.Location = new System.Drawing.Point(119, 254);
            this.lblSallary.Name = "lblSallary";
            this.lblSallary.Size = new System.Drawing.Size(48, 17);
            this.lblSallary.TabIndex = 60;
            this.lblSallary.Text = "Salary";
            // 
            // EditAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 376);
            this.Controls.Add(this.txtSallary);
            this.Controls.Add(this.lblSallary);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnSave);
            this.Name = "EditAdvisor";
            this.Text = "EditAdvisor";
            this.Load += new System.EventHandler(this.EditAdvisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSallary;
        private System.Windows.Forms.Label lblSallary;
    }
}