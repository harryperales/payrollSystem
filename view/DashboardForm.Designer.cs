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
            this.homeTabs.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // homeTabs
            // 
            this.homeTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.homeTabs.Controls.Add(this.dashboardTab);
            this.homeTabs.Controls.Add(this.myClockTab);
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
            this.userPayrollListBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.userPayrollListBox.FormattingEnabled = true;
            this.userPayrollListBox.ItemHeight = 22;
            this.userPayrollListBox.Location = new System.Drawing.Point(181, 116);
            this.userPayrollListBox.Name = "userPayrollListBox";
            this.userPayrollListBox.Size = new System.Drawing.Size(409, 202);
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
            this.myClockTab.Location = new System.Drawing.Point(4, 29);
            this.myClockTab.Name = "myClockTab";
            this.myClockTab.Padding = new System.Windows.Forms.Padding(3);
            this.myClockTab.Size = new System.Drawing.Size(607, 338);
            this.myClockTab.TabIndex = 1;
            this.myClockTab.Text = "My Clock";
            this.myClockTab.UseVisualStyleBackColor = true;
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

    }
}