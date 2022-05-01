using GraphicsApp;
using GraphicsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsApp
{
    public struct Pixel
    {
        public int x;
        public int y;

        public Pixel (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics graph;
        Pen pen;

        Line line1;
        Line line2;
        Box box1;
        Circle circle1;

        public Form1()
        {
            InitializeComponent();
            Init();
            Draw();
        }

        private void Init()
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue);
            line1 = new Line(100, 100, 200, 10);
            line2 = new Line(200, 10, 300, 100);
            box1 = new Box(100, 100, 300, 300);
            circle1 = new Circle(200, 200, 100);
        }

        private void Draw()
        {
            graph.DrawRectangle(pen, 100, 100, 200, 200);
            Draw(line1);
            Draw(line2);
            Draw(box1);
            Draw(circle1);
            picture.Image = bmp;
        }
        private void Draw (Line line){
            graph.DrawLine(pen, line.x1, line.y1, line.x2, line.y2);
        }

        private void Draw(Box box)
        {
            graph.DrawRectangle(pen, box.x1, box.y1, box.width, box.height);
        }

        private void Draw(Circle circle)
        {
            graph.DrawEllipse(pen, circle.x1, circle.y1, circle.width, circle.height);
        }
    }
}
