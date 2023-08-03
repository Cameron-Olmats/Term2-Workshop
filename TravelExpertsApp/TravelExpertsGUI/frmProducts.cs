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

namespace TravelExpertsGUI
{
    public partial class frmProducts : Form
    {
        private List<Product> products;

        public frmProducts()
        {
            InitializeComponent();
        }

        public class Product
        {
            public int ProdID { get; set; }
            public string ProdName { get; set; }
            public string ProdDesc { get; set; }
            public decimal BasePrice { get; set; }
            public decimal AgencyCommission { get; set; }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            // Fetch products from the database and populate the data grid view
            products = FetchProducts();
            dataGView_Prods.DataSource = products;
        }
        private void AddProduct(Product newProduct)
        {
            using (var dbContext = new TravelExpertsContext())
            {
                dbContext.Products.Add(newProduct);
                dbContext.SaveChanges();
            }
            LoadProducts();
        }

        private void EditProduct(Product updatedProduct)
        {
            // Your code to update the existing product in the database using ADO.NET or Entity Framework
            // After successful update, update the products list and refresh the data grid view
            // Example (assuming you're using Entity Framework):
            using (var dbContext = new TravelExpertsContext())
            {
                var existingProduct = dbContext.Products.Find(updatedProduct.ProdID);
                if (existingProduct != null)
                {
                    existingProduct.Pkg = updatedProduct.ProdName;
                    existingProduct.Prod = updatedProduct.ProdDesc;
                    existingProduct. = updatedProduct.BasePrice;
                    existingProduct.AgencyCommission = updatedProduct.AgencyCommission;
                    dbContext.SaveChanges();
                }
            }
            LoadProducts();
        }


        // modify existing products in database
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Gather the data from the input controls
            string productName = txtProdName.Text;
            string productDescription = txtPackDesc.Text;
            decimal basePrice;
            decimal agencyCommission;

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productDescription))
            {
                MessageBox.Show("Package Name and Description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtBPrice.Text, out basePrice) || !decimal.TryParse(txtAgencyComm.Text, out agencyCommission))
            {
                MessageBox.Show("Invalid price values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (agencyCommission > basePrice)
            {
                MessageBox.Show("Agency Commission cannot be greater than Base Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new product instance with the updated data and edit it in the database
            Product updatedProduct = new Product
            {
                Prod = productId,
                ProductName = productName,
                ProductDescription = productDescription,
                BasePrice = basePrice,
                AgencyCommission = agencyCommission
            };

            EditProduct(updatedProduct);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // Gather the data from the input controls
            int productId;
            if (!int.TryParse(txtProdID.Text, out productId))
            {
                MessageBox.Show("Invalid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string productName = txtProdName.Text;
            string productDescription = txtPackDesc.Text;
            decimal basePrice;
            decimal agencyCommission;

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productDescription))
            {
                MessageBox.Show("Package Name and Description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtBPrice.Text, out basePrice) || !decimal.TryParse(txtAgencyComm.Text, out agencyCommission))
            {
                MessageBox.Show("Invalid price values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (agencyCommission > basePrice)
            {
                MessageBox.Show("Agency Commission cannot be greater than Base Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new product instance with the updated data and edit it in the database
            Product updatedProduct = new Product
            {
                ProductId = productId,
                ProductName = productName,
                ProductDescription = productDescription,
                BasePrice = basePrice,
                AgencyCommission = agencyCommission
            };

            EditProduct(updatedProduct);
        }

        // handles event of the data grid view to populate the input controls with the selected product data when the user wants to edit a product
        private void dataGView_Prods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGView_Prods.Rows[e.RowIndex];
                txtProdID.Text = row.Cells["ProductId"].Value.ToString();
                txtProdName.Text = row.Cells["ProductName"].Value.ToString();
                txtPackDesc.Text = row.Cells["ProductDescription"].Value.ToString();
                txtBPrice.Text = row.Cells["BasePrice"].Value.ToString();
                txtAgencyComm.Text = row.Cells["AgencyCommission"].Value.ToString();
            }
        }
    }
}