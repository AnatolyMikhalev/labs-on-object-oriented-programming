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
        private int x1, y1; //coords of the left up corner
        private int width;
        private int height;
        private int picture_Width;
        private int picture_Height;


        public Circle(int x, int y, int radius, PictureBox picture)
        {
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            Radius = radius;
            X1 = x;
            Y1 = y - radius;
            Width();
            Height();
        }

        public Circle(PictureBox picture)
        {
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            Random rnd = new Random();
            Radius = rnd.Next(0, Math.Min(picture_Width, picture_Height)/2); 
            X1 = rnd.Next(radius, picture.Width - radius);
            Y1 = rnd.Next(radius, picture.Height - radius);
            Width();
            Height();
        }
        public int X1
        {
            set
            {
                if (value - radius < 0 || value + radius > picture_Width)
                {
                    throw new Exception();
                }
                x1 = value - radius;
            }
            get
            {
                return x1;
            }
        }
        public int Y1
        {
            set
            {
                if (value - radius < 0 || value + radius > picture_Height)
                {
                    throw new Exception();
                }
                y1 = value - radius;
            }
            get
            {
                return y1;
            }
        }
        public int Radius
        {
            set
            {
                if (value < 0)
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
        public void Width()
        {
            width = 2 * Radius;
            
        }
        public int get_Width
        {
            get
            {
                return width;
            }
        }

        public void Height()
        {
            height = 2 * Radius;
        }


        public int get_Height
        {
            get
            {
                return height;
            }
        }

        public void Show(Graphics graph, Pen pen)
        {
            graph.DrawEllipse(pen, X1, Y1, get_Width, get_Height);
        }


    }
}
