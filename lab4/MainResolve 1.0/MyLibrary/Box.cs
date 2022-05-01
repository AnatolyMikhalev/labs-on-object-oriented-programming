using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyProj
{
    public class Box
    {
        private int x, y;
        private int width;
        private int height;
        private int picture_Width;
        private int picture_Height;
        private Pixel pixel;
        public int id { get; set; }
        public string name { get; set; }

        public Box(int x, int y, int width, int height, PictureBox picture, int id)
        {
            this.id = id;
            name = "Box " + id;
            picture_Width = picture.Width;
            picture_Height = picture.Height;
            pixel = new Pixel(picture, x, y);
            Width = width;
            Height = height;
        }
        public Box(Pixel pixel1, int width, int height, PictureBox picture, int id)
        {
            this.id = id;
            name = "Box " + id;
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            pixel = pixel1;
            X = pixel.X;
            Y = pixel.Y;
            Width = width;
            Height = height;
        }

        public Box(PictureBox picture, int id)
        {
            int x, y;
            this.id = id;
            name = "Box " + id;
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            Random rnd = new Random();
            x = rnd.Next(picture_Width);
            y = rnd.Next(picture_Height);
            pixel = new Pixel(picture, x, y);
            Width = rnd.Next(picture_Width - X);
            Height = rnd.Next(picture_Height - Y);
        }

        public int X
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
        public int Y
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
        public int Width
        {
            set
            {
                if (X + value > picture_Width)
                {
                    throw new Exception();
                }
                width = value;
            }
            get
            {
                return width;
            }
                
        }

        public int Height
        {
            set
            {
                if (Y + value > picture_Height)
                {
                    throw new Exception();
                }
                height = value;
            }
            get
            {
                return height;
            }

        }
        public void MoveTo(Graphics graph, int dx, int dy)
        {
            Pen pen = new Pen(Color.White);
            Show(graph, pen);
            int x = X;
            int y = Y;
            int width = Width;
            int height = Height;
            try
            {
                X = X + dx;
                Y = Y + dy;
            }
            catch
            {
                X = x;
                Y = y;
                throw new Exception();
            }
        }

        public void Show(Graphics graph, Pen pen)
        {
            graph.DrawRectangle(pen, X, Y, Width, Height);
        }
        

    }
}
