using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyProj
{
    public class Circle
    {

        private int radius;
        private int width;
        private int height;
        private int picture_Width;
        private int picture_Height;
        private Pixel pixel;
        public int id { get; set; }
        public string name { get; set; }


        public Circle(int x, int y, int radius, PictureBox picture, int id = 0)
        {
            this.id = id;
            name = "Circle " + id;
            picture_Width = picture.Width;
            picture_Height = picture.Height;
            Radius = radius;
            pixel = new Pixel(picture, x, y);
            X = X - radius;
            Y = Y - radius;
        }
        
        public Circle(Pixel pixel1, int radius, PictureBox picture, int id = 0)
        {
            this.id = id;
            name = "Circle " + id;
            picture_Width = picture.Width;
            picture_Height = picture.Height;
            Radius = radius;
            pixel = new Pixel(picture, pixel1.X, pixel1.Y);
            X = X - radius;
            Y = Y - radius;
        }

        public Circle(PictureBox picture, int id = 0)
        {
            this.id = id;
            name = "Circle " + id;
            picture_Width = picture.Width;
            picture_Height = picture.Height;
            Random rnd = new Random();
            Radius = rnd.Next(30, Math.Min(picture_Width, picture_Height)/2);
            int x = rnd.Next(0, picture.Width - 2*radius);
            int y = rnd.Next(0, picture.Height - 2*radius);
            pixel = new Pixel(picture, x, y);
        }
        public int X
        {
            set
            {
                if (value < 0 || value + 2 * radius > picture_Width)
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
        public int Y
        {
            set
            {
                if (value < 0 || value + 2 * radius > picture_Height)
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
        public int Radius
        {
            set
            {
                if (value < 15)
                {
                    throw new Exception();
                }
                radius = value;
            }
            get
            {
                return radius;
            }
        }

        public void MoveTo(Graphics graph, int dx, int dy)
        {
            Pen pen = new Pen(Color.White);
            Show(graph, pen);
            int x1 = pixel.X;
            int y1 = pixel.Y;
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
        public void Show(Graphics graph, Pen pen)
        {
            graph.DrawEllipse(pen, pixel.X, pixel.Y, Radius*2, Radius * 2);
        }


    }
}
