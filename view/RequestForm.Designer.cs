namespace PayrollSystem.view
{
    partial class RequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            this.requestFormPanel = new System.Windows.Forms.Panel();
            this.disapproveButton = new System.Windows.Forms.Button();
            this.approveButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.requestType = new System.Windows.Forms.Label();
            this.dateRequested = new System.Windows.Forms.Label();
            this.requestedBy = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.requestTypeLabel = new System.Windows.Forms.Label();
            this.dateRequestedLabel = new System.Windows.Forms.Label();
            this.requestedByLabel = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.overtimeWorkHourLabel = new System.Windows.Forms.Label();
            this.overtimeWokingHour = new System.Windows.Forms.Label();
            this.requestFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // requestFormPanel
            // 
            this.requestFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.requestFormPanel.Controls.Add(this.overtimeWokingHour);
            this.requestFormPanel.Controls.Add(this.overtimeWorkHourLabel);
            this.requestFormPanel.Controls.Add(this.disapproveButton);
            this.requestFormPanel.Controls.Add(this.approveButton);
            this.requestFormPanel.Controls.Add(this.status);
            this.requestFormPanel.Controls.Add(this.description);
            this.requestFormPanel.Controls.Add(this.requestType);
            this.requestFormPanel.Controls.Add(this.dateRequested);
            this.requestFormPanel.Controls.Add(this.requestedBy);
            this.requestFormPanel.Controls.Add(this.descriptionLabel);
            this.requestFormPanel.Controls.Add(this.statusLabel);
            this.requestFormPanel.Controls.Add(this.requestTypeLabel);
            this.requestFormPanel.Controls.Add(this.dateRequestedLabel);
            this.requestFormPanel.Controls.Add(this.requestedByLabel);
            this.requestFormPanel.Location = new System.Drawing.Point(1, 34);
            this.requestFormPanel.Name = "requestFormPanel";
            this.requestFormPanel.Size = new System.Drawing.Size(569, 315);
            this.requestFormPanel.TabIndex = 0;
            // 
            // disapproveButton
            // 
            this.disapproveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.disapproveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disapproveButton.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.disapproveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.disapproveButton.Location = new System.Drawing.Point(377, 129);
            this.disapproveButton.Name = "disapproveButton";
            this.disapproveButton.Size = new System.Drawing.Size(139, 34);
            this.disapproveButton.TabIndex = 21;
            this.disapproveButton.Text = "Disapprove";
            this.disapproveButton.UseVisualStyleBackColor = false;
            this.disapproveButton.Click += new System.EventHandler(this.disapproveButton_Click);
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.approveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButton.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.approveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.approveButton.Location = new System.Drawing.Point(377, 77);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(139, 34);
            this.approveButton.TabIndex = 20;
            this.approveButton.Text = "Approve";
            this.approveButton.UseVisualStyleBackColor = false;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.status.Location = new System.Drawing.Point(156, 129);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(57, 17);
            this.status.TabIndex = 19;
            this.status.Text = "Status:";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.description.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description.Location = new System.Drawing.Point(49, 195);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(95, 17);
            this.description.TabIndex = 18;
            this.description.Text = "Description:";
            // 
            // requestType
            // 
            this.requestType.AutoSize = true;
            this.requestType.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.requestType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.requestType.Location = new System.Drawing.Point(156, 94);
            this.requestType.Name = "requestType";
            this.requestType.Size = new System.Drawing.Size(107, 17);
            this.requestType.TabIndex = 17;
            this.requestType.Text = "Request Type:";
            // 
            // dateRequested
            // 
            this.dateRequested.AutoSize = true;
            this.dateRequested.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.dateRequested.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateRequested.Location = new System.Drawing.Point(156, 57);
            this.dateRequested.Name = "dateRequested";
            this.dateRequested.Size = new System.Drawing.Size(121, 17);
            this.dateRequested.TabIndex = 16;
            this.dateRequested.Text = "Date requested:";
            // 
            // requestedBy
            // 
            this.requestedBy.AutoSize = true;
            this.requestedBy.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.requestedBy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.requestedBy.Location = new System.Drawing.Point(156, 24);
            this.requestedBy.Name = "requestedBy";
            this.requestedBy.Size = new System.Drawing.Size(109, 17);
            this.requestedBy.TabIndex = 15;
            this.requestedBy.Text = "Requested By:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionLabel.Location = new System.Drawing.Point(20, 167);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(95, 17);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "Description:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusLabel.Location = new System.Drawing.Point(20, 129);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(57, 17);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "Status:";
            // 
            // requestTypeLabel
            // 
            this.requestTypeLabel.AutoSize = true;
            this.requestTypeLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.requestTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.requestTypeLabel.Location = new System.Drawing.Point(20, 94);
            this.requestTypeLabel.Name = "requestTypeLabel";
            this.requestTypeLabel.Size = new System.Drawing.Size(107, 17);
            this.requestTypeLabel.TabIndex = 12;
            this.requestTypeLabel.Text = "Request Type:";
            // 
            // dateRequestedLabel
            // 
            this.dateRequestedLabel.AutoSize = true;
            this.dateRequestedLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.dateRequestedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateRequestedLabel.Location = new System.Drawing.Point(20, 57);
            this.dateRequestedLabel.Name = "dateRequestedLabel";
            this.dateRequestedLabel.Size = new System.Drawing.Size(121, 17);
            this.dateRequestedLabel.TabIndex = 11;
            this.dateRequestedLabel.Text = "Date requested:";
            // 
            // requestedByLabel
            // 
            this.requestedByLabel.AutoSize = true;
            this.requestedByLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.requestedByLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.requestedByLabel.Location = new System.Drawing.Point(20, 24);
            this.requestedByLabel.Name = "requestedByLabel";
            this.requestedByLabel.Size = new System.Drawing.Size(109, 17);
            this.requestedByLabel.TabIndex = 10;
            this.requestedByLabel.Text = "Requested By:";
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.exitPictureBox.Location = new System.Drawing.Point(537, 2);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(32, 32);
            this.exitPictureBox.TabIndex = 1;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // overtimeWorkHourLabel
            // 
            this.overtimeWorkHourLabel.AutoSize = true;
            this.overtimeWorkHourLabel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.overtimeWorkHourLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.overtimeWorkHourLabel.Location = new System.Drawing.Point(192, 167);
            this.overtimeWorkHourLabel.Name = "overtimeWorkHourLabel";
            this.overtimeWorkHourLabel.Size = new System.Drawing.Size(172, 17);
            this.overtimeWorkHourLabel.TabIndex = 22;
            this.overtimeWorkHourLabel.Text = "Overtime Woking Hour:";
            // 
            // overtimeWokingHour
            // 
            this.overtimeWokingHour.AutoSize = true;
            this.overtimeWokingHour.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.overtimeWokingHour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.overtimeWokingHour.Location = new System.Drawing.Point(374, 166);
            this.overtimeWokingHour.Name = "overtimeWokingHour";
            this.overtimeWokingHour.Size = new System.Drawing.Size(53, 17);
            this.overtimeWokingHour.TabIndex = 23;
            this.overtimeWokingHour.Text = "02:35";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 350);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.requestFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestForm";
            this.requestFormPanel.ResumeLayout(false);
            this.requestFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel requestFormPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label requestTypeLabel;
        private System.Windows.Forms.Label dateRequestedLabel;
        private System.Windows.Forms.Label requestedByLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label requestedBy;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label requestType;
        private System.Windows.Forms.Label dateRequested;
        private System.Windows.Forms.Button disapproveButton;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.Label overtimeWokingHour;
        private System.Windows.Forms.Label overtimeWorkHourLabel;
    }
}