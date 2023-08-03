/*
 * Form for adding and editing travel packages
 * 
 * Author: Dreesha, Cameron O
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


        private void frmPackages_Load(object sender, EventArgs e)
        {
            if (currentPackage == null)
            {
                currentPackage = new TravelExpertsData.Package();
                return;
            }
            displayPackage();
        }

        private void displayPackage()
        {
            txtName.Text = currentPackage.PkgName;
            txtStartDate.Text = currentPackage.PkgStartDate.ToString();
            txtEndDate.Text = currentPackage.PkgEndDate.ToString();
            txtDescription.Text = currentPackage.PkgDesc.ToString();
            txtAgencyCommission.Text = currentPackage.PkgAgencyCommission.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validator.NotEmpty(txtName) && Validator.ValidDate(txtStartDate) && Validator.ValidDate(txtEndDate) && Validator.NotEmpty(txtDescription) && Validator.NotNegative(txtAgencyCommission))
            {
                currentPackage.PkgName = txtName.Text;
                currentPackage.PkgStartDate = Convert.ToDateTime(txtStartDate.Text);
                currentPackage.PkgEndDate = Convert.ToDateTime(txtEndDate.Text);
                currentPackage.PkgDesc = txtDescription.Text;
                currentPackage.PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommission.Text);
                DialogResult = DialogResult.OK;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //if (Package.CurrentPackage != null)
            //{
            //    Package.CurrentPackage.Clear();
            //}

            txtName.Text = "";
            txtName.Focus();
            txtEndDate.Text = "";
            txtStartDate.Text = "";
            txtDescription.Text = "";
            txtBasePrice.Text = "0";
            txtAgencyCommission.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}


