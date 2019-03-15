namespace DBMSL_ProjectA
{
    partial class AssignGroup
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
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assign = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // gvStudents
            // 
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupId,
            this.Member1,
            this.Member2,
            this.Member3,
            this.Member4,
            this.Assign});
            this.gvStudents.Location = new System.Drawing.Point(99, 86);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.RowTemplate.Height = 24;
            this.gvStudents.Size = new System.Drawing.Size(955, 365);
            this.gvStudents.TabIndex = 0;
            this.gvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudents_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a group for current project";
            // 
            // GroupId
            // 
            this.GroupId.HeaderText = "Id";
            this.GroupId.Name = "GroupId";
            this.GroupId.Visible = false;
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
            // Assign
            // 
            this.Assign.HeaderText = "";
            this.Assign.Name = "Assign";
            this.Assign.Text = "Assign";
            this.Assign.UseColumnTextForButtonValue = true;
            // 
            // AssignGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvStudents);
            this.Name = "AssignGroup";
            this.Text = "Assign Group";
            this.Load += new System.EventHandler(this.AssignGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member4;
        private System.Windows.Forms.DataGridViewButtonColumn Assign;
    }
}