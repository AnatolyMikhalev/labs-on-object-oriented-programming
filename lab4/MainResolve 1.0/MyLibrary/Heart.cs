using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    public class Heart
    {
        private Circle circle1, circle2;
        private Line line1, line2;
        private int radius;
        private int x, y;
        private Pixel pixel;
        private int picture_Width;
        private int picture_Height;
        public int id { get; set; }
        public string name { get; set; }
        public int width;

        public Heart(int x, int y, int width, PictureBox picture, int id)
        {
            this.id = id;
            name = "Heart " + id;
            picture_Width = picture.Width;
            picture_Height = picture.Height;
            pixel = new Pixel(picture, x, y);

            radius = width / 4;
            circle1 = new Circle(X - radius, Y, radius, picture);
            circle2 = new Circle(X + radius, Y, radius, picture);
            line1 = new Line(
                Convert.ToInt32(X + radius + radius * ((1.41) / 2)),
                Convert.ToInt32(Y + radius * ((1.41) / 2)),
                Convert.ToInt32(X),
                Convert.ToInt32(Y + radius * 2.411),
                picture);
            line2 = new Line(
                Convert.ToInt32(X - radius - radius * ((1.41) / 2)),
                Convert.ToInt32(Y + radius * ((1.41) / 2)),
                Convert.ToInt32(X),
                Convert.ToInt32(Y + radius * 2.411),
                picture);
        }

        public Heart(Pixel pixel1, int width, PictureBox picture, int id)
        {
            this.id = id;
            name = "Heart " + id;
            picture_Width = picture.Width;
            picture_Height = picture.Height;
            pixel = pixel1;
            int x = pixel.X;
            int y = pixel.Y;

            radius = width / 4;
            circle1 = new Circle(X - radius, Y, radius, picture);
            circle2 = new Circle(X + radius, Y, radius, picture);
            line1 = new Line(
                Convert.ToInt32(X + radius + radius * ((1.41) / 2)),
                Convert.ToInt32(Y + radius * ((1.41) / 2)),
                Convert.ToInt32(X),
                Convert.ToInt32(Y + radius * 2.411),
                picture);
            line2 = new Line(
                Convert.ToInt32(X - radius - radius * ((1.41) / 2)),
                Convert.ToInt32(Y + radius * ((1.41) / 2)),
                Convert.ToInt32(X),
                Convert.ToInt32(Y + radius * 2.411),
                picture);
        }

        public Heart(PictureBox picture, int id)
        {
            this.id = id;
            name = "Heart " + id;
            picture_Width = picture.Width;
            picture_Height = picture.Height;

            Random rand = new Random();
            width = rand.Next(60, Math.Min(picture.Height, picture.Width)/2);
            int x = rand.Next(width/2, picture.Width - width/2);
            int y = rand.Next(width/2, picture.Height - width);
            pixel = new Pixel(picture, x, y);

            radius = width / 4;
            circle1 = new Circle(X - radius, Y, radius, picture);
            circle2 = new Circle(X + radius, Y, radius, picture);
            line1 = new Line(
                Convert.ToInt32(X + radius + radius * ((1.41) / 2)),
                Convert.ToInt32(Y + radius * ((1.41) / 2)),
                Convert.ToInt32(X),
                Convert.ToInt32(Y + radius * 2.411),
                picture);
            line2 = new Line(
                Convert.ToInt32(X - radius - radius * ((1.41) / 2)),
                Convert.ToInt32(Y + radius * ((1.41) / 2)),
                Convert.ToInt32(X),
                Convert.ToInt32(Y + radius * 2.411),
                picture);
        }
        public int X
        {
            set
            {
                if (value < 0 || value > picture_Width)
                {
                    throw new Exception();
                }
                pixel.X = value;
            }
            get
            {
                return pixel.X;
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
                pixel.Y = value;
            }
            get
            {
                return pixel.Y;
            }
        }

        public void MoveTo(Graphics graph, int dx, int dy)
        {
                circle1.MoveTo(graph, dx, dy);
                circle2.MoveTo(graph, dx, dy);
                line1.MoveToHeart(graph, dx, dy);
                line2.MoveToHeart(graph, dx, dy);
        }
        public void Remove(Graphics graph)
        {
            Pen pen = new Pen(Color.White);
            circle1.Show(graph, pen);
            circle2.Show(graph, pen);
            line1.ShowHeart(graph, pen);
            line2.ShowHeart(graph, pen);
        }
        public void Show(Graphics graph, Pen pen)
        {
            circle1.Show(graph, pen);
            circle2.Show(graph, pen);
            line1.ShowHeart(graph, pen);
            line2.ShowHeart(graph, pen);
        }
    }
}
