namespace TravelExpertsGUI
{
    partial class frmProductsSuppliers
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
            lblInstructions = new Label();
            lvwProducts = new ListView();
            prodID = new ColumnHeader();
            prodName = new ColumnHeader();
            btnAdd = new Button();
            btnRemove = new Button();
            lvwOfferedProducts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(732, 41);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(299, 32);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "Select a product to add to ";
            // 
            // lvwProducts
            // 
            lvwProducts.Columns.AddRange(new ColumnHeader[] { prodID, prodName });
            lvwProducts.FullRowSelect = true;
            lvwProducts.Location = new Point(783, 109);
            lvwProducts.MultiSelect = false;
            lvwProducts.Name = "lvwProducts";
            lvwProducts.Size = new Size(505, 616);
            lvwProducts.TabIndex = 1;
            lvwProducts.UseCompatibleStateImageBehavior = false;
            lvwProducts.View = View.Details;
            // 
            // prodID
            // 
            prodID.Text = "ID";
            // 
            // prodName
            // 
            prodName.Text = "Name";
            prodName.Width = 200;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(957, 760);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(194, 760);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(150, 46);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lvwOfferedProducts
            // 
            lvwOfferedProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvwOfferedProducts.FullRowSelect = true;
            lvwOfferedProducts.Location = new Point(40, 109);
            lvwOfferedProducts.MultiSelect = false;
            lvwOfferedProducts.Name = "lvwOfferedProducts";
            lvwOfferedProducts.Size = new Size(505, 616);
            lvwOfferedProducts.TabIndex = 4;
            lvwOfferedProducts.UseCompatibleStateImageBehavior = false;
            lvwOfferedProducts.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(403, 32);
            label1.TabIndex = 5;
            label1.Text = "Select an offered product to remove";
            // 
            // frmProductsSuppliers
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1362, 836);
            Controls.Add(label1);
            Controls.Add(lvwOfferedProducts);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lvwProducts);
            Controls.Add(lblInstructions);
            Name = "frmProductsSuppliers";
            Text = "frmProductsSuppliers";
            Load += frmProductsSuppliers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstructions;
        private ListView lvwProducts;
        private ColumnHeader prodID;
        private ColumnHeader prodName;
        private Button btnAdd;
        private Button btnRemove;
        private ListView lvwOfferedProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label1;
    }
}