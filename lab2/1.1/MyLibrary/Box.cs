using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyProj
{
    public class Box
    {
        int x1, y1;
        int x2, y2;
        int width;
        int height;

        public Box(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.width = this.x2 - this.x1;
            this.height = this.y2 - this.y1;
        }

        public int X1
        {
            set
            {
                this.x1 = value;
            }
            get 
            {
                return x1;
            }
        }
        public int X2
        {
            set
            {
                this.x2 = value;
            }
            get
            {
                return x2;
            }
        }
        public int Y1
        {
            set
            {
                this.y1 = value;
            }
            get
            {
                return y1;
            }
        }
        public int Y2
        {
            set
            {
                this.y2 = value;
            }
            get
            {
                return y2;
            }
        }
        public int Width
        {
            get { return width; }
        }
        public int Height
        {
            get { return height; }
        }

        public void Show(Pen pen, Graphics graph)
        {
            graph.DrawRectangle(pen, 10, 1, 200, 200);
        }
        

    }
}
