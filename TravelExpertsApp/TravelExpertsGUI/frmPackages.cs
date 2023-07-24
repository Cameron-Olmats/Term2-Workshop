/*
 * Form for adding and editing travel packages
 * 
 * Author: Cameron Olmats
 * Date: 7/10/2023
 */

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
        public bool isAdd = true; // set to true for now but will be null later
        public frmPackages()
        {
            InitializeComponent();
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                currentPackage = new Package();
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // !!!!! Validation here !!!!!!
            //currentPackage.PackageId = Convert.ToInt32(txtID.Text);
            currentPackage.PkgName = txtName.Text;
            currentPackage.PkgStartDate = Convert.ToDateTime(txtStartDate.Text);
            currentPackage.PkgEndDate = Convert.ToDateTime(txtEndDate.Text);
            currentPackage.PkgDesc = txtDescription.Text;
            currentPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);
            currentPackage.PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommission.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
