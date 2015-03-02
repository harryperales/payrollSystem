namespace PayrollSystem.view
{
    partial class PositionForm
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
            this.positionNameLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createPositionButton = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.TextBox();
            this.positionName = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateSalary = new System.Windows.Forms.TextBox();
            this.updatePositionNameLabel = new System.Windows.Forms.Label();
            this.updateSalaryLabel = new System.Windows.Forms.Label();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // positionNameLabel
            // 
            this.positionNameLabel.AutoSize = true;
            this.positionNameLabel.Location = new System.Drawing.Point(30, 40);
            this.positionNameLabel.Name = "positionNameLabel";
            this.positionNameLabel.Size = new System.Drawing.Size(78, 13);
            this.positionNameLabel.TabIndex = 0;
            this.positionNameLabel.Text = "Position Name:";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(29, 70);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 1;
            this.salaryLabel.Text = "Salary";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.positionComboBox);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.updateSalary);
            this.panel1.Controls.Add(this.updatePositionNameLabel);
            this.panel1.Controls.Add(this.updateSalaryLabel);
            this.panel1.Controls.Add(this.createPositionButton);
            this.panel1.Controls.Add(this.salary);
            this.panel1.Controls.Add(this.positionName);
            this.panel1.Controls.Add(this.positionNameLabel);
            this.panel1.Controls.Add(this.salaryLabel);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 297);
            this.panel1.TabIndex = 2;
            // 
            // createPositionButton
            // 
            this.createPositionButton.Location = new System.Drawing.Point(69, 109);
            this.createPositionButton.Name = "createPositionButton";
            this.createPositionButton.Size = new System.Drawing.Size(130, 23);
            this.createPositionButton.TabIndex = 4;
            this.createPositionButton.Text = "Create Position";
            this.createPositionButton.UseVisualStyleBackColor = true;
            this.createPositionButton.Click += new System.EventHandler(this.createPositionButton_Click);
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(114, 67);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(126, 20);
            this.salary.TabIndex = 3;
            // 
            // positionName
            // 
            this.positionName.Location = new System.Drawing.Point(114, 39);
            this.positionName.Name = "positionName";
            this.positionName.Size = new System.Drawing.Size(126, 20);
            this.positionName.TabIndex = 2;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(69, 235);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(130, 23);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateSalary
            // 
            this.updateSalary.Location = new System.Drawing.Point(114, 193);
            this.updateSalary.Name = "updateSalary";
            this.updateSalary.Size = new System.Drawing.Size(126, 20);
            this.updateSalary.TabIndex = 8;
            // 
            // updatePositionNameLabel
            // 
            this.updatePositionNameLabel.AutoSize = true;
            this.updatePositionNameLabel.Location = new System.Drawing.Point(30, 166);
            this.updatePositionNameLabel.Name = "updatePositionNameLabel";
            this.updatePositionNameLabel.Size = new System.Drawing.Size(78, 13);
            this.updatePositionNameLabel.TabIndex = 5;
            this.updatePositionNameLabel.Text = "Position Name:";
            // 
            // updateSalaryLabel
            // 
            this.updateSalaryLabel.AutoSize = true;
            this.updateSalaryLabel.Location = new System.Drawing.Point(29, 196);
            this.updateSalaryLabel.Name = "updateSalaryLabel";
            this.updateSalaryLabel.Size = new System.Drawing.Size(36, 13);
            this.updateSalaryLabel.TabIndex = 6;
            this.updateSalaryLabel.Text = "Salary";
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(114, 163);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(121, 21);
            this.positionComboBox.TabIndex = 10;
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 301);
            this.Controls.Add(this.panel1);
            this.Name = "PositionForm";
            this.Text = "Position";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label positionNameLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox positionName;
        private System.Windows.Forms.Button createPositionButton;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateSalary;
        private System.Windows.Forms.Label updatePositionNameLabel;
        private System.Windows.Forms.Label updateSalaryLabel;
        private System.Windows.Forms.ComboBox positionComboBox;

    }
}