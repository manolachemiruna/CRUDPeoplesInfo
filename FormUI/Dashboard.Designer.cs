namespace FormUI
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.emailAddressInsLabel = new System.Windows.Forms.Label();
            this.emailAddressInsText = new System.Windows.Forms.TextBox();
            this.phoneNumberInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsText = new System.Windows.Forms.TextBox();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneNumberUpdateText = new System.Windows.Forms.TextBox();
            this.emailAddressUpdateText = new System.Windows.Forms.TextBox();
            this.lastNameUpdateText = new System.Windows.Forms.TextBox();
            this.firstNameUpdateText = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.CNPInsText = new System.Windows.Forms.TextBox();
            this.CNPInsLabel = new System.Windows.Forms.Label();
            this.CNPUpdateText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUpdateText = new System.Windows.Forms.TextBox();
            this.textBoxStergText = new System.Windows.Forms.TextBox();
            this.CNPStergText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 25;
            this.peopleFoundListbox.Location = new System.Drawing.Point(50, 172);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(351, 104);
            this.peopleFoundListbox.TabIndex = 0;
            this.peopleFoundListbox.SelectedIndexChanged += new System.EventHandler(this.peopleFoundListbox_SelectedIndexChanged);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(179, 53);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(197, 31);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(38, 53);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(159, 97);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 42);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(38, 332);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(116, 25);
            this.firstNameInsLabel.TabIndex = 5;
            this.firstNameInsLabel.Text = "First Name";
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(204, 326);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(197, 31);
            this.firstNameInsText.TabIndex = 4;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(38, 366);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameInsLabel.TabIndex = 7;
            this.lastNameInsLabel.Text = "Last Name";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(204, 363);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(197, 31);
            this.lastNameInsText.TabIndex = 6;
            // 
            // emailAddressInsLabel
            // 
            this.emailAddressInsLabel.AutoSize = true;
            this.emailAddressInsLabel.Location = new System.Drawing.Point(29, 406);
            this.emailAddressInsLabel.Name = "emailAddressInsLabel";
            this.emailAddressInsLabel.Size = new System.Drawing.Size(150, 25);
            this.emailAddressInsLabel.TabIndex = 9;
            this.emailAddressInsLabel.Text = "Email Address";
            // 
            // emailAddressInsText
            // 
            this.emailAddressInsText.Location = new System.Drawing.Point(204, 400);
            this.emailAddressInsText.Name = "emailAddressInsText";
            this.emailAddressInsText.Size = new System.Drawing.Size(197, 31);
            this.emailAddressInsText.TabIndex = 8;
            // 
            // phoneNumberInsLabel
            // 
            this.phoneNumberInsLabel.AutoSize = true;
            this.phoneNumberInsLabel.Location = new System.Drawing.Point(29, 443);
            this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
            this.phoneNumberInsLabel.Size = new System.Drawing.Size(155, 25);
            this.phoneNumberInsLabel.TabIndex = 11;
            this.phoneNumberInsLabel.Text = "Phone Number";
            // 
            // phoneNumberInsText
            // 
            this.phoneNumberInsText.Location = new System.Drawing.Point(204, 437);
            this.phoneNumberInsText.Name = "phoneNumberInsText";
            this.phoneNumberInsText.Size = new System.Drawing.Size(197, 31);
            this.phoneNumberInsText.TabIndex = 10;
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(94, 531);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(133, 42);
            this.insertRecordButton.TabIndex = 12;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(740, 500);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(106, 31);
            this.Delete.TabIndex = 22;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Email Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(750, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Last Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(749, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "First Name";
            // 
            // phoneNumberUpdateText
            // 
            this.phoneNumberUpdateText.Location = new System.Drawing.Point(909, 225);
            this.phoneNumberUpdateText.Name = "phoneNumberUpdateText";
            this.phoneNumberUpdateText.Size = new System.Drawing.Size(100, 31);
            this.phoneNumberUpdateText.TabIndex = 27;
            // 
            // emailAddressUpdateText
            // 
            this.emailAddressUpdateText.Location = new System.Drawing.Point(909, 179);
            this.emailAddressUpdateText.Name = "emailAddressUpdateText";
            this.emailAddressUpdateText.Size = new System.Drawing.Size(100, 31);
            this.emailAddressUpdateText.TabIndex = 26;
            // 
            // lastNameUpdateText
            // 
            this.lastNameUpdateText.Location = new System.Drawing.Point(909, 85);
            this.lastNameUpdateText.Name = "lastNameUpdateText";
            this.lastNameUpdateText.Size = new System.Drawing.Size(100, 31);
            this.lastNameUpdateText.TabIndex = 25;
            this.lastNameUpdateText.TextChanged += new System.EventHandler(this.lastNameUpdateText_TextChanged);
            // 
            // firstNameUpdateText
            // 
            this.firstNameUpdateText.Location = new System.Drawing.Point(909, 131);
            this.firstNameUpdateText.Name = "firstNameUpdateText";
            this.firstNameUpdateText.Size = new System.Drawing.Size(100, 31);
            this.firstNameUpdateText.TabIndex = 24;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(740, 290);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(96, 36);
            this.UpdateButton.TabIndex = 32;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(50, 145);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(351, 31);
            this.textSearch.TabIndex = 33;
            // 
            // CNPInsText
            // 
            this.CNPInsText.Location = new System.Drawing.Point(204, 474);
            this.CNPInsText.Name = "CNPInsText";
            this.CNPInsText.Size = new System.Drawing.Size(197, 31);
            this.CNPInsText.TabIndex = 34;
            // 
            // CNPInsLabel
            // 
            this.CNPInsLabel.AutoSize = true;
            this.CNPInsLabel.Location = new System.Drawing.Point(61, 480);
            this.CNPInsLabel.Name = "CNPInsLabel";
            this.CNPInsLabel.Size = new System.Drawing.Size(56, 25);
            this.CNPInsLabel.TabIndex = 35;
            this.CNPInsLabel.Text = "CNP";
            // 
            // CNPUpdateText
            // 
            this.CNPUpdateText.Location = new System.Drawing.Point(909, 31);
            this.CNPUpdateText.Name = "CNPUpdateText";
            this.CNPUpdateText.Size = new System.Drawing.Size(100, 31);
            this.CNPUpdateText.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(764, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "CNP";
            // 
            // textBoxUpdateText
            // 
            this.textBoxUpdateText.Location = new System.Drawing.Point(909, 290);
            this.textBoxUpdateText.Name = "textBoxUpdateText";
            this.textBoxUpdateText.Size = new System.Drawing.Size(255, 31);
            this.textBoxUpdateText.TabIndex = 38;
            // 
            // textBoxStergText
            // 
            this.textBoxStergText.Location = new System.Drawing.Point(878, 500);
            this.textBoxStergText.Name = "textBoxStergText";
            this.textBoxStergText.Size = new System.Drawing.Size(262, 31);
            this.textBoxStergText.TabIndex = 39;
            // 
            // CNPStergText
            // 
            this.CNPStergText.Location = new System.Drawing.Point(878, 440);
            this.CNPStergText.Name = "CNPStergText";
            this.CNPStergText.Size = new System.Drawing.Size(100, 31);
            this.CNPStergText.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(749, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "CNP";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 673);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CNPStergText);
            this.Controls.Add(this.textBoxStergText);
            this.Controls.Add(this.textBoxUpdateText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CNPUpdateText);
            this.Controls.Add(this.CNPInsLabel);
            this.Controls.Add(this.CNPInsText);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phoneNumberUpdateText);
            this.Controls.Add(this.emailAddressUpdateText);
            this.Controls.Add(this.lastNameUpdateText);
            this.Controls.Add(this.firstNameUpdateText);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.phoneNumberInsLabel);
            this.Controls.Add(this.phoneNumberInsText);
            this.Controls.Add(this.emailAddressInsLabel);
            this.Controls.Add(this.emailAddressInsText);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label emailAddressInsLabel;
        private System.Windows.Forms.TextBox emailAddressInsText;
        private System.Windows.Forms.Label phoneNumberInsLabel;
        private System.Windows.Forms.TextBox phoneNumberInsText;
        private System.Windows.Forms.Button insertRecordButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneNumberUpdateText;
        private System.Windows.Forms.TextBox emailAddressUpdateText;
        private System.Windows.Forms.TextBox lastNameUpdateText;
        private System.Windows.Forms.TextBox firstNameUpdateText;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.TextBox CNPInsText;
        private System.Windows.Forms.Label CNPInsLabel;
        private System.Windows.Forms.TextBox CNPUpdateText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUpdateText;
        private System.Windows.Forms.TextBox textBoxStergText;
        private System.Windows.Forms.TextBox CNPStergText;
        private System.Windows.Forms.Label label10;
    }
}

