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

namespace lab3
{
    public partial class CreateFigures : Form
    {
        Graphics graph;
        Pen pen;
        List<Circle> circles = new List<Circle>();
        List<Box> boxes = new List<Box>();
        List<Line> lines = new List<Line>();
        List<Ring> rings = new List<Ring>();
        List<Heart> hearts = new List<Heart>();
        Pixel pixel;
        private int check;
        private int lineIndex, boxIndex, circleIndex, ringIndex, heartIndex;
        public CreateFigures()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {

            graph = picture.CreateGraphics();
            pen = new Pen(Color.Blue);
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
            foreach (var a in rings)
            {
                a.Show(graph, pen);
            }
            foreach (var a in hearts)
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
            ringIndex = 0;
            heartIndex = 0;

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
            rings.Clear();
            hearts.Clear();
            listBox.Items.Clear();

        }

        private void CheckedFigures(object sender, EventArgs e)
        {
            if (pixelButton.Checked)
            {
                check = 1;
                X1coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                X2coord.ReadOnly = true;
                Y2coord.ReadOnly = true;
                textBoxHeight.ReadOnly = true;
                textBoxWidth.ReadOnly = true;
                Radius.ReadOnly = true;
                textBoxLength.ReadOnly = true;

                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                Radius.Text = "Нет доступа";
                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                textBoxHeight.Text = "Нет доступа";
                textBoxWidth.Text = "Нет доступа";
                Radius.Text = "Нет доступа";
                textBoxLength.Text = "Нет доступа";


            }
            else if (LineButton.Checked)
            {
                check = 2;
                X1coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                X2coord.ReadOnly = true;
                Y2coord.ReadOnly = true;
                textBoxHeight.ReadOnly = true;
                textBoxWidth.ReadOnly = true;
                Radius.ReadOnly = true;
                textBoxLength.ReadOnly = false;

                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                Radius.Text = "Нет доступа";
                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                textBoxHeight.Text = "Нет доступа";
                textBoxWidth.Text = "Нет доступа";
                Radius.Text = "Нет доступа";
                textBoxLength.Text = "";


            }
            else if (RectangleButton.Checked)
            {
                check = 3;
                X1coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                X2coord.ReadOnly = true;
                Y2coord.ReadOnly = true;
                textBoxHeight.ReadOnly = false;
                textBoxWidth.ReadOnly = false;
                Radius.ReadOnly = true;
                textBoxLength.ReadOnly = true;

                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                Radius.Text = "Нет доступа";
                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                textBoxHeight.Text = "";
                textBoxWidth.Text = "";
                Radius.Text = "Нет доступа";
                textBoxLength.Text = "Нет доступа";

            }
            else if (CircleButton.Checked)
            {
                check = 4;
                X1coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                X2coord.ReadOnly = true;
                Y2coord.ReadOnly = true;
                textBoxHeight.ReadOnly = true;
                textBoxWidth.ReadOnly = true;
                Radius.ReadOnly = false;
                textBoxLength.ReadOnly = true;

                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                Radius.Text = "Нет доступа";
                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                textBoxHeight.Text = "Нет доступа";
                textBoxWidth.Text = "Нет доступа";
                Radius.Text = "";
                textBoxLength.Text = "Нет доступа";
            }
            else if (RingButton.Checked)
            {
                check = 5;
                X1coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                X2coord.ReadOnly = true;
                Y2coord.ReadOnly = true;
                textBoxHeight.ReadOnly = true;
                textBoxWidth.ReadOnly = true;
                Radius.ReadOnly = false;
                textBoxLength.ReadOnly = true;

                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                Radius.Text = "Нет доступа";
                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                textBoxHeight.Text = "Нет доступа";
                textBoxWidth.Text = "Нет доступа";
                Radius.Text = "";
                textBoxLength.Text = "Нет доступа";
            }
            else if (HeartButton.Checked)
            {
                check = 6;
                X1coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                X2coord.ReadOnly = true;
                Y2coord.ReadOnly = true;
                textBoxHeight.ReadOnly = true;
                textBoxWidth.ReadOnly = false;
                Radius.ReadOnly = true;
                textBoxLength.ReadOnly = true;

                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                Radius.Text = "Нет доступа";
                X2coord.Text = "Нет доступа";
                Y2coord.Text = "Нет доступа";
                textBoxHeight.Text = "Нет доступа";
                textBoxWidth.Text = "";
                Radius.Text = "Нет доступа";
                textBoxLength.Text = "Нет доступа";
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
                if (text.Substring(0, text.Length - 2) == "Ring")
                {
                    foreach (var a in rings)
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
                if (text.Substring(0, text.Length - 2) == "Heart")
                {
                    foreach (var a in hearts)
                    {
                        if (a.name[6] == text[6])
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
                if (text.Substring(0, text.Length - 2) == "Ring")
                {
                    for (int i = 0; i < rings.Count; i++)
                    {
                        if (rings[i].name[5] == text[5])
                        {
                            rings[i].Show(graph, new Pen(Color.White));
                            rings.RemoveAt(i);
                            listBox.Items.Remove(listBox.SelectedItem);
                        }
                    }
                }
                if (text.Substring(0, text.Length - 2) == "Heart")
                {
                    for (int i = 0; i < hearts.Count; i++)
                    {
                        if (hearts[i].name[6] == text[6])
                        {
                            hearts[i].Show(graph, new Pen(Color.White));
                            hearts.RemoveAt(i);
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

        private void CreatePixelSetButton_Click(object sender, EventArgs e)
        {switch (check)
            {
                case 1:
                    try
                    {
                        pixel = new Pixel(picture, Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text));
                        label7.Text = "Создана базовая точка с координатами x = " + pixel.X + " y = " + pixel.Y;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }

                    break;
                case 2:
                    try
                    {
                        lines.Add(new Line(picture, lineIndex, pixel, Convert.ToInt32(textBoxLength.Text)));
                        listBox.Items.Add("Line " + lineIndex);
                        lineIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }

                    break;
                case 3:
                    try
                    {
                        boxes.Add(new Box(pixel, Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text), picture, boxIndex));
                        listBox.Items.Add("Box " + boxIndex);
                        boxIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 4:
                    try
                    {
                        circles.Add(new Circle(pixel, Convert.ToInt32(Radius.Text), picture, circleIndex));
                        listBox.Items.Add("Circle " + circleIndex);
                        circleIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 5:
                    try
                    {
                        rings.Add(new Ring(pixel, Convert.ToInt32(Radius.Text), picture, ringIndex));
                        listBox.Items.Add("Ring " + ringIndex);
                        ringIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 6:
                    try
                    {
                        hearts.Add(new Heart(pixel, Convert.ToInt32(textBoxWidth.Text), picture, heartIndex));
                        listBox.Items.Add("Heart " + heartIndex);
                        heartIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;

            }

            Draw();

        }

        //private void CreateFigures_Load(object sender, EventArgs e)
        //{

        //}

        private void CreateSetButton_Click(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1:
                    try
                    {
                        pixel = new Pixel(picture, Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text));
                        label7.Text = "Создана базовая точка с координатами x = " + pixel.X + " y = " + pixel.Y;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }

                    break;
                case 2:
                    try
                    {
                        lines.Add(new Line(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(textBoxLength.Text), picture, lineIndex));
                        listBox.Items.Add("Line " + lineIndex);
                        lineIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }

                    break;
                case 3:
                    try
                    {
                        boxes.Add(new Box(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text), picture, boxIndex));
                        listBox.Items.Add("Box " + boxIndex);
                        boxIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 4:
                    try
                    {
                        circles.Add(new Circle(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(Radius.Text), picture, circleIndex));
                        listBox.Items.Add("Circle " + circleIndex);
                        circleIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 5:
                    try
                    {
                        rings.Add(new Ring(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(Radius.Text), picture, ringIndex));
                        listBox.Items.Add("Ring " + ringIndex);
                        ringIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 6:
                    try
                    {
                        hearts.Add(new Heart(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(textBoxWidth.Text), picture, heartIndex));
                        listBox.Items.Add("Heart " + heartIndex);
                        heartIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;

            }

            Draw();
        }
        private void CreateRandomButton_Click(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1:
                    try
                    {
                        pixel = new Pixel(picture);
                        label7.Text = "Создана базовая точка с координатами x = " + pixel.X + " y = " + pixel.Y;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }

                    break;
                case 2:
                    try
                    {
                        lines.Add(new Line(picture, lineIndex));
                        listBox.Items.Add("Line " + lineIndex);
                        lineIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }

                    break;
                case 3:
                    try
                    {
                        boxes.Add(new Box(picture, boxIndex));
                        listBox.Items.Add("Box " + boxIndex);
                        boxIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 4:
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
                case 5:
                    try
                    {
                        rings.Add(new Ring(picture, ringIndex));
                        listBox.Items.Add("Ring " + ringIndex);
                        ringIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 6:
                    try
                    {
                        hearts.Add(new Heart(picture, heartIndex));
                        listBox.Items.Add("Heart " + heartIndex);
                        heartIndex++;
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
            ClearAll();

        }
    }
}


