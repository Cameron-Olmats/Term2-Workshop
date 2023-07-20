﻿using System;
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
        public SupplierContact? contact;

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            if (sup == null)
            {
                sup = new Supplier();
                contact = new SupplierContact();
                return;
            }
        }
    }
}
