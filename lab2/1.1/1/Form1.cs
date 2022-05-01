using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProj;

namespace _1
{
    public partial class CreateFigures : Form
    {
        Bitmap bmp;
        Graphics graph;
        Pen pen;
        Line line1;
        Box box1;
        int check; 
        public CreateFigures()
        {
            InitializeComponent();
            Init();
            Draw();
        }
        private void Init()
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue);
            line1 = new Line(10, 20, 50, 60);
            box1 = new Box(10, 20, 50, 60);
        }
        private void Draw()
        {
            picture.Image = bmp;
            Draw(line1);
            Draw(box1);
        }

        private void Draw(Line line)
        {

            line.Show(pen, graph);
        }
        private void Draw(Box box)
        {

            box.Show(pen, graph);
        }

        private void CheckedFigures(object sender, EventArgs e)
        {
            if (Line.Checked)
            {
                check = 1;
                Xcoord.ReadOnly = false;
                X2coord.ReadOnly = false;
                Ycoord.ReadOnly = false;
                Y2coord.ReadOnly = false;
                Radius.ReadOnly = true;

                Xcoord.Text = "";
                X2coord.Text = "";
                Ycoord.Text = "";
                Y2coord.Text = "";
                Radius.Text = "Нет доступа";


            }
            else if (Rectangle.Checked)
            {
                check = 2;
                Xcoord.ReadOnly = false;
                X2coord.ReadOnly = false;
                Ycoord.ReadOnly = false;
                Y2coord.ReadOnly = false;
                Radius.ReadOnly = true;

                Xcoord.Text = "";
                X2coord.Text = "";
                Ycoord.Text = "";
                Y2coord.Text = "";
                Radius.Text = "Нет доступа";
            }
            else if (Circle.Checked)
            {
                check = 3;
                Xcoord.ReadOnly = false;
                X2coord.ReadOnly = false;
                Ycoord.ReadOnly = true;
                Y2coord.ReadOnly = true;
                Radius.ReadOnly = false;

                Xcoord.Text = "";
                X2coord.Text = "";
                Ycoord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                Radius.Text = "";
            }
        }

        private void CreateFigures(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1:

            }
        }
    }
}
