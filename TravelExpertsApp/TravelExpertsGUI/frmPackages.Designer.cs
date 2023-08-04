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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtStartDate = new TextBox();
            txtEndDate = new TextBox();
            txtDescription = new TextBox();
            txtBasePrice = new TextBox();
            txtAgencyCommission = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(32, 34);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(32, 96);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(32, 164);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(32, 229);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(32, 290);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 5;
            label6.Text = "Base Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(32, 344);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 6;
            label7.Text = "Agency Commission:";
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 30);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 27);
            txtName.TabIndex = 8;
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new Point(218, 96);
            txtStartDate.Margin = new Padding(3, 4, 3, 4);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(161, 27);
            txtStartDate.TabIndex = 9;
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new Point(218, 164);
            txtEndDate.Margin = new Padding(3, 4, 3, 4);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(161, 27);
            txtEndDate.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(218, 229);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(329, 27);
            txtDescription.TabIndex = 11;
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(218, 290);
            txtBasePrice.Margin = new Padding(3, 4, 3, 4);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(161, 27);
            txtBasePrice.TabIndex = 12;
            // 
            // txtAgencyCommission
            // 
            txtAgencyCommission.ForeColor = SystemColors.WindowText;
            txtAgencyCommission.Location = new Point(218, 340);
            txtAgencyCommission.Margin = new Padding(3, 4, 3, 4);
            txtAgencyCommission.Name = "txtAgencyCommission";
            txtAgencyCommission.Size = new Size(161, 27);
            txtAgencyCommission.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ButtonShadow;
            btnSubmit.ForeColor = SystemColors.ActiveCaptionText;
            btnSubmit.Location = new Point(106, 413);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(86, 31);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ButtonShadow;
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(246, 413);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonShadow;
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(389, 413);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 16;
            btnExit.Text = "Cancel";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmPackages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(576, 478);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtAgencyCommission);
            Controls.Add(txtBasePrice);
            Controls.Add(txtDescription);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = Color.Ivory;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPackages";
            Text = "Travel Packages";
            Load += frmPackages_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtStartDate;
        private TextBox txtEndDate;
        private TextBox txtDescription;
        private TextBox txtBasePrice;
        private TextBox txtAgencyCommission;
        private Button btnSubmit;
        private Button btnClear;
        private Button btnExit;
    }
}