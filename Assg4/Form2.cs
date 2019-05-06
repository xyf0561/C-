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
    public partial class Form2 : Form
    {
        ShopForm f1;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(ShopForm form1)
        {
            InitializeComponent();
            f1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                if (f1.products[i].stock < 0)
                {
                    f1.products[i].name = Convert.ToString(textBox1.Text);
                    f1.products[i].price = Convert.ToDouble(textBox2.Text);
                    f1.products[i].stock = Convert.ToInt32(textBox3.Text);
                    f1.queryComboBox.Items.Add(f1.products[i].name);
                    f1.Synchronize();
                    break;
                }
            }
            MessageBox.Show("添加成功");
        }
    }
}
