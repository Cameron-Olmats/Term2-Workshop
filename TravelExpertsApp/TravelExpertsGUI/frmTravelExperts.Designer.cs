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
            btnModify = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            btnExit = new Button();
            dgvMain = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // btnTravelPackage
            // 
            btnTravelPackage.Location = new Point(12, 31);
            btnTravelPackage.Name = "btnTravelPackage";
            btnTravelPackage.Size = new Size(200, 26);
            btnTravelPackage.TabIndex = 0;
            btnTravelPackage.Text = "Edit Travel Packages";
            btnTravelPackage.UseVisualStyleBackColor = true;
            btnTravelPackage.Click += btnTravelPackage_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(12, 79);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(75, 23);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(137, 79);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(75, 23);
            btnSuppliers.TabIndex = 2;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMain);
            groupBox1.Controls.Add(btnModify);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(225, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(582, 457);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnModify
            // 
            btnModify.Location = new Point(138, 414);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 6;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(240, 414);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 414);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(713, 492);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvMain
            // 
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(19, 27);
            dgvMain.Name = "dgvMain";
            dgvMain.RowTemplate.Height = 25;
            dgvMain.Size = new Size(505, 355);
            dgvMain.TabIndex = 7;
            // 
            // frmTravelExperts
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(819, 527);
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
    }
}