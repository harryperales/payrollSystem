namespace PayrollSystem.view
{
    partial class MiscellaneousForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.miscType = new System.Windows.Forms.ComboBox();
            this.miscTypeLabel = new System.Windows.Forms.Label();
            this.miscDescription = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.addMiscButton = new System.Windows.Forms.Button();
            this.miscAmount = new System.Windows.Forms.TextBox();
            this.miscAmountLabel = new System.Windows.Forms.Label();
            this.miscName = new System.Windows.Forms.TextBox();
            this.miscDescriptionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.miscType);
            this.panel1.Controls.Add(this.miscTypeLabel);
            this.panel1.Controls.Add(this.miscDescription);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.addMiscButton);
            this.panel1.Controls.Add(this.miscAmount);
            this.panel1.Controls.Add(this.miscAmountLabel);
            this.panel1.Controls.Add(this.miscName);
            this.panel1.Controls.Add(this.miscDescriptionLabel);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 363);
            this.panel1.TabIndex = 0;
            // 
            // miscType
            // 
            this.miscType.FormattingEnabled = true;
            this.miscType.Items.AddRange(new object[] {
            "Benefit",
            "Deduction"});
            this.miscType.Location = new System.Drawing.Point(15, 269);
            this.miscType.Name = "miscType";
            this.miscType.Size = new System.Drawing.Size(257, 21);
            this.miscType.TabIndex = 8;
            // 
            // miscTypeLabel
            // 
            this.miscTypeLabel.AutoSize = true;
            this.miscTypeLabel.Location = new System.Drawing.Point(15, 245);
            this.miscTypeLabel.Name = "miscTypeLabel";
            this.miscTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.miscTypeLabel.TabIndex = 7;
            this.miscTypeLabel.Text = "Type";
            // 
            // miscDescription
            // 
            this.miscDescription.Location = new System.Drawing.Point(18, 96);
            this.miscDescription.Multiline = true;
            this.miscDescription.Name = "miscDescription";
            this.miscDescription.Size = new System.Drawing.Size(254, 77);
            this.miscDescription.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(15, 76);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description";
            // 
            // addMiscButton
            // 
            this.addMiscButton.Location = new System.Drawing.Point(109, 327);
            this.addMiscButton.Name = "addMiscButton";
            this.addMiscButton.Size = new System.Drawing.Size(75, 23);
            this.addMiscButton.TabIndex = 4;
            this.addMiscButton.Text = "Add";
            this.addMiscButton.UseVisualStyleBackColor = true;
            this.addMiscButton.Click += new System.EventHandler(this.addMiscButton_Click);
            // 
            // miscAmount
            // 
            this.miscAmount.Location = new System.Drawing.Point(16, 209);
            this.miscAmount.Name = "miscAmount";
            this.miscAmount.Size = new System.Drawing.Size(256, 20);
            this.miscAmount.TabIndex = 3;
            // 
            // miscAmountLabel
            // 
            this.miscAmountLabel.AutoSize = true;
            this.miscAmountLabel.Location = new System.Drawing.Point(13, 186);
            this.miscAmountLabel.Name = "miscAmountLabel";
            this.miscAmountLabel.Size = new System.Drawing.Size(43, 13);
            this.miscAmountLabel.TabIndex = 2;
            this.miscAmountLabel.Text = "Amount";
            // 
            // miscName
            // 
            this.miscName.Location = new System.Drawing.Point(16, 40);
            this.miscName.Name = "miscName";
            this.miscName.Size = new System.Drawing.Size(256, 20);
            this.miscName.TabIndex = 1;
            // 
            // miscDescriptionLabel
            // 
            this.miscDescriptionLabel.AutoSize = true;
            this.miscDescriptionLabel.Location = new System.Drawing.Point(13, 19);
            this.miscDescriptionLabel.Name = "miscDescriptionLabel";
            this.miscDescriptionLabel.Size = new System.Drawing.Size(161, 13);
            this.miscDescriptionLabel.TabIndex = 0;
            this.miscDescriptionLabel.Text = "Benefit/ Deductions Description:";
            // 
            // MiscellaneousForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 361);
            this.Controls.Add(this.panel1);
            this.Name = "MiscellaneousForm";
            this.Text = "MiscellaneousForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label miscDescriptionLabel;
        private System.Windows.Forms.Label miscAmountLabel;
        private System.Windows.Forms.TextBox miscName;
        private System.Windows.Forms.Button addMiscButton;
        private System.Windows.Forms.TextBox miscAmount;
        private System.Windows.Forms.TextBox miscDescription;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ComboBox miscType;
        private System.Windows.Forms.Label miscTypeLabel;
    }
}