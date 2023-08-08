/*
 * This form acts as a menu where you can select and access the different functions of the application
 * 
 * Author: Dreesha, Cameron C
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
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
                            p.PkgStartDate, //col 2
                            p.PkgEndDate, // col 3
                            p.PkgBasePrice, // col 4
                            p.PkgAgencyCommission //col 5
                        })
                        .ToList();
                    dgvMain.DataSource = query;
                    dgvMain.Columns[2].DefaultCellStyle.Format = "d";
                    dgvMain.Columns[3].DefaultCellStyle.Format = "d";
                    dgvMain.Columns[4].DefaultCellStyle.Format = "c";
                    dgvMain.Columns[5].DefaultCellStyle.Format = "c";
                }
                else if (tableMode == "Products")
                {
                    products = db.Products.ToList();
                    var query = db.Products
                       .Select(p => new
                       {
                           p.ProductId,
                           p.ProdName
                       })
                       .ToList();
                    dgvMain.DataSource = query;
                }
                else if (tableMode == "Suppliers")
                {
                    suppliers = db.Suppliers.ToList();
                    var query = db.Suppliers
                        .Select(s => new
                        {
                            s.SupplierId,
                            s.SupName
                        })
                        .ToList();
                    dgvMain.DataSource = query;
                }
            }
        }

        /*
         * This is our main function for when the form loads, we set it to the default of Packages
         * which is used in our other functions. We then make a new connection to the database and store our data
         * in lists.
         * 
         */

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

        /*
         * This method takes a could arguments, this basically determines what ID the SupplierContact should have.
         * This method is used in 2 other methods, but both are used when we are adding a new SupplierContact since
         * the ID of them aren't automatically generated, we find an emtpy ID starting at however many SupplierContacts there are.
         * 
         * By: Cameron C
         */
        private int GetNextInt(List<SupplierContact> lst, TravelExpertsContext db, int Strt)
        {
            int i = lst.Count();//We grab the lengtho f the list lst
            if (Strt > i)//Check to see if the amount we pass in for Strt is bigger then i: this is for continuous use.
            {
                i = Strt;//We set i to Strt
            }
            while (true)//We create a loop which we eventually break out of
            {
                if (db.SupplierContacts.Find(i) == null)//We make sure the id we currently have selected (i) returns null when we try to find a SupplierContact with it
                {
                    break;//We break the loop so we can return the id we found
                }
                i++;//Adds 1 to i
            }
            return i;//return i: the ID we are going to use for the SupplierContact
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
            else if (tableMode == "Suppliers")//This part was made by Cameron C
            {
                frmSuppliers secondForm = new frmSuppliers();//This makes a new Supplier Form
                result = secondForm.ShowDialog();//We get the result of the form to compare for later
                if (result == DialogResult.OK)//We check to make sure the result is OK
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())//We make a new connection to the database
                    {
                        int nextInt = db.Suppliers.ToList().Count;//We set the start value to the length of the Suppliers list; this is basically the same as our GetNextInt method
                        while (true)//Make a loop
                        {
                            if (db.Suppliers.Find(nextInt) == null)//Make sure the returned Supplier is null for the ID
                            {
                                break;//Break the loop
                            }
                            nextInt++;//We add 1 to nextInt if it found a Supplier
                        }
                        Supplier cont = secondForm.sup;//We get our contact
                        cont.SupplierId = nextInt;//We set the Id to the one we got
                        db.Suppliers.Add(cont);//We add it to the list
                        int lstI = -1;//We set the start to -1: this is probably a left over before I replaced it with a method
                        for (int x = 0; x < secondForm.contacts.Count; x++)//We make a new loop for the length of contacts
                        {
                            lstI = GetNextInt(db.SupplierContacts.ToList(), db, lstI);//We get an empty ID to use for our contact
                            secondForm.contacts[x].SupplierContactId = lstI;//We set the ID
                            secondForm.contacts[x].SupplierId = nextInt;//We set the SupplierID
                            db.SupplierContacts.Add(secondForm.contacts[x]);//We add it to the list
                            lstI++;//We set the next ID to +1 to not have to loop through the list to the start again using less resources overall
                        }
                        db.SaveChanges();//We save the changes to the database
                    }
                    DisplayData("Suppliers");//We display the data for Suppliers
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
            else if (tableMode == "Suppliers")//This was also made by Cameron C
            {
                if (CurrentSelected == -1 || suppliers.Count <= CurrentSelected)//We make sure that we have a selection
                {
                    return;
                }
                frmSuppliers secondForm = new frmSuppliers();//We make a new form for Suppliers
                Supplier currentSupplier = suppliers[CurrentSelected];//We get our current Supplier that is selected
                secondForm.sup = currentSupplier;//We set the new form's Supplier
                List<SupplierContact> contacts;//We make a new contacts list
                using (TravelExpertsContext db = new TravelExpertsContext())//We make a connection to the database
                {
                    contacts = db.SupplierContacts.Where(s => s.SupplierId == currentSupplier.SupplierId).ToList();//Get the list of contacts that are connected to the supplier
                }
                secondForm.contacts = contacts;//We set the form's contacts to the one we got
                result = secondForm.ShowDialog();//We get the result
                if (result == DialogResult.OK)//Make sure the result is OK
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())//Make a new connection to the database
                    {
                        int lstI = -1;
                        for (int x = 0; x < secondForm.contacts.Count; x++)//Loop through the contacts of secondForm
                        {
                            if (secondForm.contacts[x].SupplierContactId == 0 || db.SupplierContacts.Find(secondForm.contacts[x].SupplierContactId) == null)//Check to see if the SupplierContactId is 0 or it doesn't exist in SupplierContacts
                            {
                                lstI = GetNextInt(db.SupplierContacts.ToList(), db, lstI);//Get an empty ID
                                secondForm.contacts[x].SupplierContactId = lstI;//Set the SupplierContactId to the new ID
                                secondForm.contacts[x].SupplierId = currentSupplier.SupplierId;//Set the SupplierId to the currentSupplier's
                                db.SupplierContacts.Add(secondForm.contacts[x]);//Add the new Contact to the list
                                lstI++;
                            }
                            else
                            {
                                SupplierContact contact = db.SupplierContacts.Find(secondForm.contacts[x].SupplierContactId);//Get the contact if it exists
                                contact.SupConFirstName = secondForm.contacts[x].SupConFirstName;//Update all of it's data
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
                        for (int x = 0; x < secondForm.removedContacts.Count; x++)//We have a separate Contact's list inside of the form, this one is for ones that we've removed, we loop through it and remove
                            //Any contact that we find.
                        {
                            SupplierContact contact = db.SupplierContacts.Find(secondForm.removedContacts[x].SupplierContactId);//We get the contact
                            if (contact != null)//If it isn't null - it exists
                            {
                                db.SupplierContacts.Remove(contact);//We remove it
                            }
                        }
                        currentSupplier = db.Suppliers.Find(currentSupplier.SupplierId);//We get the updated currentSupplier
                        if (currentSupplier == null)//If it's null - it was removed by someone else?
                        {
                            db.Suppliers.Add(secondForm.sup);//We add a new supplier to the list
                            db.SaveChanges();//We save the changes
                            return;
                        }
                        currentSupplier.SupName = secondForm.sup.SupName;//We update the supplier's name
                        db.SaveChanges();//We save the changes

                    }
                }
                DisplayData("Suppliers");//Display the updated changes
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
            else if (tableMode == "Suppliers")//This was made by Cameron C
                //We check to make sure the user has something selected
            {
                if (CurrentSelected == -1 || suppliers.Count <= CurrentSelected)
                {
                    return;
                }
                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())//Make a new connection
                    {
                        Supplier supplier = db.Suppliers.Find(suppliers[CurrentSelected].SupplierId);//Make sure the supplier exists
                        if (supplier != null)
                        {
                            List<SupplierContact> contacts = db.SupplierContacts.Where(s => s.SupplierId == supplier.SupplierId).ToList();//Get the contacts and loop through and remove any that are connected to the Supplier
                            for (int i = 0; i < contacts.Count; i++)
                            {
                                db.SupplierContacts.Remove(contacts[i]);//Remove them
                            }
                            List<ProductsSupplier> prods = db.ProductsSuppliers.Where(s => s.SupplierId == supplier.SupplierId).ToList();//We go through our ProductSuppliers and remove any that are connected to the Supplier
                            for (int i = 0; i < prods.Count; i++)
                            {
                                db.ProductsSuppliers.Remove(prods[i]);//Remove them
                            }
                            db.Suppliers.Remove(supplier);//We remove the Supplier
                            db.SaveChanges();//We try to save the changes
                        }
                    }
                }
                catch (Exception ex)//We catch any exception since if some customers have a purchase with them it'll cause an error to occure
                {
                    MessageBox.Show("Ran into an issue while removing a supplier. This can happen when customers have a purchase with them.");//Inform the user
                }
                DisplayData("Suppliers");//We display our updated data.
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
