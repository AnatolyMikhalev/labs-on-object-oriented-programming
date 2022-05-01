using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyProj
{
    public class Line
    {
        private int x2, y2;
        private int length;
        private int picture_Width;
        private int picture_Height;
        private Pixel pixel;
        public int id { get; set; }
        public string name { get; set; }
        public Line(int x1, int y1, int lenght, PictureBox picture, int id)
        {
            this.id = id;
            name = "Line " + id;
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            pixel = new Pixel(picture, x1, y1);
            Length = lenght;
        }
        public Line(int x1, int y1, int x2, int y2, PictureBox picture, int id = 0)
        {
            this.id = id;
            name = "Line " + id;
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;

            pixel = new Pixel(picture, x1, y1);
            X2 = x2;
            Y2 = y2;
        }
        public Line(PictureBox picture, int id, Pixel pixel1, int lenght)
        {
            this.id = id;
            name = "Line " + id;
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            pixel = pixel1;
            Length = lenght;
        }
        public Line(PictureBox picture, int id)
        {
            this.id = id;
            name = "Line " + id;
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            Random rnd = new Random();
            int x1 = rnd.Next(0, picture.Width);
            int y1 = rnd.Next(0, picture.Height);
            pixel = new Pixel(picture, x1, y1);
            Length = rnd.Next(0, picture.Width - X1);
        }

        public int X1
        {
            set
            {
                if (value < 0 || value > picture_Width)
                {
                    throw new Exception();
                }
                pixel.X = value;
            }
            get
            {
                return pixel.X;
            }
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
        public int Y1
        {
            set
            {
                if (value < 0 || value > picture_Height)
                {
                    throw new Exception();
                }
                pixel.Y = value;
            }
            get
            {
                return pixel.Y;
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
                if (value < 0 || value + X1 > picture_Width)
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
        public void MoveTo(Graphics graph, int dx, int dy)
        {
            Pen pen = new Pen(Color.White);
            Show(graph, pen);
            int x1 = X1;
            int y1 = Y1;
            try
            {
                X1 = x1 + dx;
                Y1 = y1 + dy;
            }
            catch
            {
                X1 = x1;
                Y1 = y1;
                throw new Exception();
            }
        }
        public void MoveToHeart(Graphics graph, int dx, int dy)
        {
            Pen pen = new Pen(Color.White);
            ShowHeart(graph, pen);
            int x1 = X1;
            int y1 = Y1;
            int x2 = X2;
            int y2 = Y2;
            try
            {
                X1 = x1 + dx;
                Y1 = y1 + dy;
                X2 = x2 + dx;
                Y2 = y2 + dy;
            }
            catch
            {
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
                throw new Exception();
            }
        }


        public void Show(Graphics graph, Pen pen)
        {
            graph.DrawLine(pen, X1, Y1, X1+Length, Y1);
        }
        public void ShowHeart(Graphics graph, Pen pen)
        {
            graph.DrawLine(pen, X1, Y1, X2, Y2);
        }



    }
}


