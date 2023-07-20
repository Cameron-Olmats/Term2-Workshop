﻿namespace TravelExpertsGUI
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
            btnTravelPackage.Location = new Point(15, 39);
            btnTravelPackage.Margin = new Padding(4);
            btnTravelPackage.Name = "btnTravelPackage";
            btnTravelPackage.Size = new Size(250, 32);
            btnTravelPackage.TabIndex = 0;
            btnTravelPackage.Text = "Edit Travel Packages";
            btnTravelPackage.UseVisualStyleBackColor = true;
            btnTravelPackage.Click += btnTravelPackage_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(15, 99);
            btnProducts.Margin = new Padding(4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(94, 29);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(171, 99);
            btnSuppliers.Margin = new Padding(4);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(94, 29);
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
            groupBox1.Location = new Point(281, 11);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(728, 571);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnLink
            // 
            btnLink.AutoSize = true;
            btnLink.Location = new Point(428, 518);
            btnLink.Margin = new Padding(2);
            btnLink.Name = "btnLink";
            btnLink.Size = new Size(94, 30);
            btnLink.TabIndex = 8;
            btnLink.Text = "btnLink";
            btnLink.UseVisualStyleBackColor = true;
            btnLink.Click += btnLink_Click;
            // 
            // dgvMain
            // 
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(24, 34);
            dgvMain.Margin = new Padding(4);
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersWidth = 82;
            dgvMain.RowTemplate.Height = 25;
            dgvMain.Size = new Size(631, 444);
            dgvMain.TabIndex = 7;
            dgvMain.CellClick += dgvMain_CellContentClick;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(172, 518);
            btnModify.Margin = new Padding(4);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(94, 29);
            btnModify.TabIndex = 6;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(300, 518);
            btnRemove.Margin = new Padding(4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 518);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(891, 615);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmTravelExperts
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1024, 659);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProducts);
            Controls.Add(btnTravelPackage);
            Margin = new Padding(2, 1, 2, 1);
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