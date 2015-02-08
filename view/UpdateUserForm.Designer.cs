namespace PayrollSystem.view
{
    partial class UpdateUserForm
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
            this.updateUserPanel = new System.Windows.Forms.Panel();
            this.clearButon = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.updateUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateUserPanel
            // 
            this.updateUserPanel.Controls.Add(this.clearButon);
            this.updateUserPanel.Controls.Add(this.updateButton);
            this.updateUserPanel.Controls.Add(this.confirmPasswordLabel);
            this.updateUserPanel.Controls.Add(this.confirmPassword);
            this.updateUserPanel.Controls.Add(this.passwordLabel);
            this.updateUserPanel.Controls.Add(this.password);
            this.updateUserPanel.Location = new System.Drawing.Point(13, 13);
            this.updateUserPanel.Name = "updateUserPanel";
            this.updateUserPanel.Size = new System.Drawing.Size(259, 184);
            this.updateUserPanel.TabIndex = 0;
            // 
            // clearButon
            // 
            this.clearButon.Location = new System.Drawing.Point(30, 128);
            this.clearButon.Name = "clearButon";
            this.clearButon.Size = new System.Drawing.Size(75, 23);
            this.clearButon.TabIndex = 4;
            this.clearButon.Text = "Clear";
            this.clearButon.UseVisualStyleBackColor = true;
            this.clearButon.Click += new System.EventHandler(this.clearButon_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(149, 128);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(9, 78);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPasswordLabel.TabIndex = 3;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(114, 75);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(130, 20);
            this.confirmPassword.TabIndex = 2;
            this.confirmPassword.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(9, 41);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(114, 38);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(130, 20);
            this.password.TabIndex = 0;
            this.password.UseSystemPasswordChar = true;
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.updateUserPanel);
            this.Name = "UpdateUserForm";
            this.Text = "Update Password";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateUserForm_FormClosed);
            this.updateUserPanel.ResumeLayout(false);
            this.updateUserPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updateUserPanel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button clearButon;
        private System.Windows.Forms.Button updateButton;
    }
}