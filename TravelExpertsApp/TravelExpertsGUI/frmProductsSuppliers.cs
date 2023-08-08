/*
 * Form for adding exixsting products to a selected supplier
 * 
 * Author: Cameron Olmats
 * Date created: 2023-07-19
 */


using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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

namespace TravelExpertsGUI
{
    public partial class frmProductsSuppliers : Form
    {
        public Supplier selectedSupplier;

        public frmProductsSuppliers()
        {
            InitializeComponent();
        }

        private void frmProductsSuppliers_Load(object sender, EventArgs e)
        {
            lblInstructions.Text =
                $"Please select a product to add to {selectedSupplier.SupName}";
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                foreach (Product p in db.Products.ToList())
                {
                    ListViewItem nextItem = new ListViewItem(p.ProductId.ToString());
                    nextItem.SubItems.Add(p.ProdName);

                    lvwProducts.Items.Add(nextItem);
                }
            }

            UpdateOfferedProductList();
        }



        /// <summary>
        /// Updates the list of products that are offered by the supplier.
        /// </summary>
        private void UpdateOfferedProductList()
        {
            int suppID = selectedSupplier.SupplierId; 
            // selected supplier is set by the main form when frmProductsSuppliers is created.
            lvwOfferedProducts.Items.Clear();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var query = db.Products
                    .Join(db.ProductsSuppliers,
                        p => p.ProductId,
                        ps => ps.ProductId,
                        (p, ps) => new { p.ProductId, p.ProdName, ps.SupplierId })
                    .Where(ps => ps.SupplierId == suppID)
                    .OrderBy(pps => pps.ProductId)
                    .ToList(); // get productID, Name, and SupplierID from the selected supplier.

                for (int i = 0; i < query.Count; i++) // add each item to the list
                {
                    ListViewItem nextItem =
                        new ListViewItem(query[i].ProductId.ToString());
                    nextItem.SubItems.Add(query[i].ProdName);
                    lvwOfferedProducts.Items.Add(nextItem);
                }
            }

        }


        // Add the selected product to the current supplier
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check that there is a selected product
            if (lvwProducts.SelectedItems.Count == 0)
            {
                return;
            }
            int selectedIndex = lvwProducts.SelectedIndices[0];
            //get selected product
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                List<Product> products = db.Products.ToList();
                Product prodToAdd = products.ToList()[selectedIndex];

                if (prodToAdd != null)
                {
                    foreach (ListViewItem i in lvwOfferedProducts.Items)
                    {
                        if (Convert.ToInt32(i.Text) == prodToAdd.ProductId) //check that it's not already offered
                        {
                            MessageBox.Show("The selected product is already offered");
                            return;
                        }
                    }
                    //add it to the products that the supplier offers if it isn't offered



                    ProductsSupplier nextLink = new ProductsSupplier();
                    nextLink.ProductId = prodToAdd.ProductId;
                    nextLink.SupplierId = selectedSupplier.SupplierId;

                    //Have the user confirm the choice
                    DialogResult result = MessageBox.Show(
                        $"do you want to add {prodToAdd.ProdName} to {selectedSupplier.SupName}?",
                        "confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) // if yes add to database
                    {
                        db.ProductsSuppliers.Add(nextLink);
                        db.SaveChanges();
                        //MessageBox.Show("Success");
                    }
                }

            }
            //update offered products list
            UpdateOfferedProductList();
            return;
        }


        // remove the selected product from the current supplier
        private void btnRemove_Click(object sender, EventArgs e)
        {

            // check that there are products to delete
            if (lvwOfferedProducts.Items.Count == 0)
            {
                MessageBox.Show("There are no products to delete");
                return;
            }
            // check that there is a selected product
            if (lvwOfferedProducts.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a product to delete");
                return;
            }

            int selectedIndex = lvwOfferedProducts.SelectedIndices[0];
            // delete link
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                ProductsSupplier linkToDelete;
                var query = db.ProductsSuppliers
                    .Where(p => (p.SupplierId == selectedSupplier.SupplierId)
                    && (p.ProductId == Convert.ToInt32(lvwOfferedProducts.Items[selectedIndex].Text)))
                    .ToList();
               
                // get the product of the ProdSup that you are removing.
                // For using it's ProdName in the confirmation message.
                
               


                if ((query.Count > 0) && (query != null)) // make sure that the query isn't null or zero at this point.
                {
                    String prodNameToRemove = db.ProductsSuppliers // the name of the product to remove
                        .Include(ps => ps.Product)
                        .Select(ps => ps.Product.ProdName)
                        .FirstOrDefault();

                    linkToDelete = query.FirstOrDefault(); // the entry to remove from ProductSupplier
                    DialogResult result = MessageBox.Show(
                       $"do you want to remove {prodNameToRemove} from {selectedSupplier.SupName}?",
                       "confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) // if yes add to database
                    {
                        try
                        {
                            db.ProductsSuppliers.Remove(linkToDelete);
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error while removing product from supplier: {ex.GetType()}. {ex.InnerException.Message}");
                        }

                    }
                }
                else
                {
                    // error message that the user should never see. For testing just in case
                    MessageBox.Show("Deletion unsuccessful. Query returned no results");
                }
            }
            // update offered products list
            UpdateOfferedProductList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
