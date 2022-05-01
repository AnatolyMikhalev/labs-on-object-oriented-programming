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
        private int length;
        public Line(int x1, int y1, int lenght, PictureBox picture)
            : base(picture, x1, y1)
        {
            Length = lenght;
        }
        public Line(PictureBox picture)                                           
            : base(picture)
        {
            Random rnd = new Random();
            X = rnd.Next(0, picture.Width);
            Y = rnd.Next(0, picture.Height);
            Length = rnd.Next(0, picture.Width - base.X);
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

        public override void Show(Graphics graph, Pen pen)
        {
            graph.DrawLine(pen, base.X, Y, X + Length, Y);
        }


    }
}


