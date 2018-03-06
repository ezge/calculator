using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        // global var     
        const int MAXLEN = 15;
        Double result = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign  | NumberStyles.AllowExponent;
        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB"); // convertion type

        public frmCalculator()
        {
            InitializeComponent();
            Enable(false);
        }
        
        private void Enable(bool display) // displaying the buttons
        {
            result = 0;
            if (display)
            {
                txtResult.Text = "0";
                lblHistory.Text = "";
                btnON.Hide();
                btnOFF.Show();
            }
            else
            {
                txtResult.Clear();
                lblHistory.Text = "";
                btnON.Show();
                btnOFF.Hide();
            }

            txtWords.Clear();
            btnZero.Enabled = display;
            btnOne.Enabled = display;
            btnTwo.Enabled = display;
            btnThree.Enabled = display;
            btnFour.Enabled = display;
            btnFive.Enabled = display;
            btnSix.Enabled = display;
            btnSeven.Enabled = display;
            btnEight .Enabled = display;
            btnNine.Enabled = display;
            btnBackspace.Enabled = display;
            btnClear.Enabled = display;
            btnAdd.Enabled = display;
            btnSub.Enabled = display;
            btnMul.Enabled = display;
            btnDiv.Enabled = display;
            btnResult.Enabled = display;
            btnNegative.Enabled = display;
            btnDot.Enabled = display;
            txtResult.Enabled = display;
            txtWords.Enabled = display;
            btnText.Enabled = display;
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            Enable(true);
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            Enable(false); 
        }

        private Double ConvertToNum(string text)
        {
            Double number = 0;
            
            if (Double.TryParse(text, style, culture, out number))
                return number;
            return 0;
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            
            Double number, n = 0;

            number = ConvertToNum(txtResult.Text); // formatting the number

            switch (operationPerformed)
            {
                    case "+":
                        n = Math.Floor((result + number) * 100) / 100;
                        txtResult.Text = n.ToString("G15", CultureInfo.InvariantCulture);
                        break;
                    case "-":
                        n = Math.Floor((result - number) * 100) / 100;
                        txtResult.Text = n.ToString("G15", CultureInfo.InvariantCulture);
                        break;
                    case "*":
                        n = Math.Floor((result * number) * 100) / 100;
                        txtResult.Text = n.ToString("G15", CultureInfo.InvariantCulture);
                        break;
                    case "/":
                        n = Math.Floor((result / number) * 100) / 100;
                        txtResult.Text = n.ToString("G15", CultureInfo.InvariantCulture);
                        break;
                    default:
                        break;
            }
            
            result = ConvertToNum(txtResult.Text); // formatting the result 
            lblHistory.Text = "";
            operationPerformed = "";
            txtWords.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clears the screen
            txtResult.Text = "0";
            result = 0;
            lblHistory.Text = "";
            txtWords.Text = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            // deletes digits
            int len = txtResult.Text.Length - 1;

            if (len >= 0)
                txtResult.Text = txtResult.Text.Remove(len, 1);

            if (txtResult.Text.Length == 0)
            {
                txtResult.Text = "0";
                txtWords.Clear();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // prints the digits
            if ((txtResult.Text == "0") || (isOperationPerformed))
                txtResult.Clear();

            isOperationPerformed = false;
            Button btn = sender as Button;

            if (btn.Text == ".") // decimal number
            {
                if (!txtResult.Text.Contains("."))
                    if (txtResult.Text.Length == 0)
                        txtResult.Text = "0" + btn.Text;
                    else txtResult.Text = txtResult.Text + btn.Text;
            }
            else if (btn.Text == "+/-") // negative number
            {
                int index = txtResult.Text.IndexOf('-');
                if (index < 0)
                    txtResult.Text = "-" + txtResult.Text;
                else txtResult.Text = txtResult.Text.Remove(index, 1);
            }
            else txtResult.Text = txtResult.Text + btn.Text;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            // assigns current operation
            Button btn = sender as Button;

            if (result != 0)
                btnResult.PerformClick();
            else  Double.TryParse(txtResult.Text, style, culture, out result);
            
            operationPerformed = btn.Text;
            lblHistory.Text = result.ToString("G15", CultureInfo.InvariantCulture) +" " + operationPerformed;
            isOperationPerformed = true;
        }

        private void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            // keyboard pads
            txtResult.Focus();
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btnZero.PerformClick();
                    break;

                case "1":
                    btnOne.PerformClick();
                    break;
                case "2":
                    btnTwo.PerformClick();
                    break;

                case "3":
                    btnThree.PerformClick();
                    break;

                case "4":
                    btnFour.PerformClick();
                    break;

                case "5":
                    btnFive.PerformClick();
                    break;

                case "6":
                    btnSix.PerformClick();
                    break;

                case "7":
                    btnSeven.PerformClick();
                    break;

                case "8":
                    btnEight.PerformClick();
                    break;

                case "9":
                    btnNine.PerformClick();
                    break;

                case "+":
                    btnAdd.PerformClick();
                    break;

                case "-":
                    btnSub.PerformClick();
                    break;
                case "*":
                    btnMul.PerformClick();
                    break;

                case "/":
                    btnDiv.PerformClick();
                    break;
                case "=":
                    btnResult.PerformClick();
                    break;
                case ".":
                    btnDot.PerformClick();
                    break;
                case "\b":
                    btnBackspace.PerformClick();
                    break;
                case "\r":
                    btnResult.PerformClick();
                    break;
                default :
                    break;
            }
        }

        private void tResult_TextChanged(object sender, EventArgs e)
        {
            // maximum number of digits
           // int len = txtResult.Text.Length;

           // if (len > MAXLEN)
             //   txtResult.Text = txtResult.Text.Remove(len - 1);

        }

        private void btnText_Click(object sender, EventArgs e)
        {
                // converts numbers to words, in Serbian lang
                Double number = ConvertToNum(txtResult.Text);
                txtWords.Text = Converter.NumWordsWrapper(number);
        }

    }
}
