﻿namespace TravelExpertsGUI
{
    partial class frmSuppliers
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
            label2 = new Label();
            tbxName = new TextBox();
            btnAddAddress = new Button();
            btnDelAddress = new Button();
            lstBox = new ListBox();
            groupBox1 = new GroupBox();
            btnEnter = new Button();
            tbxWebsite = new TextBox();
            label16 = new Label();
            tbxEmail = new TextBox();
            label15 = new Label();
            tbxFax = new TextBox();
            label14 = new Label();
            tbxPhone = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            tbxCountry = new TextBox();
            label9 = new Label();
            tbxPostal = new TextBox();
            label8 = new Label();
            tbxProvence = new TextBox();
            label7 = new Label();
            tbxCity = new TextBox();
            label6 = new Label();
            tbxAddress = new TextBox();
            label5 = new Label();
            tbxCompany = new TextBox();
            label4 = new Label();
            tbxLastName = new TextBox();
            tbxFirstName = new TextBox();
            label3 = new Label();
            Label = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 29);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Supplier Name:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(144, 26);
            tbxName.MaxLength = 255;
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(405, 27);
            tbxName.TabIndex = 1;
            // 
            // btnAddAddress
            // 
            btnAddAddress.Location = new Point(27, 500);
            btnAddAddress.Name = "btnAddAddress";
            btnAddAddress.Size = new Size(142, 35);
            btnAddAddress.TabIndex = 4;
            btnAddAddress.Text = "New Address";
            btnAddAddress.UseVisualStyleBackColor = true;
            btnAddAddress.Click += btnAddAddress_Click;
            // 
            // btnDelAddress
            // 
            btnDelAddress.Location = new Point(27, 541);
            btnDelAddress.Name = "btnDelAddress";
            btnDelAddress.Size = new Size(142, 35);
            btnDelAddress.TabIndex = 5;
            btnDelAddress.Text = "Delete Address";
            btnDelAddress.UseVisualStyleBackColor = true;
            btnDelAddress.Click += btnDelAddress_Click;
            // 
            // lstBox
            // 
            lstBox.FormattingEnabled = true;
            lstBox.ItemHeight = 20;
            lstBox.Location = new Point(27, 82);
            lstBox.Name = "lstBox";
            lstBox.Size = new Size(142, 404);
            lstBox.TabIndex = 6;
            lstBox.SelectedIndexChanged += lstBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEnter);
            groupBox1.Controls.Add(tbxWebsite);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(tbxEmail);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(tbxFax);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(tbxPhone);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(tbxCountry);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tbxPostal);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbxProvence);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbxCity);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbxAddress);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbxCompany);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbxLastName);
            groupBox1.Controls.Add(tbxFirstName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Label);
            groupBox1.Location = new Point(196, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(670, 504);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contact Data - Light blue is required";
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(272, 452);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(142, 35);
            btnEnter.TabIndex = 33;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // tbxWebsite
            // 
            tbxWebsite.Location = new Point(152, 408);
            tbxWebsite.MaxLength = 255;
            tbxWebsite.Name = "tbxWebsite";
            tbxWebsite.Size = new Size(352, 27);
            tbxWebsite.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(81, 411);
            label16.Name = "label16";
            label16.Size = new Size(65, 20);
            label16.TabIndex = 31;
            label16.Text = "Website:";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(152, 375);
            tbxEmail.MaxLength = 255;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(352, 27);
            tbxEmail.TabIndex = 30;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.GradientInactiveCaption;
            label15.Location = new Point(97, 378);
            label15.Name = "label15";
            label15.Size = new Size(49, 20);
            label15.TabIndex = 29;
            label15.Text = "Email:";
            // 
            // tbxFax
            // 
            tbxFax.Location = new Point(395, 339);
            tbxFax.MaxLength = 50;
            tbxFax.Name = "tbxFax";
            tbxFax.Size = new Size(261, 27);
            tbxFax.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(356, 342);
            label14.Name = "label14";
            label14.Size = new Size(33, 20);
            label14.TabIndex = 27;
            label14.Text = "Fax:";
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(138, 339);
            tbxPhone.MaxLength = 50;
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(186, 27);
            tbxPhone.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.GradientInactiveCaption;
            label13.Location = new Point(24, 342);
            label13.Name = "label13";
            label13.Size = new Size(108, 20);
            label13.TabIndex = 25;
            label13.Text = "Busness Phone:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(272, 306);
            label12.Name = "label12";
            label12.Size = new Size(129, 20);
            label12.TabIndex = 24;
            label12.Text = "Additional Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(286, 23);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 23;
            label11.Text = "Contact Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(253, 125);
            label10.Name = "label10";
            label10.Size = new Size(179, 20);
            label10.TabIndex = 22;
            label10.Text = "Company Address Details";
            // 
            // tbxCountry
            // 
            tbxCountry.Location = new Point(407, 260);
            tbxCountry.MaxLength = 255;
            tbxCountry.Name = "tbxCountry";
            tbxCountry.Size = new Size(231, 27);
            tbxCountry.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(338, 263);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 20;
            label9.Text = "Country:";
            // 
            // tbxPostal
            // 
            tbxPostal.Location = new Point(113, 260);
            tbxPostal.MaxLength = 255;
            tbxPostal.Name = "tbxPostal";
            tbxPostal.Size = new Size(204, 27);
            tbxPostal.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 263);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 18;
            label8.Text = "Postal Code:";
            // 
            // tbxProvence
            // 
            tbxProvence.Location = new Point(416, 227);
            tbxProvence.MaxLength = 255;
            tbxProvence.Name = "tbxProvence";
            tbxProvence.Size = new Size(222, 27);
            tbxProvence.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(338, 230);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 16;
            label7.Text = "Provence:";
            // 
            // tbxCity
            // 
            tbxCity.Location = new Point(106, 227);
            tbxCity.MaxLength = 255;
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new Size(211, 27);
            tbxCity.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 230);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 14;
            label6.Text = "City Name:";
            // 
            // tbxAddress
            // 
            tbxAddress.Location = new Point(152, 194);
            tbxAddress.MaxLength = 255;
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(352, 27);
            tbxAddress.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 197);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 12;
            label5.Text = "Company Address:";
            // 
            // tbxCompany
            // 
            tbxCompany.Location = new Point(152, 161);
            tbxCompany.MaxLength = 255;
            tbxCompany.Name = "tbxCompany";
            tbxCompany.Size = new Size(352, 27);
            tbxCompany.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Location = new Point(27, 164);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 10;
            label4.Text = "Company Name:";
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(438, 66);
            tbxLastName.MaxLength = 50;
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(211, 27);
            tbxLastName.TabIndex = 9;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(113, 66);
            tbxFirstName.MaxLength = 50;
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(211, 27);
            tbxFirstName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Location = new Point(350, 69);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.BackColor = SystemColors.GradientInactiveCaption;
            Label.Location = new Point(24, 69);
            Label.Name = "Label";
            Label.Size = new Size(83, 20);
            Label.TabIndex = 0;
            Label.Text = "First Name:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(576, 22);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(142, 35);
            btnConfirm.TabIndex = 34;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(724, 22);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 35);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 588);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(groupBox1);
            Controls.Add(lstBox);
            Controls.Add(btnDelAddress);
            Controls.Add(btnAddAddress);
            Controls.Add(tbxName);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSuppliers";
            Text = "frmSuppliers";
            Load += frmSuppliers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox tbxName;
        private Button btnAddAddress;
        private Button btnDelAddress;
        private ListBox lstBox;
        private GroupBox groupBox1;
        private TextBox tbxLastName;
        private TextBox tbxFirstName;
        private Label label3;
        private Label Label;
        private TextBox tbxCity;
        private Label label6;
        private TextBox tbxAddress;
        private Label label5;
        private TextBox tbxCompany;
        private Label label4;
        private TextBox tbxProvence;
        private Label label7;
        private Label label11;
        private Label label10;
        private TextBox tbxCountry;
        private Label label9;
        private TextBox tbxPostal;
        private Label label8;
        private Label label12;
        private TextBox tbxWebsite;
        private Label label16;
        private TextBox tbxEmail;
        private Label label15;
        private TextBox tbxFax;
        private Label label14;
        private TextBox tbxPhone;
        private Label label13;
        private Button btnEnter;
        private Button btnConfirm;
        private Button btnCancel;
    }
}