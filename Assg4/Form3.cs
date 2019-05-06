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
    public partial class Form3 : Form
    {
        ShopForm f1;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(ShopForm form1)
        {
            InitializeComponent();
            f1 = form1;
            for (int i = 0; i < 100; i++)
            {
                if (f1.products[i].stock >= 0)
                    comboBox1.Items.Add(f1.products[i].name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if ((f1.products[i].name.CompareTo((string)comboBox1.SelectedItem) == 0) && (f1.products[i].stock >= 0))
                {
                    f1.products[i].name = Convert.ToString(textBox1.Text);
                    f1.products[i].price = Convert.ToDouble(textBox2.Text);
                    f1.products[i].stock = Convert.ToInt32(textBox3.Text);
                    f1.queryComboBox.Items.Clear();
                    for (int j = 0; j < 100; j++)
                    {
                        if (f1.products[j].stock >= 0)
                            f1.queryComboBox.Items.Add(f1.products[j].name);
                    }
                    f1.Synchronize();
                    comboBox1.Items.Clear();
                    for (int j = 0; j < 100; j++)
                    {
                        if (f1.products[j].stock >= 0)
                            comboBox1.Items.Add(f1.products[j].name);
                    }
                    break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if ((f1.products[i].name.CompareTo((string)comboBox1.SelectedItem) == 0) && (f1.products[i].stock >= 0))
                {
                    textBox1.Text = f1.products[i].name;
                    textBox2.Text = f1.products[i].price+"";
                    textBox3.Text = f1.products[i].stock+"";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool match = false;
            string choose = (string)comboBox1.SelectedItem;
            for (int i = 0; i < 100; i++)
            {
                if ((f1.products[i].name.CompareTo(choose) == 0) && (f1.products[i].stock >= 0))
                {
                    f1.products[i].stock = -1;
                    match = true;
                }
                f1.queryComboBox.Items.Clear();
                for (int j = 0; j < 100; j++)
                {
                    if (f1.products[j].stock >= 0)
                        f1.queryComboBox.Items.Add(f1.products[j].name);
                }
                f1.Synchronize();
                comboBox1.Items.Clear();
                for (int j = 0; j < 100; j++)
                {
                    if (f1.products[j].stock >= 0)
                        comboBox1.Items.Add(f1.products[j].name);
                }
                while(match)
                    break;
            }
            MessageBox.Show("删除成功");
        }
    }
}
