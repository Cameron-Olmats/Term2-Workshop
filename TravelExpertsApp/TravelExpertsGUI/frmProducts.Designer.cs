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
			btnDelete = new Button();
			btnModify = new Button();
			btnSubmit = new Button();
			txtProdName = new TextBox();
			lblProdName = new Label();
			lblProdID = new Label();
			txtProdID = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGView_Prods).BeginInit();
			gboxAdd.SuspendLayout();
			SuspendLayout();
			// 
			// dataGView_Prods
			// 
			dataGView_Prods.BorderStyle = BorderStyle.Fixed3D;
			dataGView_Prods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGView_Prods.Location = new Point(27, 88);
			dataGView_Prods.Name = "dataGView_Prods";
			dataGView_Prods.RowHeadersWidth = 51;
			dataGView_Prods.RowTemplate.Height = 29;
			dataGView_Prods.Size = new Size(636, 217);
			dataGView_Prods.TabIndex = 5;
			dataGView_Prods.CellClick += dataGView_Prods_CellClick;
			// 
			// gboxAdd
			// 
			gboxAdd.Controls.Add(btnDelete);
			gboxAdd.Controls.Add(btnModify);
			gboxAdd.Controls.Add(dataGView_Prods);
			gboxAdd.Controls.Add(btnSubmit);
			gboxAdd.Controls.Add(txtProdName);
			gboxAdd.Controls.Add(lblProdName);
			gboxAdd.Location = new Point(12, 60);
			gboxAdd.Name = "gboxAdd";
			gboxAdd.Size = new Size(711, 377);
			gboxAdd.TabIndex = 4;
			gboxAdd.TabStop = false;
			gboxAdd.Text = "Add Product";
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(473, 329);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(158, 29);
			btnDelete.TabIndex = 15;
			btnDelete.Text = "Delete Product";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnModify
			// 
			btnModify.Location = new Point(263, 329);
			btnModify.Name = "btnModify";
			btnModify.Size = new Size(158, 29);
			btnModify.TabIndex = 12;
			btnModify.Text = "Modify Product";
			btnModify.UseVisualStyleBackColor = true;
			btnModify.Click += btnModify_Click;
			// 
			// btnSubmit
			// 
			btnSubmit.Location = new Point(62, 329);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(146, 29);
			btnSubmit.TabIndex = 11;
			btnSubmit.Text = "Add Product";
			btnSubmit.UseVisualStyleBackColor = true;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// txtProdName
			// 
			txtProdName.Location = new Point(184, 37);
			txtProdName.Name = "txtProdName";
			txtProdName.Size = new Size(479, 27);
			txtProdName.TabIndex = 6;
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
			ClientSize = new Size(736, 449);
			Controls.Add(txtProdID);
			Controls.Add(lblProdID);
			Controls.Add(gboxAdd);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Margin = new Padding(2);
			MaximizeBox = false;
			Name = "frmProducts";
			Text = "frmProducts";
			Load += frmProducts_Load;
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
		private TextBox txtProdName;
		private Label lblProdName;
		private Label lblProdID;
		private TextBox txtProdID;
		private Button btnDelete;
	}
}