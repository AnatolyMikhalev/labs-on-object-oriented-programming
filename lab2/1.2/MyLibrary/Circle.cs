using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyProj
{
    public class Circle
    {

        private int x, y;
        private int radius;
        private int x1, y1; //coords of the left up corner
        private int width;
        private int height;


        public Circle(int x, int y, int radius)
        {
            X1 = x - radius;
            Y1 = y - radius;
            Radius = radius;
            Width();
            Height();
        }
        public int X1
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                x1 = value;
            }
            get
            {
                return x1;
            }
        }
        public int Y1
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                y1 = value;
            }
            get
            {
                return y1;
            }
        }
        public int Radius
        {
            set
            {
                if (value < 0)
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
        public void Width()
        {
            width = 2 * Radius;
            
        }
        public int get_Width
        {
            get
            {
                return width;
            }
        }

        public void Height()
        {
            height = 2 * Radius;
        }


        public int get_Height
        {
            get
            {
                return height;
            }
        }

        public void Show(Graphics graph)
        {
            Pen pen = new Pen(Color.Blue);
            graph.DrawEllipse(pen, X1, Y1, get_Width, get_Height);
        }


    }
}
