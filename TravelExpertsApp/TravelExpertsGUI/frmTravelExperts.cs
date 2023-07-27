/*
 * This form acts as a menu where you can select and access the different functions of the application
 * 
 * Author: Dreesha
 * Date created: July 2023
 */

using System.Configuration;
using System.DirectoryServices.ActiveDirectory;
using TravelExpertsData;

namespace TravelExpertsGUI
{
    public partial class frmTravelExperts : Form
    {
        private string tableMode = "";

        //unused lists
        private List<Product> products = new List<Product>();
        private List<Package> packages = new List<Package>();
        private List<Supplier> suppliers = new List<Supplier>();
        private object txtPackageID;

        public frmTravelExperts()
        {
            InitializeComponent();
        }

        private void frmTravelExperts_Load(object sender, EventArgs e)
        {

            tableMode = "Packages";
            btnLink.Enabled = false;
            btnLink.Text = "Add Products To Package";

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var source = db.Packages.Select(i => new
                {
                    i.PackageId,
                    i.PkgName,
                    i.PkgBasePrice
                })
                    .ToList();
                dgvMain.DataSource = source;

                //code only for testing frmProductsSuppliers
                packages.Clear();
                foreach (Package p in db.Packages)
                {
                    packages.Add(p);
                }
                products.Clear();
                foreach (Product p in db.Products)
                {
                    products.Add(p);
                }
                suppliers.Clear();
                foreach (Supplier s in db.Suppliers)
                {
                    suppliers.Add(s);
                }
            }
        }


        //When the TravelPackage, Products, and supplier buttons are clicked:
        //The data grid view updates it's data and the buttons are chagned to match the selected button
        private void btnTravelPackage_Click(object sender, EventArgs e)
        {

            tableMode = "Packages";
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                packages.Clear();
                foreach (Package p in db.Packages)
                {
                    packages.Add(p);
                }
                dgvMain.DataSource = packages;
            }
            btnLink.Enabled = false;
            btnLink.Text = "Add Products To Package";
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            tableMode = "Products";
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                products.Clear();
                foreach (Product p in db.Products)
                {
                    products.Add(p);
                }
                dgvMain.DataSource = products;
            }
            btnLink.Enabled = false;
            btnLink.Text = "notImplemented";
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            tableMode = "Suppliers";
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                suppliers.Clear();
                foreach (Supplier s in db.Suppliers)
                {
                    suppliers.Add(s);
                }
                dgvMain.DataSource = suppliers;
            }
            btnLink.Enabled = true;
            btnLink.Text = "Add Products To Supplier";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (tableMode == null)
            {
                MessageBox.Show("Please select a table to add data to");
                return;
            }
            else if (tableMode == "Products")
            {
                frmProducts secondForm = new frmProducts();
                result = secondForm.ShowDialog();
            }
            else if (tableMode == "Suppliers")
            {
                frmSuppliers secondForm = new frmSuppliers();
                result = secondForm.ShowDialog();
            }
            else  // tableMode == "Packages"
            {
                frmPackages secondForm = new frmPackages();
                secondForm.isAdd = true;
                result = secondForm.ShowDialog();
                if (result == DialogResult.OK)
                {

                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        db.Packages.Add(secondForm.currentPackage);
                        db.SaveChanges();
                        packages.Add(secondForm.currentPackage);
                    }
                }
                dgvMain.Update();
            }


            //switch (tableMode)
            //{
            //    case "Packages":
            //        {
            //            frmPackages secondForm = new frmPackages();
            //            DialogResult result = secondForm.ShowDialog();
            //            break;
            //        }

            //    //case "Products":
            //    //    frmProducts secondForm = new frmProducts();
            //    //    DialogResult result = secondForm.ShowDialog();
            //    //    break;
            //    case "Suppliers":
            //        {
            //            frmSuppliers secondForm = new frmSuppliers();
            //            DialogResult result = secondForm.ShowDialog();
            //            break;
            //        }
            //    default:
            //        {
            //            frmPackages secondForm = null;
            //            break;
            //        }
            //}
            //if (secondForm != null)
            //{

            //}
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            if (true)
            {
                frmProductsSuppliers secondForm = new frmProductsSuppliers();
                secondForm.selectedSupplier = suppliers[dgvMain.CurrentCell.RowIndex];
                DialogResult result = secondForm.ShowDialog();

            }
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            if (TravelExpertsContext.CurrentRow.Index =-1) ;
            {
                Package.PackageID = Convert.ToInt32(dgvMain.Main.CurrentRow.Cells[0].Value);
                using TravelExpertsContext db = new TravelExpertsContext();
                {
                    Package package = db.Packages.Where(x=> x.PackageId == package.PackageId).FirstOrDefault();
                    txtPackageID.text = package.PackageId
                    txt
                }
                btnSave.text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show)
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        //method for displaying data in the list view. It takes a list as a parrameter.
        //private void updateListView()
        //{
        //    lvwMain.Items.Clear();
        //    switch (tableMode)
        //    {
        //        case "Packages":

        //            foreach (Package p in packages)
        //            {
        //                lvwMain.Items.Add(p.ToString());
        //            }
        //            break;

        //        case "Products":
        //            foreach (Product p in products)
        //            {
        //                lvwMain.Items.Add(p.ToString());
        //            }
        //            break;

        //        case "Suppliers":
        //            foreach (Supplier s in suppliers)
        //            {
        //                lvwMain.Items.Add(s.ToString());
        //            }
        //            break;
        //        default:
        //            MessageBox.Show("Data did not display correctly");
        //            return;
        //    }
        //}
    }
}
