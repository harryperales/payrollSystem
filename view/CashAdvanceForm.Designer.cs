namespace PayrollSystem.view
{
    partial class CashAdvanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashAdvanceForm));
            this.cashAdvancePanel = new System.Windows.Forms.Panel();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.cashAdvanceAmount = new System.Windows.Forms.TextBox();
            this.cashAdvanceRequestLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.employeeNumber = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.dateFiled = new System.Windows.Forms.Label();
            this.dateFiledLabel = new System.Windows.Forms.Label();
            this.cashAdvanceButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.requestDescription = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.cashAdvancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cashAdvancePanel
            // 
            this.cashAdvancePanel.BackColor = System.Drawing.Color.Transparent;
            this.cashAdvancePanel.Controls.Add(this.descriptionLabel);
            this.cashAdvancePanel.Controls.Add(this.requestDescription);
            this.cashAdvancePanel.Controls.Add(this.errorMessageLabel);
            this.cashAdvancePanel.Controls.Add(this.cashAdvanceButton);
            this.cashAdvancePanel.Controls.Add(this.dateFiled);
            this.cashAdvancePanel.Controls.Add(this.dateFiledLabel);
            this.cashAdvancePanel.Controls.Add(this.employeeName);
            this.cashAdvancePanel.Controls.Add(this.employeeNumber);
            this.cashAdvancePanel.Controls.Add(this.employeeNameLabel);
            this.cashAdvancePanel.Controls.Add(this.employeeNumberLabel);
            this.cashAdvancePanel.Controls.Add(this.amountLabel);
            this.cashAdvancePanel.Controls.Add(this.cashAdvanceRequestLabel);
            this.cashAdvancePanel.Controls.Add(this.cashAdvanceAmount);
            this.cashAdvancePanel.Location = new System.Drawing.Point(11, 33);
            this.cashAdvancePanel.Name = "cashAdvancePanel";
            this.cashAdvancePanel.Size = new System.Drawing.Size(404, 305);
            this.cashAdvancePanel.TabIndex = 0;
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.exitPictureBox.Location = new System.Drawing.Point(392, 1);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(33, 31);
            this.exitPictureBox.TabIndex = 1;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // cashAdvanceAmount
            // 
            this.cashAdvanceAmount.Font = new System.Drawing.Font("Century", 12F);
            this.cashAdvanceAmount.Location = new System.Drawing.Point(136, 102);
            this.cashAdvanceAmount.Name = "cashAdvanceAmount";
            this.cashAdvanceAmount.Size = new System.Drawing.Size(104, 27);
            this.cashAdvanceAmount.TabIndex = 44;
            this.cashAdvanceAmount.Text = "0";
            // 
            // cashAdvanceRequestLabel
            // 
            this.cashAdvanceRequestLabel.AutoSize = true;
            this.cashAdvanceRequestLabel.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashAdvanceRequestLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashAdvanceRequestLabel.Location = new System.Drawing.Point(16, 11);
            this.cashAdvanceRequestLabel.Name = "cashAdvanceRequestLabel";
            this.cashAdvanceRequestLabel.Size = new System.Drawing.Size(216, 21);
            this.cashAdvanceRequestLabel.TabIndex = 45;
            this.cashAdvanceRequestLabel.Text = "CASH ADVANCE REQUEST";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amountLabel.Location = new System.Drawing.Point(17, 102);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(62, 17);
            this.amountLabel.TabIndex = 46;
            this.amountLabel.Text = "Amount";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeName.Location = new System.Drawing.Point(133, 56);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(107, 15);
            this.employeeName.TabIndex = 50;
            this.employeeName.Text = "Last, First Middle";
            // 
            // employeeNumber
            // 
            this.employeeNumber.AutoSize = true;
            this.employeeNumber.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeNumber.Location = new System.Drawing.Point(133, 79);
            this.employeeNumber.Name = "employeeNumber";
            this.employeeNumber.Size = new System.Drawing.Size(103, 15);
            this.employeeNumber.TabIndex = 49;
            this.employeeNumber.Text = "123456789101";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeNameLabel.Location = new System.Drawing.Point(17, 56);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(97, 15);
            this.employeeNameLabel.TabIndex = 48;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.AutoSize = true;
            this.employeeNumberLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeNumberLabel.Location = new System.Drawing.Point(17, 79);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(110, 15);
            this.employeeNumberLabel.TabIndex = 47;
            this.employeeNumberLabel.Text = "Employee Number";
            // 
            // dateFiled
            // 
            this.dateFiled.AutoSize = true;
            this.dateFiled.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFiled.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateFiled.Location = new System.Drawing.Point(316, 17);
            this.dateFiled.Name = "dateFiled";
            this.dateFiled.Size = new System.Drawing.Size(83, 15);
            this.dateFiled.TabIndex = 52;
            this.dateFiled.Text = "01/22/2015";
            // 
            // dateFiledLabel
            // 
            this.dateFiledLabel.AutoSize = true;
            this.dateFiledLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFiledLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateFiledLabel.Location = new System.Drawing.Point(246, 17);
            this.dateFiledLabel.Name = "dateFiledLabel";
            this.dateFiledLabel.Size = new System.Drawing.Size(64, 15);
            this.dateFiledLabel.TabIndex = 51;
            this.dateFiledLabel.Text = "Date Filed";
            // 
            // cashAdvanceButton
            // 
            this.cashAdvanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cashAdvanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashAdvanceButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashAdvanceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashAdvanceButton.Location = new System.Drawing.Point(254, 98);
            this.cashAdvanceButton.Name = "cashAdvanceButton";
            this.cashAdvanceButton.Size = new System.Drawing.Size(134, 36);
            this.cashAdvanceButton.TabIndex = 53;
            this.cashAdvanceButton.Text = "Submit";
            this.cashAdvanceButton.UseVisualStyleBackColor = false;
            this.cashAdvanceButton.Click += new System.EventHandler(this.cashAdvanceButton_Click);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorMessageLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.errorMessageLabel.Location = new System.Drawing.Point(16, 269);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(41, 20);
            this.errorMessageLabel.TabIndex = 54;
            this.errorMessageLabel.Text = "Error";
            this.errorMessageLabel.Visible = false;
            // 
            // requestDescription
            // 
            this.requestDescription.Font = new System.Drawing.Font("Century", 12F);
            this.requestDescription.Location = new System.Drawing.Point(20, 143);
            this.requestDescription.Multiline = true;
            this.requestDescription.Name = "requestDescription";
            this.requestDescription.Size = new System.Drawing.Size(368, 123);
            this.requestDescription.TabIndex = 55;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionLabel.Location = new System.Drawing.Point(20, 125);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(48, 15);
            this.descriptionLabel.TabIndex = 56;
            this.descriptionLabel.Text = "Reason";
            // 
            // CashAdvanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(427, 350);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.cashAdvancePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashAdvanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CashAdvanceForm";
            this.cashAdvancePanel.ResumeLayout(false);
            this.cashAdvancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cashAdvancePanel;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.TextBox cashAdvanceAmount;
        private System.Windows.Forms.Label cashAdvanceRequestLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label employeeNumber;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Label dateFiled;
        private System.Windows.Forms.Label dateFiledLabel;
        private System.Windows.Forms.Button cashAdvanceButton;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox requestDescription;
    }
}