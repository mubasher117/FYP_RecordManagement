namespace DBMSL_ProjectA
{
    partial class Marksheet
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
            this.gvMarksheet = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWeightage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupEvaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarksheet)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMarksheet
            // 
            this.gvMarksheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMarksheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.TotalMarks,
            this.TotalWeightage,
            this.GroupEvaluation,
            this.Member1,
            this.Member2,
            this.Member3,
            this.Member4});
            this.gvMarksheet.Location = new System.Drawing.Point(67, 152);
            this.gvMarksheet.Name = "gvMarksheet";
            this.gvMarksheet.RowTemplate.Height = 24;
            this.gvMarksheet.Size = new System.Drawing.Size(971, 379);
            this.gvMarksheet.TabIndex = 0;
            this.gvMarksheet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TotalMarks
            // 
            this.TotalMarks.HeaderText = "Total Marks";
            this.TotalMarks.Name = "TotalMarks";
            // 
            // TotalWeightage
            // 
            this.TotalWeightage.HeaderText = "Total Weightage";
            this.TotalWeightage.Name = "TotalWeightage";
            this.TotalWeightage.Width = 110;
            // 
            // GroupEvaluation
            // 
            this.GroupEvaluation.HeaderText = "Group Evaluation";
            this.GroupEvaluation.Name = "GroupEvaluation";
            // 
            // Member1
            // 
            this.Member1.HeaderText = "";
            this.Member1.Name = "Member1";
            // 
            // Member2
            // 
            this.Member2.HeaderText = "";
            this.Member2.Name = "Member2";
            // 
            // Member3
            // 
            this.Member3.HeaderText = "";
            this.Member3.Name = "Member3";
            // 
            // Member4
            // 
            this.Member4.HeaderText = "";
            this.Member4.Name = "Member4";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(931, 549);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(62, 103);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 29);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marksheet";
            // 
            // Marksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gvMarksheet);
            this.Name = "Marksheet";
            this.Text = "Marksheet";
            this.Load += new System.EventHandler(this.Marksheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMarksheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMarksheet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWeightage;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupEvaluation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member4;
    }
}