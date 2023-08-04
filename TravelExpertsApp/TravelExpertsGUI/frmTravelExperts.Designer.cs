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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTravelExperts));
            btnTravelPackage = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            grpData = new GroupBox();
            btnLink = new Button();
            dgvMain = new DataGridView();
            btnModify = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTravelPackage
            // 
            btnTravelPackage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnTravelPackage.Location = new Point(17, 200);
            btnTravelPackage.Margin = new Padding(4, 4, 4, 4);
            btnTravelPackage.Name = "btnTravelPackage";
            btnTravelPackage.Size = new Size(250, 101);
            btnTravelPackage.TabIndex = 0;
            btnTravelPackage.Text = "Edit Travel Packages";
            btnTravelPackage.UseVisualStyleBackColor = true;
            btnTravelPackage.Click += btnTravelPackage_Click;
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.Location = new Point(17, 346);
            btnProducts.Margin = new Padding(4, 4, 4, 4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(250, 101);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuppliers.Location = new Point(17, 490);
            btnSuppliers.Margin = new Padding(4, 4, 4, 4);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(250, 101);
            btnSuppliers.TabIndex = 2;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // grpData
            // 
            grpData.Controls.Add(btnLink);
            grpData.Controls.Add(dgvMain);
            grpData.Controls.Add(btnModify);
            grpData.Controls.Add(btnRemove);
            grpData.Controls.Add(btnAdd);
            grpData.Location = new Point(283, 172);
            grpData.Margin = new Padding(4, 4, 4, 4);
            grpData.Name = "grpData";
            grpData.Padding = new Padding(4, 4, 4, 4);
            grpData.Size = new Size(728, 571);
            grpData.TabIndex = 4;
            grpData.TabStop = false;
            // 
            // btnLink
            // 
            btnLink.AutoSize = true;
            btnLink.Location = new Point(428, 518);
            btnLink.Margin = new Padding(2, 2, 2, 2);
            btnLink.Name = "btnLink";
            btnLink.Size = new Size(103, 42);
            btnLink.TabIndex = 8;
            btnLink.Text = "btnLink";
            btnLink.UseVisualStyleBackColor = true;
            btnLink.Click += btnLink_Click;
            // 
            // dgvMain
            // 
            dgvMain.BackgroundColor = Color.FromArgb(60, 80, 99);
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(24, 34);
            dgvMain.Margin = new Padding(4, 4, 4, 4);
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
            btnModify.Margin = new Padding(4, 4, 4, 4);
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
            btnRemove.Margin = new Padding(4, 4, 4, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 518);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(888, 751);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -4);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1099, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmTravelExperts
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1034, 797);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(grpData);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProducts);
            Controls.Add(btnTravelPackage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmTravelExperts";
            Text = "Travel Experts";
            Load += frmTravelExperts_Load;
            grpData.ResumeLayout(false);
            grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTravelPackage;
        private Button btnProducts;
        private Button btnSuppliers;
        private GroupBox grpData;
        private Button btnModify;
        private Button btnRemove;
        private Button btnAdd;
        private Button btnExit;
        private DataGridView dgvMain;
        private Button btnLink;
        private PictureBox pictureBox1;
    }
}