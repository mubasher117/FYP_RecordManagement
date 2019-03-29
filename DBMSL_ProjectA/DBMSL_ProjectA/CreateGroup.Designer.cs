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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.RegistrationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCreateGroup = new System.Windows.Forms.Button();
            this.cmbSelectStudent = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
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
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(523, 134);
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
            this.gvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistrationNo,
            this.SName,
            this.Action,
            this.Action2});
            this.gvStudents.Location = new System.Drawing.Point(74, 195);
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
            // cmbSelectStudent
            // 
            this.cmbSelectStudent.FormattingEnabled = true;
            this.cmbSelectStudent.Location = new System.Drawing.Point(254, 92);
            this.cmbSelectStudent.Name = "cmbSelectStudent";
            this.cmbSelectStudent.Size = new System.Drawing.Size(366, 24);
            this.cmbSelectStudent.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(507, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 34);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 486);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbSelectStudent);
            this.Controls.Add(this.txtCreateGroup);
            this.Controls.Add(this.gvStudents);
            this.Controls.Add(this.btnAddStudent);
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
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
        private System.Windows.Forms.Button txtCreateGroup;
        private System.Windows.Forms.ComboBox cmbSelectStudent;
        private System.Windows.Forms.Button btnCancel;
    }
}