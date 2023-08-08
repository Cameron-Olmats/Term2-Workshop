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
            txtDescription = new TextBox();
            txtBasePrice = new TextBox();
            txtAgencyCommission = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            btnExit = new Button();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(52, 54);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(52, 154);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 2;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(52, 262);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 3;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(52, 366);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 4;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(52, 464);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 32);
            label6.TabIndex = 5;
            label6.Text = "Base Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(52, 578);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(236, 32);
            label7.TabIndex = 6;
            label7.Text = "Agency Commission:";
            // 
            // txtName
            // 
            txtName.Location = new Point(354, 48);
            txtName.Margin = new Padding(5, 6, 5, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(532, 39);
            txtName.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(354, 366);
            txtDescription.Margin = new Padding(5, 6, 5, 6);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(532, 39);
            txtDescription.TabIndex = 11;
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(354, 464);
            txtBasePrice.Margin = new Padding(5, 6, 5, 6);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(532, 39);
            txtBasePrice.TabIndex = 12;
            txtBasePrice.Tag = "Base Price";
            // 
            // txtAgencyCommission
            // 
            txtAgencyCommission.ForeColor = SystemColors.WindowText;
            txtAgencyCommission.Location = new Point(354, 573);
            txtAgencyCommission.Margin = new Padding(5, 6, 5, 6);
            txtAgencyCommission.Name = "txtAgencyCommission";
            txtAgencyCommission.Size = new Size(532, 39);
            txtAgencyCommission.TabIndex = 13;
            txtAgencyCommission.Tag = "Agency Commission";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ButtonShadow;
            btnSubmit.ForeColor = SystemColors.ActiveCaptionText;
            btnSubmit.Location = new Point(169, 675);
            btnSubmit.Margin = new Padding(5, 6, 5, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(140, 50);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ButtonShadow;
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(400, 675);
            btnClear.Margin = new Padding(5, 6, 5, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 50);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonShadow;
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(618, 675);
            btnExit.Margin = new Padding(5, 6, 5, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 50);
            btnExit.TabIndex = 16;
            btnExit.Text = "Cancel";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(354, 146);
            dtpStart.Margin = new Padding(5);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(532, 39);
            dtpStart.TabIndex = 17;
            dtpStart.Tag = "Start Date";
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(354, 250);
            dtpEnd.Margin = new Padding(5);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(532, 39);
            dtpEnd.TabIndex = 18;
            dtpEnd.Tag = "End Date";
            // 
            // frmPackages
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(936, 765);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtAgencyCommission);
            Controls.Add(txtBasePrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = Color.Ivory;
            Margin = new Padding(5, 6, 5, 6);
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
        private TextBox txtDescription;
        private TextBox txtBasePrice;
        private TextBox txtAgencyCommission;
        private Button btnSubmit;
        private Button btnClear;
        private Button btnExit;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
    }
}