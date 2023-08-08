using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace TravelExpertsGUI
{
    internal class PackageValidator
    {
        // !!!!! Validation here !!!!!!
        Package currentPackage = new Package();
        //currentPackage.PackageId = Convert.ToInt32(txtID.Text);
        
            //currentPackage.PkgName = frmtxtName.Text;
            //currentPackage.PkgStartDate = Convert.ToDateTime(txtStartDate.Text);
            //currentPackage.PkgEndDate = Convert.ToDateTime(txtEndDate.Text);
            //currentPackage.PkgDesc = txtDescription.Text;
            //currentPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);
            //currentPackage.PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommission.Text);
            //this.DialogResult = DialogResult.OK;
    }
}

namespace TravelExpertsGUI
{

    public class Validator
    {

        public static bool NotEmpty(TextBox tbx)
        {
            if (tbx.Text == "")
            {
                tbx.Focus();
                MessageBox.Show(tbx.Name + " is required.");
                return false;
            }
            return true;
        }

        public static bool IsSelected(ComboBox cb)
        {
            if (cb.SelectedIndex == -1)
            {
                cb.Focus();
                MessageBox.Show(cb.Name + " is required.");
                return false;
            }
            return true;
        }

        public static bool IsNumber(TextBox tbx)
        {
            if (!NotEmpty(tbx)) return false;
            decimal outPut;
            if (!decimal.TryParse(tbx.Text, out outPut))
            {
                tbx.Focus();
                MessageBox.Show("Text entered is not a number.");
                return false;
            }
            return true;
        }

        public static bool NotNegative(TextBox tbx)
        {
            if (!NotEmpty(tbx)) return false;
            decimal outPut;
            if (!decimal.TryParse(tbx.Text, out outPut))
            {
                tbx.Focus();
                MessageBox.Show("Text entered is not a number.");
                return false;
            }
            else if (outPut < 0)
            {
                tbx.Focus();
                MessageBox.Show("Number is less then 0.");
                return false;
            }


            return true;
        }

        public static bool GreaterThan(TextBox tbxBigger, TextBox tbxSmaller)
        {
            if (!NotNegative(tbxBigger) || !NotNegative(tbxSmaller))
            {
                return false;
            }
            if (decimal.Parse(tbxBigger.Text) < decimal.Parse(tbxSmaller.Text))
            {
                tbxSmaller.Focus();
                //MessageBox.Show("The textbox: " + tbxSmaller.Name + " must be smaller then: " + tbxBigger.Name + ".");
                MessageBox.Show("" + tbxSmaller.Tag + " must be smaller than " + tbxBigger.Tag + ".");
                return false;
            }
            return true;
        }

        // Cameron O:
        public static bool DateGreaterThan(DateTimePicker startPicker, DateTimePicker endPicker)
        {
            if (startPicker.Value > endPicker.Value)
            {
                startPicker.Focus();
                MessageBox.Show($"{startPicker.Tag} must be before {endPicker.Tag}.");
                return false;
            }
            return true;
        }

        public static bool ValidDate(TextBox tbx)
        {
            if (!NotEmpty(tbx)) return false;
            DateTime dt;
            if (!DateTime.TryParse(tbx.Text, out dt))
            {
                tbx.Focus();
                MessageBox.Show("Text entered is not a date.");
                return false;
            }

            return true;
        }

    }
}
