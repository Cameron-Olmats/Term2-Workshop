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

        public frmTravelExperts()
        {
            InitializeComponent();
        }

        private void frmTravelExperts_Load(object sender, EventArgs e)
        {
            //using (TravelExpertsContext db = new TravelExpertsContext())
            //{
            //    //dataGridView1.DataSource = db.Customers.ToList();
            //}

        }


        //When the TravelPackage, Products, and supplier buttons are clicked:
        //The data grid view updates it's data and the buttons are chagned to match the selected button
        private void btnTravelPackage_Click(object sender, EventArgs e)
        {

            tableMode = "Packages";
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                dgvMain.DataSource = db.Packages.ToList();
            }

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            tableMode = "Products";
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                
                dgvMain.DataSource = db.Products.ToList();
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            tableMode = "Suppliers";
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                dgvMain.DataSource = db.Suppliers.ToList();
            }
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
