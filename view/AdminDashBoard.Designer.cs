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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            this.employeeOptionPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.viewRequest = new System.Windows.Forms.Button();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.endDatePeriod = new System.Windows.Forms.DateTimePicker();
            this.startDatePeriod = new System.Windows.Forms.DateTimePicker();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.searchForUpdateLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.usernameOrEmployeeId = new System.Windows.Forms.TextBox();
            this.updateUserPasswordButton = new System.Windows.Forms.Button();
            this.updateEmployeeInfoButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.createPayrollButton = new System.Windows.Forms.Button();
            this.createMiscButton = new System.Windows.Forms.Button();
            this.addPositionButton = new System.Windows.Forms.Button();
            this.adminTab = new System.Windows.Forms.TabControl();
            this.userListTab = new System.Windows.Forms.TabPage();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.pendingRequestTab = new System.Windows.Forms.TabPage();
            this.pendingRequestListBox = new System.Windows.Forms.ListBox();
            this.approvedRequestTab = new System.Windows.Forms.TabPage();
            this.approvedRequestListBox = new System.Windows.Forms.ListBox();
            this.payrollTab = new System.Windows.Forms.TabPage();
            this.payrollListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewPayrollSheetDataGridButton = new System.Windows.Forms.Button();
            this.thirteenMonthPayCheckBox = new System.Windows.Forms.CheckBox();
            this.resetLeaveCreditsButton = new System.Windows.Forms.Button();
            this.viewPayslipButton = new System.Windows.Forms.Button();
            this.spinnerPictureBox = new System.Windows.Forms.PictureBox();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.employeeOptionPanel.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.adminTab.SuspendLayout();
            this.userListTab.SuspendLayout();
            this.pendingRequestTab.SuspendLayout();
            this.approvedRequestTab.SuspendLayout();
            this.payrollTab.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeOptionPanel
            // 
            this.employeeOptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeOptionPanel.BackColor = System.Drawing.Color.Transparent;
            this.employeeOptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeOptionPanel.Controls.Add(this.label1);
            this.employeeOptionPanel.Controls.Add(this.thirteenMonthPayCheckBox);
            this.employeeOptionPanel.Controls.Add(this.selectAllCheckBox);
            this.employeeOptionPanel.Controls.Add(this.resetLeaveCreditsButton);
            this.employeeOptionPanel.Controls.Add(this.viewRequest);
            this.employeeOptionPanel.Controls.Add(this.endDateLabel);
            this.employeeOptionPanel.Controls.Add(this.startDateLabel);
            this.employeeOptionPanel.Controls.Add(this.updateLabel);
            this.employeeOptionPanel.Controls.Add(this.endDatePeriod);
            this.employeeOptionPanel.Controls.Add(this.startDatePeriod);
            this.employeeOptionPanel.Controls.Add(this.updatePanel);
            this.employeeOptionPanel.Controls.Add(this.addEmployeeButton);
            this.employeeOptionPanel.Controls.Add(this.createPayrollButton);
            this.employeeOptionPanel.Controls.Add(this.createMiscButton);
            this.employeeOptionPanel.Location = new System.Drawing.Point(24, 50);
            this.employeeOptionPanel.Name = "employeeOptionPanel";
            this.employeeOptionPanel.Size = new System.Drawing.Size(315, 373);
            this.employeeOptionPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(177, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Applicable for payroll\r\nand leave credits";
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllCheckBox.Location = new System.Drawing.Point(151, 72);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(76, 21);
            this.selectAllCheckBox.TabIndex = 12;
            this.selectAllCheckBox.Text = "All Users";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // viewRequest
            // 
            this.viewRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.viewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewRequest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRequest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewRequest.Location = new System.Drawing.Point(6, 156);
            this.viewRequest.Name = "viewRequest";
            this.viewRequest.Size = new System.Drawing.Size(139, 36);
            this.viewRequest.TabIndex = 11;
            this.viewRequest.Text = "View Request";
            this.viewRequest.UseVisualStyleBackColor = false;
            this.viewRequest.Click += new System.EventHandler(this.viewRequest_Click);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.endDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endDateLabel.Location = new System.Drawing.Point(2, 43);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(72, 17);
            this.endDateLabel.TabIndex = 10;
            this.endDateLabel.Text = "End Date";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.startDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startDateLabel.Location = new System.Drawing.Point(3, 14);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(79, 17);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "Start Date";
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.updateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateLabel.Location = new System.Drawing.Point(38, 198);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(94, 17);
            this.updateLabel.TabIndex = 6;
            this.updateLabel.Text = "Update Area";
            // 
            // endDatePeriod
            // 
            this.endDatePeriod.Font = new System.Drawing.Font("Century", 12F);
            this.endDatePeriod.Location = new System.Drawing.Point(90, 43);
            this.endDatePeriod.Name = "endDatePeriod";
            this.endDatePeriod.Size = new System.Drawing.Size(210, 27);
            this.endDatePeriod.TabIndex = 8;
            // 
            // startDatePeriod
            // 
            this.startDatePeriod.Font = new System.Drawing.Font("Century", 12F);
            this.startDatePeriod.Location = new System.Drawing.Point(87, 7);
            this.startDatePeriod.Name = "startDatePeriod";
            this.startDatePeriod.Size = new System.Drawing.Size(213, 27);
            this.startDatePeriod.TabIndex = 7;
            // 
            // updatePanel
            // 
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatePanel.Controls.Add(this.searchForUpdateLabel);
            this.updatePanel.Controls.Add(this.searchButton);
            this.updatePanel.Controls.Add(this.usernameOrEmployeeId);
            this.updatePanel.Controls.Add(this.updateUserPasswordButton);
            this.updatePanel.Controls.Add(this.updateEmployeeInfoButton);
            this.updatePanel.Location = new System.Drawing.Point(6, 209);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(294, 157);
            this.updatePanel.TabIndex = 5;
            // 
            // searchForUpdateLabel
            // 
            this.searchForUpdateLabel.AutoSize = true;
            this.searchForUpdateLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.searchForUpdateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchForUpdateLabel.Location = new System.Drawing.Point(15, 7);
            this.searchForUpdateLabel.Name = "searchForUpdateLabel";
            this.searchForUpdateLabel.Size = new System.Drawing.Size(213, 17);
            this.searchForUpdateLabel.TabIndex = 5;
            this.searchForUpdateLabel.Text = "Username/Employee number";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(164, 113);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(114, 34);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // usernameOrEmployeeId
            // 
            this.usernameOrEmployeeId.Font = new System.Drawing.Font("Century", 12F);
            this.usernameOrEmployeeId.Location = new System.Drawing.Point(18, 27);
            this.usernameOrEmployeeId.Name = "usernameOrEmployeeId";
            this.usernameOrEmployeeId.Size = new System.Drawing.Size(260, 27);
            this.usernameOrEmployeeId.TabIndex = 4;
            // 
            // updateUserPasswordButton
            // 
            this.updateUserPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.updateUserPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateUserPasswordButton.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.updateUserPasswordButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateUserPasswordButton.Location = new System.Drawing.Point(18, 113);
            this.updateUserPasswordButton.Name = "updateUserPasswordButton";
            this.updateUserPasswordButton.Size = new System.Drawing.Size(140, 35);
            this.updateUserPasswordButton.TabIndex = 1;
            this.updateUserPasswordButton.Text = "User password";
            this.updateUserPasswordButton.UseVisualStyleBackColor = false;
            this.updateUserPasswordButton.Click += new System.EventHandler(this.updateUserPasswordButton_Click);
            // 
            // updateEmployeeInfoButton
            // 
            this.updateEmployeeInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.updateEmployeeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateEmployeeInfoButton.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.updateEmployeeInfoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateEmployeeInfoButton.Location = new System.Drawing.Point(18, 70);
            this.updateEmployeeInfoButton.Name = "updateEmployeeInfoButton";
            this.updateEmployeeInfoButton.Size = new System.Drawing.Size(260, 37);
            this.updateEmployeeInfoButton.TabIndex = 3;
            this.updateEmployeeInfoButton.Text = "Employee Information";
            this.updateEmployeeInfoButton.UseVisualStyleBackColor = false;
            this.updateEmployeeInfoButton.Click += new System.EventHandler(this.updateEmployeeInfoButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeButton.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.addEmployeeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployeeButton.Location = new System.Drawing.Point(151, 156);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(158, 36);
            this.addEmployeeButton.TabIndex = 2;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // createPayrollButton
            // 
            this.createPayrollButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.createPayrollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPayrollButton.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.createPayrollButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createPayrollButton.Location = new System.Drawing.Point(6, 116);
            this.createPayrollButton.Name = "createPayrollButton";
            this.createPayrollButton.Size = new System.Drawing.Size(139, 34);
            this.createPayrollButton.TabIndex = 0;
            this.createPayrollButton.Text = "Create Payroll";
            this.createPayrollButton.UseVisualStyleBackColor = false;
            this.createPayrollButton.Click += new System.EventHandler(this.createPayrollButton_Click);
            // 
            // createMiscButton
            // 
            this.createMiscButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.createMiscButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMiscButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMiscButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createMiscButton.Location = new System.Drawing.Point(151, 156);
            this.createMiscButton.Name = "createMiscButton";
            this.createMiscButton.Size = new System.Drawing.Size(157, 36);
            this.createMiscButton.TabIndex = 8;
            this.createMiscButton.Text = "Add Benefits/ Deductions";
            this.createMiscButton.UseVisualStyleBackColor = false;
            this.createMiscButton.Click += new System.EventHandler(this.createMiscButton_Click);
            // 
            // addPositionButton
            // 
            this.addPositionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addPositionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPositionButton.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.addPositionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPositionButton.Location = new System.Drawing.Point(480, 48);
            this.addPositionButton.Name = "addPositionButton";
            this.addPositionButton.Size = new System.Drawing.Size(139, 36);
            this.addPositionButton.TabIndex = 7;
            this.addPositionButton.Text = "Add Position";
            this.addPositionButton.UseVisualStyleBackColor = false;
            this.addPositionButton.Click += new System.EventHandler(this.addPositionButton_Click);
            // 
            // adminTab
            // 
            this.adminTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.adminTab.Controls.Add(this.userListTab);
            this.adminTab.Controls.Add(this.pendingRequestTab);
            this.adminTab.Controls.Add(this.approvedRequestTab);
            this.adminTab.Controls.Add(this.payrollTab);
            this.adminTab.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTab.Location = new System.Drawing.Point(360, 94);
            this.adminTab.Name = "adminTab";
            this.adminTab.SelectedIndex = 0;
            this.adminTab.Size = new System.Drawing.Size(446, 329);
            this.adminTab.TabIndex = 2;
            // 
            // userListTab
            // 
            this.userListTab.Controls.Add(this.usersListBox);
            this.userListTab.Location = new System.Drawing.Point(4, 29);
            this.userListTab.Name = "userListTab";
            this.userListTab.Padding = new System.Windows.Forms.Padding(3);
            this.userListTab.Size = new System.Drawing.Size(438, 296);
            this.userListTab.TabIndex = 0;
            this.userListTab.Text = "Users";
            this.userListTab.UseVisualStyleBackColor = true;
            // 
            // usersListBox
            // 
            this.usersListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 17;
            this.usersListBox.Location = new System.Drawing.Point(0, 2);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(438, 327);
            this.usersListBox.TabIndex = 0;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersListBox_SelectedIndexChanged);
            // 
            // pendingRequestTab
            // 
            this.pendingRequestTab.Controls.Add(this.pendingRequestListBox);
            this.pendingRequestTab.Location = new System.Drawing.Point(4, 29);
            this.pendingRequestTab.Name = "pendingRequestTab";
            this.pendingRequestTab.Padding = new System.Windows.Forms.Padding(3);
            this.pendingRequestTab.Size = new System.Drawing.Size(438, 296);
            this.pendingRequestTab.TabIndex = 3;
            this.pendingRequestTab.Text = "Pending Requests";
            this.pendingRequestTab.UseVisualStyleBackColor = true;
            // 
            // pendingRequestListBox
            // 
            this.pendingRequestListBox.FormattingEnabled = true;
            this.pendingRequestListBox.ItemHeight = 17;
            this.pendingRequestListBox.Location = new System.Drawing.Point(0, 2);
            this.pendingRequestListBox.Name = "pendingRequestListBox";
            this.pendingRequestListBox.Size = new System.Drawing.Size(438, 327);
            this.pendingRequestListBox.TabIndex = 1;
            // 
            // approvedRequestTab
            // 
            this.approvedRequestTab.Controls.Add(this.approvedRequestListBox);
            this.approvedRequestTab.Location = new System.Drawing.Point(4, 29);
            this.approvedRequestTab.Name = "approvedRequestTab";
            this.approvedRequestTab.Padding = new System.Windows.Forms.Padding(3);
            this.approvedRequestTab.Size = new System.Drawing.Size(438, 296);
            this.approvedRequestTab.TabIndex = 4;
            this.approvedRequestTab.Text = "Approved Request";
            this.approvedRequestTab.UseVisualStyleBackColor = true;
            // 
            // approvedRequestListBox
            // 
            this.approvedRequestListBox.FormattingEnabled = true;
            this.approvedRequestListBox.ItemHeight = 17;
            this.approvedRequestListBox.Location = new System.Drawing.Point(0, 2);
            this.approvedRequestListBox.Name = "approvedRequestListBox";
            this.approvedRequestListBox.Size = new System.Drawing.Size(438, 327);
            this.approvedRequestListBox.TabIndex = 2;
            // 
            // payrollTab
            // 
            this.payrollTab.Controls.Add(this.payrollListBox);
            this.payrollTab.Location = new System.Drawing.Point(4, 29);
            this.payrollTab.Name = "payrollTab";
            this.payrollTab.Padding = new System.Windows.Forms.Padding(3);
            this.payrollTab.Size = new System.Drawing.Size(438, 296);
            this.payrollTab.TabIndex = 5;
            this.payrollTab.Text = "Payroll Sheet";
            this.payrollTab.UseVisualStyleBackColor = true;
            // 
            // payrollListBox
            // 
            this.payrollListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.payrollListBox.FormattingEnabled = true;
            this.payrollListBox.ItemHeight = 17;
            this.payrollListBox.Location = new System.Drawing.Point(0, 0);
            this.payrollListBox.Name = "payrollListBox";
            this.payrollListBox.Size = new System.Drawing.Size(438, 293);
            this.payrollListBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.viewPayrollSheetDataGridButton);
            this.panel2.Controls.Add(this.viewPayslipButton);
            this.panel2.Controls.Add(this.spinnerPictureBox);
            this.panel2.Controls.Add(this.errorMessageLabel);
            this.panel2.Controls.Add(this.exitPictureBox);
            this.panel2.Controls.Add(this.employeeOptionPanel);
            this.panel2.Controls.Add(this.adminTab);
            this.panel2.Controls.Add(this.addPositionButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 478);
            this.panel2.TabIndex = 3;
            // 
            // viewPayrollSheetDataGridButton
            // 
            this.viewPayrollSheetDataGridButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.viewPayrollSheetDataGridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPayrollSheetDataGridButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPayrollSheetDataGridButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewPayrollSheetDataGridButton.Location = new System.Drawing.Point(648, 51);
            this.viewPayrollSheetDataGridButton.Name = "viewPayrollSheetDataGridButton";
            this.viewPayrollSheetDataGridButton.Size = new System.Drawing.Size(158, 34);
            this.viewPayrollSheetDataGridButton.TabIndex = 18;
            this.viewPayrollSheetDataGridButton.Text = "View Payroll Sheet";
            this.viewPayrollSheetDataGridButton.UseVisualStyleBackColor = false;
            this.viewPayrollSheetDataGridButton.Click += new System.EventHandler(this.viewPayrollSheetDataGridButton_Click);
            // 
            // thirteenMonthPayCheckBox
            // 
            this.thirteenMonthPayCheckBox.AutoSize = true;
            this.thirteenMonthPayCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.thirteenMonthPayCheckBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirteenMonthPayCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thirteenMonthPayCheckBox.Location = new System.Drawing.Point(26, 74);
            this.thirteenMonthPayCheckBox.Name = "thirteenMonthPayCheckBox";
            this.thirteenMonthPayCheckBox.Size = new System.Drawing.Size(87, 36);
            this.thirteenMonthPayCheckBox.TabIndex = 17;
            this.thirteenMonthPayCheckBox.Text = "Add 13th \r\nMonth Pay";
            this.thirteenMonthPayCheckBox.UseVisualStyleBackColor = false;
            // 
            // resetLeaveCreditsButton
            // 
            this.resetLeaveCreditsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.resetLeaveCreditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetLeaveCreditsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetLeaveCreditsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetLeaveCreditsButton.Location = new System.Drawing.Point(152, 118);
            this.resetLeaveCreditsButton.Name = "resetLeaveCreditsButton";
            this.resetLeaveCreditsButton.Size = new System.Drawing.Size(151, 34);
            this.resetLeaveCreditsButton.TabIndex = 15;
            this.resetLeaveCreditsButton.Text = "Reset Leave Credits";
            this.resetLeaveCreditsButton.UseVisualStyleBackColor = false;
            this.resetLeaveCreditsButton.Click += new System.EventHandler(this.resetLeaveCreditsButton_Click);
            // 
            // viewPayslipButton
            // 
            this.viewPayslipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.viewPayslipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPayslipButton.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.viewPayslipButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewPayslipButton.Location = new System.Drawing.Point(648, 51);
            this.viewPayslipButton.Name = "viewPayslipButton";
            this.viewPayslipButton.Size = new System.Drawing.Size(158, 34);
            this.viewPayslipButton.TabIndex = 14;
            this.viewPayslipButton.Text = "View Payslip";
            this.viewPayslipButton.UseVisualStyleBackColor = false;
            this.viewPayslipButton.Click += new System.EventHandler(this.viewPayslipButton_Click);
            // 
            // spinnerPictureBox
            // 
            this.spinnerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.spinnerPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spinnerPictureBox.BackgroundImage")));
            this.spinnerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spinnerPictureBox.Location = new System.Drawing.Point(324, 169);
            this.spinnerPictureBox.Name = "spinnerPictureBox";
            this.spinnerPictureBox.Size = new System.Drawing.Size(81, 74);
            this.spinnerPictureBox.TabIndex = 13;
            this.spinnerPictureBox.TabStop = false;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorMessageLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.errorMessageLabel.Location = new System.Drawing.Point(97, 442);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(41, 20);
            this.errorMessageLabel.TabIndex = 12;
            this.errorMessageLabel.Text = "Error";
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.exitPictureBox.Location = new System.Drawing.Point(787, 4);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(42, 37);
            this.exitPictureBox.TabIndex = 3;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 478);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashBoard_FormClosed);
            this.employeeOptionPanel.ResumeLayout(false);
            this.employeeOptionPanel.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.adminTab.ResumeLayout(false);
            this.userListTab.ResumeLayout(false);
            this.pendingRequestTab.ResumeLayout(false);
            this.approvedRequestTab.ResumeLayout(false);
            this.payrollTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel employeeOptionPanel;
//<<<<<<< HEAD
        private System.Windows.Forms.Button createPayrollButton;
        //=======
//>>>>>>> PayrollSystem/master
        private System.Windows.Forms.Button updateUserPasswordButton;
        private System.Windows.Forms.Button updateEmployeeInfoButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.TextBox usernameOrEmployeeId;
        private System.Windows.Forms.Label searchForUpdateLabel;
//<<<<<<< HEAD
        //private System.Windows.Forms.ListBox usersListBox;
        //private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.DateTimePicker startDatePeriod;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker endDatePeriod;
//=======
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Button addPositionButton;
        private System.Windows.Forms.Button createMiscButton;
        private System.Windows.Forms.TabControl adminTab;
        private System.Windows.Forms.TabPage userListTab;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Button viewRequest;
        private System.Windows.Forms.TabPage pendingRequestTab;
        private System.Windows.Forms.ListBox pendingRequestListBox;
        private System.Windows.Forms.CheckBox selectAllCheckBox;
        private System.Windows.Forms.TabPage approvedRequestTab;
        private System.Windows.Forms.ListBox approvedRequestListBox;
        private System.Windows.Forms.PictureBox spinnerPictureBox;
        private System.Windows.Forms.Button viewPayslipButton;
        private System.Windows.Forms.TabPage payrollTab;
        private System.Windows.Forms.ListBox payrollListBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetLeaveCreditsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox thirteenMonthPayCheckBox;
        private System.Windows.Forms.Button viewPayrollSheetDataGridButton;
//>>>>>>> PayrollSystem/master
    }
}