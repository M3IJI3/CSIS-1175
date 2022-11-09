using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.XPath;

namespace Jie_300364433
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string temp;

        private void btnZero_Click(object sender, EventArgs e)
        {
            temp += "0";
            txbDisplay.Text = temp;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            temp += "1";
            txbDisplay.Text = temp;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            temp += "2";
            txbDisplay.Text = temp;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            temp += "3";
            txbDisplay.Text = temp;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            temp += "4";
            txbDisplay.Text = temp;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            temp += "5";
            txbDisplay.Text = temp;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            temp += "6";
            txbDisplay.Text = temp;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            temp += "7";
            txbDisplay.Text = temp;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            temp += "8";
            txbDisplay.Text = temp;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            temp += "9";
            txbDisplay.Text = temp;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            temp += ".";
            txbDisplay.Text = temp;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            temp += "+";
            txbDisplay.Text = temp;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            temp += "-";
            txbDisplay.Text = temp;     
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            temp += "x";
            txbDisplay.Text = temp;
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            temp += "/";
            txbDisplay.Text = temp;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            temp += "=";
            
            int intNumber;
            double decimalNumber;
            string[] numbers;

            double firstNumber;
            double secondNumber;
            double result;

            bool value;
            // btnResultClicked = !btnResultClicked;
            
            // split temp to find two numbers 
            numbers = temp.Split('+', '-', 'x', '/', '=');

            // judge if there is a "=" in the equation
            

            // judge if the numbers are legal
            while (((int.TryParse(numbers[0], out intNumber) || double.TryParse(numbers[0], out decimalNumber)) &&
                (int.TryParse(numbers[1], out intNumber) || double.TryParse(numbers[1], out decimalNumber))) == false)
            {
                MessageBox.Show("Please input valid numbers!");
                txbDisplay.Text = "";
                temp = "";
                txbDisplay.Focus();
                return;
            }

            firstNumber = double.Parse(numbers[0]);
            secondNumber = double.Parse(numbers[1]);

            // calculate
            if(txbDisplay.Text.Contains("+"))
            {
                result = firstNumber + secondNumber;
                temp += result;
                
            }
           
            else if(txbDisplay.Text.Contains("-"))
            {
                result = firstNumber - secondNumber;
                temp += result;
            }

            else if(txbDisplay.Text.Contains("x"))
            {
                result = firstNumber * secondNumber;
                temp += result;
            }

            else if(txbDisplay.Text.Contains("/"))
            {
                if(secondNumber == 0)
                {
                    txbDisplay.Text = "NaN";
                    MessageBox.Show("Invalid! Please try again!");
                    temp = "";
                }
                else
                {
                    result = firstNumber / secondNumber;
                    temp += result;
                }
                
            }

            txbDisplay.Text = temp;
            
            value = false;
            setBtnEnabled(value);

            btnReset.Visible = true;
            
        }
        
        private void setBtnEnabled(bool value)
        {
            btnZero.Enabled = value;
            btnOne.Enabled = value;
            btnTwo.Enabled = value;
            btnThree.Enabled = value;
            btnFour.Enabled = value;
            btnFive.Enabled = value;
            btnSix.Enabled = value;
            btnSeven.Enabled = value;
            btnEight.Enabled = value;
            btnNine.Enabled = value;
            btnPlus.Enabled = value;
            btnMinus.Enabled = value;
            btnTimes.Enabled = value;
            btnDevide.Enabled = value;
            btnPoint.Enabled = value;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbDisplay.Clear();
            btnReset.Visible = false;
            setBtnEnabled(true);
            temp = "";
        }
    }
}
