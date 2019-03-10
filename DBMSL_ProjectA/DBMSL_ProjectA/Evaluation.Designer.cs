namespace DBMSL_ProjectA
{
    partial class Evaluation
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblTotalWeightage = new System.Windows.Forms.Label();
            this.lblObtainedMarks = new System.Windows.Forms.Label();
            this.txtTotalWeightage = new System.Windows.Forms.TextBox();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.txtObtainedMarks = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(71, 130);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(71, 168);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(82, 17);
            this.lblTotalMarks.TabIndex = 1;
            this.lblTotalMarks.Text = "Total Marks";
            // 
            // lblTotalWeightage
            // 
            this.lblTotalWeightage.AutoSize = true;
            this.lblTotalWeightage.Location = new System.Drawing.Point(71, 212);
            this.lblTotalWeightage.Name = "lblTotalWeightage";
            this.lblTotalWeightage.Size = new System.Drawing.Size(112, 17);
            this.lblTotalWeightage.TabIndex = 2;
            this.lblTotalWeightage.Text = "Total Weightage";
            // 
            // lblObtainedMarks
            // 
            this.lblObtainedMarks.AutoSize = true;
            this.lblObtainedMarks.Location = new System.Drawing.Point(71, 247);
            this.lblObtainedMarks.Name = "lblObtainedMarks";
            this.lblObtainedMarks.Size = new System.Drawing.Size(108, 17);
            this.lblObtainedMarks.TabIndex = 3;
            this.lblObtainedMarks.Text = "Obtained Marks";
            // 
            // txtTotalWeightage
            // 
            this.txtTotalWeightage.Location = new System.Drawing.Point(241, 212);
            this.txtTotalWeightage.Name = "txtTotalWeightage";
            this.txtTotalWeightage.Size = new System.Drawing.Size(222, 22);
            this.txtTotalWeightage.TabIndex = 5;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(241, 168);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(222, 22);
            this.txtTotalMarks.TabIndex = 6;
            // 
            // txtObtainedMarks
            // 
            this.txtObtainedMarks.Location = new System.Drawing.Point(241, 247);
            this.txtObtainedMarks.Name = "txtObtainedMarks";
            this.txtObtainedMarks.Size = new System.Drawing.Size(222, 22);
            this.txtObtainedMarks.TabIndex = 7;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(241, 130);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(222, 22);
            this.dtDate.TabIndex = 8;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(370, 298);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(93, 33);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click_1);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(29, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(337, 60);
            this.txtTitle.TabIndex = 10;
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 448);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.txtObtainedMarks);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.txtTotalWeightage);
            this.Controls.Add(this.lblObtainedMarks);
            this.Controls.Add(this.lblTotalWeightage);
            this.Controls.Add(this.lblTotalMarks);
            this.Controls.Add(this.lblDate);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblTotalWeightage;
        private System.Windows.Forms.Label lblObtainedMarks;
        private System.Windows.Forms.TextBox txtTotalWeightage;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.TextBox txtObtainedMarks;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtTitle;
    }
}