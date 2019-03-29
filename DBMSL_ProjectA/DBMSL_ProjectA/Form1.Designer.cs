namespace DBMSL_ProjectA
{
    partial class frmRegisterStudent
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblFNameWarning = new System.Windows.Forms.Label();
            this.lblLNameWarning = new System.Windows.Forms.Label();
            this.lblRegWarning = new System.Windows.Forms.Label();
            this.lblCellWarning = new System.Windows.Forms.Label();
            this.lblEmailWarning = new System.Windows.Forms.Label();
            this.lblGenderWarning = new System.Windows.Forms.Label();
            this.lblDOBwarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(260, 281);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 31;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(260, 242);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(200, 22);
            this.txtContactNo.TabIndex = 30;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(260, 200);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(200, 22);
            this.txtRegNo.TabIndex = 29;
            this.txtRegNo.TextChanged += new System.EventHandler(this.txtRegNo_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(260, 155);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 28;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(260, 109);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 27;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(112, 364);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(90, 17);
            this.lblDOB.TabIndex = 26;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(114, 324);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 25;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(114, 284);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(114, 245);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(78, 17);
            this.lblContactNo.TabIndex = 23;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(112, 203);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(106, 17);
            this.lblRegNo.TabIndex = 22;
            this.lblRegNo.Text = "Registration No";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(114, 158);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(114, 112);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 20;
            this.lblFirstName.Text = "First Name";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(369, 406);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 29);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(260, 317);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(200, 24);
            this.cmbGender.TabIndex = 34;
            this.cmbGender.TextChanged += new System.EventHandler(this.cmbGender_TextChanged);
            // 
            // cmbDay
            // 
            this.cmbDay.DisplayMember = "Day";
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Day",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDay.Location = new System.Drawing.Point(260, 361);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(55, 24);
            this.cmbDay.TabIndex = 35;
            this.cmbDay.TextChanged += new System.EventHandler(this.cmbDay_TextChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Month",
            "January",
            "Febraury",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(321, 361);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(71, 24);
            this.cmbMonth.TabIndex = 36;
            this.cmbMonth.TextChanged += new System.EventHandler(this.cmbMonth_TextChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "Year",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005"});
            this.cmbYear.Location = new System.Drawing.Point(398, 362);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(64, 24);
            this.cmbYear.TabIndex = 37;
            this.cmbYear.TextChanged += new System.EventHandler(this.cmbYear_TextChanged);
            // 
            // lblFNameWarning
            // 
            this.lblFNameWarning.AutoSize = true;
            this.lblFNameWarning.ForeColor = System.Drawing.Color.Red;
            this.lblFNameWarning.Location = new System.Drawing.Point(466, 114);
            this.lblFNameWarning.Name = "lblFNameWarning";
            this.lblFNameWarning.Size = new System.Drawing.Size(138, 17);
            this.lblFNameWarning.TabIndex = 38;
            this.lblFNameWarning.Text = "*Enter Correct Name";
            this.lblFNameWarning.Visible = false;
            // 
            // lblLNameWarning
            // 
            this.lblLNameWarning.AutoSize = true;
            this.lblLNameWarning.ForeColor = System.Drawing.Color.Red;
            this.lblLNameWarning.Location = new System.Drawing.Point(466, 160);
            this.lblLNameWarning.Name = "lblLNameWarning";
            this.lblLNameWarning.Size = new System.Drawing.Size(138, 17);
            this.lblLNameWarning.TabIndex = 39;
            this.lblLNameWarning.Text = "*Enter Correct Name";
            this.lblLNameWarning.Visible = false;
            // 
            // lblRegWarning
            // 
            this.lblRegWarning.AutoSize = true;
            this.lblRegWarning.ForeColor = System.Drawing.Color.Red;
            this.lblRegWarning.Location = new System.Drawing.Point(466, 203);
            this.lblRegWarning.Name = "lblRegWarning";
            this.lblRegWarning.Size = new System.Drawing.Size(134, 17);
            this.lblRegWarning.TabIndex = 40;
            this.lblRegWarning.Text = "*Enter Valid Reg No";
            this.lblRegWarning.Visible = false;
            // 
            // lblCellWarning
            // 
            this.lblCellWarning.AutoSize = true;
            this.lblCellWarning.ForeColor = System.Drawing.Color.Red;
            this.lblCellWarning.Location = new System.Drawing.Point(466, 245);
            this.lblCellWarning.Name = "lblCellWarning";
            this.lblCellWarning.Size = new System.Drawing.Size(96, 17);
            this.lblCellWarning.TabIndex = 41;
            this.lblCellWarning.Text = "*Enter Cell No";
            this.lblCellWarning.Visible = false;
            // 
            // lblEmailWarning
            // 
            this.lblEmailWarning.AutoSize = true;
            this.lblEmailWarning.ForeColor = System.Drawing.Color.Red;
            this.lblEmailWarning.Location = new System.Drawing.Point(466, 284);
            this.lblEmailWarning.Name = "lblEmailWarning";
            this.lblEmailWarning.Size = new System.Drawing.Size(120, 17);
            this.lblEmailWarning.TabIndex = 42;
            this.lblEmailWarning.Text = "*Enter Valid Email";
            this.lblEmailWarning.Visible = false;
            // 
            // lblGenderWarning
            // 
            this.lblGenderWarning.AutoSize = true;
            this.lblGenderWarning.ForeColor = System.Drawing.Color.Red;
            this.lblGenderWarning.Location = new System.Drawing.Point(466, 324);
            this.lblGenderWarning.Name = "lblGenderWarning";
            this.lblGenderWarning.Size = new System.Drawing.Size(104, 17);
            this.lblGenderWarning.TabIndex = 43;
            this.lblGenderWarning.Text = "*Select Gender";
            this.lblGenderWarning.Visible = false;
            // 
            // lblDOBwarning
            // 
            this.lblDOBwarning.AutoSize = true;
            this.lblDOBwarning.ForeColor = System.Drawing.Color.Red;
            this.lblDOBwarning.Location = new System.Drawing.Point(466, 364);
            this.lblDOBwarning.Name = "lblDOBwarning";
            this.lblDOBwarning.Size = new System.Drawing.Size(138, 17);
            this.lblDOBwarning.TabIndex = 44;
            this.lblDOBwarning.Text = "*Select Date Of Birth";
            this.lblDOBwarning.Visible = false;
            // 
            // frmRegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 519);
            this.Controls.Add(this.lblDOBwarning);
            this.Controls.Add(this.lblGenderWarning);
            this.Controls.Add(this.lblEmailWarning);
            this.Controls.Add(this.lblCellWarning);
            this.Controls.Add(this.lblRegWarning);
            this.Controls.Add(this.lblLNameWarning);
            this.Controls.Add(this.lblFNameWarning);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnRegister);
            this.Name = "frmRegisterStudent";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.frmRegisterStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblFNameWarning;
        private System.Windows.Forms.Label lblLNameWarning;
        private System.Windows.Forms.Label lblRegWarning;
        private System.Windows.Forms.Label lblCellWarning;
        private System.Windows.Forms.Label lblEmailWarning;
        private System.Windows.Forms.Label lblGenderWarning;
        private System.Windows.Forms.Label lblDOBwarning;
    }
}

