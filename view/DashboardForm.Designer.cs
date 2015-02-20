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
            this.payrollsLabel = new System.Windows.Forms.Label();
            this.viewPayrollButton = new System.Windows.Forms.Button();
            this.userPayrollListBox = new System.Windows.Forms.ListBox();
            this.username = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.myClockTab = new System.Windows.Forms.TabPage();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.attendanceListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateToday = new System.Windows.Forms.Label();
            this.clockInLabel = new System.Windows.Forms.Label();
            this.clockedOutLabel = new System.Windows.Forms.Label();
            this.clockedIn = new System.Windows.Forms.Label();
            this.clockedOut = new System.Windows.Forms.Label();
            this.clockOutNotificationLabel = new System.Windows.Forms.Label();
            this.validClockOut = new System.Windows.Forms.Label();
            this.myRequestTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeTabs.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.myClockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.myRequestTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeTabs
            // 
            this.homeTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.homeTabs.Controls.Add(this.dashboardTab);
            this.homeTabs.Controls.Add(this.myClockTab);
            this.homeTabs.Controls.Add(this.myRequestTab);
            this.homeTabs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.homeTabs.Location = new System.Drawing.Point(0, 41);
            this.homeTabs.Name = "homeTabs";
            this.homeTabs.SelectedIndex = 0;
            this.homeTabs.Size = new System.Drawing.Size(615, 371);
            this.homeTabs.TabIndex = 0;
            // 
            // dashboardTab
            // 
            this.dashboardTab.BackColor = System.Drawing.Color.DarkGreen;
            this.dashboardTab.Controls.Add(this.payrollsLabel);
            this.dashboardTab.Controls.Add(this.viewPayrollButton);
            this.dashboardTab.Controls.Add(this.userPayrollListBox);
            this.dashboardTab.Controls.Add(this.username);
            this.dashboardTab.Controls.Add(this.imagePanel);
            this.dashboardTab.Location = new System.Drawing.Point(4, 29);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(607, 338);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
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
            this.viewPayrollButton.Location = new System.Drawing.Point(356, 72);
            this.viewPayrollButton.Name = "viewPayrollButton";
            this.viewPayrollButton.Size = new System.Drawing.Size(234, 38);
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
            this.username.Location = new System.Drawing.Point(192, 44);
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
            this.myClockTab.Size = new System.Drawing.Size(607, 338);
            this.myClockTab.TabIndex = 1;
            this.myClockTab.Text = "My Clock";
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.exitPictureBox.Location = new System.Drawing.Point(572, 1);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(42, 35);
            this.exitPictureBox.TabIndex = 1;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
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
            // myRequestTab
            // 
            this.myRequestTab.BackColor = System.Drawing.Color.DarkGreen;
            this.myRequestTab.Controls.Add(this.panel2);
            this.myRequestTab.Location = new System.Drawing.Point(4, 29);
            this.myRequestTab.Name = "myRequestTab";
            this.myRequestTab.Padding = new System.Windows.Forms.Padding(3);
            this.myRequestTab.Size = new System.Drawing.Size(607, 338);
            this.myRequestTab.TabIndex = 2;
            this.myRequestTab.Text = "My Request";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 325);
            this.panel2.TabIndex = 0;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 413);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.homeTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.homeTabs.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.dashboardTab.PerformLayout();
            this.myClockTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.myRequestTab.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage myRequestTab;
        private System.Windows.Forms.Panel panel2;

    }
}