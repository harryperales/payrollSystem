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
            this.homeTabs = new System.Windows.Forms.TabControl();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.payrollsLabel = new System.Windows.Forms.Label();
            this.viewPayrollButton = new System.Windows.Forms.Button();
            this.userPayrollListBox = new System.Windows.Forms.ListBox();
            this.username = new System.Windows.Forms.Label();
            this.requirementPanel = new System.Windows.Forms.Panel();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.myClockTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.myClockSubTab = new System.Windows.Forms.TabPage();
            this.clockInAndOutPanel = new System.Windows.Forms.Panel();
            this.todaySchedulePanel = new System.Windows.Forms.Panel();
            this.timeCardSubTab = new System.Windows.Forms.TabPage();
            this.scheduleSubTab = new System.Windows.Forms.TabPage();
            this.analyticsTab = new System.Windows.Forms.TabPage();
            this.homeTabs.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.myClockTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.myClockSubTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeTabs
            // 
            this.homeTabs.Controls.Add(this.dashboardTab);
            this.homeTabs.Controls.Add(this.myClockTab);
            this.homeTabs.Controls.Add(this.analyticsTab);
            this.homeTabs.Location = new System.Drawing.Point(1, 1);
            this.homeTabs.Name = "homeTabs";
            this.homeTabs.SelectedIndex = 0;
            this.homeTabs.Size = new System.Drawing.Size(613, 394);
            this.homeTabs.TabIndex = 0;
            // 
            // dashboardTab
            // 
            this.dashboardTab.Controls.Add(this.payrollsLabel);
            this.dashboardTab.Controls.Add(this.viewPayrollButton);
            this.dashboardTab.Controls.Add(this.userPayrollListBox);
            this.dashboardTab.Controls.Add(this.username);
            this.dashboardTab.Controls.Add(this.requirementPanel);
            this.dashboardTab.Controls.Add(this.imagePanel);
            this.dashboardTab.Location = new System.Drawing.Point(4, 22);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(605, 368);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
            this.dashboardTab.UseVisualStyleBackColor = true;
            // 
            // payrollsLabel
            // 
            this.payrollsLabel.AutoSize = true;
            this.payrollsLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollsLabel.Location = new System.Drawing.Point(84, 149);
            this.payrollsLabel.Name = "payrollsLabel";
            this.payrollsLabel.Size = new System.Drawing.Size(59, 20);
            this.payrollsLabel.TabIndex = 6;
            this.payrollsLabel.Text = "Payrolls";
            // 
            // viewPayrollButton
            // 
            this.viewPayrollButton.Location = new System.Drawing.Point(19, 336);
            this.viewPayrollButton.Name = "viewPayrollButton";
            this.viewPayrollButton.Size = new System.Drawing.Size(234, 23);
            this.viewPayrollButton.TabIndex = 5;
            this.viewPayrollButton.Text = "View Payroll";
            this.viewPayrollButton.UseVisualStyleBackColor = true;
            this.viewPayrollButton.Click += new System.EventHandler(this.viewPayrollButton_Click);
            // 
            // userPayrollListBox
            // 
            this.userPayrollListBox.FormattingEnabled = true;
            this.userPayrollListBox.Location = new System.Drawing.Point(19, 172);
            this.userPayrollListBox.Name = "userPayrollListBox";
            this.userPayrollListBox.Size = new System.Drawing.Size(234, 160);
            this.userPayrollListBox.TabIndex = 4;
            this.userPayrollListBox.SelectedIndexChanged += new System.EventHandler(this.userPayrollListBox_SelectedIndexChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(192, 44);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(105, 24);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            // 
            // requirementPanel
            // 
            this.requirementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requirementPanel.Location = new System.Drawing.Point(259, 172);
            this.requirementPanel.Name = "requirementPanel";
            this.requirementPanel.Size = new System.Drawing.Size(328, 187);
            this.requirementPanel.TabIndex = 2;
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
            this.myClockTab.Controls.Add(this.tabControl1);
            this.myClockTab.Location = new System.Drawing.Point(4, 22);
            this.myClockTab.Name = "myClockTab";
            this.myClockTab.Padding = new System.Windows.Forms.Padding(3);
            this.myClockTab.Size = new System.Drawing.Size(605, 368);
            this.myClockTab.TabIndex = 1;
            this.myClockTab.Text = "My Clock";
            this.myClockTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.myClockSubTab);
            this.tabControl1.Controls.Add(this.timeCardSubTab);
            this.tabControl1.Controls.Add(this.scheduleSubTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // myClockSubTab
            // 
            this.myClockSubTab.Controls.Add(this.clockInAndOutPanel);
            this.myClockSubTab.Controls.Add(this.todaySchedulePanel);
            this.myClockSubTab.Location = new System.Drawing.Point(4, 22);
            this.myClockSubTab.Name = "myClockSubTab";
            this.myClockSubTab.Padding = new System.Windows.Forms.Padding(3);
            this.myClockSubTab.Size = new System.Drawing.Size(597, 342);
            this.myClockSubTab.TabIndex = 0;
            this.myClockSubTab.Text = "My Clock";
            this.myClockSubTab.UseVisualStyleBackColor = true;
            // 
            // clockInAndOutPanel
            // 
            this.clockInAndOutPanel.Location = new System.Drawing.Point(206, 7);
            this.clockInAndOutPanel.Name = "clockInAndOutPanel";
            this.clockInAndOutPanel.Size = new System.Drawing.Size(381, 328);
            this.clockInAndOutPanel.TabIndex = 1;
            // 
            // todaySchedulePanel
            // 
            this.todaySchedulePanel.Location = new System.Drawing.Point(8, 7);
            this.todaySchedulePanel.Name = "todaySchedulePanel";
            this.todaySchedulePanel.Size = new System.Drawing.Size(191, 329);
            this.todaySchedulePanel.TabIndex = 0;
            // 
            // timeCardSubTab
            // 
            this.timeCardSubTab.Location = new System.Drawing.Point(4, 22);
            this.timeCardSubTab.Name = "timeCardSubTab";
            this.timeCardSubTab.Padding = new System.Windows.Forms.Padding(3);
            this.timeCardSubTab.Size = new System.Drawing.Size(597, 342);
            this.timeCardSubTab.TabIndex = 1;
            this.timeCardSubTab.Text = "Time Card";
            this.timeCardSubTab.UseVisualStyleBackColor = true;
            // 
            // scheduleSubTab
            // 
            this.scheduleSubTab.Location = new System.Drawing.Point(4, 22);
            this.scheduleSubTab.Name = "scheduleSubTab";
            this.scheduleSubTab.Padding = new System.Windows.Forms.Padding(3);
            this.scheduleSubTab.Size = new System.Drawing.Size(597, 342);
            this.scheduleSubTab.TabIndex = 2;
            this.scheduleSubTab.Text = "Schedule";
            this.scheduleSubTab.UseVisualStyleBackColor = true;
            // 
            // analyticsTab
            // 
            this.analyticsTab.Location = new System.Drawing.Point(4, 22);
            this.analyticsTab.Name = "analyticsTab";
            this.analyticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.analyticsTab.Size = new System.Drawing.Size(605, 368);
            this.analyticsTab.TabIndex = 2;
            this.analyticsTab.Text = "Analytics";
            this.analyticsTab.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 395);
            this.Controls.Add(this.homeTabs);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.homeTabs.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.dashboardTab.PerformLayout();
            this.myClockTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.myClockSubTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl homeTabs;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.Panel requirementPanel;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.TabPage myClockTab;
        private System.Windows.Forms.TabPage analyticsTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage myClockSubTab;
        private System.Windows.Forms.TabPage timeCardSubTab;
        private System.Windows.Forms.TabPage scheduleSubTab;
        private System.Windows.Forms.Panel clockInAndOutPanel;
        private System.Windows.Forms.Panel todaySchedulePanel;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button viewPayrollButton;
        private System.Windows.Forms.ListBox userPayrollListBox;
        private System.Windows.Forms.Label payrollsLabel;

    }
}