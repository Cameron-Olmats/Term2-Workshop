/*
 * This form acts as a menu where you can select and access the different functions of the application
 * 
 * Author: Cameron Olmats
 * Date created: 7/10/2023
 */

using System.Configuration;
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

        int CurrentSelected;

        public frmTravelExperts()
        {
            InitializeComponent();
        }

        private void DisplayData(string Mode)
        {
            tableMode = Mode;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                if (tableMode == "Packages")
                {
                    packages = db.Packages.ToList();
                    dgvMain.DataSource = packages;
                }
                else if(tableMode == "Products")
                {
                    products = db.Products.ToList();
                    dgvMain.DataSource = products;
                }
                else if(tableMode == "Suppliers")
                {
                    suppliers = db.Suppliers.ToList();
                    dgvMain.DataSource = suppliers;
                }
            }
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
            DisplayData("Packages");
            btnLink.Enabled = false;
            btnLink.Text = "Add Products To Package";
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            DisplayData("Products");
            btnLink.Enabled = false;
            btnLink.Text = "notImplemented";
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            DisplayData("Suppliers");
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
                if (result == DialogResult.OK)
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        int i = db.Suppliers.ToList().Count;
                        while (true)
                        {
                            if (db.Suppliers.Find(i) == null)
                            {
                                break;
                            }
                            i++;
                        }


                    }
                }
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
        }

        private void print(Object o)
        {
            System.Diagnostics.Debug.WriteLine(o);
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentSelected = dgvMain.CurrentRow.Index;
            print(CurrentSelected);
        }
    }
}
