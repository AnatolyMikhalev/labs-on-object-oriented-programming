using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    public class Romb : Box
    {
        private int height;
        public Romb(int x, int y, int width, int height, PictureBox picture, int id)
            : base(x, y, width, picture, id)
        {
            name = "Romb " + id;
            Height = height;

            line1 = new Line(X + Width / 2, Y + Height, X + Width, Y + Height / 2, picture, id);
            line2 = new Line(X + Width / 2, Y, X, Y + Height / 2, picture, id);
            line3 = new Line(X, Y + Height / 2, X + Width / 2, Y + Height, picture, id);
            line4 = new Line(X + Width / 2, Y, X + Width, Y + Height / 2, picture, id);
        }
        public Romb(Pixel pixel, int width, int height, PictureBox picture, int id)
            : base(pixel, width, picture, id)
        {
            name = "Romb " + id;
            Height = height;

            line1 = new Line(X + Width / 2, Y + Height, X + Width, Y + Height / 2, picture, id);
            line2 = new Line(X + Width / 2, Y, X, Y + Height / 2, picture, id);
            line3 = new Line(X, Y + Height / 2, X + Width / 2, Y + Height, picture, id);
            line4 = new Line(X + Width / 2, Y, X + Width, Y + Height / 2, picture, id);
        }
        public Romb(PictureBox picture, int id)
            : base(picture, id)
        {
            name = "Romb " + id;
            Random rnd = new Random();
            width = rnd.Next(picture_Width);
            height = rnd.Next(picture_Height);
            X = rnd.Next(picture_Width - Width);
            Y = rnd.Next(picture_Height - Height);
            //coords = new Pixel(picture, X, Y);

            line1 = new Line(X + Width / 2, Y + Height, X + Width, Y + Height / 2, picture, id);
            line2 = new Line(X + Width / 2, Y, X, Y + Height / 2, picture, id);
            line3 = new Line(X, Y + Height / 2, X + Width / 2, Y + Height, picture, id);
            line4 = new Line(X + Width / 2, Y, X + Width, Y + Height / 2, picture, id);
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
