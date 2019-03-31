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
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectAdvisor
            // 
            this.lblSelectAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectAdvisor.AutoSize = true;
            this.lblSelectAdvisor.Location = new System.Drawing.Point(52, 113);
            this.lblSelectAdvisor.Name = "lblSelectAdvisor";
            this.lblSelectAdvisor.Size = new System.Drawing.Size(98, 17);
            this.lblSelectAdvisor.TabIndex = 0;
            this.lblSelectAdvisor.Text = "Select Advisor";
            // 
            // cmbSelctAdvisor
            // 
            this.cmbSelctAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSelctAdvisor.FormattingEnabled = true;
            this.cmbSelctAdvisor.Location = new System.Drawing.Point(200, 110);
            this.cmbSelctAdvisor.Name = "cmbSelctAdvisor";
            this.cmbSelctAdvisor.Size = new System.Drawing.Size(366, 24);
            this.cmbSelctAdvisor.TabIndex = 1;
            this.cmbSelctAdvisor.SelectedIndexChanged += new System.EventHandler(this.cmbSelctAdvisor_SelectedIndexChanged);
            // 
            // lblAdd
            // 
            this.lblAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdd.Location = new System.Drawing.Point(450, 177);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(116, 40);
            this.lblAdd.TabIndex = 2;
            this.lblAdd.Text = "Add";
            this.lblAdd.UseVisualStyleBackColor = true;
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(207, 137);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(122, 17);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "*Select an advisor";
            this.lblWarning.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(328, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 31);
            this.label1.TabIndex = 68;
            this.label1.Text = "Add Advisor To Project";
            // 
            // AddAdvisorToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(400, 200);
            this.ClientSize = new System.Drawing.Size(670, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblWarning);
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
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}