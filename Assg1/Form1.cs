using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int interest;
        private double amount;

        private void simpleButton_CheckedChanged(object sender, EventArgs e)
        {
            interest = 0;
        }

        private void compoundButton_CheckedChanged(object sender, EventArgs e)
        {
            interest = 1;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double principal = Convert.ToDouble(principalText.Text);
            double rate = Convert.ToDouble(rateText.Text) * 0.01;
            int period = Convert.ToInt32(loanPeriodText.Text);

            if (interest == 0)
            {
                amount = principal + principal * rate * period;
                amountLabel.Text = string.Format("{0}",amount);
            }
            if (interest == 1)
            {
                amount = principal + principal * Math.Pow((1 + rate), period);
                amountLabel.Text = string.Format("{0}", amount);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            principalText.Text = "";
            rateText.Text = "";
            loanPeriodText.Text = "";
            amountLabel.Text = "The result will be shown here";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
