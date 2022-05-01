using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    public abstract class TFigure
    {
        protected int x, y;
        protected int picture_Width;
        protected int picture_Height;
        public int id { get; }
        public string name { get; set; }


        public TFigure(PictureBox picture, int x, int y, int id)
        {
            this.x = x;
            this.y = y;
            picture_Width = picture.Width;
            picture_Height = picture.Height;
            this.id = id;
        }
        public TFigure(PictureBox picture, int id)
        {
            picture_Width = picture.Width;
            picture_Height = picture.Height;
            this.id = id;
        }
        public void MoveTo(Graphics graph, int dx, int dy)
        {
            Pen pen = new Pen(Color.White);
            Show(graph, pen);

            X += dx;
            Y += dy;

            pen = new Pen(Color.Blue);
            Show(graph, pen);
        }
        public virtual void Show(Graphics graph, Pen pen)
        {

        }

        public int X
        {
            set
            {
                if (value < 0 || value > picture_Width)
                {
                    throw new Exception();
                }
                x = value;
            }
            get
            {
                return x;
            }
        }
        public int Y
        {
            set
            {
                if (value < 0 || value > picture_Height)
                {
                    throw new Exception();
                }
                y = value;
            }
            get
            {
                return y;
            }
        }


    }
}
