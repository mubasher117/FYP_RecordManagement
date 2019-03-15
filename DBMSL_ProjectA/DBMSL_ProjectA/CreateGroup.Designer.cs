namespace DBMSL_ProjectA
{
    partial class CreateGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.RegistrationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCreateGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.Location = new System.Drawing.Point(71, 95);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(144, 17);
            this.lblRegistrationNo.TabIndex = 0;
            this.lblRegistrationNo.Text = "Enter Registration No";
            this.lblRegistrationNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(255, 92);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(203, 22);
            this.txtRegistrationNo.TabIndex = 1;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(361, 120);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(97, 34);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // gvStudents
            // 
            this.gvStudents.AllowUserToAddRows = false;
            this.gvStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistrationNo,
            this.SName,
            this.Action,
            this.Action2});
            this.gvStudents.Location = new System.Drawing.Point(74, 199);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.RowTemplate.Height = 24;
            this.gvStudents.Size = new System.Drawing.Size(683, 177);
            this.gvStudents.TabIndex = 3;
            this.gvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudents_CellContentClick);
            // 
            // RegistrationNo
            // 
            this.RegistrationNo.HeaderText = "Reg No";
            this.RegistrationNo.MinimumWidth = 7;
            this.RegistrationNo.Name = "RegistrationNo";
            this.RegistrationNo.ReadOnly = true;
            this.RegistrationNo.Width = 120;
            // 
            // SName
            // 
            this.SName.HeaderText = "Name";
            this.SName.MinimumWidth = 10;
            this.SName.Name = "SName";
            this.SName.Width = 130;
            // 
            // Action
            // 
            this.Action.HeaderText = "";
            this.Action.Name = "Action";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.Text = "Edit";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 60;
            // 
            // Action2
            // 
            this.Action2.HeaderText = "";
            this.Action2.Name = "Action2";
            this.Action2.Text = "Delete";
            this.Action2.UseColumnTextForButtonValue = true;
            this.Action2.Width = 60;
            // 
            // txtCreateGroup
            // 
            this.txtCreateGroup.Location = new System.Drawing.Point(626, 404);
            this.txtCreateGroup.Name = "txtCreateGroup";
            this.txtCreateGroup.Size = new System.Drawing.Size(131, 34);
            this.txtCreateGroup.TabIndex = 4;
            this.txtCreateGroup.Text = "Create Group";
            this.txtCreateGroup.UseVisualStyleBackColor = true;
            this.txtCreateGroup.Click += new System.EventHandler(this.txtCreateGroup_Click);
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCreateGroup);
            this.Controls.Add(this.gvStudents);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.lblRegistrationNo);
            this.Name = "CreateGroup";
            this.Text = "CreateGroup";
            this.Load += new System.EventHandler(this.CreateGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
        private System.Windows.Forms.Button txtCreateGroup;
    }
}