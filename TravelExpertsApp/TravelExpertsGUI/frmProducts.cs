using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace TravelExpertsGUI
{
    public partial class frmProducts : Form
    {
        private List<Product> products;
        public Product SelectedProd;
        private Product modifiedProduct; // To track the modified product in the DataGridView

        public frmProducts()
        {
            InitializeComponent();
        }

        public frmProducts(Product selectedProd)
        {
            SelectedProd = selectedProd;
            InitializeComponent();
        }

        //public class Product
        //{
        //    public int ProdID { get; set; }
        //    public string ProdName { get; set; }
        //    public string ProdDesc { get; set; }
        //    public decimal BasePrice { get; set; }
        //    public decimal AgencyCommission { get; set; }
        //}

        private void LoadProducts()
        {
            // Fetch products from the database and populate the data grid view
            using (var dbContext = new TravelExpertsContext())
            {
                products = dbContext.Products.ToList();
            }

            dataGView_Prods.DataSource = products;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGView_Prods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < products.Count)
            {
                // Get the selected product from the data grid view
                SelectedProd = products[e.RowIndex];

                // Display the selected product's details in the text boxes
                txtProdID.Text = SelectedProd.ProductId.ToString();
                txtProdName.Text = SelectedProd.ProdName;
                // Add other TextBoxes to display other product details if needed
            }
            else if (e.RowIndex >= 0 && e.RowIndex < products.Count && e.ColumnIndex >= 0)
            {
                // Store the modified product in the DataGridView
                modifiedProduct = products[e.RowIndex];
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGView_Prods.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a product to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Open the frmModifyProduct form and pass the selected product as an argument
            frmProducts modifyForm = new frmProducts(SelectedProd);
            DialogResult result = modifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Reload products when the modification is successful
                LoadProducts();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            {
                if (modifiedProduct != null)
                {
                    // Save the modified product details back to the database
                    using (var dbContext = new TravelExpertsContext())
                    {
                        var existingProduct = dbContext.Products.Find(modifiedProduct.ProductId);
                        if (existingProduct != null)
                        {
                            // Update the product with the modified data
                            existingProduct.ProdName = modifiedProduct.ProdName;
                            // Update other product details here if needed
                            dbContext.SaveChanges();
                        }
                    }

                    // Clear the modifiedProduct variable after saving changes
                    modifiedProduct = null;

                    // Reload products when the modification is successful
                    LoadProducts();
                }
            }
        }
    }
}

