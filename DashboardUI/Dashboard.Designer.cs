namespace DashboardUI
{
    partial class Dashboard
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
            this.createUserLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.errorListBox = new System.Windows.Forms.ListBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.accountBalanceLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.errorListLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.accountBalanceText = new System.Windows.Forms.TextBox();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // createUserLabel
            // 
            this.createUserLabel.AutoSize = true;
            this.createUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserLabel.Location = new System.Drawing.Point(77, 37);
            this.createUserLabel.Name = "createUserLabel";
            this.createUserLabel.Size = new System.Drawing.Size(235, 44);
            this.createUserLabel.TabIndex = 0;
            this.createUserLabel.Text = "Create User";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(301, 141);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(282, 38);
            this.firstNameText.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(196, 402);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(293, 85);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // errorListBox
            // 
            this.errorListBox.FormattingEnabled = true;
            this.errorListBox.ItemHeight = 31;
            this.errorListBox.Location = new System.Drawing.Point(637, 130);
            this.errorListBox.Name = "errorListBox";
            this.errorListBox.Size = new System.Drawing.Size(701, 314);
            this.errorListBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(37, 144);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(152, 32);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(38, 197);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(151, 32);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name";
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.AutoSize = true;
            this.accountBalanceLabel.Location = new System.Drawing.Point(37, 250);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(229, 32);
            this.accountBalanceLabel.TabIndex = 6;
            this.accountBalanceLabel.Text = "Account Balance";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(38, 303);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(172, 32);
            this.dobLabel.TabIndex = 7;
            this.dobLabel.Text = "Date of Birth";
            // 
            // errorListLabel
            // 
            this.errorListLabel.AutoSize = true;
            this.errorListLabel.Location = new System.Drawing.Point(631, 86);
            this.errorListLabel.Name = "errorListLabel";
            this.errorListLabel.Size = new System.Drawing.Size(129, 32);
            this.errorListLabel.TabIndex = 8;
            this.errorListLabel.Text = "Error List";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(301, 194);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(282, 38);
            this.lastNameText.TabIndex = 9;
            // 
            // accountBalanceText
            // 
            this.accountBalanceText.Location = new System.Drawing.Point(301, 247);
            this.accountBalanceText.Name = "accountBalanceText";
            this.accountBalanceText.Size = new System.Drawing.Size(282, 38);
            this.accountBalanceText.TabIndex = 10;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.CustomFormat = "";
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(301, 297);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(282, 38);
            this.dateOfBirthPicker.TabIndex = 11;
            this.dateOfBirthPicker.Value = new System.DateTime(2020, 7, 4, 11, 57, 34, 0);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 557);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.accountBalanceText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.errorListLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.accountBalanceLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.errorListBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.createUserLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createUserLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ListBox errorListBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label accountBalanceLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label errorListLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox accountBalanceText;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
    }
}