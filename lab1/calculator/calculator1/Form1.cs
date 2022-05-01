using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator1
{
    public partial class Калькулятор : Form
    {
        public string C;
        public string N1;
        public bool n2;
        public Калькулятор()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void Operations(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            C = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void Clean(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            C = "";
        }

        private void Delete(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void equally(object sender, EventArgs e)
        {
            double dn1, dn2;
            string res1;
            try
            {
                dn1 = Convert.ToDouble(N1);
                dn2 = Convert.ToDouble(textBox1.Text);
                if (dn2 == 0)
                {
                    throw new Exception();
                }
                else
                {
                    Equally res = new Equally(dn1, dn2, C);
                    res1 = res.Culculate();

                    n2 = true;
                    textBox1.Text = res1;
                }
            }
            catch
            {
                textBox1.Text = "Ошибка";
                C = "";
            }
        }
    }
}
