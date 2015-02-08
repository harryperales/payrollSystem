namespace PayrollSystem.view
{
    partial class AdminDashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateLabel = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.searchForUpdateLabel = new System.Windows.Forms.Label();
            this.usernameOrEmployeeId = new System.Windows.Forms.TextBox();
            this.updateUserPasswordButton = new System.Windows.Forms.Button();
            this.updateEmployeeInfoButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.createPayrollButton = new System.Windows.Forms.Button();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.startDatePeriod = new System.Windows.Forms.DateTimePicker();
            this.endDatePeriod = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.endDateLabel);
            this.panel1.Controls.Add(this.startDateLabel);
            this.panel1.Controls.Add(this.endDatePeriod);
            this.panel1.Controls.Add(this.startDatePeriod);
            this.panel1.Controls.Add(this.updateLabel);
            this.panel1.Controls.Add(this.updatePanel);
            this.panel1.Controls.Add(this.addEmployeeButton);
            this.panel1.Controls.Add(this.createPayrollButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 358);
            this.panel1.TabIndex = 0;
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Location = new System.Drawing.Point(31, 186);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(67, 13);
            this.updateLabel.TabIndex = 6;
            this.updateLabel.Text = "Update Area";
            // 
            // updatePanel
            // 
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatePanel.Controls.Add(this.searchForUpdateLabel);
            this.updatePanel.Controls.Add(this.usernameOrEmployeeId);
            this.updatePanel.Controls.Add(this.updateUserPasswordButton);
            this.updatePanel.Controls.Add(this.updateEmployeeInfoButton);
            this.updatePanel.Location = new System.Drawing.Point(9, 193);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(190, 155);
            this.updatePanel.TabIndex = 5;
            // 
            // searchForUpdateLabel
            // 
            this.searchForUpdateLabel.AutoSize = true;
            this.searchForUpdateLabel.Location = new System.Drawing.Point(15, 13);
            this.searchForUpdateLabel.Name = "searchForUpdateLabel";
            this.searchForUpdateLabel.Size = new System.Drawing.Size(124, 13);
            this.searchForUpdateLabel.TabIndex = 5;
            this.searchForUpdateLabel.Text = "Username/Employee no.";
            // 
            // usernameOrEmployeeId
            // 
            this.usernameOrEmployeeId.Location = new System.Drawing.Point(18, 32);
            this.usernameOrEmployeeId.Name = "usernameOrEmployeeId";
            this.usernameOrEmployeeId.Size = new System.Drawing.Size(158, 20);
            this.usernameOrEmployeeId.TabIndex = 4;
            // 
            // updateUserPasswordButton
            // 
            this.updateUserPasswordButton.Location = new System.Drawing.Point(18, 119);
            this.updateUserPasswordButton.Name = "updateUserPasswordButton";
            this.updateUserPasswordButton.Size = new System.Drawing.Size(158, 23);
            this.updateUserPasswordButton.TabIndex = 1;
            this.updateUserPasswordButton.Text = "User password";
            this.updateUserPasswordButton.UseVisualStyleBackColor = true;
            this.updateUserPasswordButton.Click += new System.EventHandler(this.updateUserPasswordButton_Click);
            // 
            // updateEmployeeInfoButton
            // 
            this.updateEmployeeInfoButton.Location = new System.Drawing.Point(18, 90);
            this.updateEmployeeInfoButton.Name = "updateEmployeeInfoButton";
            this.updateEmployeeInfoButton.Size = new System.Drawing.Size(158, 23);
            this.updateEmployeeInfoButton.TabIndex = 3;
            this.updateEmployeeInfoButton.Text = "Employee Information";
            this.updateEmployeeInfoButton.UseVisualStyleBackColor = true;
            this.updateEmployeeInfoButton.Click += new System.EventHandler(this.updateEmployeeInfoButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(28, 137);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(158, 23);
            this.addEmployeeButton.TabIndex = 2;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // createPayrollButton
            // 
            this.createPayrollButton.Location = new System.Drawing.Point(5, 58);
            this.createPayrollButton.Name = "createPayrollButton";
            this.createPayrollButton.Size = new System.Drawing.Size(200, 23);
            this.createPayrollButton.TabIndex = 0;
            this.createPayrollButton.Text = "Create Payroll";
            this.createPayrollButton.UseVisualStyleBackColor = true;
            this.createPayrollButton.Click += new System.EventHandler(this.createPayrollButton_Click);
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(241, 12);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(141, 355);
            this.usersListBox.TabIndex = 1;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersListBox_SelectedIndexChanged);
            // 
            // startDatePeriod
            // 
            this.startDatePeriod.Location = new System.Drawing.Point(63, 6);
            this.startDatePeriod.Name = "startDatePeriod";
            this.startDatePeriod.Size = new System.Drawing.Size(142, 20);
            this.startDatePeriod.TabIndex = 7;
            // 
            // endDatePeriod
            // 
            this.endDatePeriod.Location = new System.Drawing.Point(63, 32);
            this.endDatePeriod.Name = "endDatePeriod";
            this.endDatePeriod.Size = new System.Drawing.Size(142, 20);
            this.endDatePeriod.TabIndex = 8;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(2, 6);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(2, 33);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 10;
            this.endDateLabel.Text = "End Date";
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 382);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashBoard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createPayrollButton;
        private System.Windows.Forms.Button updateUserPasswordButton;
        private System.Windows.Forms.Button updateEmployeeInfoButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.TextBox usernameOrEmployeeId;
        private System.Windows.Forms.Label searchForUpdateLabel;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.DateTimePicker startDatePeriod;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker endDatePeriod;
    }
}