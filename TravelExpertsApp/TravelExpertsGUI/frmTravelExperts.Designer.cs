namespace TravelExpertsGUI
{
    partial class frmTravelExperts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTravelPackage = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            groupBox1 = new GroupBox();
            btnLink = new Button();
            dgvMain = new DataGridView();
            btnModify = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // btnTravelPackage
            // 
            btnTravelPackage.Location = new Point(24, 62);
            btnTravelPackage.Margin = new Padding(6);
            btnTravelPackage.Name = "btnTravelPackage";
            btnTravelPackage.Size = new Size(400, 52);
            btnTravelPackage.TabIndex = 0;
            btnTravelPackage.Text = "Edit Travel Packages";
            btnTravelPackage.UseVisualStyleBackColor = true;
            btnTravelPackage.Click += btnTravelPackage_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(24, 158);
            btnProducts.Margin = new Padding(6);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(150, 46);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(274, 158);
            btnSuppliers.Margin = new Padding(6);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(150, 46);
            btnSuppliers.TabIndex = 2;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLink);
            groupBox1.Controls.Add(dgvMain);
            groupBox1.Controls.Add(btnModify);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(450, 18);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(1164, 914);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnLink
            // 
            btnLink.AutoSize = true;
            btnLink.Location = new Point(684, 828);
            btnLink.Name = "btnLink";
            btnLink.Size = new Size(150, 46);
            btnLink.TabIndex = 8;
            btnLink.Text = "btnLink";
            btnLink.UseVisualStyleBackColor = true;
            btnLink.Click += btnLink_Click;
            // 
            // dgvMain
            // 
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(38, 54);
            dgvMain.Margin = new Padding(6);
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersWidth = 82;
            dgvMain.RowTemplate.Height = 25;
            dgvMain.Size = new Size(1010, 710);
            dgvMain.TabIndex = 7;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(276, 828);
            btnModify.Margin = new Padding(6);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(150, 46);
            btnModify.TabIndex = 6;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(480, 828);
            btnRemove.Margin = new Padding(6);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(150, 46);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(60, 828);
            btnAdd.Margin = new Padding(6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1426, 984);
            btnExit.Margin = new Padding(6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmTravelExperts
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1638, 1054);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProducts);
            Controls.Add(btnTravelPackage);
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmTravelExperts";
            Text = "Travel Experts";
            Load += frmTravelExperts_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTravelPackage;
        private Button btnProducts;
        private Button btnSuppliers;
        private GroupBox groupBox1;
        private Button btnModify;
        private Button btnRemove;
        private Button btnAdd;
        private Button btnExit;
        private DataGridView dgvMain;
        private Button btnLink;
    }
}