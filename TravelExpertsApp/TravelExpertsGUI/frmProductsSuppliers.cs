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


        private void UpdateOfferedProductList()
        {
            int suppID = selectedSupplier.SupplierId;
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
                    .ToList();

                for (int i = 0; i < query.Count; i++)
                {
                    ListViewItem nextItem =
                        new ListViewItem(query[i].ProductId.ToString());
                    nextItem.SubItems.Add(query[i].ProdName);
                    lvwOfferedProducts.Items.Add(nextItem);
                }
            }

        }

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

                    DialogResult result = MessageBox.Show(
                        $"do you want to add {prodToAdd.ProdName} to {selectedSupplier.SupName}?",
                        "confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
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
                if ((query.Count > 0) && (query != null))
                {
                    linkToDelete = query.FirstOrDefault();
                    db.ProductsSuppliers.Remove(linkToDelete);
                    db.SaveChanges();
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
            Application.Exit();
        }
    }
}
