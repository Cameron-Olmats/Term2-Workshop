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

/*
 *  Products form takes existing products from TravelExperts database, and puts them into grid-view box
 *  Users can select each cell to modify, create new cells to add, or select a cell and delete
 *  Validates for empty text fields, or unselected cell to modify/delete
 *  Date: 03 AUG 23
 *  Author: Nancy
 */
namespace TravelExpertsGUI
{
    public partial class frmProducts : Form
    {
        private List<Product> products;
        public Product SelectedProd; // To track the selected product in the DataGridView
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
            dataGView_Prods.ClearSelection(); // Clear the selection before loading products
            LoadProducts();
        }

        private void dataGView_Prods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < products.Count)
            {
                // Get the selected product from the data grid view
                modifiedProduct = products[e.RowIndex];

                // Display the selected product's details in the text boxes
                txtProdID.Text = modifiedProduct.ProductId.ToString();
                txtProdName.Text = modifiedProduct.ProdName;
            }
        }

        // Button Validations
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (modifiedProduct == null)
            {
                MessageBox.Show("Please select a product to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newName = txtProdName.Text;
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Product Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ModifyProduct();
        }

        private void ModifyProduct()
        {
            using (var dbContext = new TravelExpertsContext())
            {
                // Find the current product to be modified based on its ProductId
                Product currentProduct = dbContext.Products.Find(modifiedProduct.ProductId);

                // Check if the product with the specified ProductId exists in the database
                if (currentProduct != null)

                    // Update the ProdName property of the current product with the value from txtProdName control
                    currentProduct.ProdName = txtProdName.Text;
                dbContext.SaveChanges();
            }

            // Reload products when the addition is successful
            LoadProducts();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Gather the data from the input controls
            string productName = txtProdName.Text;

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Product Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new product instance and add it to the database
            Product newProduct = new Product
            {
                ProdName = productName
            };

            AddProduct(newProduct);
        }

        private void AddProduct(Product newProduct)
        {
            using (var dbContext = new TravelExpertsContext())
            {
                // Add the newProduct object to the Products DbSet in the context
                dbContext.Products.Add(newProduct);
                dbContext.SaveChanges();
            }

            // Reload products when the addition is successful
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if Name text box is  empty
            if (string.IsNullOrEmpty(txtProdName.Text))
            {
                MessageBox.Show("Please enter a valid Product Name to proceed with deletion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if a product is selected for deletion
            if (modifiedProduct == null)
            {
                MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion with user
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Deletion validation
            if (result == DialogResult.Yes)
            {
                // If user confirms deletion
                using (var dbContext = new TravelExpertsContext())
                {
                    // Find the existing product in the database based on its ProductId
                    var existingProduct = dbContext.Products.Find(modifiedProduct.ProductId);

                    // If the existing product is found
                    if (existingProduct != null)
                    {
                        try
                        {
                            dbContext.Products.Remove(existingProduct);
                            dbContext.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.GetType()}. {ex.Message}");

                        }
                    }
                }

                // Clear the selected product after deletion
                modifiedProduct = null;

                // Reload products after deletion
                LoadProducts();
            }
        }
    }
}

