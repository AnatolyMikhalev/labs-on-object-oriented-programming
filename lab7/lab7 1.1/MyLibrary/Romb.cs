using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    public class Romb : Box
    {
        private int height;
        public Romb(int x, int y, int width, int height, PictureBox picture)
            : base(x, y, width, picture)
        {
            Height = height;

        }
        public Romb(PictureBox picture, Random rnd)
            : base(picture, rnd)
        {
            width = rnd.Next(picture_Width);
            height = rnd.Next(picture_Height);
            X = rnd.Next(picture_Width - Width);
            Y = rnd.Next(picture_Height - Height);
        }


        public override void Show(Graphics graph, Pen pen)
        {
            graph.DrawLine(pen, X + Width / 2, Y + Height, X + Width, Y + Height / 2);
            graph.DrawLine(pen, X + Width / 2, Y, X, Y + Height / 2);
            graph.DrawLine(pen, X, Y + Height / 2, X + Width / 2, Y + Height);
            graph.DrawLine(pen, X + Width / 2, Y, X + Width, Y + Height / 2);
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
