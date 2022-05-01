using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyProj
{
    public class Box
    {
        private int x1, y1;
        private int x2, y2;
        private int width;
        private int height;
        private int picture_Width;
        private int picture_Height;
        public int id { get; set; }
        public string name { get; set; }

        public Box(int x1, int y1, int x2, int y2, PictureBox picture, int id)
        {
            this.id = id;
            name = "Box " + id;
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            X1 = Math.Min(x1, x2);
            Y1 = Math.Min(y1, y2);
            X2 = Math.Max(x1, x2);
            Y2 = Math.Max(y1, y2);
            Width();
            Height();
        }

        public Box(PictureBox picture, int id)
        {
            int x1, x2, y1, y2;
            this.id = id;
            name = "Box " + id;
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            Random rnd = new Random();
            x1 = rnd.Next(picture_Width);
            y1 = rnd.Next(picture_Height);
            x2 = rnd.Next(picture_Width);
            y2 = rnd.Next(picture_Height);

            X1 = Math.Min(x1, x2);
            Y1 = Math.Min(y1, y2);
            X2 = Math.Max(x1, x2);
            Y2 = Math.Max(y1, y2);

            Width();
            Height();
        }

        public int X1
        {
            set
            {
                if (value < 0 || value > picture_Width)
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
        public int X2
        {
            set
            {
                if (value < 0 || value > picture_Width)
                {
                    throw new Exception();
                }
                x2 = value;
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
                if (value < 0 || value > picture_Height)
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
        public int Y2
        {
            set
            {
                if (value < 0 || value > picture_Height)
                {
                    throw new Exception();
                }
                y2 = value;
            }
            get
            {
                return y2;
            }
        }
        public void Width()
        {
            width = Math.Abs(X2 - X1);
                
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
            height = Math.Abs(Y2 - Y1);
        }
        public int get_Height
        {
            get
            {
                return height;
            }
        }

        public void MoveTo(Graphics graph, int dx, int dy)
        {
            Pen pen = new Pen(Color.White);
            Show(graph, pen);
            int x1 = X1;
            int y1 = Y1;
            int x2 = X2;
            int y2 = Y2;
            try
            {
                X1 = x1 + dx;
                Y1 = y1 + dy;
                X2 = x2 + dx;
                Y2 = y2 + dy;
            }
            catch
            {
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
                throw new Exception();
            }
        }

        public void Show(Graphics graph, Pen pen)
        {
            graph.DrawRectangle(pen, X1, Y1, get_Width, get_Height);
        }
        

    }
}
