/*
 * Form for adding products-suppliers to a travel package
 * 
 * Author: Cameron Olmats
 * Date-Created: 2023-07-20
 */

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
        public TravelExpertsData.Package selectedPackage;
        public frmPackagesProductsSuppliers()
        {

            InitializeComponent();
        }


        private void frmPackagesProductsSuppliers_Load(object sender, EventArgs e)
        {
            lblInstructions.Text = $"Select a product to add to {selectedPackage.PkgName}";
            updateIncludedProductsList();
        }

        private void updateIncludedProductsList()
        {
            int packID = selectedPackage.PackageId;
            lvwAvailableProducts.Items.Clear();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {


                var query = (from a in db.PackagesProductsSuppliers
                             join b in db.ProductsSuppliers
                                on a.ProductSupplierId equals b.ProductSupplierId
                             join c in db.Suppliers on b.SupplierId equals c.SupplierId
                             join d in db.Products on b.SupplierId equals d.ProductId
                             where a.PackageId == selectedPackage.PackageId
                             orderby b.ProductId, d.ProdName, c.SupName
                             select new //does the user need to see the PackageProductSupplierId?
                             {
                                 b.ProductId, d.ProdName, c.SupName
                             }).ToList();
                for (int i = 0; i < query.Count; i++)
                {
                    ListViewItem nextItem =
                        new ListViewItem(query[i].ProductId.ToString());
                    nextItem.SubItems.Add(query[i].ProdName);
                    nextItem.SubItems.Add(query[i].SupName);
                    lvwIncludedProducts.Items.Add(nextItem);
                }


                //var query = db.PackagesProductsSuppliers
                //    .Join(db.ProductsSuppliers,
                //    pps => pps.ProductSupplierId,
                //    ps => ps.ProductSupplierId,
                //    (pps, ps) => new { ps.SupplierId, ps.ProductId })
                //    .Join(db.Products,
                //     => prod.ProductId)
                    
                
                
                
                
                //var queryft = db.ProductsSuppliers
                //    .Join(db.PackagesProductsSuppliers,
                //    ps => ps.ProductSupplierId,
                //    pps => pps.ProductSupplierId,
                //    (ps, pps) => new { ps.ProductSupplierId, ps.ProductId, ps.SupplierId })
                //    .Join(db.Products,
                    
                //    )
                //    .Where(pps => pps)
                //    .ToList();

                //var query2 = db.Products
                //   .Join(db.ProductsSuppliers,
                //       p => p.ProductId,
                //       ps => ps.ProductId,
                //       (p, ps) => new { p.ProductId, p.ProdName, ps.SupplierId })
                //   .Where(ps => ps.SupplierId == suppID)
                //   .OrderBy(pps => pps.ProductId)
                //   .ToList();
            }
        }
    }
}
