using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConverter
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void btnConvertForBinary_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBinary.Text.Trim()))
                return;

            lblDecimalForBinary.Text = clsConvert.ConvertFromBinaryToDecimal(txtBinary.Text).ToString();
            lblHexaForBinary.Text = clsConvert.ConvertFromBinaryToHexadecimal(txtBinary.Text);
            lblOctalForBinary.Text = clsConvert.ConvertFromBinaryToOctal(txtBinary.Text);
        }

        private void txtBinary_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // to make sure that the user can only enter 0, 1 and use the back space.
            e.Handled = !(e.KeyChar == '1' || e.KeyChar == '0' || e.KeyChar == (char)Keys.Back);
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // to make sure that the user can only numbers
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void btnConvertForDecimal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDecimal.Text.Trim()))
                return;

            long Decimal = long.Parse(txtDecimal.Text);

            lblBinaryForDecimal.Text = clsConvert.ConvertFromDecimalToBinary(Decimal);
            lblHexaForDecimal.Text = clsConvert.ConvertFromDecimalToHexadecimal(Decimal);
            lblOctalForDecimal.Text = clsConvert.ConvertFromDecimalToOctal(Decimal);
        }

        private void txtHexadecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // to make sure that the user can only enter Hexadecimal
            e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar >= 'A' && e.KeyChar <= 'F') || (e.KeyChar >= 'a' && e.KeyChar <= 'f')) || char.IsControl(e.KeyChar));
        }

        private void btnConvertForHexa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHexadecimal.Text.Trim()))
                return;

            lblBinaryForHexa.Text = clsConvert.ConvertFromHexadecimalToBinary(txtHexadecimal.Text);
            lblDecimalForHexa.Text = clsConvert.ConvertFromHexadecimalToDecimal(txtHexadecimal.Text).ToString();
            lblOctalForHexa.Text = clsConvert.ConvertFromHexadecimalToOctal(txtHexadecimal.Text);
        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitle.Text = tcConverter.SelectedTab.Text;
        }

        private void txtOctal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // to make sure that the user can only enter Octal digits
            e.Handled = !((char.IsDigit(e.KeyChar) && e.KeyChar >= '0' && e.KeyChar <= '7') || char.IsControl(e.KeyChar));
        }

        private void btnConvertForOctal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOctal.Text.Trim()))
                return;

            lblBinaryForOctal.Text = clsConvert.ConvertFromOctalToBinary(txtOctal.Text);
            lblDecimalForOctal.Text = clsConvert.ConvertFromOctalToDecimal(txtOctal.Text).ToString();
            lblHexaForOctal.Text = clsConvert.ConvertFromOctalToHexadecimal(txtOctal.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBinary.Clear();
            txtDecimal.Clear();
            txtHexadecimal.Clear();
            txtOctal.Clear();

            lblDecimalForBinary.Text = "[????]";
            lblHexaForBinary.Text = "[????]";
            lblOctalForBinary.Text = "[????]";

            lblBinaryForDecimal.Text = "[????]";
            lblHexaForDecimal.Text = "[????]";
            lblOctalForDecimal.Text = "[????]";

            lblBinaryForHexa.Text = "[????]";
            lblDecimalForHexa.Text = "[????]";
            lblOctalForHexa.Text = "[????]";

            lblBinaryForOctal.Text = "[????]";
            lblDecimalForOctal.Text = "[????]";
            lblHexaForOctal.Text = "[????]";
        }
    }
}
