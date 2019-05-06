using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assg4
{
    public partial class ShopForm : Form
    {
        public product[] products = new product[100];
        bool queryPrice = true;

        public ShopForm()
        {
            InitializeComponent();
            for(int i = 0; i < 100; i++)
                products[i] = new product("None", 0, -1);
            products[0] = new product("Computer", 6199.00, 20);
            products[1] = new product("Phone", 4688.00, 30);
            Synchronize();
        }

        private void priceButton_CheckedChanged(object sender, EventArgs e)
        {
            queryPrice = true;
        }

        private void numberButton_CheckedChanged(object sender, EventArgs e)
        {
            queryPrice = false;
        }
        
        private void queryButton_Click(object sender, EventArgs e)
        {
            if (queryPrice)
            {
                for (int i = 0; i < 100; i++)
                {
                    if ((products[i].name.CompareTo((string)queryComboBox.SelectedItem) == 0) && (products[i].stock >= 0))
                        queryLabel.Text = ("$" + products[i].price);
                }
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    if ((products[i].name.CompareTo((string)queryComboBox.SelectedItem) == 0) && (products[i].stock >= 0))
                        queryLabel.Text = (products[i].stock + "");
                }
            }
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void modifyOrRemoveButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            double amount = 0;
            int[] temp = {0,0,0,0,0 };

            if ("- - - -".CompareTo((string)comboBox1.SelectedItem) != 0)
                temp[0] = 1;
            if ("- - - -".CompareTo((string)comboBox2.SelectedItem) != 0)
                temp[1] = 1;
            if ("- - - -".CompareTo((string)comboBox3.SelectedItem) != 0)
                temp[2] = 1;
            if ("- - - -".CompareTo((string)comboBox4.SelectedItem) != 0)
                temp[3] = 1;
            if ("- - - -".CompareTo((string)comboBox5.SelectedItem) != 0)
                temp[4] = 1;

            if(temp[0] == 1)
            {
                for (int i = 0; i < 100; i++)
                {
                    if ((products[i].name.CompareTo((string)comboBox1.SelectedItem) == 0) && (products[i].stock >= 0))
                        amount += products[i].price * Convert.ToInt32(textBox1.Text);
                    if (textBox1.Text.CompareTo("-") != 0)
                        products[i].stock -= Convert.ToInt32(textBox1.Text);
                }
            }
            if (temp[1] == 1)
            {
                for (int i = 0; i < 100; i++)
                {
                    if ((products[i].name.CompareTo((string)comboBox2.SelectedItem) == 0) && (products[i].stock >= 0))
                        amount += products[i].price * Convert.ToInt32(textBox2.Text);
                    if (textBox2.Text.CompareTo("-") != 0)
                        products[i].stock -= Convert.ToInt32(textBox2.Text);
                }
            }
            if (temp[2] == 1)
            {
                for (int i = 0; i < 100; i++)
                {
                    if ((products[i].name.CompareTo((string)comboBox3.SelectedItem) == 0) && (products[i].stock >= 0))
                        amount += products[i].price * Convert.ToInt32(textBox3.Text);
                    if(textBox3.Text.CompareTo("-") != 0)
                        products[i].stock -= Convert.ToInt32(textBox3.Text);
                }
            }
            if (temp[3] == 1)
            {
                for (int i = 0; i < 100; i++)
                {
                    if ((products[i].name.CompareTo((string)comboBox4.SelectedItem) == 0) && (products[i].stock >= 0))
                        amount += products[i].price * Convert.ToInt32(textBox4.Text);
                    if (textBox4.Text.CompareTo("-") != 0)
                        products[i].stock -= Convert.ToInt32(textBox4.Text);
                }
            }
            if (temp[4] == 1)
            {
                for (int i = 0; i < 100; i++)
                {
                    if ((products[i].name.CompareTo((string)comboBox5.SelectedItem) == 0) && (products[i].stock >= 0))
                        amount += products[i].price * Convert.ToInt32(textBox5.Text);
                    if (textBox5.Text.CompareTo("-") != 0)
                        products[i].stock -= Convert.ToInt32(textBox5.Text);
                }
            }
            PurchaseLabel.Text ="$" + amount;
            Synchronize();

        }

        public void Synchronize()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox1.Items.Add("- - - -");
            comboBox2.Items.Add("- - - -");
            comboBox3.Items.Add("- - - -");
            comboBox4.Items.Add("- - - -");
            comboBox5.Items.Add("- - - -");
            for (int i = 0; i < 100; i++)
            {
                if (products[i].stock >= 0)
                {
                    comboBox1.Items.Add(products[i].name);
                    comboBox2.Items.Add(products[i].name);
                    comboBox3.Items.Add(products[i].name);
                    comboBox4.Items.Add(products[i].name);
                    comboBox5.Items.Add(products[i].name);
                }
            }
        }

    }

    public class product
    {
        public string name;
        public double price;
        public int stock;

        public product(string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }
        public override string ToString()
        {
            return name;
        }
    }

}
