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

        int CurrentSelected = -1;

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
            btnLink.Enabled = true;
            btnLink.Text = "Add Products To Package";
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            DisplayData("Products");
            btnLink.Enabled = false;
            btnLink.Text = "";
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            DisplayData("Suppliers");
            btnLink.Enabled = true;
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
            else if (tableMode == "Products")
            {
            }
            else if (tableMode == "Suppliers")
            {
                if (CurrentSelected == -1 || suppliers.Count <= CurrentSelected)
                {
                    return;
                }
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
                DisplayData("Suppliers");
            }
            else
            {

            }
        }
    }
}
