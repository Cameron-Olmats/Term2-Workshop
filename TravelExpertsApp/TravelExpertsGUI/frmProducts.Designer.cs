namespace TravelExpertsGUI
{
    partial class frmProducts
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
            dataGView_Prods = new DataGridView();
            gboxAdd = new GroupBox();
            txtAgencyComm = new TextBox();
            lblAgencyComm = new Label();
            btnModify = new Button();
            btnSubmit = new Button();
            txtBPrice = new TextBox();
            txtPackDesc = new TextBox();
            txtEndDat = new TextBox();
            txtStarDate = new TextBox();
            txtProdName = new TextBox();
            lblBasPric = new Label();
            lblPackDesc = new Label();
            lblEndDate = new Label();
            lblStarDate = new Label();
            lblProdName = new Label();
            lblProdID = new Label();
            txtProdID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGView_Prods).BeginInit();
            gboxAdd.SuspendLayout();
            SuspendLayout();
            // 
            // dataGView_Prods
            // 
            dataGView_Prods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGView_Prods.Location = new Point(753, 65);
            dataGView_Prods.Name = "dataGView_Prods";
            dataGView_Prods.RowHeadersWidth = 51;
            dataGView_Prods.RowTemplate.Height = 29;
            dataGView_Prods.Size = new Size(394, 365);
            dataGView_Prods.TabIndex = 5;
            dataGView_Prods.CellClick += dataGView_Prods_CellClick;
            // 
            // gboxAdd
            // 
            gboxAdd.Controls.Add(txtAgencyComm);
            gboxAdd.Controls.Add(lblAgencyComm);
            gboxAdd.Controls.Add(btnModify);
            gboxAdd.Controls.Add(btnSubmit);
            gboxAdd.Controls.Add(txtBPrice);
            gboxAdd.Controls.Add(txtPackDesc);
            gboxAdd.Controls.Add(txtEndDat);
            gboxAdd.Controls.Add(txtStarDate);
            gboxAdd.Controls.Add(txtProdName);
            gboxAdd.Controls.Add(lblBasPric);
            gboxAdd.Controls.Add(lblPackDesc);
            gboxAdd.Controls.Add(lblEndDate);
            gboxAdd.Controls.Add(lblStarDate);
            gboxAdd.Controls.Add(lblProdName);
            gboxAdd.Location = new Point(12, 60);
            gboxAdd.Name = "gboxAdd";
            gboxAdd.Size = new Size(711, 377);
            gboxAdd.TabIndex = 4;
            gboxAdd.TabStop = false;
            gboxAdd.Text = "Add Product";
            // 
            // txtAgencyComm
            // 
            txtAgencyComm.Location = new Point(184, 305);
            txtAgencyComm.Name = "txtAgencyComm";
            txtAgencyComm.Size = new Size(479, 27);
            txtAgencyComm.TabIndex = 14;
            // 
            // lblAgencyComm
            // 
            lblAgencyComm.AutoSize = true;
            lblAgencyComm.Location = new Point(27, 305);
            lblAgencyComm.Name = "lblAgencyComm";
            lblAgencyComm.Size = new Size(93, 20);
            lblAgencyComm.TabIndex = 13;
            lblAgencyComm.Text = "Commission:";
            // 
            // btnModify
            // 
            btnModify.Location = new Point(399, 341);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(197, 29);
            btnModify.TabIndex = 12;
            btnModify.Text = "Modify Product";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(88, 341);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(197, 29);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit Product";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtBPrice
            // 
            txtBPrice.Location = new Point(184, 258);
            txtBPrice.Name = "txtBPrice";
            txtBPrice.Size = new Size(479, 27);
            txtBPrice.TabIndex = 10;
            // 
            // txtPackDesc
            // 
            txtPackDesc.Location = new Point(240, 201);
            txtPackDesc.Name = "txtPackDesc";
            txtPackDesc.Size = new Size(423, 27);
            txtPackDesc.TabIndex = 9;
            // 
            // txtEndDat
            // 
            txtEndDat.Location = new Point(184, 146);
            txtEndDat.Name = "txtEndDat";
            txtEndDat.Size = new Size(479, 27);
            txtEndDat.TabIndex = 8;
            // 
            // txtStarDate
            // 
            txtStarDate.Location = new Point(184, 88);
            txtStarDate.Name = "txtStarDate";
            txtStarDate.Size = new Size(479, 27);
            txtStarDate.TabIndex = 7;
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(184, 37);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(479, 27);
            txtProdName.TabIndex = 6;
            // 
            // lblBasPric
            // 
            lblBasPric.AutoSize = true;
            lblBasPric.Location = new Point(27, 261);
            lblBasPric.Name = "lblBasPric";
            lblBasPric.Size = new Size(79, 20);
            lblBasPric.TabIndex = 5;
            lblBasPric.Text = "Base Price:";
            // 
            // lblPackDesc
            // 
            lblPackDesc.AutoSize = true;
            lblPackDesc.Location = new Point(27, 204);
            lblPackDesc.Name = "lblPackDesc";
            lblPackDesc.Size = new Size(146, 20);
            lblPackDesc.TabIndex = 4;
            lblPackDesc.Text = "Package Description:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(27, 149);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(73, 20);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "End Date:";
            // 
            // lblStarDate
            // 
            lblStarDate.AutoSize = true;
            lblStarDate.Location = new Point(27, 91);
            lblStarDate.Name = "lblStarDate";
            lblStarDate.Size = new Size(79, 20);
            lblStarDate.TabIndex = 2;
            lblStarDate.Text = "Start Date:";
            // 
            // lblProdName
            // 
            lblProdName.AutoSize = true;
            lblProdName.Location = new Point(27, 40);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new Size(107, 20);
            lblProdName.TabIndex = 1;
            lblProdName.Text = "Product Name:";
            // 
            // lblProdID
            // 
            lblProdID.AutoSize = true;
            lblProdID.Location = new Point(100, 21);
            lblProdID.Name = "lblProdID";
            lblProdID.Size = new Size(82, 20);
            lblProdID.TabIndex = 15;
            lblProdID.Text = "Product ID:";
            // 
            // txtProdID
            // 
            txtProdID.Location = new Point(196, 18);
            txtProdID.Name = "txtProdID";
            txtProdID.Size = new Size(211, 27);
            txtProdID.TabIndex = 15;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1159, 449);
            Controls.Add(txtProdID);
            Controls.Add(lblProdID);
            Controls.Add(dataGView_Prods);
            Controls.Add(gboxAdd);
            Margin = new Padding(2);
            Name = "frmProducts";
            Text = "frmProducts";
            ((System.ComponentModel.ISupportInitialize)dataGView_Prods).EndInit();
            gboxAdd.ResumeLayout(false);
            gboxAdd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGView_Prods;
        private GroupBox gboxAdd;
        private Button btnModify;
        private Button btnSubmit;
        private TextBox txtBPrice;
        private TextBox txtPackDesc;
        private TextBox txtEndDat;
        private TextBox txtStarDate;
        private TextBox txtProdName;
        private Label lblBasPric;
        private Label lblPackDesc;
        private Label lblEndDate;
        private Label lblStarDate;
        private Label lblProdName;
        private TextBox txtAgencyComm;
        private Label lblAgencyComm;
        private Label lblProdID;
        private TextBox txtProdID;
    }
}