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
        private int x1, y1;
        private int x2, y2;
        private int width;
        private int height;
        private int picture_Width;
        private int picture_Height;

        public Box(int x1, int y1, int x2, int y2, PictureBox picture)
        {
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Width();
            Height();
        }

        public Box(PictureBox picture)
        {
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            Random rnd = new Random();
            X1 = rnd.Next(picture.Width - 100);
            Y1 = rnd.Next(picture.Height-100);
            X2 = rnd.Next(picture.Width - 100);
            Y2 = rnd.Next(picture.Height - 100);
            Width();
            Height();
        }

        public int X1
        {
            set
            {
                if (value < 0 || value > picture_Width)
                {
                    throw new Exception();
                }
                x1 = value;
            }
            get
            {
                return x1;
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
                y1 = value;
            }
            get
            {
                return y1;
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
        public void Width()
        {
            width = Math.Abs(X2 - X1);
                
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
            height = Math.Abs(Y2 - Y1);
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
            graph.DrawRectangle(pen, x1, y1, get_Width, get_Height);
        }
        

    }
}
