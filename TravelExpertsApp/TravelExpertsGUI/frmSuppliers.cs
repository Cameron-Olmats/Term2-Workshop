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
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        public Supplier? sup;
        public List<SupplierContact> contacts = new List<SupplierContact>();
        public List<SupplierContact> removedContacts = new List<SupplierContact>();
        private SupplierContact? CurrentSelected;
        private int CurrentSelectedIndx = -1;

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            boxes = new TextBox[] {
                tbxFirstName, tbxLastName, tbxCompany, tbxAddress,
                tbxCity, tbxProvence, tbxPostal, tbxCountry, tbxPhone,
                tbxFax, tbxEmail, tbxWebsite
            };
            if (sup == null)
            {
                sup = new Supplier();
                return;
            }
            Display();
        }

        private void Display()
        {
            int tmpIdx = 0;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].SupConCompany == null)
                {
                    lstBox.Items.Add("Address " + tmpIdx.ToString());
                    tmpIdx++;
                }
                else
                {
                    lstBox.Items.Add(contacts[i].SupConCompany);
                }
            }
            tbxName.Text = sup.SupName;

        }

        TextBox[] boxes;

        private void setBox(TextBox box, object o)
        {
            if (o == null || o.ToString() == "")
            {
                return;
            }
            box.Text = o.ToString();
        }

        private void DisplayContact(SupplierContact contact)
        {
            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i].Text = "";
                boxes[i].ReadOnly = contact == null;
            }
            if (contact == null) return;
            setBox(tbxFirstName, contact.SupConFirstName);
            setBox(tbxLastName, contact.SupConLastName);
            setBox(tbxCompany, contact.SupConCompany);
            setBox(tbxAddress, contact.SupConAddress);
            setBox(tbxCity, contact.SupConCity);
            setBox(tbxCountry, contact.SupConCountry);
            setBox(tbxEmail, contact.SupConEmail);
            setBox(tbxFax, contact.SupConFax);
            setBox(tbxPhone, contact.SupConBusPhone);
            setBox(tbxPostal, contact.SupConPostal);
            setBox(tbxProvence, contact.SupConProv);
            setBox(tbxWebsite, contact.SupConUrl);
        }

        private void CreateEmptyAddress()
        {
            int SelectedIndx = lstBox.Items.Count;
            CurrentSelected = new SupplierContact();
            contacts.Add(CurrentSelected);
            lstBox.Items.Add("Address " + SelectedIndx.ToString());
            lstBox.SelectedIndex = SelectedIndx;
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            CreateEmptyAddress();
            UpdateItemList();
        }

        private void UpdateItemList()
        {
            int TmpIndx = 0;
            for (int i = 0; i < lstBox.Items.Count; i++)
            {

                if (contacts[i].SupConCompany == null || contacts[i].SupConCompany == "")
                {
                    lstBox.Items[i] = "Address " + TmpIndx.ToString();
                    TmpIndx++;
                }
                else
                {
                    lstBox.Items[i] = contacts[i].SupConCompany;
                }
            }
        }

        private void btnDelAddress_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != null)
            {
                removedContacts.Add(CurrentSelected);
                contacts.Remove(CurrentSelected);
                lstBox.Items.RemoveAt(CurrentSelectedIndx);
                CurrentSelected = null;

                UpdateItemList();

            }
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBox.SelectedItem == null)
            {
                CurrentSelected = null;
                CurrentSelectedIndx = -1;
                return;
            }
            CurrentSelectedIndx = lstBox.SelectedIndex;
            CurrentSelected = contacts[CurrentSelectedIndx];
            DisplayContact(CurrentSelected);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != null)
            {
                CurrentSelected.SupConFirstName = tbxFirstName.Text;
                CurrentSelected.SupConLastName = tbxLastName.Text;
                CurrentSelected.SupConCompany = tbxCompany.Text;
                CurrentSelected.SupConAddress = tbxAddress.Text;
                CurrentSelected.SupConCity = tbxCity.Text;
                CurrentSelected.SupConCountry = tbxCountry.Text;
                CurrentSelected.SupConEmail = tbxEmail.Text;
                CurrentSelected.SupConFax = tbxFax.Text;
                CurrentSelected.SupConBusPhone = tbxPhone.Text;
                CurrentSelected.SupConPostal = tbxPostal.Text;
                CurrentSelected.SupConProv = tbxProvence.Text;
                CurrentSelected.SupConUrl = tbxWebsite.Text;
                UpdateItemList();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].SupplierId == null && (contacts[i].SupConFirstName == null ||
                    contacts[i].SupConLastName == null || contacts[i].SupConCompany == null ||
                    contacts[i].SupConBusPhone == null || contacts[i].SupConEmail == null))
                {
                    DisplayContact(contacts[i]);
                    MessageBox.Show("Required data isn't entered.");
                    return;
                }
            }
            if (tbxName.Text == "")
            {
                tbxName.Focus();
                MessageBox.Show("Supplier name required.");
                return;
            }
            sup.SupName = tbxName.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
