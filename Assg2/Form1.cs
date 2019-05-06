using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int order;
        private List<int> numbers = new List<int>();
        private void ascendingButton_CheckedChanged(object sender, EventArgs e)
        {
            order = 0;
        }

        private void descendingButton_CheckedChanged(object sender, EventArgs e)
        {
            order = 1;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int minnum, maxnum;
            try
            {
                minnum = int.Parse(textBox1.Text);
                maxnum = int.Parse(textBox2.Text);
                if (minnum > maxnum)
                {
                    int t = maxnum;
                    maxnum = minnum;
                    minnum = t;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Your input is invalid!", "Error");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            if(maxnum <= 1)
            {
                resultTextBox.Text = "there is no prime number.";
                return;
            }

            numbers.Clear();
            for(int i = 2; i <= maxnum; i++)
            {
                if (isPrimeNumber(i))
                    numbers.Add(i);
            }

            if(numbers.Count == 0)
            {
                resultTextBox.Text = "there is no prime number.";
            }
            else if(order == 0)
            {
                numbers.Sort();
                printNumbers(numbers);
            }
            else
            {
                numbers.Sort();
                numbers.Reverse();
                printNumbers(numbers);
            }
            
        }

        Boolean isPrimeNumber(int x)
        {
            int i;
            double k;
            k = Math.Sqrt(x);
            for (i = 2; i <= k; i++)
            {
                if (x % i == 0)
                    break;
            }
            if (i <= k)
                return false;
            else
                return true;
        }

        void printNumbers(List<int> n)
        {
            string a = "";
            foreach (int x in n)
            {
                a = a + x.ToString()+"\r\n";
            }
            resultTextBox.Text = a;
        }
    }
}
