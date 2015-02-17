namespace PayrollSystem.view
{
    partial class TimeInOutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeInOutForm));
            this.timeInOutPanel = new System.Windows.Forms.Panel();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateStringLabel = new System.Windows.Forms.Label();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.timeOutButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.timeInButton = new System.Windows.Forms.Button();
            this.employeeIdNumber = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.clockTickLabel = new System.Windows.Forms.Label();
            this.timeInOutTimer = new System.Windows.Forms.Timer(this.components);
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.timeInOutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timeInOutPanel
            // 
            this.timeInOutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timeInOutPanel.BackgroundImage")));
            this.timeInOutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timeInOutPanel.Controls.Add(this.errorMessageLabel);
            this.timeInOutPanel.Controls.Add(this.exitPictureBox);
            this.timeInOutPanel.Controls.Add(this.timeLabel);
            this.timeInOutPanel.Controls.Add(this.dateStringLabel);
            this.timeInOutPanel.Controls.Add(this.employeeNumberLabel);
            this.timeInOutPanel.Controls.Add(this.timeOutButton);
            this.timeInOutPanel.Controls.Add(this.signInButton);
            this.timeInOutPanel.Controls.Add(this.timeInButton);
            this.timeInOutPanel.Controls.Add(this.employeeIdNumber);
            this.timeInOutPanel.Controls.Add(this.dateLabel);
            this.timeInOutPanel.Controls.Add(this.clockTickLabel);
            this.timeInOutPanel.Location = new System.Drawing.Point(-1, 1);
            this.timeInOutPanel.Name = "timeInOutPanel";
            this.timeInOutPanel.Size = new System.Drawing.Size(538, 351);
            this.timeInOutPanel.TabIndex = 0;
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.exitPictureBox.Location = new System.Drawing.Point(505, 3);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(30, 30);
            this.exitPictureBox.TabIndex = 9;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(95, 88);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(51, 17);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Time :";
            // 
            // dateStringLabel
            // 
            this.dateStringLabel.AutoSize = true;
            this.dateStringLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateStringLabel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStringLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateStringLabel.Location = new System.Drawing.Point(95, 51);
            this.dateStringLabel.Name = "dateStringLabel";
            this.dateStringLabel.Size = new System.Drawing.Size(50, 17);
            this.dateStringLabel.TabIndex = 7;
            this.dateStringLabel.Text = "Date :";
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.AutoSize = true;
            this.employeeNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeNumberLabel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberLabel.Location = new System.Drawing.Point(197, 135);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(157, 17);
            this.employeeNumberLabel.TabIndex = 6;
            this.employeeNumberLabel.Text = "Employee ID Number";
            // 
            // timeOutButton
            // 
            this.timeOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.timeOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeOutButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.timeOutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeOutButton.Location = new System.Drawing.Point(348, 212);
            this.timeOutButton.Name = "timeOutButton";
            this.timeOutButton.Size = new System.Drawing.Size(112, 41);
            this.timeOutButton.TabIndex = 5;
            this.timeOutButton.Text = "TIME OUT";
            this.timeOutButton.UseVisualStyleBackColor = false;
            this.timeOutButton.Click += new System.EventHandler(this.timeOutButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signInButton.Location = new System.Drawing.Point(212, 212);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(130, 41);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "SIGN IN";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // timeInButton
            // 
            this.timeInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.timeInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeInButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.timeInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeInButton.Location = new System.Drawing.Point(95, 212);
            this.timeInButton.Name = "timeInButton";
            this.timeInButton.Size = new System.Drawing.Size(111, 41);
            this.timeInButton.TabIndex = 3;
            this.timeInButton.Text = "TIME IN";
            this.timeInButton.UseVisualStyleBackColor = false;
            this.timeInButton.Click += new System.EventHandler(this.timeInButton_Click);
            // 
            // employeeIdNumber
            // 
            this.employeeIdNumber.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdNumber.Location = new System.Drawing.Point(172, 155);
            this.employeeIdNumber.Name = "employeeIdNumber";
            this.employeeIdNumber.Size = new System.Drawing.Size(204, 27);
            this.employeeIdNumber.TabIndex = 2;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateLabel.Location = new System.Drawing.Point(181, 35);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(137, 37);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date Now";
            // 
            // clockTickLabel
            // 
            this.clockTickLabel.AutoSize = true;
            this.clockTickLabel.BackColor = System.Drawing.Color.Transparent;
            this.clockTickLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.clockTickLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clockTickLabel.Location = new System.Drawing.Point(181, 72);
            this.clockTickLabel.Name = "clockTickLabel";
            this.clockTickLabel.Size = new System.Drawing.Size(149, 37);
            this.clockTickLabel.TabIndex = 0;
            this.clockTickLabel.Text = "Clock Tick";
            // 
            // timeInOutTimer
            // 
            this.timeInOutTimer.Enabled = true;
            this.timeInOutTimer.Interval = 1000;
            this.timeInOutTimer.Tick += new System.EventHandler(this.timeInOutTimer_Tick);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorMessageLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.errorMessageLabel.Location = new System.Drawing.Point(47, 296);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(41, 20);
            this.errorMessageLabel.TabIndex = 10;
            this.errorMessageLabel.Text = "Error";
            // 
            // TimeInOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 350);
            this.Controls.Add(this.timeInOutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeInOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeInOutForm";
            this.timeInOutPanel.ResumeLayout(false);
            this.timeInOutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel timeInOutPanel;
        private System.Windows.Forms.Timer timeInOutTimer;
        private System.Windows.Forms.Label clockTickLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox employeeIdNumber;
        private System.Windows.Forms.Button timeInButton;
        private System.Windows.Forms.Button timeOutButton;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateStringLabel;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}