using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using MyProj;

namespace _1
{
    public partial class CreateFigures : Form
    {
        Bitmap bmp;
        Graphics graph;
        //Pen pen;
        List<Circle> circles = new List<Circle>();
        List<Box> boxes = new List<Box>();
        List<Line> lines = new List<Line>();
        private int check; 
        public CreateFigures()
        {
            InitializeComponent();
            Init();
            //pen = new Pen(Color.Blue);
            //Draw();
            ClearAll();
        }
        private void Init()
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            //graph = picture.CreateGraphics();
            //lines.Add(new Line(10, 20, 500, 60));
            //boxes.Add(new Box(10, 20, 50, 60));
            //circles.Add(new Circle(200, 200, 100));
        }
        private void Draw()
        {

            foreach(var a in lines)
            {
                a.Show(graph);
            }
            foreach(var a in boxes)
            {
                a.Show(graph);
            }
            foreach(var a in circles)
            {
                a.Show(graph);
            }
            picture.Image = bmp;
        }

        public void ClearAll()
        {
            graph.Clear(Color.White);
        }

        private void CheckedFigures(object sender, EventArgs e)
        {
            if (Line.Checked)
            {
                check = 1;
                X1coord.ReadOnly = false;
                X2coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                Y2coord.ReadOnly = false;
                Radius.ReadOnly = true;

                X1coord.Text = "";
                X2coord.Text = "";
                Y1coord.Text = "";
                Y2coord.Text = "";
                Radius.Text = "Нет доступа";


            }
            else if (Rectangle.Checked)
            {
                check = 2;
                X1coord.ReadOnly = false;
                X2coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                Y2coord.ReadOnly = false;
                Radius.ReadOnly = true;

                X1coord.Text = "";
                X2coord.Text = "";
                Y1coord.Text = "";
                Y2coord.Text = "";
                Radius.Text = "Нет доступа";
            }
            else if (Circle.Checked)
            {
                check = 3;
                X1coord.ReadOnly = false;
                X2coord.ReadOnly = true;
                Y1coord.ReadOnly = false;
                Y2coord.ReadOnly = true;
                Radius.ReadOnly = false;

                X1coord.Text = "";
                X2coord.Text = "Нет доступа";
                Y1coord.Text = "";
                Y2coord.Text = "Нет доступа";
                Radius.Text = "";
            }
        }

        public void BuildFigures(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1:
                    try 
                    {
                        lines.Add(new Line(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(X2coord.Text), Convert.ToInt32(Y2coord.Text)));
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }

                    break;
                case 2:
                    try
                    {
                        boxes.Add(new Box(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(X2coord.Text), Convert.ToInt32(Y2coord.Text)));
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 3:
                    try
                    {
                        circles.Add(new Circle(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(Radius.Text)));
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;

            }

            Draw();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //graph.Clear(Color.White);
            ClearAll();
            //this.CreateGraphics().Clear(CreateFigures.ActiveForm.BackColor);
            //Graphics.FromImage(bmp).Clear(Color.Blue);

        }
    }
}


