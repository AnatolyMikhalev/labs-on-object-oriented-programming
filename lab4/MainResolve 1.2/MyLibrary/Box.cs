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
        protected Line line1;
        protected Line line2;
        protected Line line3;
        protected Line line4;

        public Box(int x, int y, int width, PictureBox picture, int id)
            : base(picture, x, y, id)
        {
            name = "Box " + id;
            Width = width;
            line1 = new Line(X, Y, X + Width, Y, picture, id);
            line2 = new Line(X, Y, X, Y + Width, picture, id);
            line3 = new Line(X + Width, Y, X + Width, Y + Width, picture, id);
            line4 = new Line(X, Y + Width, X + Width, Y + Width, picture, id);
        }
        public Box(Pixel pixel, int width, PictureBox picture, int id)
            : base(picture, pixel, id)
        {
            name = "Box " + id;
            Width = width;
            line1 = new Line(X, Y, X + Width, Y, picture, id);
            line2 = new Line(X, Y, X, Y + Width, picture, id);
            line3 = new Line(X + Width, Y, X + Width, Y + Width, picture, id);
            line4 = new Line(X, Y + Width, X + Width, Y + Width, picture, id);
        }

        public Box(PictureBox picture, int id)
            : base(picture, id)
        {
            int x, y;
            name = "Box " + id;
            Random rnd = new Random();
            width = rnd.Next(Math.Min(picture_Width, picture_Height));
            x = rnd.Next(picture_Width - Width);
            y = rnd.Next(picture_Height - Width);
            coords = new Pixel(picture, x, y);
            line1 = new Line(X, Y, X + Width, Y, picture, id);
            line2 = new Line(X, Y, X, Y + Width, picture, id);
            line3 = new Line(X + Width, Y, X + Width, Y + Width, picture, id);
            line4 = new Line(X, Y + Width, X + Width, Y + Width, picture, id);
        }

        public override void MoveTo(Graphics graph, int dx, int dy)
        {
            line1.MoveToCoords(graph, dx, dy);
            line2.MoveToCoords(graph, dx, dy);
            line3.MoveToCoords(graph, dx, dy);
            line4.MoveToCoords(graph, dx, dy);
        }

        public override void Show(Graphics graph, Pen pen)
        {
            line1.ShowToCoords(graph, pen);
            line2.ShowToCoords(graph, pen);
            line3.ShowToCoords(graph, pen);
            line4.ShowToCoords(graph, pen);
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
