namespace TravelExpertsGUI
{
    partial class frmPackages
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtStartDate = new TextBox();
            txtEndDate = new TextBox();
            txtDescription = new TextBox();
            txtBasePrice = new TextBox();
            txtAgencyCommission = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 124);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 218);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 299);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 2;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 407);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 3;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 514);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 4;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(160, 599);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 32);
            label6.TabIndex = 5;
            label6.Text = "Base Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 695);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(236, 32);
            label7.TabIndex = 6;
            label7.Text = "Agency Commission:";
            // 
            // txtID
            // 
            txtID.Location = new Point(379, 130);
            txtID.Margin = new Padding(6, 6, 6, 6);
            txtID.Name = "txtID";
            txtID.Size = new Size(182, 39);
            txtID.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(379, 211);
            txtName.Margin = new Padding(6, 6, 6, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 39);
            txtName.TabIndex = 8;
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new Point(357, 292);
            txtStartDate.Margin = new Padding(6, 6, 6, 6);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(182, 39);
            txtStartDate.TabIndex = 9;
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new Point(379, 401);
            txtEndDate.Margin = new Padding(6, 6, 6, 6);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(182, 39);
            txtEndDate.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(444, 518);
            txtDescription.Margin = new Padding(6, 6, 6, 6);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(182, 39);
            txtDescription.TabIndex = 11;
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(444, 606);
            txtBasePrice.Margin = new Padding(6, 6, 6, 6);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(182, 39);
            txtBasePrice.TabIndex = 12;
            // 
            // txtAgencyCommission
            // 
            txtAgencyCommission.Location = new Point(444, 695);
            txtAgencyCommission.Margin = new Padding(6, 6, 6, 6);
            txtAgencyCommission.Name = "txtAgencyCommission";
            txtAgencyCommission.Size = new Size(182, 39);
            txtAgencyCommission.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(163, 841);
            btnSubmit.Margin = new Padding(6, 6, 6, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(139, 49);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // frmPackages
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1486, 960);
            Controls.Add(btnSubmit);
            Controls.Add(txtAgencyCommission);
            Controls.Add(txtBasePrice);
            Controls.Add(txtDescription);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "frmPackages";
            Text = "Travel Packages";
            Load += frmPackages_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtStartDate;
        private TextBox txtEndDate;
        private TextBox txtDescription;
        private TextBox txtBasePrice;
        private TextBox txtAgencyCommission;
        private Button btnSubmit;
    }
}