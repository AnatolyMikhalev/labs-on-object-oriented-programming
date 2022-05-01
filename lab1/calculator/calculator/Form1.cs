using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string C;
        public string N1;
        public bool n2;

        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if(textBox1.Text=="0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            C = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            C = B.Text;
            N1 = textBox1.Text;
            n2 = true; 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (C == "+")
            {
                res = dn1 + dn2;
            }
            if (C == "-")
            {
                res = dn1 - dn2;
            }
            if (C == "X")
            {
                res = dn1 * dn2;
            }
            if (C == "/")
            {
                res = dn1 / dn2;
            }
            n2 = true;
            textBox1.Text = res.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
    }
}
