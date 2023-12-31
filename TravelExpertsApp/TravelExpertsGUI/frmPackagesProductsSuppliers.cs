﻿/*
 * Form for adding products-suppliers to a travel package
 * 
 * Author: Cameron Olmats
 * Date-Created: 2023-07-20
 */

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace TravelExpertsGUI
{
    public partial class frmPackagesProductsSuppliers : Form
    {
        public TravelExpertsData.Package selectedPackage; // passed in from the main form.
        private List<Int32> includedProductSupplierIds = new List<Int32>(); // list of ProdSupIds that
                                                                            // are already included
                                                                            // in the current package

        private List<Int32> offeredProductSupplierIds = new List<Int32>(); // List of all ProdSupIds that
                                                                           // are available to put in
                                                                           // a travel package

        //private List<PackagesProductsSupplier> packprodsups = new List<PackagesProductsSupplier>();
        //private List<ProductsSupplier> prodSups = new List<ProductsSupplier>();

        public frmPackagesProductsSuppliers()
        {
            InitializeComponent();
        }

        
        private void frmPackagesProductsSuppliers_Load(object sender, EventArgs e)
        {
            lblInstructions.Text = $"Select a product to add to {selectedPackage.PkgName}";
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                UpdateIncludedProductsList(db); // update the products included in the current package 
                offeredProductSupplierIds.Clear(); // Get the list of offeredProdSupsIds ready for updating
                var query = (from ps in db.ProductsSuppliers
                             join p in db.Products on ps.ProductId equals p.ProductId
                             join s in db.Suppliers on ps.SupplierId equals s.SupplierId
                             orderby ps.ProductId, p.ProdName, s.SupplierId
                             select new
                             {
                                 ps.ProductSupplierId,
                                 p.ProdName,
                                 s.SupName,
                                 s.SupplierId
                             }).ToList();

                for (int i = 0; i < query.Count; i++) // add each prodsupid to the list.
                {
                    ListViewItem nextItem = new ListViewItem(query[i].ProdName);
                    nextItem.SubItems.Add(query[i].SupName);
                    nextItem.SubItems.Add(query[i].SupplierId.ToString());
                    lvwAvailableProducts.Items.Add(nextItem);
                    offeredProductSupplierIds.Add(query[i].ProductSupplierId);
                }
            }
        }

        private void UpdateIncludedProductsList(TravelExpertsContext db)
        {
            int packID = selectedPackage.PackageId;
            lvwIncludedProducts.Items.Clear();
            includedProductSupplierIds.Clear();

            var query = (from pps in db.PackagesProductsSuppliers
                         join ps in db.ProductsSuppliers
                            on pps.ProductSupplierId equals ps.ProductSupplierId
                         join s in db.Suppliers on ps.SupplierId equals s.SupplierId
                         join p in db.Products on ps.ProductId equals p.ProductId
                         where pps.PackageId == selectedPackage.PackageId
                         orderby ps.ProductId, p.ProdName, s.SupplierId
                         select new
                         {
                             //pps.PackageProductSupplierId,
                             pps.ProductSupplierId,
                             //pps.PackageId,
                             ps.ProductId,
                             p.ProdName,
                             s.SupName
                         }).ToList();
            for (int i = 0; i < query.Count; i++)
            {
                ListViewItem nextItem =
                    new ListViewItem(query[i].ProductId.ToString());
                nextItem.SubItems.Add(query[i].ProdName);
                nextItem.SubItems.Add(query[i].SupName);
                lvwIncludedProducts.Items.Add(nextItem); // add each included product
                // to the list of products in the travel package

                includedProductSupplierIds.Add(query[i].ProductSupplierId);
                // add each supplier id to the list of suppliers. (same order as the
                // ProdSups in the List View)
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check that there is a selected product
            if (lvwAvailableProducts.SelectedItems.Count == 0)
            {
                return;
            }
            int selectedIndex = lvwAvailableProducts.SelectedIndices[0];

            //get selected product
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                //List<ProductsSupplier> prodSups = db.ProductsSuppliers.OrderBy(ps => ps.ProductId).ToList();
                // get all the prodsups from the database and add them to a list
                List<ProductsSupplier> prodSups = new List<ProductsSupplier>(); 
                var query = (from ps in db.ProductsSuppliers
                             join p in db.Products on ps.ProductId equals p.ProductId
                             join s in db.Suppliers on ps.SupplierId equals s.SupplierId
                             orderby p.ProductId, p.ProdName, s.SupplierId
                             select new
                             {
                                 ps.ProductSupplierId,
                                 ps.ProductId,
                                 ps.SupplierId
                             }).ToList();
                for (int i = 0; i < query.Count(); i++) 
                {
                    ProductsSupplier nextProdSup = new ProductsSupplier();
                    nextProdSup.ProductSupplierId = query[i].ProductSupplierId;
                    nextProdSup.ProductId = query[i].ProductId;
                    nextProdSup.SupplierId = query[i].SupplierId;
                    prodSups.Add(nextProdSup);
                }
                //{
                    ProductsSupplier prodSupToAdd = prodSups[selectedIndex];
                    Console.WriteLine(prodSups.ToString());
                    if (prodSupToAdd != null)
                    {
                        for (int i = 0; i < includedProductSupplierIds.Count; i++)
                        {
                            if (includedProductSupplierIds[i] == prodSupToAdd.ProductSupplierId) //check that it's not already offered
                            {
                                MessageBox.Show("The selected product is already offered");
                                return;
                            }
                        }
                    //add it to the products that the supplier offers if it isn't offered

                    //Create the PackageProductSuppliers to add to the database
                    PackagesProductsSupplier nextLink = new PackagesProductsSupplier();
                    nextLink.ProductSupplierId = prodSupToAdd.ProductSupplierId;
                    nextLink.PackageId = selectedPackage.PackageId; 

                    // get names of product and sup for the confirmation message
                    string msgProdName = lvwAvailableProducts.Items[selectedIndex].SubItems[0].Text;
                    string msgSupName = lvwAvailableProducts.Items[selectedIndex].SubItems[1].Text;
                    
                    DialogResult result = MessageBox.Show(
                        $"do you want to add {msgProdName} by {msgSupName} to {selectedPackage.PkgName}?",
                        "confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.PackagesProductsSuppliers.Add(nextLink);
                        db.SaveChanges();
                        //MessageBox.Show("Success");
                    }
                }
                    //update offered products list
                    UpdateIncludedProductsList(db);
                //}
                return;
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            // check that there are products to delete
            if (lvwIncludedProducts.Items.Count == 0)
            {
                MessageBox.Show("There are no products to delete");
                return;
            }
            // check that there is a selected product
            if (lvwIncludedProducts.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a product to delete");
                return;
            }

            int selectedIndex = lvwIncludedProducts.SelectedIndices[0];
            // delete link
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                PackagesProductsSupplier linkToDelete;
                var query = db.PackagesProductsSuppliers
                    .Include(p => p.ProductSupplier)
                    .Include("ProductSupplier.Product")
                    .Include("ProductSupplier.Supplier") // this syntax lets you include on includes.
                    //.ThenInclude(ps => ps.Product)
                    .Where(p => (p.PackageId == selectedPackage.PackageId)
                    && (p.ProductSupplierId == includedProductSupplierIds[selectedIndex]))
                    .ToList();

                if ((query.Count > 0) && (query != null))
                {

                    linkToDelete = query.FirstOrDefault();
                    string deleteProdName = linkToDelete.ProductSupplier.Product.ProdName;
                    string deleteSupName = linkToDelete.ProductSupplier.Supplier.SupName;
                    DialogResult result = MessageBox.Show(
                      $"do you want to remove " +
                      $"{deleteProdName} by {deleteSupName} from {selectedPackage.PkgName}?",
                      "confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) 
                    {
                        db.PackagesProductsSuppliers.Remove(linkToDelete);
                        db.SaveChanges();
                    }
                    
                }
                else
                {
                    // error message that the user should never see. For testing just in case
                    MessageBox.Show("Deletion unsuccessful. Query returned no results");
                }
                // update offered products list
                UpdateIncludedProductsList(db);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
