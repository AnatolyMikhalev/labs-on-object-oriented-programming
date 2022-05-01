using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    public class RectangleFigure : Box
    {
        private int height;
        public RectangleFigure(int x, int y, int width, int height, PictureBox picture, int id)
            : base(x, y, width, picture, id)
        {
            name = "Rectangle " + id;
            Height = height;

            line1 = new Line(X, Y, X + Width, Y, picture, id);
            line2 = new Line(X, Y, X, Y + Height, picture, id);
            line3 = new Line(X + Width, Y, X + Width, Y + Height, picture, id);
            line4 = new Line(X, Y + Height, X + Width, Y + Height, picture, id);
        }

        public RectangleFigure(PictureBox picture, int id)
            : base(picture, id)
        {
            name = "Rectangle " + id;
            Random rnd = new Random();
            width = rnd.Next(picture_Width);
            height = rnd.Next(picture_Height);
            int x = rnd.Next(picture_Width - Width);
            int y = rnd.Next(picture_Height - Height);
            X = x;
            Y = y;
            line1 = new Line(X, Y, X + Width, Y, picture, id);
            line2 = new Line(X, Y, X, Y + Height, picture, id);
            line3 = new Line(X + Width, Y, X + Width, Y + Height, picture, id);
            line4 = new Line(X, Y + Height, X + Width, Y + Height, picture, id);
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
