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
        protected Pixel coords;
        protected int picture_Width;
        protected int picture_Height;
        public int id { get; }
        public string name { get; set; }


        public TFigure(PictureBox picture, int x, int y, int id)
        {
            coords = new Pixel(picture, x, y);
            picture_Width = picture.Width;
            picture_Height = picture.Height;
            this.id = id;
        }
        public TFigure(PictureBox picture, Pixel pixel, int id)
        {
            coords = pixel;
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
        public abstract void MoveTo(Graphics graph, int dx, int dy);
        public abstract void Show(Graphics graph, Pen pen);

        public int X
        {
            set
            {
                if (value < 0 || value > picture_Width)
                {
                    throw new Exception();
                }
                coords.X = value;
            }
            get
            {
                return coords.X;
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
                coords.Y = value;
            }
            get
            {
                return coords.Y;
            }
        }


    }
}
