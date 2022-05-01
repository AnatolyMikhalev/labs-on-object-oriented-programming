using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyProj
{
    public class Line : TFigure
    {
        private int x2, y2;
        private int length;
        public Line(int x1, int y1, int lenght, PictureBox picture, int id)
            : base(picture, x1, y1, id)
        {
            name = "Line " + id;
            Length = lenght;
        }
        public Line(int x1, int y1, int x2, int y2, PictureBox picture, int id = 0)
            : base(picture, x1, y1, id)
        {
            name = "Line " + id;
            X2 = x2;
            Y2 = y2;
        }
        public Line(PictureBox picture, int id, Pixel pixel, int lenght)
            : base(picture, pixel, id)
        {
            name = "Line " + id;
            Length = lenght;
        }
        public Line(PictureBox picture, int id)                                              // Random   
            : base(picture, id)
        {
            name = "Line " + id;
            Random rnd = new Random();
            int x = rnd.Next(0, picture.Width);
            int y = rnd.Next(0, picture.Height);
            coords = new Pixel(picture, x, y);
            Length = rnd.Next(0, picture.Width - base.X);
        }

        public int X2
        {
            set
            {
                if (value < 0 || value > picture_Width)
                {
                    throw new Exception();
                }
                x2 = value;
            }
            get
            {
                return x2;
            }
        }

        public int Y2
        {
            set
            {
                if (value < 0 || value > picture_Height)
                {
                    throw new Exception();
                }
                y2 = value;
            }
            get
            {
                return y2;
            }
        }
        public int Length
        {
            set
            {
                if (value < 0 || value + X > picture_Width)
                {
                    throw new Exception();
                }
                length = value;
            }
            get
            {
                return length;
            }
        }
        public override void MoveTo(Graphics graph, int dx, int dy)
        {
            Pen pen = new Pen(Color.White);
            Show(graph, pen);
            int x1 = X;
            int y1 = Y;
            try
            {
                X = x1 + dx;
                Y = y1 + dy;
            }
            catch
            {
                X = x1;
                Y = y1;
                throw new Exception();
            }
        }
        public void MoveToCoords(Graphics graph, int dx, int dy)
        {
            Pen pen = new Pen(Color.White);
            ShowToCoords(graph, pen);
            int x1 = X;
            int y1 = Y;
            int x2 = X2;
            int y2 = Y2;
            try
            {
                X = x1 + dx;
                Y = y1 + dy;
                X2 = x2 + dx;
                Y2 = y2 + dy;
            }
            catch
            {
                X = x1;
                Y = y1;
                X2 = x2;
                Y2 = y2;
                throw new Exception();
            }
        }


        public override void Show(Graphics graph, Pen pen)
        {
            graph.DrawLine(pen, base.X, Y, X + Length, Y);
        }
        public void ShowToCoords(Graphics graph, Pen pen)
        {
            graph.DrawLine(pen, X, Y, X2, Y2);
        }


    }
}


