/*
 * Form for adding and editing travel packages
<<<<<<< Updated upstream
 * 
 * Author: Dreesha, Cameron O., Cameron C.
=======
 * Uses data from the TravelExpertsData to view existing package data, as well as create new package data.
 * Author: Dreesha, Cameron
>>>>>>> Stashed changes
 * Date: July 2023
 */

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class frmPackages : Form
    {
        public Package currentPackage;

        public frmPackages()
        {
            InitializeComponent();


        }

        /// <summary>
        /// if no existing package is selected, new package can be created. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPackages_Load(object sender, EventArgs e)
        {
            if (currentPackage == null)
            {
                currentPackage = new TravelExpertsData.Package();
                return;
            }
            displayPackage();
        }
        /// <summary>
        /// This displays the whole package form, which includes the name, the start and end dates, the description and agency commission to the admin
        /// </summary>
        private void displayPackage()
        {
            txtName.Text = (string)currentPackage.PkgName;
            dtpStart = (DateTimePicker)currentPackage.PkgStartDate;
            dtpEnd = (DateTimePicker)currentPackage.PkgEndDate;
            txtDescription.Text = currentPackage.PkgDesc.ToString();
            txtAgencyCommission.Text = currentPackage.PkgAgencyCommission.ToString();
        }
        /// <summary>
        /// By clicking the submit button, it stores newly added package data into database, from the registered user
        /// The embedded validator will check if there is any invalid inputs and will not submit data if it does not meet the required formatted inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validator.NotEmpty(txtName) && dtpEnd.Value > dtpStart.Value  && Validator.NotEmpty(txtDescription) && Validator.GreaterThan(txtBasePrice, txtAgencyCommission))
            {
                currentPackage.PkgName = txtName.Text;
                currentPackage.PkgStartDate = Convert.ToDateTime(dtpStart);
                currentPackage.PkgEndDate = Convert.ToDateTime(dtpEnd);
                currentPackage.PkgDesc = txtDescription.Text;
                currentPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);
                currentPackage.PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommission.Text);
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// When clicked, it erases all inputed information from the textboxes and deletes inputted dates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //if (Package.CurrentPackage != null)
            //{
            //    Package.CurrentPackage.Clear();
            //}

            txtName.Text = "";
            txtName.Focus();
            _=dtpStart.Value;
            _=dtpEnd.Value;
            txtDescription.Text = "";
            txtBasePrice.Text = "0";
            txtAgencyCommission.Text = "0";
        }

        /// <summary>
        /// Cancels any input or changes done by user and exits out form as is.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">closes packages form</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
      

      





