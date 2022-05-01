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
        public Ellipse(int x, int y, int radius, int radius2, PictureBox picture)
            : base(x, y, radius, picture)
        {
            Radius2 = radius2;
        }

        public Ellipse(PictureBox picture, Random rnd)
            : base(picture, rnd)
        {
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
        public void Rotate(Graphics graph)
        {
            Pen pen = new Pen(Color.White);
            Show(graph, pen);
            int temp_radius1 = Radius;
            int temp_radius2 = Radius2;
            int y1 = Y;
            try
            {
                Radius = temp_radius2;
                Radius2 = temp_radius1;
            }
            catch
            {
                Radius = temp_radius1;
                Radius2 = temp_radius2;
                throw new Exception();
            }
            pen = new Pen(Color.Blue);
            Show(graph, pen);
        }


    }
}
