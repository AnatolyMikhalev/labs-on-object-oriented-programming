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
        private int x1, y1;
        private int x2, y2;
        private int picture_Width;
        private int picture_Height;
        public Line(int x1, int y1, int x2, int y2, PictureBox picture)
        {
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
        public Line(PictureBox picture)
        {
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            Random rnd = new Random();
            X1 = rnd.Next(0, picture.Width);
            Y1 = rnd.Next(0, picture.Height);
            X2 = rnd.Next(0, picture.Width);
            Y2 = rnd.Next(0, picture.Height);
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

        public void Show(Graphics graph, Pen pen)
        {
            graph.DrawLine(pen, X1, Y1, X2, Y2);
        }



    }
}
