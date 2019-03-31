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
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assign = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.gvStudents.Location = new System.Drawing.Point(103, 150);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.RowTemplate.Height = 24;
            this.gvStudents.Size = new System.Drawing.Size(955, 365);
            this.gvStudents.TabIndex = 0;
            this.gvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudents_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a group for current project";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(858, 542);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 29);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(965, 542);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(93, 29);
            this.btnOk.TabIndex = 67;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 31);
            this.label2.TabIndex = 69;
            this.label2.Text = "Assign Group to Project";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AssignGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 625);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
    }
}