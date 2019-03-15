namespace DBMSL_ProjectA
{
    partial class ManageAdvisors
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.gvAdvisors = new System.Windows.Forms.DataGridView();
            this.hiddenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action3 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdvisors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(608, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add New Advisor";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gvAdvisors
            // 
            this.gvAdvisors.AllowUserToAddRows = false;
            this.gvAdvisors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvAdvisors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvAdvisors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvAdvisors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAdvisors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hiddenId,
            this.RegistrationNo,
            this.SName,
            this.Action,
            this.Action2,
            this.Action3});
            this.gvAdvisors.Location = new System.Drawing.Point(54, 173);
            this.gvAdvisors.Name = "gvAdvisors";
            this.gvAdvisors.RowTemplate.Height = 24;
            this.gvAdvisors.Size = new System.Drawing.Size(689, 254);
            this.gvAdvisors.TabIndex = 4;
            this.gvAdvisors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAdvisors_CellContentClick);
            // 
            // hiddenId
            // 
            this.hiddenId.HeaderText = "Id";
            this.hiddenId.Name = "hiddenId";
            this.hiddenId.Visible = false;
            // 
            // RegistrationNo
            // 
            this.RegistrationNo.HeaderText = "Name";
            this.RegistrationNo.MinimumWidth = 7;
            this.RegistrationNo.Name = "RegistrationNo";
            this.RegistrationNo.ReadOnly = true;
            this.RegistrationNo.Width = 120;
            // 
            // SName
            // 
            this.SName.HeaderText = "Designation";
            this.SName.MinimumWidth = 10;
            this.SName.Name = "SName";
            this.SName.Width = 130;
            // 
            // Action
            // 
            this.Action.HeaderText = "";
            this.Action.Name = "Action";
            this.Action.Text = "View";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // Action2
            // 
            this.Action2.HeaderText = "";
            this.Action2.Name = "Action2";
            this.Action2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action2.Text = "Edit";
            this.Action2.UseColumnTextForButtonValue = true;
            this.Action2.Width = 60;
            // 
            // Action3
            // 
            this.Action3.HeaderText = "";
            this.Action3.Name = "Action3";
            this.Action3.Text = "Delete";
            this.Action3.UseColumnTextForButtonValue = true;
            this.Action3.Width = 60;
            // 
            // ManageAdvisors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 489);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gvAdvisors);
            this.Name = "ManageAdvisors";
            this.Text = "ManageAdvisors";
            this.Load += new System.EventHandler(this.ManageAdvisors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAdvisors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gvAdvisors;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiddenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
        private System.Windows.Forms.DataGridViewButtonColumn Action3;
    }
}