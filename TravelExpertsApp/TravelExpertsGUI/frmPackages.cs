/*
 * Form for adding and editing travel packages
 * 
 * Author: Dreesha 
 * Date: July 2023
 */

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
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
        private object model;
        private object secondform;

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
            package.PkgName = txtName.Text; 
            package.PkgStartDate = txtStartDate.Text; 
            package.PkgEndDate = txtEndDate.Text; 
            package.PkgDesc = txtDescription.Text;
            package.PkgAgencyCommission = txtAgencyCommission.Text;
            using (TravelExpertsContext db = new TravelExpertsContext()
            {
                db.Packages.Add(secondform.currentPackage)
            { 
            object value = db.Packages.SaveChanges.();
            }
            MessageBox.Show("Data has been added");



            
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (Package.CurrentPackage != null)
            {
                Package.CurrentPackage.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

   
    