using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyProj
{
    public class Line
    {
        int x1, x2, y1, y2;
        public Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = x1;
            this.y2 = x2;
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

        public void Show(Pen pen, Graphics graph)
        {
            graph.DrawLine(pen, x1, y1, x2, y2);
        }



    }
}
