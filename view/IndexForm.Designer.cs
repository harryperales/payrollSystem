namespace PayrollSystem.view
{
    partial class IndexForm
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
            this.viewUsersButton = new System.Windows.Forms.Button();
            this.indexFormPanel = new System.Windows.Forms.Panel();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.indexFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewUsersButton
            // 
            this.viewUsersButton.Location = new System.Drawing.Point(172, 162);
            this.viewUsersButton.Name = "viewUsersButton";
            this.viewUsersButton.Size = new System.Drawing.Size(70, 36);
            this.viewUsersButton.TabIndex = 6;
            this.viewUsersButton.Text = "View All";
            this.viewUsersButton.UseVisualStyleBackColor = true;
            this.viewUsersButton.Click += new System.EventHandler(this.viewUsers_Click);
            // 
            // indexFormPanel
            // 
            this.indexFormPanel.Controls.Add(this.confirmPasswordLabel);
            this.indexFormPanel.Controls.Add(this.confirmPassword);
            this.indexFormPanel.Controls.Add(this.passwordLabel);
            this.indexFormPanel.Controls.Add(this.usernameLabel);
            this.indexFormPanel.Controls.Add(this.password);
            this.indexFormPanel.Controls.Add(this.username);
            this.indexFormPanel.Controls.Add(this.updateUserButton);
            this.indexFormPanel.Controls.Add(this.addUserButton);
            this.indexFormPanel.Controls.Add(this.viewUsersButton);
            this.indexFormPanel.Location = new System.Drawing.Point(12, 12);
            this.indexFormPanel.Name = "indexFormPanel";
            this.indexFormPanel.Size = new System.Drawing.Size(256, 231);
            this.indexFormPanel.TabIndex = 1;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(11, 125);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPasswordLabel.TabIndex = 8;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(105, 122);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(137, 20);
            this.confirmPassword.TabIndex = 3;
            this.confirmPassword.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(11, 89);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(11, 49);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(105, 86);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(137, 20);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(105, 46);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(137, 20);
            this.username.TabIndex = 1;
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(93, 162);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(70, 36);
            this.updateUserButton.TabIndex = 5;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(14, 162);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(70, 36);
            this.addUserButton.TabIndex = 4;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 255);
            this.Controls.Add(this.indexFormPanel);
            this.Name = "IndexForm";
            this.Text = "Payroll System";
            this.indexFormPanel.ResumeLayout(false);
            this.indexFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewUsersButton;
        private System.Windows.Forms.Panel indexFormPanel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPassword;
    }
}