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

/*
 * This is the controller for our Suppliers Form.
 * In here we validate that the user enters in correct values and for the case of the supplier they enter the minimum requirements
 * This only makes a new Supplier and new Contacts, it doesn't add them to the database.
 * 
 * Created by Cameron C
 */

namespace TravelExpertsGUI
{
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }
        //These values that are public are used by the main form.
        public Supplier? sup;//This is only ever set if we are modifying a supplier
        public List<SupplierContact> contacts = new List<SupplierContact>();//We make a new list, but it might be overridden by the main form
        public List<SupplierContact> removedContacts = new List<SupplierContact>();//We make a new list again, but this one is never overridden by the main form
        private SupplierContact? CurrentSelected;//This is used only in the form for when we are modifying a contact
        private int CurrentSelectedIndx = -1;//This is also only used in the form.

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            boxes = new TextBox[] {//This is only ever used for when we select a different contact or when we create one
                tbxFirstName, tbxLastName, tbxCompany, tbxAddress,
                tbxCity, tbxProvence, tbxPostal, tbxCountry, tbxPhone,
                tbxFax, tbxEmail, tbxWebsite
            };
            if (sup == null)//Check to see if the supplier is null - should be a new supplier
            {
                sup = new Supplier();//Make a new supplier
                return;
            }
            Display();//Display the current supplier if it isn't new
        }

        private void Display()
        {
            int tmpIdx = 0;
            for (int i = 0; i < contacts.Count; i++)//Loop through the contacts list
            {
                if (contacts[i].SupConCompany == null)//We check to see if the Company name is null - no company name is set
                {
                    lstBox.Items.Add("Address " + tmpIdx.ToString());//We assign a temp name using tmpIdx as the end
                    tmpIdx++;
                }
                else
                {
                    lstBox.Items.Add(contacts[i].SupConCompany);//We add the name of the company to the list
                }
            }
            tbxName.Text = sup.SupName;//We set the textbox tbxName to the name of the supplier

        }

        TextBox[] boxes;

        /*
         * This method just set's the text of box to o.
         * This method is useful since it can convert anything to a string.
         * and shortens it a bit.
         */
        private void setBox(TextBox box, object o)//Takes 2 arguments, a textbox and any other type.
        {
            if (o == null || o.ToString() == "")//We make sure that it doesn't equal to null and that it's not empty
            {
                return;//We return if it is
            }
            box.Text = o.ToString();//We set the textbox's text to the return of o.Tostring() which is just the data
        }

        private void DisplayContact(SupplierContact contact)
        {
            for (int i = 0; i < boxes.Length; i++)//We loop through the boxes
            {
                boxes[i].Text = "";//Set the text to empty
                boxes[i].ReadOnly = contact == null;//Set the read only value to true if contact is null otherwise it is false
            }
            if (contact == null) return;//If contact is null we return
            setBox(tbxFirstName, contact.SupConFirstName);//Update all of the textboxes with their respective values
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

        private void CreateEmptyAddress()//We make a new supplier with this method
        {
            int SelectedIndx = lstBox.Items.Count;//Get the current length of lstBox
            CurrentSelected = new SupplierContact();//We make a new SupplierContact
            contacts.Add(CurrentSelected);//We add it to the list of contacts
            lstBox.Items.Add("Address " + SelectedIndx.ToString());//We add a new string to lstBox
            lstBox.SelectedIndex = SelectedIndx;//We set the current SelectedIndex to our variable SelectedIndx
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            CreateEmptyAddress();//We make a new contact
            UpdateItemList();//We update the list
        }

        /*
         * This method is to update the text names for the contacts.
         * Anything that doesn't have a CompanyName will default to Address #
         * 
         */
        private void UpdateItemList()
        {
            int TmpIndx = 0;//Set the start index to 0
            for (int i = 0; i < lstBox.Items.Count; i++)//We loop through the list of lstBox, this list is linked with our contacts list
            {

                if (contacts[i].SupConCompany == null || contacts[i].SupConCompany == "")//Check to see if the Company name is null or empty
                {
                    lstBox.Items[i] = "Address " + TmpIndx.ToString();//We add a new string "Addres #" to the list
                    TmpIndx++;//Add 1 to TmpIndx
                }
                else
                {
                    lstBox.Items[i] = contacts[i].SupConCompany;//We set the string to the Company's name
                }
            }
        }

        /*
         * This is only to handle when we delete a contact
         * We make sure that the CurrentSeleted doesn't equal to null and then we add it to the
         * removedContacts list then update the list
         */
        private void btnDelAddress_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != null)//Make sure the CurrentSelected doesn't equal to null
            {
                removedContacts.Add(CurrentSelected);//We add it to the removedContacts list
                contacts.Remove(CurrentSelected);//We remove it from contacts
                lstBox.Items.RemoveAt(CurrentSelectedIndx);//We remove the string that is in it's location
                CurrentSelected = null;//Set CurrentSelected to null

                UpdateItemList();//We update the list

            }
        }
       
        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)//this is triggered whenever a user clicks something
        {
            if (lstBox.SelectedItem == null)//We check to see if the SelectedItem is null: if it's -1 or something
            {
                CurrentSelected = null;//Set our values to null and -1
                CurrentSelectedIndx = -1;
                return;//return
            }
            CurrentSelectedIndx = lstBox.SelectedIndex;//We set our CurrentSelectedIndx and CurrentSelected
            CurrentSelected = contacts[CurrentSelectedIndx];
            DisplayContact(CurrentSelected);//We display the contact that was selected
        }

        private void btnEnter_Click(object sender, EventArgs e)//This is our method for when the user presses the enter button for the contact
        {
            if (CurrentSelected != null)//Make sure the CurrentSelected isn't null
            {
                //We update our contact with the data.
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
                //Update our list view
                UpdateItemList();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contacts.Count; i++)//We loop through the contacts list, we make sure that any contact that is new has the required data
            {
                if (contacts[i].SupplierId == null && (contacts[i].SupConFirstName == null ||
                    contacts[i].SupConLastName == null || contacts[i].SupConCompany == null ||
                    contacts[i].SupConBusPhone == null || contacts[i].SupConEmail == null))
                {
                    DisplayContact(contacts[i]);//We display our contact if we're missing some data
                    MessageBox.Show("Required data isn't entered.");//We inform the user that they're mising some data.
                    return;
                }
            }
            if (tbxName.Text == "")//We check the text in tbxName: name of the Supplier
            {
                tbxName.Focus();//Focus on the textbox
                MessageBox.Show("Supplier name required.");//Inform the user that a name is required
                return;
            }
            sup.SupName = tbxName.Text;//Set the supplier name
            DialogResult = DialogResult.OK;//Set the DialogResult
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;//When the user presses cancel, the form closes and nothing is added or updated.
        }
    }
}
