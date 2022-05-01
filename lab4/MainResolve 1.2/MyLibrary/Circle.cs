using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyProj
{
    public class Circle : TFigure
    {

        private int radius;

        public Circle(int x, int y, int radius, PictureBox picture, int id = 0)
            : base(picture, x, y, id)
        {
            name = "Circle " + id;
            Radius = radius;
            X = X - radius;
            Y = Y - radius;
        }
        
        public Circle(Pixel pixel, int radius, PictureBox picture, int id = 0)
            : base(picture, pixel, id)
        {
            name = "Circle " + id;
            Radius = radius;
            X = X - radius;
            Y = Y - radius;
        }

        public Circle(PictureBox picture, int id = 0)
            : base(picture, id)
        {
            name = "Circle " + id;
            Random rnd = new Random();
            Radius = rnd.Next(30, Math.Min(picture_Width, picture_Height)/2);
            int x = rnd.Next(0, picture.Width - 2*radius);
            int y = rnd.Next(0, picture.Height - 2*radius);
            coords = new Pixel(picture, x, y);
        }

        public override void MoveTo(Graphics graph, int dx, int dy)
        {
            Pen pen = new Pen(Color.White);
            Show(graph, pen);
            int x1 = coords.X;
            int y1 = coords.Y;
            try
            {
                X = x1 + dx;
                Y = y1 + dy;
            }
            catch
            {
                X = x1;
                Y = y1;
                throw new Exception();
            }
        }
        public override void Show(Graphics graph, Pen pen)
        {
            graph.DrawEllipse(pen, X, Y, Radius * 2, Radius * 2);
        }
        public int Radius
        {
            set
            {
                if (value < 15)
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


    }
}
