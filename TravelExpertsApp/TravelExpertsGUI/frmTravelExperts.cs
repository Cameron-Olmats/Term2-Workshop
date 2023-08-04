/*
 * This form acts as a menu where you can select and access the different functions of the application
 * 
 * Author: Dreesha
 * Date created: July 2023
 */

using Microsoft.EntityFrameworkCore;
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

        int CurrentSelected = -1;
        private Product selectedProd;

        public frmTravelExperts()
        {
            InitializeComponent();
        }

        public frmTravelExperts(Product selectedProd)
        {
            this.selectedProd = selectedProd;
        }

        private void DisplayData(string Mode)
        {
            tableMode = Mode;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                if (tableMode == "Packages")
                {
                    packages = db.Packages.ToList();
                    var query = db.Packages.
                        Select(p => new
                        {
                            p.PackageId,
                            p.PkgName,
                            p.PkgStartDate,
                            p.PkgEndDate,
                            p.PkgBasePrice,
                            p.PkgAgencyCommission
                        })
                        .ToList();
                    dgvMain.DataSource = query;
                }
                else if (tableMode == "Products")
                {
                    products = db.Products.ToList();
                    dgvMain.DataSource = products;
                }
                else if (tableMode == "Suppliers")
                {
                    suppliers = db.Suppliers.ToList();
                    dgvMain.DataSource = suppliers;
                }
            }
        }

        private void frmTravelExperts_Load(object sender, EventArgs e)
        {

            tableMode = "Packages";
            btnLink.Enabled = true;
            btnLink.Text = "Add Products To Package";

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                //var source = db.Packages.Select(i => new
                //{
                //    i.PackageId,
                //    i.PkgName,
                //    i.PkgBasePrice
                //})
                //    .ToList();
                //dgvMain.DataSource = source;

                DisplayData(tableMode);

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
            btnAdd.Enabled = true;
            btnLink.Enabled = true;
            btnModify.Enabled = true;
            btnRemove.Enabled = true;
            btnAdd.Visible = true;
            btnLink.Visible = true;
            btnModify.Visible = true;
            btnRemove.Visible = true;
            btnLink.Text = "Add Products To Package";
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            DisplayData("Products");
            btnLink.Enabled = true;
            btnLink.Visible = true;

            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnRemove.Enabled = false;
            btnAdd.Visible = false;
            btnModify.Visible = false;
            btnRemove.Visible = false;
            btnLink.Text = "Edit Products";
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            DisplayData("Suppliers");

            btnAdd.Enabled = true;
            btnLink.Enabled = true;
            btnModify.Enabled = true;
            btnRemove.Enabled = true;
            btnAdd.Visible = true;
            btnLink.Visible = true;
            btnModify.Visible = true;
            btnRemove.Visible = true;
            btnLink.Text = "Add Products To Supplier";
        }

        private int GetNextInt(List<SupplierContact> lst, TravelExpertsContext db, int Strt)
        {
            int i = lst.Count();
            if (Strt > i)
            {
                i = Strt;
            }
            while (true)
            {
                if (db.SupplierContacts.Find(i) != null)
                {
                    break;
                }
                i++;
            }
            return i;
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
                        int nextInt = db.Suppliers.ToList().Count;
                        while (true)
                        {
                            if (db.Suppliers.Find(nextInt) == null)
                            {
                                break;
                            }
                            nextInt++;
                        }
                        Supplier cont = secondForm.sup;
                        cont.SupplierId = nextInt;
                        db.Suppliers.Add(cont);
                        int lstI = -1;
                        for (int x = 0; x < secondForm.contacts.Count; x++)
                        {
                            lstI = GetNextInt(db.SupplierContacts.ToList(), db, lstI);
                            secondForm.contacts[x].SupplierContactId = lstI;
                            db.SupplierContacts.Add(secondForm.contacts[x]);
                            lstI++;
                        }
                        db.SaveChanges();
                    }
                    DisplayData("Suppliers");
                }
            }
            else  // tableMode == "Packages"
            {
                frmPackages secondForm = new frmPackages();
                result = secondForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        Package prod = secondForm.currentPackage;
                        db.Packages.Add(prod);
                        db.SaveChanges();
                    }
                    DisplayData("Packages");
                }
            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            if (tableMode == "Suppliers")
            {
                frmProductsSuppliers secondForm = new frmProductsSuppliers();
                secondForm.selectedSupplier = suppliers[dgvMain.CurrentCell.RowIndex];
                DialogResult result = secondForm.ShowDialog();
            }
            else if (tableMode == "Packages")
            {
                frmPackagesProductsSuppliers secondForm = new frmPackagesProductsSuppliers();
                secondForm.selectedPackage = packages[dgvMain.CurrentCell.RowIndex];
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    DialogResult result = secondForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Dispose();
                    }
                }
            }

            else if (tableMode == "Products")
            {
                frmProducts secondForm = new frmProducts();
                secondForm.SelectedProd = products[dgvMain.CurrentCell.RowIndex];
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
                secondForm.SelectedProd = products[dgvMain.CurrentCell.RowIndex];
                result = secondForm.ShowDialog();
            }
            else if (tableMode == "Packages")
            {
                if (CurrentSelected == -1 || packages.Count <= CurrentSelected)
                {
                    return;
                }
                frmPackages secondForm = new frmPackages();
                secondForm.currentPackage = packages[CurrentSelected];
                result = secondForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        Package? pack = db.Packages.Find(secondForm.currentPackage.PackageId);
                        if (pack != null)
                        {
                            pack.PkgName = secondForm.currentPackage.PkgName;
                            pack.PkgStartDate = secondForm.currentPackage.PkgStartDate;
                            pack.PkgEndDate = secondForm.currentPackage.PkgEndDate;
                            pack.PkgDesc = secondForm.currentPackage.PkgDesc;
                            pack.PkgAgencyCommission = secondForm.currentPackage.PkgAgencyCommission;
                            db.SaveChanges();
                        }
                    }
                    DisplayData("Packages");
                }
            }
            else if (tableMode == "Suppliers")
            {
                if (CurrentSelected == -1 || suppliers.Count <= CurrentSelected)
                {
                    return;
                }
                frmSuppliers secondForm = new frmSuppliers();
                Supplier currentSupplier = suppliers[CurrentSelected];
                secondForm.sup = currentSupplier;
                List<SupplierContact> contacts;
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    contacts = db.SupplierContacts.Where(s => s.SupplierId == currentSupplier.SupplierId).ToList();
                }
                secondForm.contacts = contacts;
                result = secondForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        int lstI = -1;
                        for (int x = 0; x < secondForm.contacts.Count; x++)
                        {
                            if (secondForm.contacts[x].SupplierContactId == 0 || db.SupplierContacts.Find(secondForm.contacts[x].SupplierContactId) == null)
                            {
                                lstI = GetNextInt(db.SupplierContacts.ToList(), db, lstI);
                                secondForm.contacts[x].SupplierContactId = lstI;
                                db.SupplierContacts.Add(secondForm.contacts[x]);
                                lstI++;
                            }
                            else
                            {
                                SupplierContact contact = db.SupplierContacts.Find(secondForm.contacts[x].SupplierContactId);
                                contact.SupConFirstName = secondForm.contacts[x].SupConFirstName;
                                contact.SupConLastName = secondForm.contacts[x].SupConLastName;
                                contact.SupConEmail = secondForm.contacts[x].SupConEmail;
                                contact.SupConCity = secondForm.contacts[x].SupConCity;
                                contact.SupConBusPhone = secondForm.contacts[x].SupConBusPhone;
                                contact.SupConCompany = secondForm.contacts[x].SupConCompany;
                                contact.SupConCountry = secondForm.contacts[x].SupConCountry;
                                contact.SupConFax = secondForm.contacts[x].SupConFax;
                                contact.SupConPostal = secondForm.contacts[x].SupConPostal;
                                contact.SupConProv = secondForm.contacts[x].SupConProv;
                                contact.SupConAddress = secondForm.contacts[x].SupConAddress;
                                contact.SupConUrl = secondForm.contacts[x].SupConUrl;
                            }

                        }
                        for (int x = 0; x < secondForm.removedContacts.Count; x++)
                        {
                            SupplierContact contact = db.SupplierContacts.Find(secondForm.removedContacts[x].SupplierContactId);
                            if (contact != null)
                            {
                                db.SupplierContacts.Remove(contact);
                            }
                        }
                        currentSupplier = db.Suppliers.Find(currentSupplier.SupplierId);
                        if (currentSupplier == null)
                        {
                            db.Suppliers.Add(secondForm.sup);
                            db.SaveChanges();
                            return;
                        }
                        currentSupplier.SupName = secondForm.sup.SupName;
                        db.SaveChanges();

                    }
                }
                DisplayData("Suppliers");
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tableMode == null)
            {
                MessageBox.Show("Please select a table to remove data from");
                return;
            }
            else if (tableMode == "Suppliers")
            {
                if (CurrentSelected == -1 || suppliers.Count <= CurrentSelected)
                {
                    return;
                }
                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        Supplier supplier = db.Suppliers.Find(suppliers[CurrentSelected].SupplierId);
                        if (supplier != null)
                        {
                            List<SupplierContact> contacts = db.SupplierContacts.Where(s => s.SupplierId == supplier.SupplierId).ToList();
                            for (int i = 0; i < contacts.Count; i++)
                            {
                                db.SupplierContacts.Remove(contacts[i]);
                            }
                            List<ProductsSupplier> prods = db.ProductsSuppliers.Where(s => s.SupplierId == supplier.SupplierId).ToList();
                            for (int i = 0; i < prods.Count; i++)
                            {
                                db.ProductsSuppliers.Remove(prods[i]);
                            }
                            db.Suppliers.Remove(supplier);
                            db.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ran into an issue while removing a supplier. This can happen when customers have a purchase with them.");
                }
                DisplayData("Suppliers");
            }
            else if (tableMode == "Packages")
            {
                if (CurrentSelected == -1 || packages.Count <= CurrentSelected)
                {
                    return;
                }
                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        Package pack = db.Packages.Find(packages[CurrentSelected].PackageId);
                        if (pack != null)
                        {
                            db.Packages.Remove(pack);
                            db.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ran into an issue while removing package.");
                }
                DisplayData("Packages");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
