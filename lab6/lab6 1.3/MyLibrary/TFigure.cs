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
        Random rnd;

        public TFigure(PictureBox picture, int x, int y)
        {
            this.x = x;
            this.y = y;
            picture_Width = picture.Width;
            picture_Height = picture.Height;
        }
        public TFigure(PictureBox picture, Random rand)
        {
            rnd = rand;
            picture_Width = picture.Width;
            picture_Height = picture.Height;
        }
        public void MoveTo(Graphics graph, int dx, int dy)
        {
            Pen pen = new Pen(Color.White);
            Show(graph, pen);

            X = dx;
            Y = dy;

            pen = new Pen(Color.Blue);
            Show(graph, pen);
        }
        public virtual void Show(Graphics graph, Pen pen)
        {

        }
        public virtual void Remove(Graphics graph)
        {
            Pen pen = new Pen(Color.White);
            Show(graph, pen);
        }

        public int X
        {
            set
            {
                
                x += value;
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
                y += value;
            }
            get
            {
                return y;
            }
        }


    }
}
