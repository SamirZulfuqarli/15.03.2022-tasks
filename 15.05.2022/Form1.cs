using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._05._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int cavab1 = 0;
            int cavab2 = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 4 == 0 && i % 6 == 0)
                {
                    cavab1++;
                    cavab2 += i;

                }
            }
            label1.Text = $"{cavab1.ToString()}";
            label2.Text = cavab2.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            double cavab = 0;
            cavab = Math.Pow(a, b);
            label3.Text = $"{cavab.ToString()}";
        }
    }
}
