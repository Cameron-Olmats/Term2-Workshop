namespace TravelExpertsGUI
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
            label2.Location = new Point(34, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 1;
            label2.Text = "Supplier Name:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(180, 32);
            tbxName.Margin = new Padding(4, 4, 4, 4);
            tbxName.MaxLength = 255;
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(505, 31);
            tbxName.TabIndex = 1;
            // 
            // btnAddAddress
            // 
            btnAddAddress.Location = new Point(34, 625);
            btnAddAddress.Margin = new Padding(4, 4, 4, 4);
            btnAddAddress.Name = "btnAddAddress";
            btnAddAddress.Size = new Size(178, 44);
            btnAddAddress.TabIndex = 4;
            btnAddAddress.Text = "New Address";
            btnAddAddress.UseVisualStyleBackColor = true;
            btnAddAddress.Click += btnAddAddress_Click;
            // 
            // btnDelAddress
            // 
            btnDelAddress.Location = new Point(34, 676);
            btnDelAddress.Margin = new Padding(4, 4, 4, 4);
            btnDelAddress.Name = "btnDelAddress";
            btnDelAddress.Size = new Size(178, 44);
            btnDelAddress.TabIndex = 5;
            btnDelAddress.Text = "Delete Address";
            btnDelAddress.UseVisualStyleBackColor = true;
            btnDelAddress.Click += btnDelAddress_Click;
            // 
            // lstBox
            // 
            lstBox.FormattingEnabled = true;
            lstBox.ItemHeight = 25;
            lstBox.Location = new Point(34, 102);
            lstBox.Margin = new Padding(4, 4, 4, 4);
            lstBox.Name = "lstBox";
            lstBox.Size = new Size(176, 504);
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
            groupBox1.Location = new Point(245, 90);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(838, 630);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contact Data - Highlighted is required";
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(340, 565);
            btnEnter.Margin = new Padding(4, 4, 4, 4);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(178, 44);
            btnEnter.TabIndex = 33;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // tbxWebsite
            // 
            tbxWebsite.Location = new Point(190, 510);
            tbxWebsite.Margin = new Padding(4, 4, 4, 4);
            tbxWebsite.MaxLength = 255;
            tbxWebsite.Name = "tbxWebsite";
            tbxWebsite.Size = new Size(439, 31);
            tbxWebsite.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(101, 514);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(79, 25);
            label16.TabIndex = 31;
            label16.Text = "Website:";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(190, 469);
            tbxEmail.Margin = new Padding(4, 4, 4, 4);
            tbxEmail.MaxLength = 255;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(439, 31);
            tbxEmail.TabIndex = 30;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.GradientInactiveCaption;
            label15.Location = new Point(121, 472);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(58, 25);
            label15.TabIndex = 29;
            label15.Text = "Email:";
            // 
            // tbxFax
            // 
            tbxFax.Location = new Point(494, 424);
            tbxFax.Margin = new Padding(4, 4, 4, 4);
            tbxFax.MaxLength = 50;
            tbxFax.Name = "tbxFax";
            tbxFax.Size = new Size(325, 31);
            tbxFax.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(445, 428);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(41, 25);
            label14.TabIndex = 27;
            label14.Text = "Fax:";
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(172, 424);
            tbxPhone.Margin = new Padding(4, 4, 4, 4);
            tbxPhone.MaxLength = 50;
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(232, 31);
            tbxPhone.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.GradientInactiveCaption;
            label13.Location = new Point(30, 428);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(134, 25);
            label13.TabIndex = 25;
            label13.Text = "Busness Phone:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(340, 382);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(152, 25);
            label12.TabIndex = 24;
            label12.Text = "Additional Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(358, 29);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(125, 25);
            label11.TabIndex = 23;
            label11.Text = "Contact Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(316, 156);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(217, 25);
            label10.TabIndex = 22;
            label10.Text = "Company Address Details";
            // 
            // tbxCountry
            // 
            tbxCountry.Location = new Point(509, 325);
            tbxCountry.Margin = new Padding(4, 4, 4, 4);
            tbxCountry.MaxLength = 255;
            tbxCountry.Name = "tbxCountry";
            tbxCountry.Size = new Size(288, 31);
            tbxCountry.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(422, 329);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 20;
            label9.Text = "Country:";
            // 
            // tbxPostal
            // 
            tbxPostal.Location = new Point(141, 325);
            tbxPostal.Margin = new Padding(4, 4, 4, 4);
            tbxPostal.MaxLength = 255;
            tbxPostal.Name = "tbxPostal";
            tbxPostal.Size = new Size(254, 31);
            tbxPostal.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 329);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 25);
            label8.TabIndex = 18;
            label8.Text = "Postal Code:";
            // 
            // tbxProvence
            // 
            tbxProvence.Location = new Point(520, 284);
            tbxProvence.Margin = new Padding(4, 4, 4, 4);
            tbxProvence.MaxLength = 255;
            tbxProvence.Name = "tbxProvence";
            tbxProvence.Size = new Size(276, 31);
            tbxProvence.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 288);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 16;
            label7.Text = "Provence:";
            // 
            // tbxCity
            // 
            tbxCity.Location = new Point(132, 284);
            tbxCity.Margin = new Padding(4, 4, 4, 4);
            tbxCity.MaxLength = 255;
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new Size(263, 31);
            tbxCity.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 288);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 14;
            label6.Text = "City Name:";
            // 
            // tbxAddress
            // 
            tbxAddress.Location = new Point(190, 242);
            tbxAddress.Margin = new Padding(4, 4, 4, 4);
            tbxAddress.MaxLength = 255;
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(439, 31);
            tbxAddress.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 246);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 12;
            label5.Text = "Company Address:";
            // 
            // tbxCompany
            // 
            tbxCompany.Location = new Point(190, 201);
            tbxCompany.Margin = new Padding(4, 4, 4, 4);
            tbxCompany.MaxLength = 255;
            tbxCompany.Name = "tbxCompany";
            tbxCompany.Size = new Size(439, 31);
            tbxCompany.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Location = new Point(34, 205);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 10;
            label4.Text = "Company Name:";
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(548, 82);
            tbxLastName.Margin = new Padding(4, 4, 4, 4);
            tbxLastName.MaxLength = 50;
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(263, 31);
            tbxLastName.TabIndex = 9;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(141, 82);
            tbxFirstName.Margin = new Padding(4, 4, 4, 4);
            tbxFirstName.MaxLength = 50;
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(263, 31);
            tbxFirstName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Location = new Point(438, 86);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.BackColor = SystemColors.GradientInactiveCaption;
            Label.Location = new Point(30, 86);
            Label.Margin = new Padding(4, 0, 4, 0);
            Label.Name = "Label";
            Label.Size = new Size(101, 25);
            Label.TabIndex = 0;
            Label.Text = "First Name:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(720, 28);
            btnConfirm.Margin = new Padding(4, 4, 4, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(178, 44);
            btnConfirm.TabIndex = 34;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(905, 28);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(178, 44);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmSuppliers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1114, 735);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(groupBox1);
            Controls.Add(lstBox);
            Controls.Add(btnDelAddress);
            Controls.Add(btnAddAddress);
            Controls.Add(tbxName);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
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