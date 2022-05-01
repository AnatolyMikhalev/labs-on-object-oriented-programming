using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    public class Ellipse : Circle
    {
        private int radius2;
        public Ellipse(int x, int y, int radius, int radius2, PictureBox picture, int id = 0)
            : base(x, y, radius, picture, id)
        {
            name = "Ellipse " + id;
            Radius2 = radius2;
        }
        public Ellipse(Pixel pixel, int radius, int radius2, PictureBox picture, int id = 0)
            : base(pixel, radius, picture, id)
        {
            name = "Ellipse " + id;
            Radius2 = radius2;
        }

        public Ellipse(PictureBox picture, int id = 0)
            : base(picture, id)
        {
            name = "Ellipse " + id;
            Random rnd = new Random();
            Radius2 = rnd.Next(5, Math.Min(picture_Width, picture_Height) / 2);
        }
        public int Radius2
        {
            set
            {
                if (value < 2)
                {
                    throw new Exception();
                }
                radius2 = value;
            }
            get
            {
                return radius2;
            }
        }
        public override void Show(Graphics graph, Pen pen)
        {
            graph.DrawEllipse(pen, X, Y, Radius * 2, Radius2 * 2);
        }


    }
}
