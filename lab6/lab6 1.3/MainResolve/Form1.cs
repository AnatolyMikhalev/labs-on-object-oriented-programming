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
        Pen penBlue, penClear;
        static int n = 22;
        int count = 0;
        int check = 7;
        Random rand = new Random();
        TFigure[] array;

        public Form1()
        {
            InitializeComponent();
            Init();
            this.KeyPreview = true;
        }

        private void Init()
        {
            graph = picture.CreateGraphics();
            penBlue = new Pen(Color.Blue);
            penClear = new Pen(Color.White);
            AllFiguresButton.Checked = true;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (array != null)
            {
                foreach (var a in array)
                {
                    a.Show(graph, penBlue);
                }
            }
            else
            {
                MessageBox.Show("Массив пуст");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1:
                    {
                        foreach (var a in array)
                        {
                            if (a is Line)
                                a.Remove(graph);
                        }
                        break;
                    }
                case 2:
                    {
                        foreach (var a in array)
                        {
                            if (a is Box)
                                a.Remove(graph);
                        }
                        break;
                    }
                case 3:
                    {
                        foreach (var a in array)
                        {
                            if (a is Circle)
                                a.Remove(graph);
                        }
                        break;
                    }
                case 4:
                    {
                        foreach (var a in array)
                        {
                            if (a is RectangleFigure)
                                a.Remove(graph);
                        }
                        break;
                    }
                case 5:
                    {
                        foreach (var a in array)
                        {
                            if (a is Romb)
                                a.Remove(graph);
                        }
                        break;
                    }
                case 6:
                    {
                        foreach (var a in array)
                        {
                            if (a is Ellipse)
                                a.Remove(graph);
                        }
                        break;
                    }
                case 7:
                    {
                        foreach (var a in array)
                        {
                            if (a is TFigure)
                                a.Remove(graph);
                        }
                        break;
                    }

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            count = 0;
            array = null;

        }


        private void Figure_Selection(object sender, EventArgs e)
        {
            if (LineButton.Checked)
            {
                check = 1;
            }
            else if (BoxButton.Checked)
            {
                check = 2;
            }
            else if (CircleButton.Checked)
            {
                check = 3;
            }
            else if (RectangleButton.Checked)
            {
                check = 4;
            }
            else if (RombButton.Checked)
            {
                check = 5;
            }
            else if (EllipseButton.Checked)
            {
                check = 6;
            }
            else if (AllFiguresButton.Checked)
            {
                check = 7;
            }
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
                    MoveFigures(x, y);
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

        private void RotateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i] is Ellipse)
                    (array[i] as Ellipse).Rotate(graph);
            }
        }

        private void MoveFigures(int dx, int dy)
        {
            int x, y;
            x = dx;
            y = dy;
            switch (check)
            {
                case 1:
                    {
                        foreach (var a in array)
                        {
                            if (a is Line)
                                a.MoveTo(graph, x, y);
                        }
                        break;
                    }
                case 2:
                    {
                        foreach (var a in array)
                        {
                            if (a is Box)
                                a.MoveTo(graph, x, y);
                        }
                        break;
                    }
                case 3:
                    {
                        foreach (var a in array)
                        {
                            if (a is Circle)
                                a.MoveTo(graph, x, y);
                        }
                        break;
                    }
                case 4:
                    {
                        foreach (var a in array)
                        {
                            if (a is RectangleFigure)
                                a.MoveTo(graph, x, y);
                        }
                        break;
                    }
                case 5:
                    {
                        foreach (var a in array)
                        {
                            if (a is Romb)
                                a.MoveTo(graph, x, y);
                        }
                        break;
                    }
                case 6:
                    {
                        foreach (var a in array)
                        {
                            if (a is Ellipse)
                                a.MoveTo(graph, x, y);
                        }
                        break;
                    }
                case 7:
                    {
                        foreach (var a in array)
                        {
                            if (a is TFigure)
                                a.MoveTo(graph, x, y);
                        }
                        break;
                    }

            }
            
        } 

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (count != 0)
            {
                if (e.KeyCode == Keys.Left)
                        MoveFigures(-5,0);

                if (e.KeyCode == Keys.Right)
                        MoveFigures(5, 0);

                if (e.KeyCode == Keys.Up)
                    foreach (var a in array)
                        MoveFigures(0, 5);

                if (e.KeyCode == Keys.Down)
                    foreach (var a in array)
                        MoveFigures(0, -5);
            }
            else
            {
                MessageBox.Show("Массив пуст!");
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (count < n)
            {
                array = new TFigure[n];
                Random rand = new Random();
                foreach (var a in array)
                {
                    int rnd = rand.Next(6);

                    switch (rnd)
                    {
                        case 0:
                            {
                                array[count] = new Box(picture, rand);
                                break;
                            }
                        case 1:
                            {
                                array[count] = new RectangleFigure(picture, rand);
                                break;
                            }
                        case 2:
                            {
                                array[count] = new Romb(picture, rand);
                                break;
                            }
                        case 3:
                            {
                                array[count] = new Line(picture, rand);
                                break;
                            }
                        case 4:
                            {
                                array[count] = new Circle(picture, rand);
                                break;
                            }
                        case 5:
                            {
                                array[count] = new Ellipse(picture, rand);
                                break;
                            }
                    }
                    count++;


                }
            }
            else
            {
                MessageBox.Show("Массив заполнен");
            }
        }












    }
}
