namespace PayrollSystem.view
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.homeTabs = new System.Windows.Forms.TabControl();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.idNumber = new System.Windows.Forms.Label();
            this.payrollsLabel = new System.Windows.Forms.Label();
            this.viewPayrollButton = new System.Windows.Forms.Button();
            this.userPayrollListBox = new System.Windows.Forms.ListBox();
            this.username = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.myClockTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.validClockOut = new System.Windows.Forms.Label();
            this.clockOutNotificationLabel = new System.Windows.Forms.Label();
            this.clockedOut = new System.Windows.Forms.Label();
            this.clockedIn = new System.Windows.Forms.Label();
            this.clockedOutLabel = new System.Windows.Forms.Label();
            this.clockInLabel = new System.Windows.Forms.Label();
            this.dateToday = new System.Windows.Forms.Label();
            this.attendanceListBox = new System.Windows.Forms.ListBox();
            this.requestTab = new System.Windows.Forms.TabPage();
            this.requestPanel = new System.Windows.Forms.Panel();
            this.cashAdvanceButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.workingHour = new System.Windows.Forms.TextBox();
            this.overtimeReqeustDescriptionLabel = new System.Windows.Forms.Label();
            this.overtimeRequestDescription = new System.Windows.Forms.TextBox();
            this.leaveDescription = new System.Windows.Forms.TextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.overtimeRequestButton = new System.Windows.Forms.Button();
            this.overtimeRequestLabel = new System.Windows.Forms.Label();
            this.workingHourLabel = new System.Windows.Forms.Label();
            this.dateOfRequest = new System.Windows.Forms.DateTimePicker();
            this.otherDateOfLeaveLabel = new System.Windows.Forms.Label();
            this.leaveRequestButton = new System.Windows.Forms.Button();
            this.leaveRequestLabel = new System.Windows.Forms.Label();
            this.typeOfLeaveComboBox = new System.Windows.Forms.ComboBox();
            this.typeOfLeaveLabel = new System.Windows.Forms.Label();
            this.dateOfLeave = new System.Windows.Forms.DateTimePicker();
            this.dateOfLeaveLabel = new System.Windows.Forms.Label();
            this.dateFiled = new System.Windows.Forms.Label();
            this.dateFiledLabel = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.employeeNumber = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.pendingRequestTab = new System.Windows.Forms.TabPage();
            this.pendingRequestListBox = new System.Windows.Forms.ListBox();
            this.approvedRequetTab = new System.Windows.Forms.TabPage();
            this.approvedRequestListBox = new System.Windows.Forms.ListBox();
            this.leaveCreditsTab = new System.Windows.Forms.TabPage();
            this.birthdayLeave = new System.Windows.Forms.Label();
            this.bereavementLeave = new System.Windows.Forms.Label();
            this.paternityLeave = new System.Windows.Forms.Label();
            this.emergencyLeave = new System.Windows.Forms.Label();
            this.sickLeave = new System.Windows.Forms.Label();
            this.vacationLeave = new System.Windows.Forms.Label();
            this.birthdayLeaveLabel = new System.Windows.Forms.Label();
            this.bereavementLeaveLabel = new System.Windows.Forms.Label();
            this.paternityLeaveLabel = new System.Windows.Forms.Label();
            this.emergencyLeaveLabel = new System.Windows.Forms.Label();
            this.sickLeaveLabel = new System.Windows.Forms.Label();
            this.vacationLeaveLabel = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.employeeFullName = new System.Windows.Forms.Label();
            this.homeTabs.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.myClockTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.requestTab.SuspendLayout();
            this.requestPanel.SuspendLayout();
            this.pendingRequestTab.SuspendLayout();
            this.approvedRequetTab.SuspendLayout();
            this.leaveCreditsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // homeTabs
            // 
            this.homeTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.homeTabs.Controls.Add(this.dashboardTab);
            this.homeTabs.Controls.Add(this.myClockTab);
            this.homeTabs.Controls.Add(this.requestTab);
            this.homeTabs.Controls.Add(this.pendingRequestTab);
            this.homeTabs.Controls.Add(this.approvedRequetTab);
            this.homeTabs.Controls.Add(this.leaveCreditsTab);
            this.homeTabs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.homeTabs.Location = new System.Drawing.Point(0, 41);
            this.homeTabs.Name = "homeTabs";
            this.homeTabs.SelectedIndex = 0;
            this.homeTabs.Size = new System.Drawing.Size(642, 371);
            this.homeTabs.TabIndex = 0;
            // 
            // dashboardTab
            // 
            this.dashboardTab.BackColor = System.Drawing.Color.DarkGreen;
            this.dashboardTab.Controls.Add(this.employeeFullName);
            this.dashboardTab.Controls.Add(this.idNumber);
            this.dashboardTab.Controls.Add(this.payrollsLabel);
            this.dashboardTab.Controls.Add(this.viewPayrollButton);
            this.dashboardTab.Controls.Add(this.userPayrollListBox);
            this.dashboardTab.Controls.Add(this.username);
            this.dashboardTab.Controls.Add(this.imagePanel);
            this.dashboardTab.Location = new System.Drawing.Point(4, 29);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(634, 338);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
            // 
            // idNumber
            // 
            this.idNumber.AutoSize = true;
            this.idNumber.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.idNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idNumber.Location = new System.Drawing.Point(177, 11);
            this.idNumber.Name = "idNumber";
            this.idNumber.Size = new System.Drawing.Size(128, 17);
            this.idNumber.TabIndex = 7;
            this.idNumber.Text = "123456789101";
            // 
            // payrollsLabel
            // 
            this.payrollsLabel.AutoSize = true;
            this.payrollsLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.payrollsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.payrollsLabel.Location = new System.Drawing.Point(177, 88);
            this.payrollsLabel.Name = "payrollsLabel";
            this.payrollsLabel.Size = new System.Drawing.Size(65, 17);
            this.payrollsLabel.TabIndex = 6;
            this.payrollsLabel.Text = "Payrolls";
            // 
            // viewPayrollButton
            // 
            this.viewPayrollButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.viewPayrollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPayrollButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.viewPayrollButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewPayrollButton.Location = new System.Drawing.Point(411, 78);
            this.viewPayrollButton.Name = "viewPayrollButton";
            this.viewPayrollButton.Size = new System.Drawing.Size(179, 32);
            this.viewPayrollButton.TabIndex = 5;
            this.viewPayrollButton.Text = "View Payroll";
            this.viewPayrollButton.UseVisualStyleBackColor = false;
            this.viewPayrollButton.Click += new System.EventHandler(this.viewPayrollButton_Click);
            // 
            // userPayrollListBox
            // 
            this.userPayrollListBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPayrollListBox.FormattingEnabled = true;
            this.userPayrollListBox.ItemHeight = 17;
            this.userPayrollListBox.Location = new System.Drawing.Point(181, 116);
            this.userPayrollListBox.Name = "userPayrollListBox";
            this.userPayrollListBox.Size = new System.Drawing.Size(409, 191);
            this.userPayrollListBox.TabIndex = 4;
            this.userPayrollListBox.SelectedIndexChanged += new System.EventHandler(this.userPayrollListBox_SelectedIndexChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Location = new System.Drawing.Point(178, 28);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(79, 17);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            // 
            // imagePanel
            // 
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Location = new System.Drawing.Point(19, 18);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(134, 119);
            this.imagePanel.TabIndex = 0;
            // 
            // myClockTab
            // 
            this.myClockTab.BackColor = System.Drawing.Color.DarkGreen;
            this.myClockTab.Controls.Add(this.panel1);
            this.myClockTab.Controls.Add(this.attendanceListBox);
            this.myClockTab.Location = new System.Drawing.Point(4, 29);
            this.myClockTab.Name = "myClockTab";
            this.myClockTab.Padding = new System.Windows.Forms.Padding(3);
            this.myClockTab.Size = new System.Drawing.Size(634, 338);
            this.myClockTab.TabIndex = 1;
            this.myClockTab.Text = "My Clock";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.validClockOut);
            this.panel1.Controls.Add(this.clockOutNotificationLabel);
            this.panel1.Controls.Add(this.clockedOut);
            this.panel1.Controls.Add(this.clockedIn);
            this.panel1.Controls.Add(this.clockedOutLabel);
            this.panel1.Controls.Add(this.clockInLabel);
            this.panel1.Controls.Add(this.dateToday);
            this.panel1.Location = new System.Drawing.Point(19, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 214);
            this.panel1.TabIndex = 6;
            // 
            // validClockOut
            // 
            this.validClockOut.AutoSize = true;
            this.validClockOut.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validClockOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.validClockOut.Location = new System.Drawing.Point(31, 172);
            this.validClockOut.Name = "validClockOut";
            this.validClockOut.Size = new System.Drawing.Size(63, 15);
            this.validClockOut.TabIndex = 16;
            this.validClockOut.Text = "22:00:00";
            // 
            // clockOutNotificationLabel
            // 
            this.clockOutNotificationLabel.AutoSize = true;
            this.clockOutNotificationLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockOutNotificationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clockOutNotificationLabel.Location = new System.Drawing.Point(13, 157);
            this.clockOutNotificationLabel.Name = "clockOutNotificationLabel";
            this.clockOutNotificationLabel.Size = new System.Drawing.Size(143, 15);
            this.clockOutNotificationLabel.TabIndex = 15;
            this.clockOutNotificationLabel.Text = "You can clock out after:";
            // 
            // clockedOut
            // 
            this.clockedOut.AutoSize = true;
            this.clockedOut.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockedOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clockedOut.Location = new System.Drawing.Point(31, 119);
            this.clockedOut.Name = "clockedOut";
            this.clockedOut.Size = new System.Drawing.Size(63, 15);
            this.clockedOut.TabIndex = 14;
            this.clockedOut.Text = "22:00:00";
            // 
            // clockedIn
            // 
            this.clockedIn.AutoSize = true;
            this.clockedIn.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockedIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clockedIn.Location = new System.Drawing.Point(31, 54);
            this.clockedIn.Name = "clockedIn";
            this.clockedIn.Size = new System.Drawing.Size(63, 15);
            this.clockedIn.TabIndex = 13;
            this.clockedIn.Text = "12:00:00";
            // 
            // clockedOutLabel
            // 
            this.clockedOutLabel.AutoSize = true;
            this.clockedOutLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockedOutLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clockedOutLabel.Location = new System.Drawing.Point(13, 104);
            this.clockedOutLabel.Name = "clockedOutLabel";
            this.clockedOutLabel.Size = new System.Drawing.Size(94, 15);
            this.clockedOutLabel.TabIndex = 12;
            this.clockedOutLabel.Text = "Clocked Out at:";
            // 
            // clockInLabel
            // 
            this.clockInLabel.AutoSize = true;
            this.clockInLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clockInLabel.Location = new System.Drawing.Point(13, 39);
            this.clockInLabel.Name = "clockInLabel";
            this.clockInLabel.Size = new System.Drawing.Size(86, 15);
            this.clockInLabel.TabIndex = 11;
            this.clockInLabel.Text = "Clocked in at:";
            // 
            // dateToday
            // 
            this.dateToday.AutoSize = true;
            this.dateToday.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.dateToday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateToday.Location = new System.Drawing.Point(13, 13);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(155, 17);
            this.dateToday.TabIndex = 10;
            this.dateToday.Text = "Jan 01, 2015 Friday";
            // 
            // attendanceListBox
            // 
            this.attendanceListBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceListBox.FormattingEnabled = true;
            this.attendanceListBox.ItemHeight = 17;
            this.attendanceListBox.Location = new System.Drawing.Point(249, 37);
            this.attendanceListBox.Name = "attendanceListBox";
            this.attendanceListBox.Size = new System.Drawing.Size(350, 259);
            this.attendanceListBox.TabIndex = 5;
            // 
            // requestTab
            // 
            this.requestTab.BackColor = System.Drawing.Color.DarkGreen;
            this.requestTab.Controls.Add(this.requestPanel);
            this.requestTab.Location = new System.Drawing.Point(4, 29);
            this.requestTab.Name = "requestTab";
            this.requestTab.Padding = new System.Windows.Forms.Padding(3);
            this.requestTab.Size = new System.Drawing.Size(634, 338);
            this.requestTab.TabIndex = 2;
            this.requestTab.Text = "Request";
            // 
            // requestPanel
            // 
            this.requestPanel.BackColor = System.Drawing.Color.Transparent;
            this.requestPanel.Controls.Add(this.cashAdvanceButton);
            this.requestPanel.Controls.Add(this.errorMessageLabel);
            this.requestPanel.Controls.Add(this.workingHour);
            this.requestPanel.Controls.Add(this.overtimeReqeustDescriptionLabel);
            this.requestPanel.Controls.Add(this.overtimeRequestDescription);
            this.requestPanel.Controls.Add(this.leaveDescription);
            this.requestPanel.Controls.Add(this.reasonLabel);
            this.requestPanel.Controls.Add(this.overtimeRequestButton);
            this.requestPanel.Controls.Add(this.overtimeRequestLabel);
            this.requestPanel.Controls.Add(this.workingHourLabel);
            this.requestPanel.Controls.Add(this.dateOfRequest);
            this.requestPanel.Controls.Add(this.otherDateOfLeaveLabel);
            this.requestPanel.Controls.Add(this.leaveRequestButton);
            this.requestPanel.Controls.Add(this.leaveRequestLabel);
            this.requestPanel.Controls.Add(this.typeOfLeaveComboBox);
            this.requestPanel.Controls.Add(this.typeOfLeaveLabel);
            this.requestPanel.Controls.Add(this.dateOfLeave);
            this.requestPanel.Controls.Add(this.dateOfLeaveLabel);
            this.requestPanel.Controls.Add(this.dateFiled);
            this.requestPanel.Controls.Add(this.dateFiledLabel);
            this.requestPanel.Controls.Add(this.employeeName);
            this.requestPanel.Controls.Add(this.employeeNumber);
            this.requestPanel.Controls.Add(this.employeeNameLabel);
            this.requestPanel.Controls.Add(this.employeeNumberLabel);
            this.requestPanel.Location = new System.Drawing.Point(8, 6);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(591, 325);
            this.requestPanel.TabIndex = 0;
            // 
            // cashAdvanceButton
            // 
            this.cashAdvanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cashAdvanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashAdvanceButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashAdvanceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashAdvanceButton.Location = new System.Drawing.Point(401, 18);
            this.cashAdvanceButton.Name = "cashAdvanceButton";
            this.cashAdvanceButton.Size = new System.Drawing.Size(183, 29);
            this.cashAdvanceButton.TabIndex = 45;
            this.cashAdvanceButton.Text = "Cash Advance Request";
            this.cashAdvanceButton.UseVisualStyleBackColor = false;
            this.cashAdvanceButton.Click += new System.EventHandler(this.cashAdvanceButton_Click);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorMessageLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.errorMessageLabel.Location = new System.Drawing.Point(3, 294);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(41, 20);
            this.errorMessageLabel.TabIndex = 44;
            this.errorMessageLabel.Text = "Error";
            // 
            // workingHour
            // 
            this.workingHour.Font = new System.Drawing.Font("Century", 12F);
            this.workingHour.Location = new System.Drawing.Point(401, 101);
            this.workingHour.Name = "workingHour";
            this.workingHour.Size = new System.Drawing.Size(183, 27);
            this.workingHour.TabIndex = 43;
            this.workingHour.Text = "0";
            // 
            // overtimeReqeustDescriptionLabel
            // 
            this.overtimeReqeustDescriptionLabel.AutoSize = true;
            this.overtimeReqeustDescriptionLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overtimeReqeustDescriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.overtimeReqeustDescriptionLabel.Location = new System.Drawing.Point(295, 141);
            this.overtimeReqeustDescriptionLabel.Name = "overtimeReqeustDescriptionLabel";
            this.overtimeReqeustDescriptionLabel.Size = new System.Drawing.Size(233, 15);
            this.overtimeReqeustDescriptionLabel.TabIndex = 42;
            this.overtimeReqeustDescriptionLabel.Text = "Reason or Purpose of Leave or Absence";
            // 
            // overtimeRequestDescription
            // 
            this.overtimeRequestDescription.Font = new System.Drawing.Font("Century", 12F);
            this.overtimeRequestDescription.Location = new System.Drawing.Point(298, 159);
            this.overtimeRequestDescription.Multiline = true;
            this.overtimeRequestDescription.Name = "overtimeRequestDescription";
            this.overtimeRequestDescription.Size = new System.Drawing.Size(286, 81);
            this.overtimeRequestDescription.TabIndex = 41;
            // 
            // leaveDescription
            // 
            this.leaveDescription.Font = new System.Drawing.Font("Century", 12F);
            this.leaveDescription.Location = new System.Drawing.Point(6, 160);
            this.leaveDescription.Multiline = true;
            this.leaveDescription.Name = "leaveDescription";
            this.leaveDescription.Size = new System.Drawing.Size(271, 81);
            this.leaveDescription.TabIndex = 40;
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reasonLabel.Location = new System.Drawing.Point(4, 142);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(233, 15);
            this.reasonLabel.TabIndex = 39;
            this.reasonLabel.Text = "Reason or Purpose of Leave or Absence";
            // 
            // overtimeRequestButton
            // 
            this.overtimeRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.overtimeRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overtimeRequestButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overtimeRequestButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.overtimeRequestButton.Location = new System.Drawing.Point(386, 247);
            this.overtimeRequestButton.Name = "overtimeRequestButton";
            this.overtimeRequestButton.Size = new System.Drawing.Size(198, 34);
            this.overtimeRequestButton.TabIndex = 38;
            this.overtimeRequestButton.Text = "Submit Overtime Request";
            this.overtimeRequestButton.UseVisualStyleBackColor = false;
            this.overtimeRequestButton.Click += new System.EventHandler(this.overtimeRequestButton_Click);
            // 
            // overtimeRequestLabel
            // 
            this.overtimeRequestLabel.AutoSize = true;
            this.overtimeRequestLabel.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overtimeRequestLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.overtimeRequestLabel.Location = new System.Drawing.Point(294, 49);
            this.overtimeRequestLabel.Name = "overtimeRequestLabel";
            this.overtimeRequestLabel.Size = new System.Drawing.Size(176, 21);
            this.overtimeRequestLabel.TabIndex = 37;
            this.overtimeRequestLabel.Text = "OVERTIME REQUEST";
            // 
            // workingHourLabel
            // 
            this.workingHourLabel.AutoSize = true;
            this.workingHourLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingHourLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.workingHourLabel.Location = new System.Drawing.Point(295, 108);
            this.workingHourLabel.Name = "workingHourLabel";
            this.workingHourLabel.Size = new System.Drawing.Size(88, 15);
            this.workingHourLabel.TabIndex = 35;
            this.workingHourLabel.Text = "Working Hour";
            // 
            // dateOfRequest
            // 
            this.dateOfRequest.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfRequest.Location = new System.Drawing.Point(401, 72);
            this.dateOfRequest.Name = "dateOfRequest";
            this.dateOfRequest.Size = new System.Drawing.Size(183, 22);
            this.dateOfRequest.TabIndex = 34;
            // 
            // otherDateOfLeaveLabel
            // 
            this.otherDateOfLeaveLabel.AutoSize = true;
            this.otherDateOfLeaveLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherDateOfLeaveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.otherDateOfLeaveLabel.Location = new System.Drawing.Point(295, 78);
            this.otherDateOfLeaveLabel.Name = "otherDateOfLeaveLabel";
            this.otherDateOfLeaveLabel.Size = new System.Drawing.Size(104, 15);
            this.otherDateOfLeaveLabel.TabIndex = 33;
            this.otherDateOfLeaveLabel.Text = "Date Of Overtime";
            // 
            // leaveRequestButton
            // 
            this.leaveRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.leaveRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaveRequestButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveRequestButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leaveRequestButton.Location = new System.Drawing.Point(105, 247);
            this.leaveRequestButton.Name = "leaveRequestButton";
            this.leaveRequestButton.Size = new System.Drawing.Size(172, 34);
            this.leaveRequestButton.TabIndex = 26;
            this.leaveRequestButton.Text = "Submit Leave Request";
            this.leaveRequestButton.UseVisualStyleBackColor = false;
            this.leaveRequestButton.Click += new System.EventHandler(this.leaveRequestButton_Click);
            // 
            // leaveRequestLabel
            // 
            this.leaveRequestLabel.AutoSize = true;
            this.leaveRequestLabel.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveRequestLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leaveRequestLabel.Location = new System.Drawing.Point(3, 49);
            this.leaveRequestLabel.Name = "leaveRequestLabel";
            this.leaveRequestLabel.Size = new System.Drawing.Size(142, 21);
            this.leaveRequestLabel.TabIndex = 25;
            this.leaveRequestLabel.Text = "LEAVE REQUEST";
            // 
            // typeOfLeaveComboBox
            // 
            this.typeOfLeaveComboBox.FormattingEnabled = true;
            this.typeOfLeaveComboBox.Items.AddRange(new object[] {
            "Vacation Leave",
            "Sick Leave",
            "Bereavement Leave",
            "Emergency Leave",
            "Birthday Leave",
            "Paternity Leave",
            ""});
            this.typeOfLeaveComboBox.Location = new System.Drawing.Point(94, 104);
            this.typeOfLeaveComboBox.Name = "typeOfLeaveComboBox";
            this.typeOfLeaveComboBox.Size = new System.Drawing.Size(183, 25);
            this.typeOfLeaveComboBox.TabIndex = 24;
            this.typeOfLeaveComboBox.Text = "Vacation Leave";
            // 
            // typeOfLeaveLabel
            // 
            this.typeOfLeaveLabel.AutoSize = true;
            this.typeOfLeaveLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfLeaveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.typeOfLeaveLabel.Location = new System.Drawing.Point(3, 114);
            this.typeOfLeaveLabel.Name = "typeOfLeaveLabel";
            this.typeOfLeaveLabel.Size = new System.Drawing.Size(85, 15);
            this.typeOfLeaveLabel.TabIndex = 19;
            this.typeOfLeaveLabel.Text = "Type Of Leave";
            // 
            // dateOfLeave
            // 
            this.dateOfLeave.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfLeave.Location = new System.Drawing.Point(94, 73);
            this.dateOfLeave.Name = "dateOfLeave";
            this.dateOfLeave.Size = new System.Drawing.Size(183, 22);
            this.dateOfLeave.TabIndex = 18;
            // 
            // dateOfLeaveLabel
            // 
            this.dateOfLeaveLabel.AutoSize = true;
            this.dateOfLeaveLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfLeaveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateOfLeaveLabel.Location = new System.Drawing.Point(3, 79);
            this.dateOfLeaveLabel.Name = "dateOfLeaveLabel";
            this.dateOfLeaveLabel.Size = new System.Drawing.Size(85, 15);
            this.dateOfLeaveLabel.TabIndex = 17;
            this.dateOfLeaveLabel.Text = "Date Of Leave";
            // 
            // dateFiled
            // 
            this.dateFiled.AutoSize = true;
            this.dateFiled.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFiled.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateFiled.Location = new System.Drawing.Point(486, 0);
            this.dateFiled.Name = "dateFiled";
            this.dateFiled.Size = new System.Drawing.Size(83, 15);
            this.dateFiled.TabIndex = 16;
            this.dateFiled.Text = "01/22/2015";
            // 
            // dateFiledLabel
            // 
            this.dateFiledLabel.AutoSize = true;
            this.dateFiledLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFiledLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateFiledLabel.Location = new System.Drawing.Point(398, 0);
            this.dateFiledLabel.Name = "dateFiledLabel";
            this.dateFiledLabel.Size = new System.Drawing.Size(64, 15);
            this.dateFiledLabel.TabIndex = 15;
            this.dateFiledLabel.Text = "Date Filed";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeName.Location = new System.Drawing.Point(120, 0);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(107, 15);
            this.employeeName.TabIndex = 14;
            this.employeeName.Text = "Last, First Middle";
            // 
            // employeeNumber
            // 
            this.employeeNumber.AutoSize = true;
            this.employeeNumber.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeNumber.Location = new System.Drawing.Point(120, 23);
            this.employeeNumber.Name = "employeeNumber";
            this.employeeNumber.Size = new System.Drawing.Size(103, 15);
            this.employeeNumber.TabIndex = 13;
            this.employeeNumber.Text = "123456789101";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeNameLabel.Location = new System.Drawing.Point(4, 0);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(97, 15);
            this.employeeNameLabel.TabIndex = 12;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.AutoSize = true;
            this.employeeNumberLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeNumberLabel.Location = new System.Drawing.Point(4, 23);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(110, 15);
            this.employeeNumberLabel.TabIndex = 11;
            this.employeeNumberLabel.Text = "Employee Number";
            // 
            // pendingRequestTab
            // 
            this.pendingRequestTab.BackColor = System.Drawing.Color.DarkGreen;
            this.pendingRequestTab.Controls.Add(this.pendingRequestListBox);
            this.pendingRequestTab.Location = new System.Drawing.Point(4, 29);
            this.pendingRequestTab.Name = "pendingRequestTab";
            this.pendingRequestTab.Padding = new System.Windows.Forms.Padding(3);
            this.pendingRequestTab.Size = new System.Drawing.Size(634, 338);
            this.pendingRequestTab.TabIndex = 3;
            this.pendingRequestTab.Text = "Pending Request";
            // 
            // pendingRequestListBox
            // 
            this.pendingRequestListBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingRequestListBox.FormattingEnabled = true;
            this.pendingRequestListBox.ItemHeight = 17;
            this.pendingRequestListBox.Location = new System.Drawing.Point(20, 23);
            this.pendingRequestListBox.Name = "pendingRequestListBox";
            this.pendingRequestListBox.Size = new System.Drawing.Size(564, 293);
            this.pendingRequestListBox.TabIndex = 6;
            // 
            // approvedRequetTab
            // 
            this.approvedRequetTab.BackColor = System.Drawing.Color.DarkGreen;
            this.approvedRequetTab.Controls.Add(this.approvedRequestListBox);
            this.approvedRequetTab.Location = new System.Drawing.Point(4, 29);
            this.approvedRequetTab.Name = "approvedRequetTab";
            this.approvedRequetTab.Padding = new System.Windows.Forms.Padding(3);
            this.approvedRequetTab.Size = new System.Drawing.Size(634, 338);
            this.approvedRequetTab.TabIndex = 4;
            this.approvedRequetTab.Text = "Approved Request";
            // 
            // approvedRequestListBox
            // 
            this.approvedRequestListBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.approvedRequestListBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedRequestListBox.FormattingEnabled = true;
            this.approvedRequestListBox.ItemHeight = 17;
            this.approvedRequestListBox.Location = new System.Drawing.Point(21, 23);
            this.approvedRequestListBox.Name = "approvedRequestListBox";
            this.approvedRequestListBox.Size = new System.Drawing.Size(564, 293);
            this.approvedRequestListBox.TabIndex = 7;
            // 
            // leaveCreditsTab
            // 
            this.leaveCreditsTab.BackColor = System.Drawing.Color.DarkGreen;
            this.leaveCreditsTab.Controls.Add(this.birthdayLeave);
            this.leaveCreditsTab.Controls.Add(this.bereavementLeave);
            this.leaveCreditsTab.Controls.Add(this.paternityLeave);
            this.leaveCreditsTab.Controls.Add(this.emergencyLeave);
            this.leaveCreditsTab.Controls.Add(this.sickLeave);
            this.leaveCreditsTab.Controls.Add(this.vacationLeave);
            this.leaveCreditsTab.Controls.Add(this.birthdayLeaveLabel);
            this.leaveCreditsTab.Controls.Add(this.bereavementLeaveLabel);
            this.leaveCreditsTab.Controls.Add(this.paternityLeaveLabel);
            this.leaveCreditsTab.Controls.Add(this.emergencyLeaveLabel);
            this.leaveCreditsTab.Controls.Add(this.sickLeaveLabel);
            this.leaveCreditsTab.Controls.Add(this.vacationLeaveLabel);
            this.leaveCreditsTab.Location = new System.Drawing.Point(4, 29);
            this.leaveCreditsTab.Name = "leaveCreditsTab";
            this.leaveCreditsTab.Padding = new System.Windows.Forms.Padding(3);
            this.leaveCreditsTab.Size = new System.Drawing.Size(634, 338);
            this.leaveCreditsTab.TabIndex = 5;
            this.leaveCreditsTab.Text = "Leave Credits";
            // 
            // birthdayLeave
            // 
            this.birthdayLeave.AutoSize = true;
            this.birthdayLeave.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.birthdayLeave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthdayLeave.Location = new System.Drawing.Point(207, 208);
            this.birthdayLeave.Name = "birthdayLeave";
            this.birthdayLeave.Size = new System.Drawing.Size(18, 17);
            this.birthdayLeave.TabIndex = 15;
            this.birthdayLeave.Text = "1";
            // 
            // bereavementLeave
            // 
            this.bereavementLeave.AutoSize = true;
            this.bereavementLeave.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.bereavementLeave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bereavementLeave.Location = new System.Drawing.Point(207, 176);
            this.bereavementLeave.Name = "bereavementLeave";
            this.bereavementLeave.Size = new System.Drawing.Size(18, 17);
            this.bereavementLeave.TabIndex = 14;
            this.bereavementLeave.Text = "3";
            // 
            // paternityLeave
            // 
            this.paternityLeave.AutoSize = true;
            this.paternityLeave.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.paternityLeave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paternityLeave.Location = new System.Drawing.Point(207, 142);
            this.paternityLeave.Name = "paternityLeave";
            this.paternityLeave.Size = new System.Drawing.Size(18, 17);
            this.paternityLeave.TabIndex = 13;
            this.paternityLeave.Text = "3";
            // 
            // emergencyLeave
            // 
            this.emergencyLeave.AutoSize = true;
            this.emergencyLeave.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.emergencyLeave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emergencyLeave.Location = new System.Drawing.Point(207, 107);
            this.emergencyLeave.Name = "emergencyLeave";
            this.emergencyLeave.Size = new System.Drawing.Size(18, 17);
            this.emergencyLeave.TabIndex = 12;
            this.emergencyLeave.Text = "7";
            // 
            // sickLeave
            // 
            this.sickLeave.AutoSize = true;
            this.sickLeave.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.sickLeave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sickLeave.Location = new System.Drawing.Point(207, 74);
            this.sickLeave.Name = "sickLeave";
            this.sickLeave.Size = new System.Drawing.Size(28, 17);
            this.sickLeave.TabIndex = 11;
            this.sickLeave.Text = "12";
            // 
            // vacationLeave
            // 
            this.vacationLeave.AutoSize = true;
            this.vacationLeave.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.vacationLeave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vacationLeave.Location = new System.Drawing.Point(207, 43);
            this.vacationLeave.Name = "vacationLeave";
            this.vacationLeave.Size = new System.Drawing.Size(28, 17);
            this.vacationLeave.TabIndex = 10;
            this.vacationLeave.Text = "12";
            // 
            // birthdayLeaveLabel
            // 
            this.birthdayLeaveLabel.AutoSize = true;
            this.birthdayLeaveLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.birthdayLeaveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthdayLeaveLabel.Location = new System.Drawing.Point(43, 208);
            this.birthdayLeaveLabel.Name = "birthdayLeaveLabel";
            this.birthdayLeaveLabel.Size = new System.Drawing.Size(116, 17);
            this.birthdayLeaveLabel.TabIndex = 9;
            this.birthdayLeaveLabel.Text = "Birthday Leave:";
            // 
            // bereavementLeaveLabel
            // 
            this.bereavementLeaveLabel.AutoSize = true;
            this.bereavementLeaveLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.bereavementLeaveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bereavementLeaveLabel.Location = new System.Drawing.Point(43, 176);
            this.bereavementLeaveLabel.Name = "bereavementLeaveLabel";
            this.bereavementLeaveLabel.Size = new System.Drawing.Size(148, 17);
            this.bereavementLeaveLabel.TabIndex = 8;
            this.bereavementLeaveLabel.Text = "Bereavement Leave:";
            // 
            // paternityLeaveLabel
            // 
            this.paternityLeaveLabel.AutoSize = true;
            this.paternityLeaveLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.paternityLeaveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paternityLeaveLabel.Location = new System.Drawing.Point(43, 142);
            this.paternityLeaveLabel.Name = "paternityLeaveLabel";
            this.paternityLeaveLabel.Size = new System.Drawing.Size(120, 17);
            this.paternityLeaveLabel.TabIndex = 7;
            this.paternityLeaveLabel.Text = "Paternity Leave:";
            // 
            // emergencyLeaveLabel
            // 
            this.emergencyLeaveLabel.AutoSize = true;
            this.emergencyLeaveLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.emergencyLeaveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emergencyLeaveLabel.Location = new System.Drawing.Point(43, 107);
            this.emergencyLeaveLabel.Name = "emergencyLeaveLabel";
            this.emergencyLeaveLabel.Size = new System.Drawing.Size(130, 17);
            this.emergencyLeaveLabel.TabIndex = 6;
            this.emergencyLeaveLabel.Text = "Emergency Leave";
            // 
            // sickLeaveLabel
            // 
            this.sickLeaveLabel.AutoSize = true;
            this.sickLeaveLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.sickLeaveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sickLeaveLabel.Location = new System.Drawing.Point(43, 74);
            this.sickLeaveLabel.Name = "sickLeaveLabel";
            this.sickLeaveLabel.Size = new System.Drawing.Size(86, 17);
            this.sickLeaveLabel.TabIndex = 5;
            this.sickLeaveLabel.Text = "Sick Leave:";
            // 
            // vacationLeaveLabel
            // 
            this.vacationLeaveLabel.AutoSize = true;
            this.vacationLeaveLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.vacationLeaveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vacationLeaveLabel.Location = new System.Drawing.Point(43, 43);
            this.vacationLeaveLabel.Name = "vacationLeaveLabel";
            this.vacationLeaveLabel.Size = new System.Drawing.Size(117, 17);
            this.vacationLeaveLabel.TabIndex = 4;
            this.vacationLeaveLabel.Text = "Vacation Leave:";
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.exitPictureBox.Location = new System.Drawing.Point(609, 0);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(42, 35);
            this.exitPictureBox.TabIndex = 1;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // employeeFullName
            // 
            this.employeeFullName.AutoSize = true;
            this.employeeFullName.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.employeeFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeFullName.Location = new System.Drawing.Point(178, 45);
            this.employeeFullName.Name = "employeeFullName";
            this.employeeFullName.Size = new System.Drawing.Size(119, 17);
            this.employeeFullName.TabIndex = 8;
            this.employeeFullName.Text = "Employee Name";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 413);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.homeTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.homeTabs.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.dashboardTab.PerformLayout();
            this.myClockTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.requestTab.ResumeLayout(false);
            this.requestPanel.ResumeLayout(false);
            this.requestPanel.PerformLayout();
            this.pendingRequestTab.ResumeLayout(false);
            this.approvedRequetTab.ResumeLayout(false);
            this.leaveCreditsTab.ResumeLayout(false);
            this.leaveCreditsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl homeTabs;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.TabPage myClockTab;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button viewPayrollButton;
        private System.Windows.Forms.ListBox userPayrollListBox;
        private System.Windows.Forms.Label payrollsLabel;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.ListBox attendanceListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateToday;
        private System.Windows.Forms.Label clockInLabel;
        private System.Windows.Forms.Label clockedOutLabel;
        private System.Windows.Forms.Label clockedOut;
        private System.Windows.Forms.Label clockedIn;
        private System.Windows.Forms.Label validClockOut;
        private System.Windows.Forms.Label clockOutNotificationLabel;
        private System.Windows.Forms.TabPage requestTab;
        private System.Windows.Forms.Panel requestPanel;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label employeeNumber;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label dateOfLeaveLabel;
        private System.Windows.Forms.DateTimePicker dateOfLeave;
        private System.Windows.Forms.Label typeOfLeaveLabel;
        private System.Windows.Forms.ComboBox typeOfLeaveComboBox;
        private System.Windows.Forms.Label leaveRequestLabel;
        private System.Windows.Forms.Button leaveRequestButton;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.Button overtimeRequestButton;
        private System.Windows.Forms.Label overtimeRequestLabel;
        private System.Windows.Forms.Label workingHourLabel;
        private System.Windows.Forms.DateTimePicker dateOfRequest;
        private System.Windows.Forms.Label otherDateOfLeaveLabel;
        private System.Windows.Forms.TextBox leaveDescription;
        private System.Windows.Forms.Label overtimeReqeustDescriptionLabel;
        private System.Windows.Forms.TextBox overtimeRequestDescription;
        private System.Windows.Forms.Label dateFiled;
        private System.Windows.Forms.Label dateFiledLabel;
        private System.Windows.Forms.TextBox workingHour;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.TabPage pendingRequestTab;
        private System.Windows.Forms.TabPage approvedRequetTab;
        private System.Windows.Forms.ListBox pendingRequestListBox;
        private System.Windows.Forms.ListBox approvedRequestListBox;
        private System.Windows.Forms.TabPage leaveCreditsTab;
        private System.Windows.Forms.Label birthdayLeave;
        private System.Windows.Forms.Label bereavementLeave;
        private System.Windows.Forms.Label paternityLeave;
        private System.Windows.Forms.Label emergencyLeave;
        private System.Windows.Forms.Label sickLeave;
        private System.Windows.Forms.Label vacationLeave;
        private System.Windows.Forms.Label birthdayLeaveLabel;
        private System.Windows.Forms.Label bereavementLeaveLabel;
        private System.Windows.Forms.Label paternityLeaveLabel;
        private System.Windows.Forms.Label emergencyLeaveLabel;
        private System.Windows.Forms.Label sickLeaveLabel;
        private System.Windows.Forms.Label vacationLeaveLabel;
        private System.Windows.Forms.Label idNumber;
        private System.Windows.Forms.Button cashAdvanceButton;
        private System.Windows.Forms.Label employeeFullName;

    }
}