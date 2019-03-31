namespace DBMSL_ProjectA
{
    partial class ProjectEvaluation
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbTitles = new System.Windows.Forms.ComboBox();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblTotalWeightage = new System.Windows.Forms.Label();
            this.lblObtainedMarks = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.txtObtainedMarks = new System.Windows.Forms.TextBox();
            this.txtWeightage = new System.Windows.Forms.TextBox();
            this.lblTotalMarksWarning = new System.Windows.Forms.Label();
            this.lblTotalWeightageWarning = new System.Windows.Forms.Label();
            this.lblObtaninedMarksWarning = new System.Windows.Forms.Label();
            this.lblTitleWarning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date    :";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Location = new System.Drawing.Point(178, 124);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(46, 17);
            this.lblCurrentDate.TabIndex = 3;
            this.lblCurrentDate.Text = "label4";
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(425, 359);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(103, 34);
            this.btnEvaluate.TabIndex = 5;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(88, 170);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 17);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Select Project";
            // 
            // cmbTitles
            // 
            this.cmbTitles.FormattingEnabled = true;
            this.cmbTitles.Location = new System.Drawing.Point(230, 167);
            this.cmbTitles.Name = "cmbTitles";
            this.cmbTitles.Size = new System.Drawing.Size(298, 24);
            this.cmbTitles.TabIndex = 8;
            this.cmbTitles.SelectedIndexChanged += new System.EventHandler(this.cmbTitles_SelectedIndexChanged);
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(88, 219);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(82, 17);
            this.lblTotalMarks.TabIndex = 9;
            this.lblTotalMarks.Text = "Total Marks";
            // 
            // lblTotalWeightage
            // 
            this.lblTotalWeightage.AutoSize = true;
            this.lblTotalWeightage.Location = new System.Drawing.Point(88, 263);
            this.lblTotalWeightage.Name = "lblTotalWeightage";
            this.lblTotalWeightage.Size = new System.Drawing.Size(112, 17);
            this.lblTotalWeightage.TabIndex = 10;
            this.lblTotalWeightage.Text = "Total Weightage";
            // 
            // lblObtainedMarks
            // 
            this.lblObtainedMarks.AutoSize = true;
            this.lblObtainedMarks.Location = new System.Drawing.Point(88, 307);
            this.lblObtainedMarks.Name = "lblObtainedMarks";
            this.lblObtainedMarks.Size = new System.Drawing.Size(108, 17);
            this.lblObtainedMarks.TabIndex = 11;
            this.lblObtainedMarks.Text = "Obtained Marks";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(230, 214);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(298, 22);
            this.txtTotalMarks.TabIndex = 12;
            this.txtTotalMarks.TextChanged += new System.EventHandler(this.txtTotalMarks_TextChanged);
            // 
            // txtObtainedMarks
            // 
            this.txtObtainedMarks.Location = new System.Drawing.Point(230, 304);
            this.txtObtainedMarks.Name = "txtObtainedMarks";
            this.txtObtainedMarks.Size = new System.Drawing.Size(298, 22);
            this.txtObtainedMarks.TabIndex = 13;
            this.txtObtainedMarks.TextChanged += new System.EventHandler(this.txtObtainedMarks_TextChanged);
            // 
            // txtWeightage
            // 
            this.txtWeightage.Location = new System.Drawing.Point(230, 260);
            this.txtWeightage.Name = "txtWeightage";
            this.txtWeightage.Size = new System.Drawing.Size(298, 22);
            this.txtWeightage.TabIndex = 14;
            this.txtWeightage.TextChanged += new System.EventHandler(this.txtWeightage_TextChanged);
            // 
            // lblTotalMarksWarning
            // 
            this.lblTotalMarksWarning.AutoSize = true;
            this.lblTotalMarksWarning.ForeColor = System.Drawing.Color.Red;
            this.lblTotalMarksWarning.Location = new System.Drawing.Point(237, 239);
            this.lblTotalMarksWarning.Name = "lblTotalMarksWarning";
            this.lblTotalMarksWarning.Size = new System.Drawing.Size(181, 17);
            this.lblTotalMarksWarning.TabIndex = 39;
            this.lblTotalMarksWarning.Text = "*Enter decimal number only";
            this.lblTotalMarksWarning.Visible = false;
            // 
            // lblTotalWeightageWarning
            // 
            this.lblTotalWeightageWarning.AutoSize = true;
            this.lblTotalWeightageWarning.ForeColor = System.Drawing.Color.Red;
            this.lblTotalWeightageWarning.Location = new System.Drawing.Point(237, 284);
            this.lblTotalWeightageWarning.Name = "lblTotalWeightageWarning";
            this.lblTotalWeightageWarning.Size = new System.Drawing.Size(181, 17);
            this.lblTotalWeightageWarning.TabIndex = 40;
            this.lblTotalWeightageWarning.Text = "*Enter decimal number only";
            this.lblTotalWeightageWarning.Visible = false;
            // 
            // lblObtaninedMarksWarning
            // 
            this.lblObtaninedMarksWarning.AutoSize = true;
            this.lblObtaninedMarksWarning.ForeColor = System.Drawing.Color.Red;
            this.lblObtaninedMarksWarning.Location = new System.Drawing.Point(237, 329);
            this.lblObtaninedMarksWarning.Name = "lblObtaninedMarksWarning";
            this.lblObtaninedMarksWarning.Size = new System.Drawing.Size(181, 17);
            this.lblObtaninedMarksWarning.TabIndex = 41;
            this.lblObtaninedMarksWarning.Text = "*Enter decimal number only";
            this.lblObtaninedMarksWarning.Visible = false;
            // 
            // lblTitleWarning
            // 
            this.lblTitleWarning.AutoSize = true;
            this.lblTitleWarning.ForeColor = System.Drawing.Color.Red;
            this.lblTitleWarning.Location = new System.Drawing.Point(237, 194);
            this.lblTitleWarning.Name = "lblTitleWarning";
            this.lblTitleWarning.Size = new System.Drawing.Size(83, 17);
            this.lblTitleWarning.TabIndex = 42;
            this.lblTitleWarning.Text = "*Select Title";
            this.lblTitleWarning.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 69;
            this.label1.Text = "Evaluate Projects";
            // 
            // ProjectEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitleWarning);
            this.Controls.Add(this.lblObtaninedMarksWarning);
            this.Controls.Add(this.lblTotalWeightageWarning);
            this.Controls.Add(this.lblTotalMarksWarning);
            this.Controls.Add(this.txtWeightage);
            this.Controls.Add(this.txtObtainedMarks);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.lblObtainedMarks);
            this.Controls.Add(this.lblTotalWeightage);
            this.Controls.Add(this.lblTotalMarks);
            this.Controls.Add(this.cmbTitles);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.label2);
            this.Name = "ProjectEvaluation";
            this.Text = "Project Evaluation";
            this.Load += new System.EventHandler(this.ProjectEvaluation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbTitles;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblTotalWeightage;
        private System.Windows.Forms.Label lblObtainedMarks;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.TextBox txtObtainedMarks;
        private System.Windows.Forms.TextBox txtWeightage;
        private System.Windows.Forms.Label lblTotalMarksWarning;
        private System.Windows.Forms.Label lblTotalWeightageWarning;
        private System.Windows.Forms.Label lblObtaninedMarksWarning;
        private System.Windows.Forms.Label lblTitleWarning;
        private System.Windows.Forms.Label label1;
    }
}