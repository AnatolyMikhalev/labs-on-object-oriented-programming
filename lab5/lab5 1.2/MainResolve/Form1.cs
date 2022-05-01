using MyProj;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab5
{
    public partial class CreateFigures : Form
    {
        Graphics graph;
        Pen penBlue, penClear;

        int count;
        TFigure[] listFigures = new TFigure[15];

        private int check;
        public CreateFigures()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            graph = picture.CreateGraphics();
            penBlue = new Pen(Color.Blue);
            penClear = new Pen(Color.White);
        }
        private void Draw(Pen pen)
        {
            foreach (var a in listFigures)
            {
                a.Show(graph, pen);
            }
        }

        public void ClearAll()
        {
            graph.Clear(Color.White);

            X1coord.Clear();
            X2coord.Clear();
            Y1coord.Clear();
            Y2coord.Clear();
            Radius.Clear();
            textBoxDX.Clear();
            textBoxDY.Clear();
            lines.Clear();
            boxes.Clear();
            circles.Clear();
            rectangles.Clear();
            rombs.Clear();
            ellipses.Clear();
            listBox.Items.Clear();

        }

        private void CheckedFigures(object sender, EventArgs e)
        {
            if (LineButton.Checked)
            {
            }
            else if (BoxButton.Checked)
            {
            }
            else if (CircleButton.Checked)
            {
            }
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            int IndexObject;
            try
            {

            }
            catch
            {
                MessageBox.Show("Выберите объект");
            }
            

        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            foreach (var a in listFigures)
            {
                a.Rotate(graph);
            }
            Draw(penBlue);
        }

        private void CreateFigures_Load(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Выберите объект");
            }
        }


        private void CreateSetButton_Click(object sender, EventArgs e)
        {
            int TypeOfFigure;
            if (count != 0)
                Array.Resize<TFigure>(ref array, count + 1);
            TypeOfFigure = rnd.Next(0, 7);
            switch (TypeOfFigure)
            {
                case 0:
                    {
                        array[count] = new Circle(rnd.Next(20, 400), rnd.Next(20, 400), rnd.Next(60, 100));
                        break;
                    }
                case 1:
                    {
                        array[count] = new Rectan(rnd.Next(20, 400), rnd.Next(20, 400), rnd.Next(60, 100), rnd.Next(60, 100));
                        break;
                    }
                case 2:
                    {
                        array[count] = new Triangle(rnd.Next(0, 300), rnd.Next(0, 300), rnd.Next(60, 100), rnd.Next(60, 100));
                        break;
                    }
                case 3:
                    {
                        array[count] = new Segment(rnd.Next(0, 300), rnd.Next(0, 300), rnd.Next(60, 100));
                        break;
                    }
                case 4:
                    {
                        array[count] = new Ellipse(rnd.Next(20, 400), rnd.Next(20, 400), rnd.Next(60, 100), rnd.Next(60, 100));
                        break;
                    }
                case 5:
                    {
                        array[count] = new Trapeze(rnd.Next(20, 400), rnd.Next(20, 400), rnd.Next(60, 100), rnd.Next(60, 100));
                        break;
                    }
                case 6:
                    {
                        array[count] = new Rhombus(rnd.Next(20, 400), rnd.Next(20, 400), rnd.Next(60, 100), rnd.Next(60, 100));
                        break;
                    }
            }
            count++;

            Draw(penBlue);
        }
        private void CreateRandomButton_Click(object sender, EventArgs e)
        {
            int TypeOfFigure;
            //if (count != 0)
            //Array.Resize<TFigure>(ref array, count + 1);
            TypeOfFigure = rnd.Next(0, 6);
            switch (TypeOfFigure)
            {
                case 0:
                    {
                        array[count] = new Circle(rnd.Next(20, 400), rnd.Next(20, 400), rnd.Next(60, 100));
                        break;
                    }
                case 1:
                    {
                        array[count] = new Rectan(rnd.Next(20, 400), rnd.Next(20, 400), rnd.Next(60, 100), rnd.Next(60, 100));
                        break;
                    }
                case 2:
                    {
                        array[count] = new Triangle(rnd.Next(0, 300), rnd.Next(0, 300), rnd.Next(60, 100), rnd.Next(60, 100));
                        break;
                    }
                case 3:
                    {
                        array[count] = new Segment(rnd.Next(0, 300), rnd.Next(0, 300), rnd.Next(60, 100));
                        break;
                    }
                case 4:
                    {
                        array[count] = new Ellipse(rnd.Next(20, 400), rnd.Next(20, 400), rnd.Next(60, 100), rnd.Next(60, 100));
                        break;
                    }
                case 5:
                    {
                        array[count] = new Trapeze(rnd.Next(20, 400), rnd.Next(20, 400), rnd.Next(60, 100), rnd.Next(60, 100));
                        break;
                    }
                case 6:
                    {
                        array[count] = new Rhombus(rnd.Next(20, 400), rnd.Next(20, 400), rnd.Next(60, 100), rnd.Next(60, 100));
                        break;
                    }
            }
            count++;

            Draw(penBlue);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();

        }
    }
}


