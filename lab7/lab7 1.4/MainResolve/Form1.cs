using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProj;

namespace MainResolve
{
    public partial class Form1 : Form
    {

        Graphics graph;
        Graphics graph1;
        static int n = 15;
        int count = 0;
        int check = 7;
        ElementaryContainer A;
        LinearList B;

        public Form1()
        {
            InitializeComponent();
            Init();
            this.KeyPreview = true;
        }

        private void Init()
        {
            graph = picture.CreateGraphics();
            graph1 = picture1.CreateGraphics();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            A.Iterator(graph, 0);
        }

        private void buttonShow1_Click(object sender, EventArgs e)
        {
            B.Iterator(graph1, 0);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            A.Iterator(graph, 1);
        }
        private void ClearButton1_Click(object sender, EventArgs e)
        {
            B.Iterator(graph1, 1);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            A.FreeAll();
        }
        private void DeleteButton1_Click(object sender, EventArgs e)
        {
            B.FreeAll();

        }



        private void buttonMove_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y;
                x = int.Parse(Xcoord.Text);
                y = int.Parse(Ycoord.Text);
                try
                {
                    A.Iterator(graph, 2, x, y);
                }
                catch
                {
                    MessageBox.Show("Неверные координаты");
                }
            }
            catch
            {
                MessageBox.Show("Неверные формат координат");
            }
        }
        private void buttonMove1_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y;
                x = int.Parse(X1coord.Text);
                y = int.Parse(Y1coord.Text);
                try
                {
                    B.Iterator(graph1, 2, x, y);
                }
                catch
                {
                    MessageBox.Show("Неверные координаты");
                }
            }
            catch
            {
                MessageBox.Show("Неверные формат координат");
            }

        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            A = new ElementaryContainer();
        }
        private void buttonCreate1_Click(object sender, EventArgs e)
        {
            B = new LinearList();
        }
        private void buttonCreateMass_Click(object sender, EventArgs e)
        {
            A = new ElementaryContainer(picture);
        }

        private void buttonCreateMass1_Click(object sender, EventArgs e)
        {
            B = new LinearList(picture1);
        }

        private void buttonCreateRandomFigure_Click(object sender, EventArgs e)
        {
            A.Add(picture);
        }


        private void buttonCreateRandomFigure1_Click(object sender, EventArgs e)
        {
            B.AddRandom(picture1);
        }

    }
}
