using MyProj;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    public class Ring
    {
        private Circle circle1, circle2;
        public int id { get; set; }
        public string name { get; set; }


        public Ring(int x, int y, int radius, PictureBox picture, int id)
        {
            this.id = id;
            name = "Ring " + id;
            circle1 = new Circle(x, y, radius, picture);
            circle2 = new Circle(x, y, radius-10, picture);
        }

        public Ring(Pixel pixel, int radius, PictureBox picture, int id)
        {
            this.id = id;
            name = "Ring " + id;
            circle1 = new Circle(pixel, radius, picture);
            circle2 = new Circle(pixel, (radius - 10), picture);
        }

        public Ring(PictureBox picture, int id)
        {
            this.id = id;
            name = "Ring " + id;
            circle1 = new Circle(picture);
            circle2 = new Circle(circle1.X + circle1.Radius, circle1.Y + circle1.Radius, circle1.Radius - 10, picture);
        }
        public void MoveTo(Graphics graph, int dx, int dy)
        {
            circle1.MoveTo(graph, dx, dy);
            circle2.MoveTo(graph, dx, dy);
        }
        public void Show(Graphics graph, Pen pen)
        {
            circle1.Show(graph, pen);
            circle2.Show(graph, pen);
        }
    }
}
