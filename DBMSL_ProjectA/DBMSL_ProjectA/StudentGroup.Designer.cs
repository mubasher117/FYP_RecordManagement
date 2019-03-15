namespace DBMSL_ProjectA
{
    partial class StudentGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.GName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // gvStudents
            // 
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GName,
            this.GReg});
            this.gvStudents.Location = new System.Drawing.Point(3, 3);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.RowTemplate.Height = 24;
            this.gvStudents.Size = new System.Drawing.Size(408, 212);
            this.gvStudents.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(21, 249);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "id";
            this.lblId.Visible = false;
            // 
            // GName
            // 
            this.GName.HeaderText = "Name";
            this.GName.Name = "GName";
            this.GName.ReadOnly = true;
            // 
            // GReg
            // 
            this.GReg.HeaderText = "Registration No";
            this.GReg.Name = "GReg";
            this.GReg.ReadOnly = true;
            // 
            // StudentGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvStudents);
            this.Name = "StudentGroup";
            this.Size = new System.Drawing.Size(415, 277);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GReg;
    }
}
