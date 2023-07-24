namespace TravelExpertsGUI
{
    partial class frmPackagesProductsSuppliers
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
            lvwIncludedProducts = new ListView();
            productID = new ColumnHeader();
            prodName = new ColumnHeader();
            supplierName = new ColumnHeader();
            lvwAvailableProducts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            lblInstructions = new Label();
            btnRemove = new Button();
            btnAdd = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lvwIncludedProducts
            // 
            lvwIncludedProducts.Columns.AddRange(new ColumnHeader[] { productID, prodName, supplierName });
            lvwIncludedProducts.FullRowSelect = true;
            lvwIncludedProducts.Location = new Point(48, 94);
            lvwIncludedProducts.MultiSelect = false;
            lvwIncludedProducts.Name = "lvwIncludedProducts";
            lvwIncludedProducts.Size = new Size(505, 616);
            lvwIncludedProducts.TabIndex = 5;
            lvwIncludedProducts.UseCompatibleStateImageBehavior = false;
            lvwIncludedProducts.View = View.Details;
            // 
            // productID
            // 
            productID.Text = "ID";
            // 
            // prodName
            // 
            prodName.Text = "Product";
            prodName.Width = 200;
            // 
            // supplierName
            // 
            supplierName.Text = "Supplier";
            supplierName.Width = 200;
            // 
            // lvwAvailableProducts
            // 
            lvwAvailableProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvwAvailableProducts.FullRowSelect = true;
            lvwAvailableProducts.Location = new Point(747, 94);
            lvwAvailableProducts.MultiSelect = false;
            lvwAvailableProducts.Name = "lvwAvailableProducts";
            lvwAvailableProducts.Size = new Size(704, 616);
            lvwAvailableProducts.TabIndex = 6;
            lvwAvailableProducts.UseCompatibleStateImageBehavior = false;
            lvwAvailableProducts.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Product";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Supplier";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Supplier ID";
            columnHeader3.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 38);
            label1.Name = "label1";
            label1.Size = new Size(499, 32);
            label1.TabIndex = 7;
            label1.Text = "Select a product to remove from the package";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(747, 38);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(137, 32);
            lblInstructions.TabIndex = 8;
            lblInstructions.Text = "Instructions";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(397, 738);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(150, 46);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(747, 738);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.Location = new Point(908, 828);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 11;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1102, 828);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 12;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmPackagesProductsSuppliers
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 886);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(lblInstructions);
            Controls.Add(label1);
            Controls.Add(lvwAvailableProducts);
            Controls.Add(lvwIncludedProducts);
            Name = "frmPackagesProductsSuppliers";
            Text = "frmPackagesProductsSuppliers";
            Load += frmPackagesProductsSuppliers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvwIncludedProducts;
        private ColumnHeader productID;
        private ColumnHeader prodName;
        private ListView lvwAvailableProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label1;
        private Label lblInstructions;
        private ColumnHeader supplierName;
        private ColumnHeader columnHeader3;
        private Button btnRemove;
        private Button btnAdd;
        private Button button1;
        private Button button2;
    }
}