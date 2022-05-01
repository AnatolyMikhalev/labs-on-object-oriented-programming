using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    public class Pixel
    {
        private int x, y;
        private int picture_Width;
        private int picture_Height;
        public Pixel(PictureBox picture, int x, int y)
        {
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            X = x;
            Y = y;
            Console.WriteLine("Создана точка с координатами x = \"{0}\" y = \"{0}\"", X, Y);
        }
        public Pixel(PictureBox picture)
        {
            this.picture_Width = picture.Width;
            this.picture_Height = picture.Height;
            Random rnd = new Random();
            X = rnd.Next(0, picture.Width);
            Y = rnd.Next(0, picture.Height);
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {

                if (value < 0 || value > picture_Width)
                {
                    throw new Exception();
                }
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {

                if (value < 0 || value > picture_Width)
                {
                    throw new Exception();
                }
                y = value;
            }
        }
    }
}
