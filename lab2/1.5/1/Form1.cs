using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using MyProj;

namespace _1
{
    public partial class CreateFigures : Form
    {
        //Bitmap bmp;
        Graphics graph;
        Pen pen;
        List<Circle> circles = new List<Circle>();
        List<Box> boxes = new List<Box>();
        List<Line> lines = new List<Line>();
        private int check;
        private int lineIndex, boxIndex, circleIndex;
        public CreateFigures()
        {
            InitializeComponent();
            Init();
            //pen = new Pen(Color.Blue);
            //Draw();
            //ClearAll();
        }
        private void Init()
        {

            graph = picture.CreateGraphics();
            pen = new Pen(Color.Blue);
            //bmp = new Bitmap(picture.Width, picture.Height);
            //graph = Graphics.FromImage(bmp);
            //Graphics graph = picture.CreateGraphics();
            //lines.Add(new Line(10, 20, 500, 60));
            //boxes.Add(new Box(10, 20, 50, 60));
            //circles.Add(new Circle(200, 200, 100));
        }
        private void Draw()
        {

            foreach (var a in lines)
            {
                a.Show(graph, pen);
            }
            foreach (var a in boxes)
            {
                a.Show(graph, pen);
            }
            foreach (var a in circles)
            {
                a.Show(graph, pen);
            }
        }

        public void ClearAll()
        {
            graph.Clear(Color.White);

            lineIndex = 0;
            boxIndex = 0;
            circleIndex = 0;

            X1coord.Clear();
            X2coord.Clear();
            Y1coord.Clear();
            Y2coord.Clear();
            Radius.Clear();
            textBoxDX.Clear();
            textBoxDY.Clear();
            lines.Clear();
            boxes.Clear();
            circles.Clear();
            listBox.Items.Clear();

        }

        private void CheckedFigures(object sender, EventArgs e)
        {
            if (LineButton.Checked)
            {
                check = 1;
                X1coord.ReadOnly = false;
                X2coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                Y2coord.ReadOnly = false;
                Radius.ReadOnly = true;

                X1coord.Text = "";
                X2coord.Text = "";
                Y1coord.Text = "";
                Y2coord.Text = "";
                Radius.Text = "Нет доступа";


            }
            else if (RectangleButton.Checked)
            {
                check = 2;
                X1coord.ReadOnly = false;
                X2coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                Y2coord.ReadOnly = false;
                Radius.ReadOnly = true;

                X1coord.Text = "";
                X2coord.Text = "";
                Y1coord.Text = "";
                Y2coord.Text = "";
                Radius.Text = "Нет доступа";
            }
            else if (CircleButton.Checked)
            {
                check = 3;
                X1coord.ReadOnly = false;
                X2coord.ReadOnly = true;
                Y1coord.ReadOnly = false;
                Y2coord.ReadOnly = true;
                Radius.ReadOnly = false;

                X1coord.Text = "";
                X2coord.Text = "Нет доступа";
                Y1coord.Text = "";
                Y2coord.Text = "Нет доступа";
                Radius.Text = "";
            }
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            int IndexObject;
            try
            {
                string text = listBox.SelectedItem.ToString();
                if (text.Substring(0, text.Length - 2) == "Line")
                {
                    foreach (var a in lines)
                    {
                        if (a.name[5] == text[5])
                        {
                            try
                            {
                                a.MoveTo(graph, Convert.ToInt32(textBoxDX.Text), Convert.ToInt32(textBoxDY.Text));
                                break;
                            }
                            catch
                            {

                                MessageBox.Show("Неверные параметры");
                            }
                        }
                    }
                }
                if (text.Substring(0, text.Length - 2) == "Box")
                {
                    foreach (var a in boxes)
                    {
                        if (a.name[4] == text[4])
                        {
                            try
                            {
                                a.MoveTo(graph, Convert.ToInt32(textBoxDX.Text), Convert.ToInt32(textBoxDY.Text));
                                break;
                            }
                            catch
                            {

                                MessageBox.Show("Неверные параметры");
                            }
                        }
                    }
                }
                if (text.Substring(0, text.Length - 2) == "Circle")
                {
                    foreach (var a in circles)
                    {
                        if (a.name[7] == text[7])
                        {
                            try
                            {
                                a.MoveTo(graph, Convert.ToInt32(textBoxDX.Text), Convert.ToInt32(textBoxDY.Text));
                                break;
                            }
                            catch
                            {

                                MessageBox.Show("Неверные параметры");
                            }
                        }
                    }
                }
                Draw();

            }
            catch
            {
                MessageBox.Show("Выберите объект");
            }
            

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int IndexObject;
            try
            {
                string text = listBox.SelectedItem.ToString();
                if (text.Substring(0, text.Length - 2) == "Line")
                {
                    for(int i = 0; i < lines.Count; i++) 
                    {
                        if (lines[i].name[5] == text[5])
                        {
                            lines[i].Show(graph, new Pen(Color.White));
                            lines.RemoveAt(i);
                            listBox.Items.Remove(listBox.SelectedItem);
                        }
                    }
                }
                if (text.Substring(0, text.Length - 2) == "Box")
                {
                    for (int i = 0; i < boxes.Count; i++)
                    {
                        if (boxes[i].name[4] == text[4])
                        {
                            boxes[i].Show(graph, new Pen(Color.White));
                            boxes.RemoveAt(i);
                            listBox.Items.Remove(listBox.SelectedItem);
                        }
                    }
                }
                if (text.Substring(0, text.Length - 2) == "Circle")
                {
                    for (int i = 0; i < circles.Count; i++)
                    {
                        if (circles[i].name[7] == text[7])
                        {
                            circles[i].Show(graph, new Pen(Color.White));
                            circles.RemoveAt(i);
                            listBox.Items.Remove(listBox.SelectedItem);
                        }
                    }
                }
                Draw();

            }
            catch
            {
                MessageBox.Show("Выберите объект");
            }
        }
        private void CreateRandomButton_Click(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1:
                    try
                    {
                        lines.Add(new Line(picture, lineIndex));
                        //DataObjects.Items.Add("Линия " + lineIndex);
                        //DataObjects.DataSource = lines;// ItemsSource = ListOfNames
                        listBox.Items.Add("Line " + lineIndex);
                        lineIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }

                    break;
                case 2:
                    try
                    {
                        boxes.Add(new Box(picture, boxIndex));
                        //DataObjects.Items.Add("Прямоугольник " + boxIndex);
                        //listBox.DataSource = boxes;
                        listBox.Items.Add("Box "+ boxIndex);
                        boxIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 3:
                    try
                    {
                        circles.Add(new Circle(picture, circleIndex));
                        listBox.Items.Add("Circle " + circleIndex);
                        circleIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;

            }


            Draw();
        }


        private void CreateSetButton_Click(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1:
                    try
                    {
                        lines.Add(new Line(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(X2coord.Text), Convert.ToInt32(Y2coord.Text), picture, lineIndex));
                        //DataObjects.Items.Add("Линия " + lineIndex);
                        listBox.DataSource = lines;// ItemsSource = ListOfNames
                        listBox.DisplayMember = "name";
                        listBox.ValueMember = "id";
                        lineIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }

                    break;
                case 2:
                    try
                    {
                        boxes.Add(new Box(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(X2coord.Text), Convert.ToInt32(Y2coord.Text), picture, boxIndex));
                        //DataObjects.Items.Add("Прямоугольник " + boxIndex);
                        listBox.DataSource = boxes;
                        listBox.DisplayMember = "Прямоугольник " + boxIndex;
                        listBox.ValueMember = "id";
                        boxIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 3:
                    try
                    {
                        circles.Add(new Circle(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(Radius.Text), picture, circleIndex));
                        //DataObjects.Items.Add("Круг " + circleIndex);
                        circleIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;

            }

            Draw();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //graph.Clear(Color.White);
            ClearAll();
            //this.CreateGraphics().Clear(CreateFigures.ActiveForm.BackColor);
            //Graphics.FromImage(bmp).Clear(Color.Blue);

        }
    }
}


