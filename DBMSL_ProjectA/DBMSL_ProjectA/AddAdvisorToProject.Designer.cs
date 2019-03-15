namespace DBMSL_ProjectA
{
    partial class AddAdvisorToProject
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
            this.lblSelectAdvisor = new System.Windows.Forms.Label();
            this.cmbSelctAdvisor = new System.Windows.Forms.ComboBox();
            this.lblAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectAdvisor
            // 
            this.lblSelectAdvisor.AutoSize = true;
            this.lblSelectAdvisor.Location = new System.Drawing.Point(52, 95);
            this.lblSelectAdvisor.Name = "lblSelectAdvisor";
            this.lblSelectAdvisor.Size = new System.Drawing.Size(98, 17);
            this.lblSelectAdvisor.TabIndex = 0;
            this.lblSelectAdvisor.Text = "Select Advisor";
            // 
            // cmbSelctAdvisor
            // 
            this.cmbSelctAdvisor.FormattingEnabled = true;
            this.cmbSelctAdvisor.Location = new System.Drawing.Point(200, 92);
            this.cmbSelctAdvisor.Name = "cmbSelctAdvisor";
            this.cmbSelctAdvisor.Size = new System.Drawing.Size(366, 24);
            this.cmbSelctAdvisor.TabIndex = 1;
            // 
            // lblAdd
            // 
            this.lblAdd.Location = new System.Drawing.Point(450, 161);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(116, 40);
            this.lblAdd.TabIndex = 2;
            this.lblAdd.Text = "Add";
            this.lblAdd.UseVisualStyleBackColor = true;
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // AddAdvisorToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 579);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.cmbSelctAdvisor);
            this.Controls.Add(this.lblSelectAdvisor);
            this.Name = "AddAdvisorToProject";
            this.Text = "Add Advisor To Project";
            this.Load += new System.EventHandler(this.AddAdvisorToProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectAdvisor;
        private System.Windows.Forms.ComboBox cmbSelctAdvisor;
        private System.Windows.Forms.Button lblAdd;
    }
}