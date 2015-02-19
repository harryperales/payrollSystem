namespace PayrollSystem.view
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.dependents = new System.Windows.Forms.TextBox();
            this.dependentsLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.sssId = new System.Windows.Forms.TextBox();
            this.tin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.contactNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pagIbigId = new System.Windows.Forms.TextBox();
            this.philHealthId = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.birthdayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.civilStatusComboBox = new System.Windows.Forms.ComboBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.middlename = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.employeeId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.exitPictureBox);
            this.panel1.Controls.Add(this.positionComboBox);
            this.panel1.Controls.Add(this.salary);
            this.panel1.Controls.Add(this.salaryLabel);
            this.panel1.Controls.Add(this.dependents);
            this.panel1.Controls.Add(this.dependentsLabel);
            this.panel1.Controls.Add(this.genderComboBox);
            this.panel1.Controls.Add(this.createEmployeeButton);
            this.panel1.Controls.Add(this.sssId);
            this.panel1.Controls.Add(this.tin);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.contactNumber);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.pagIbigId);
            this.panel1.Controls.Add(this.philHealthId);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.birthdayTimePicker);
            this.panel1.Controls.Add(this.civilStatusComboBox);
            this.panel1.Controls.Add(this.confirmPassword);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lastname);
            this.panel1.Controls.Add(this.middlename);
            this.panel1.Controls.Add(this.firstname);
            this.panel1.Controls.Add(this.employeeId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 300);
            this.panel1.TabIndex = 0;
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Associate",
            "Probationary",
            "Regular",
            "Senior",
            "Supervisor",
            "Manager"});
            this.positionComboBox.Location = new System.Drawing.Point(114, 243);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(128, 21);
            this.positionComboBox.TabIndex = 23;
            this.positionComboBox.SelectedIndexChanged += new System.EventHandler(this.positionComboBox_SelectedIndexChanged);
            // 
            // salary
            // 
            this.salary.Enabled = false;
            this.salary.Location = new System.Drawing.Point(356, 60);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(128, 20);
            this.salary.TabIndex = 22;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.salaryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salaryLabel.Location = new System.Drawing.Point(269, 63);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(44, 15);
            this.salaryLabel.TabIndex = 21;
            this.salaryLabel.Text = "Salary";
            // 
            // dependents
            // 
            this.dependents.Location = new System.Drawing.Point(356, 37);
            this.dependents.Name = "dependents";
            this.dependents.Size = new System.Drawing.Size(128, 20);
            this.dependents.TabIndex = 20;
            // 
            // dependentsLabel
            // 
            this.dependentsLabel.AutoSize = true;
            this.dependentsLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.dependentsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dependentsLabel.Location = new System.Drawing.Point(263, 40);
            this.dependentsLabel.Name = "dependentsLabel";
            this.dependentsLabel.Size = new System.Drawing.Size(72, 15);
            this.dependentsLabel.TabIndex = 19;
            this.dependentsLabel.Text = "Dependents";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(114, 219);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(128, 21);
            this.genderComboBox.TabIndex = 18;
            // 
            // createEmployeeButton
            // 
            this.createEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.createEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createEmployeeButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.createEmployeeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createEmployeeButton.Location = new System.Drawing.Point(356, 236);
            this.createEmployeeButton.Name = "createEmployeeButton";
            this.createEmployeeButton.Size = new System.Drawing.Size(128, 40);
            this.createEmployeeButton.TabIndex = 17;
            this.createEmployeeButton.Text = "Create";
            this.createEmployeeButton.UseVisualStyleBackColor = false;
            this.createEmployeeButton.Click += new System.EventHandler(this.createEmployeeButton_Click);
            // 
            // sssId
            // 
            this.sssId.Location = new System.Drawing.Point(356, 154);
            this.sssId.Name = "sssId";
            this.sssId.Size = new System.Drawing.Size(128, 20);
            this.sssId.TabIndex = 14;
            // 
            // tin
            // 
            this.tin.Location = new System.Drawing.Point(356, 131);
            this.tin.Name = "tin";
            this.tin.Size = new System.Drawing.Size(128, 20);
            this.tin.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(263, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "SSS ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(263, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "TIN";
            // 
            // contactNumber
            // 
            this.contactNumber.Location = new System.Drawing.Point(356, 105);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(128, 20);
            this.contactNumber.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(251, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Contact Number";
            // 
            // pagIbigId
            // 
            this.pagIbigId.Location = new System.Drawing.Point(356, 200);
            this.pagIbigId.Name = "pagIbigId";
            this.pagIbigId.Size = new System.Drawing.Size(128, 20);
            this.pagIbigId.TabIndex = 16;
            // 
            // philHealthId
            // 
            this.philHealthId.Location = new System.Drawing.Point(356, 178);
            this.philHealthId.Name = "philHealthId";
            this.philHealthId.Size = new System.Drawing.Size(128, 20);
            this.philHealthId.TabIndex = 15;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(356, 82);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(128, 20);
            this.address.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(263, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Pag-ibig ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(263, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "PhilHealth ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(263, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Address";
            // 
            // birthdayTimePicker
            // 
            this.birthdayTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.birthdayTimePicker.Location = new System.Drawing.Point(114, 197);
            this.birthdayTimePicker.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.birthdayTimePicker.Name = "birthdayTimePicker";
            this.birthdayTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.birthdayTimePicker.RightToLeftLayout = true;
            this.birthdayTimePicker.Size = new System.Drawing.Size(128, 20);
            this.birthdayTimePicker.TabIndex = 7;
            this.birthdayTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // civilStatusComboBox
            // 
            this.civilStatusComboBox.FormattingEnabled = true;
            this.civilStatusComboBox.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Separated"});
            this.civilStatusComboBox.Location = new System.Drawing.Point(114, 267);
            this.civilStatusComboBox.Name = "civilStatusComboBox";
            this.civilStatusComboBox.Size = new System.Drawing.Size(128, 21);
            this.civilStatusComboBox.TabIndex = 10;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(114, 105);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(128, 20);
            this.confirmPassword.TabIndex = 3;
            this.confirmPassword.UseSystemPasswordChar = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(114, 82);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(128, 20);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(0, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Confirm password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(21, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Password";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(114, 60);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(128, 20);
            this.username.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(21, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Username";
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(114, 243);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(128, 20);
            this.position.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(21, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Civil Status";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(114, 175);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(128, 20);
            this.lastname.TabIndex = 6;
            // 
            // middlename
            // 
            this.middlename.Location = new System.Drawing.Point(114, 151);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(128, 20);
            this.middlename.TabIndex = 5;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(114, 129);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(128, 20);
            this.firstname.TabIndex = 4;
            // 
            // employeeId
            // 
            this.employeeId.Enabled = false;
            this.employeeId.Location = new System.Drawing.Point(114, 37);
            this.employeeId.Name = "employeeId";
            this.employeeId.Size = new System.Drawing.Size(128, 20);
            this.employeeId.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(21, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(21, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(21, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Middlename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firstname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Location = new System.Drawing.Point(485, -10);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(32, 29);
            this.exitPictureBox.TabIndex = 24;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 324);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox employeeId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker birthdayTimePicker;
        private System.Windows.Forms.ComboBox civilStatusComboBox;
        private System.Windows.Forms.TextBox sssId;
        private System.Windows.Forms.TextBox tin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox contactNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pagIbigId;
        private System.Windows.Forms.TextBox philHealthId;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button createEmployeeButton;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dependents;
        private System.Windows.Forms.Label dependentsLabel;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
    }
}