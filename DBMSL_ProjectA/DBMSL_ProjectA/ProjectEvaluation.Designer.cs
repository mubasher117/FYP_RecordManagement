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
            this.gvEvaluation = new System.Windows.Forms.DataGridView();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.Entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weightage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obtained = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvEvaluation)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date    :";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Location = new System.Drawing.Point(154, 110);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(46, 17);
            this.lblCurrentDate.TabIndex = 3;
            this.lblCurrentDate.Text = "label4";
            // 
            // gvEvaluation
            // 
            this.gvEvaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEvaluation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entity,
            this.TotalMarks,
            this.Weightage,
            this.Obtained});
            this.gvEvaluation.Location = new System.Drawing.Point(63, 165);
            this.gvEvaluation.Name = "gvEvaluation";
            this.gvEvaluation.RowTemplate.Height = 24;
            this.gvEvaluation.Size = new System.Drawing.Size(636, 226);
            this.gvEvaluation.TabIndex = 4;
            this.gvEvaluation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEvaluation_CellContentClick);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(596, 413);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(103, 34);
            this.btnEvaluate.TabIndex = 5;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // Entity
            // 
            this.Entity.HeaderText = "Entity";
            this.Entity.Name = "Entity";
            // 
            // TotalMarks
            // 
            this.TotalMarks.HeaderText = "Total Marks";
            this.TotalMarks.Name = "TotalMarks";
            this.TotalMarks.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Weightage
            // 
            this.Weightage.HeaderText = "Weightage";
            this.Weightage.Name = "Weightage";
            // 
            // Obtained
            // 
            this.Obtained.HeaderText = "Obtained Marks";
            this.Obtained.Name = "Obtained";
            // 
            // ProjectEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 492);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.gvEvaluation);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.label2);
            this.Name = "ProjectEvaluation";
            this.Text = "Project Evaluation";
            this.Load += new System.EventHandler(this.ProjectEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEvaluation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.DataGridView gvEvaluation;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weightage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obtained;
    }
}