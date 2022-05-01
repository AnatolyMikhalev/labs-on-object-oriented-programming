using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyProj
{
    public class Box : TFigure
    {
        protected int width;

        public Box(int x, int y, int width, PictureBox picture)
            : base(picture, x, y)
        {
            Width = width;
        }

        public Box(PictureBox picture)
            : base(picture)
        {
            Random rnd = new Random();
            width = rnd.Next(Math.Min(picture_Width, picture_Height));
            X = rnd.Next(picture_Width - Width);
            Y = rnd.Next(picture_Height - Width);
        }
        public override void Show(Graphics graph, Pen pen)
        {
            graph.DrawLine(pen, X, Y, X + Width, Y);
            graph.DrawLine(pen, X, Y, X, Y + Width);
            graph.DrawLine(pen, X + Width, Y, X + Width, Y + Width);
            graph.DrawLine(pen, X, Y + Width, X + Width, Y + Width);
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

        

    }
}
