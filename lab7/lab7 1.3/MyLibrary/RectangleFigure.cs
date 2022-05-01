using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    public class RectangleFigure : Box
    {
        private int height;
        public RectangleFigure(int x, int y, int width, int height, PictureBox picture)
            : base(x, y, width, picture)
        {
            Height = height;
        }

        public RectangleFigure(PictureBox picture)
            : base(picture)
        {
            Random rnd = new Random();
            width = rnd.Next(picture_Width);
            height = rnd.Next(picture_Height);
            int x = rnd.Next(picture_Width - Width);
            int y = rnd.Next(picture_Height - Height);
            X = x;
            Y = y;
        }
        public override void Show(Graphics graph, Pen pen)
        {
            graph.DrawLine(pen, X, Y, X + Width, Y);
            graph.DrawLine(pen, X, Y, X, Y + Height);
            graph.DrawLine(pen, X + Width, Y, X + Width, Y + Height);
            graph.DrawLine(pen, X, Y + Height, X + Width, Y + Height);
        }

        public int Height
        {
            set
            {
                if (value < 2)
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
    }
}
