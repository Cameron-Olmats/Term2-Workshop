/*
 * This form acts as a menu where you can select and access the different functions of the application
 * 
 * Author: Cameron Olmats
 * Date created: 7/10/2023
 */

using TravelExpertsData;

namespace TravelExpertsGUI
{
    public partial class frmTravelExperts : Form
    {
        private string tableSelection = "";
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
            
            tableSelection = "Packages";
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                dgvMain.DataSource = db.Packages.ToList();
            }

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            tableSelection = "Products";
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                dgvMain.DataSource = db.Products.ToList();
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            tableSelection = "Suppliers";
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                dgvMain.DataSource = db.Suppliers.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (tableSelection)
            {
                case "Packages":
                    {
                        frmPackages secondForm = new frmPackages();
                        DialogResult result = secondForm.ShowDialog();
                        break;
                    }
                    
                //case "Products":
                //    frmProducts secondForm = new frmProducts();
                //    DialogResult result = secondForm.ShowDialog();
                //    break;
                case "Suppliers":
                    {
                        frmSuppliers secondForm = new frmSuppliers();
                        DialogResult result = secondForm.ShowDialog();
                        break;
                    }
                    
            }
        }
    }
}