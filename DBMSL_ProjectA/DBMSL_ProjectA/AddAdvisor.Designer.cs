namespace DBMSL_ProjectA
{
    partial class AddAdvisor
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
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAddAdvisor = new System.Windows.Forms.Button();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.lblDOBwarning = new System.Windows.Forms.Label();
            this.lblGenderWarning = new System.Windows.Forms.Label();
            this.lblEmailWarning = new System.Windows.Forms.Label();
            this.lblCellWarning = new System.Windows.Forms.Label();
            this.lblDesgWarning = new System.Windows.Forms.Label();
            this.lblLNameWarning = new System.Windows.Forms.Label();
            this.lblFNameWarning = new System.Windows.Forms.Label();
            this.lblSalaryWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.cmbYear.Location = new System.Drawing.Point(440, 354);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(64, 24);
            this.cmbYear.TabIndex = 54;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
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
            this.cmbMonth.Location = new System.Drawing.Point(363, 353);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(71, 24);
            this.cmbMonth.TabIndex = 53;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
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
            this.cmbDay.Location = new System.Drawing.Point(302, 353);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(55, 24);
            this.cmbDay.TabIndex = 52;
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.cmbDay_SelectedIndexChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(302, 307);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(200, 24);
            this.cmbGender.TabIndex = 51;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(302, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 50;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(302, 223);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(200, 22);
            this.txtContactNo.TabIndex = 49;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(302, 138);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 47;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(302, 94);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 46;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(153, 356);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(90, 17);
            this.lblDOB.TabIndex = 45;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(156, 307);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 44;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(156, 267);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 43;
            this.lblEmail.Text = "Email";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(156, 226);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(78, 17);
            this.lblContactNo.TabIndex = 42;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(153, 182);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(83, 17);
            this.lblDesignation.TabIndex = 41;
            this.lblDesignation.Text = "Designation";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(156, 143);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 40;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(156, 97);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 39;
            this.lblFirstName.Text = "First Name";
            // 
            // btnAddAdvisor
            // 
            this.btnAddAdvisor.Location = new System.Drawing.Point(409, 447);
            this.btnAddAdvisor.Name = "btnAddAdvisor";
            this.btnAddAdvisor.Size = new System.Drawing.Size(93, 29);
            this.btnAddAdvisor.TabIndex = 38;
            this.btnAddAdvisor.Text = "Add";
            this.btnAddAdvisor.UseVisualStyleBackColor = true;
            this.btnAddAdvisor.Click += new System.EventHandler(this.btnAddAdvisor_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(154, 400);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(48, 17);
            this.lblSalary.TabIndex = 55;
            this.lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(302, 400);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 22);
            this.txtSalary.TabIndex = 56;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.cmbDesignation.Location = new System.Drawing.Point(302, 179);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(200, 24);
            this.cmbDesignation.TabIndex = 57;
            this.cmbDesignation.TextChanged += new System.EventHandler(this.cmbDesignation_TextChanged);
            // 
            // lblDOBwarning
            // 
            this.lblDOBwarning.AutoSize = true;
            this.lblDOBwarning.ForeColor = System.Drawing.Color.Red;
            this.lblDOBwarning.Location = new System.Drawing.Point(508, 357);
            this.lblDOBwarning.Name = "lblDOBwarning";
            this.lblDOBwarning.Size = new System.Drawing.Size(138, 17);
            this.lblDOBwarning.TabIndex = 64;
            this.lblDOBwarning.Text = "*Select Date Of Birth";
            this.lblDOBwarning.Visible = false;
            // 
            // lblGenderWarning
            // 
            this.lblGenderWarning.AutoSize = true;
            this.lblGenderWarning.ForeColor = System.Drawing.Color.Red;
            this.lblGenderWarning.Location = new System.Drawing.Point(508, 314);
            this.lblGenderWarning.Name = "lblGenderWarning";
            this.lblGenderWarning.Size = new System.Drawing.Size(104, 17);
            this.lblGenderWarning.TabIndex = 63;
            this.lblGenderWarning.Text = "*Select Gender";
            this.lblGenderWarning.Visible = false;
            // 
            // lblEmailWarning
            // 
            this.lblEmailWarning.AutoSize = true;
            this.lblEmailWarning.ForeColor = System.Drawing.Color.Red;
            this.lblEmailWarning.Location = new System.Drawing.Point(508, 272);
            this.lblEmailWarning.Name = "lblEmailWarning";
            this.lblEmailWarning.Size = new System.Drawing.Size(120, 17);
            this.lblEmailWarning.TabIndex = 62;
            this.lblEmailWarning.Text = "*Enter Valid Email";
            this.lblEmailWarning.Visible = false;
            // 
            // lblCellWarning
            // 
            this.lblCellWarning.AutoSize = true;
            this.lblCellWarning.ForeColor = System.Drawing.Color.Red;
            this.lblCellWarning.Location = new System.Drawing.Point(508, 228);
            this.lblCellWarning.Name = "lblCellWarning";
            this.lblCellWarning.Size = new System.Drawing.Size(96, 17);
            this.lblCellWarning.TabIndex = 61;
            this.lblCellWarning.Text = "*Enter Cell No";
            this.lblCellWarning.Visible = false;
            // 
            // lblDesgWarning
            // 
            this.lblDesgWarning.AutoSize = true;
            this.lblDesgWarning.ForeColor = System.Drawing.Color.Red;
            this.lblDesgWarning.Location = new System.Drawing.Point(508, 186);
            this.lblDesgWarning.Name = "lblDesgWarning";
            this.lblDesgWarning.Size = new System.Drawing.Size(131, 17);
            this.lblDesgWarning.TabIndex = 60;
            this.lblDesgWarning.Text = "*Select Designation";
            this.lblDesgWarning.Visible = false;
            // 
            // lblLNameWarning
            // 
            this.lblLNameWarning.AutoSize = true;
            this.lblLNameWarning.ForeColor = System.Drawing.Color.Red;
            this.lblLNameWarning.Location = new System.Drawing.Point(508, 143);
            this.lblLNameWarning.Name = "lblLNameWarning";
            this.lblLNameWarning.Size = new System.Drawing.Size(138, 17);
            this.lblLNameWarning.TabIndex = 59;
            this.lblLNameWarning.Text = "*Enter Correct Name";
            this.lblLNameWarning.Visible = false;
            // 
            // lblFNameWarning
            // 
            this.lblFNameWarning.AutoSize = true;
            this.lblFNameWarning.ForeColor = System.Drawing.Color.Red;
            this.lblFNameWarning.Location = new System.Drawing.Point(508, 97);
            this.lblFNameWarning.Name = "lblFNameWarning";
            this.lblFNameWarning.Size = new System.Drawing.Size(138, 17);
            this.lblFNameWarning.TabIndex = 58;
            this.lblFNameWarning.Text = "*Enter Correct Name";
            this.lblFNameWarning.Visible = false;
            // 
            // lblSalaryWarning
            // 
            this.lblSalaryWarning.AutoSize = true;
            this.lblSalaryWarning.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryWarning.Location = new System.Drawing.Point(508, 400);
            this.lblSalaryWarning.Name = "lblSalaryWarning";
            this.lblSalaryWarning.Size = new System.Drawing.Size(99, 17);
            this.lblSalaryWarning.TabIndex = 65;
            this.lblSalaryWarning.Text = "*Enter Salaray";
            this.lblSalaryWarning.Visible = false;
            // 
            // AddAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(694, 512);
            this.Controls.Add(this.lblSalaryWarning);
            this.Controls.Add(this.lblDOBwarning);
            this.Controls.Add(this.lblGenderWarning);
            this.Controls.Add(this.lblEmailWarning);
            this.Controls.Add(this.lblCellWarning);
            this.Controls.Add(this.lblDesgWarning);
            this.Controls.Add(this.lblLNameWarning);
            this.Controls.Add(this.lblFNameWarning);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnAddAdvisor);
            this.Name = "AddAdvisor";
            this.Text = "Add Advisor";
            this.Load += new System.EventHandler(this.AddAdvisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAddAdvisor;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label lblDOBwarning;
        private System.Windows.Forms.Label lblGenderWarning;
        private System.Windows.Forms.Label lblEmailWarning;
        private System.Windows.Forms.Label lblCellWarning;
        private System.Windows.Forms.Label lblDesgWarning;
        private System.Windows.Forms.Label lblLNameWarning;
        private System.Windows.Forms.Label lblFNameWarning;
        private System.Windows.Forms.Label lblSalaryWarning;
    }
}