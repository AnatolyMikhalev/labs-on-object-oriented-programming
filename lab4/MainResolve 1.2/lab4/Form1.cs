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
        Pen penBlue, penClear;
        List<Circle> circles = new List<Circle>();
        List<Box> boxes = new List<Box>();
        List<Line> lines = new List<Line>();
        List<Ring> rings = new List<Ring>();
        List<Heart> hearts = new List<Heart>();
        List<RectangleFigure> rectangles = new List<RectangleFigure>();
        List<Romb> rombs = new List<Romb>();
        List<Ellipse> ellipses = new List<Ellipse>();
        Pixel pixel;
        private int check;
        private int lineIndex, boxIndex, circleIndex, ringIndex, heartIndex;
        private int rectangleIndex, rombIndex, ellipseIndex;
        public CreateFigures()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            graph = picture.CreateGraphics();
            penBlue = new Pen(Color.Blue);
            penClear = new Pen(Color.White);
        }
        private void Draw(Pen pen)
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
            foreach (var a in rectangles)
            {
                a.Show(graph, pen);
            }
            foreach (var a in rombs)
            {
                a.Show(graph, pen);
            }
            foreach (var a in ellipses)
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
            rectangleIndex = 0;
            rombIndex = 0;
            ellipseIndex = 0;

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
            rectangles.Clear();
            rombs.Clear();
            ellipses.Clear();
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
            else if (BoxButton.Checked)
            {
                check = 3;
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
                X2coord.ReadOnly = false;
                Y2coord.ReadOnly = false;
                textBoxHeight.ReadOnly = false;
                textBoxWidth.ReadOnly = false;
                Radius.ReadOnly = false;
                textBoxLength.ReadOnly = false;

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
            else if (RectangleButton.Checked)
            {
                check = 7;
                X1coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                X2coord.ReadOnly = false;
                Y2coord.ReadOnly = false;
                textBoxHeight.ReadOnly = false;
                textBoxWidth.ReadOnly = false;
                Radius.ReadOnly = false;
                textBoxLength.ReadOnly = false;

                X2coord.Text = "";
                Y2coord.Text = "";
                Radius.Text = "";
                X2coord.Text = "";
                Y2coord.Text = "";
                textBoxHeight.Text = "";
                textBoxWidth.Text = "";
                Radius.Text = "";
                textBoxLength.Text = "";
            }
            else if (RombButton.Checked)
            {
                check = 8;
                X1coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                X2coord.ReadOnly = false;
                Y2coord.ReadOnly = false;
                textBoxHeight.ReadOnly = false;
                textBoxWidth.ReadOnly = false;
                Radius.ReadOnly = false;
                textBoxLength.ReadOnly = false;

                X2coord.Text = "";
                Y2coord.Text = "";
                Radius.Text = "";
                X2coord.Text = "";
                Y2coord.Text = "";
                textBoxHeight.Text = "";
                textBoxWidth.Text = "";
                Radius.Text = "";
                textBoxLength.Text = "";
            }
            else if (EllipseButton.Checked)
            {
                check = 9;
                X1coord.ReadOnly = false;
                Y1coord.ReadOnly = false;
                X2coord.ReadOnly = false;
                Y2coord.ReadOnly = false;
                textBoxHeight.ReadOnly = false;
                textBoxWidth.ReadOnly = false;
                Radius.ReadOnly = false;
                textBoxLength.ReadOnly = false;

                X2coord.Text = "";
                Y2coord.Text = "";
                Radius.Text = "";
                X2coord.Text = "";
                Y2coord.Text = "";
                textBoxHeight.Text = "";
                textBoxWidth.Text = "";
                Radius.Text = "";
                textBoxLength.Text = "";
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
                if (text.Substring(0, text.Length - 2) == "Rectangle")
                {
                    foreach (var a in rectangles)
                    {
                        if (a.name[10] == text[10])
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
                if (text.Substring(0, text.Length - 2) == "Romb")
                {
                    foreach (var a in rombs)
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
                if (text.Substring(0, text.Length - 2) == "Ellipse")
                {
                    foreach (var a in ellipses)
                    {
                        if (a.name[8] == text[8])
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


                Draw(penBlue);

            }
            catch
            {
                MessageBox.Show("Выберите объект");
            }
            

        }

        private void CreateFigures_Load(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
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
                if (text.Substring(0, text.Length - 2) == "Rectangle")
                {
                    for (int i = 0; i < rectangles.Count; i++)
                    {
                        if (hearts[i].name[10] == text[10])
                        {
                            rectangles[i].Show(graph, new Pen(Color.White));
                            rectangles.RemoveAt(i);
                            listBox.Items.Remove(listBox.SelectedItem);
                        }
                    }
                }
                if (text.Substring(0, text.Length - 2) == "Romb")
                {
                    for (int i = 0; i < rombs.Count; i++)
                    {
                        if (rombs[i].name[5] == text[5])
                        {
                            rombs[i].Show(graph, new Pen(Color.White));
                            rombs.RemoveAt(i);
                            listBox.Items.Remove(listBox.SelectedItem);
                        }
                    }
                }
                if (text.Substring(0, text.Length - 2) == "Ellipse")
                {
                    for (int i = 0; i < ellipses.Count; i++)
                    {
                        if (ellipses[i].name[8] == text[8])
                        {
                            ellipses[i].Show(graph, new Pen(Color.White));
                            ellipses.RemoveAt(i);
                            listBox.Items.Remove(listBox.SelectedItem);
                        }
                    }
                }

                Draw(penBlue);

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
                        boxes.Add(new Box(pixel, Convert.ToInt32(textBoxWidth.Text), picture, boxIndex));
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
                case 7:
                    try
                    {
                        rectangles.Add(new RectangleFigure(pixel, Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text), picture, rectangleIndex));
                        listBox.Items.Add("Rectangle " + rectangleIndex);
                        rectangleIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 8:
                    try
                    {
                        rombs.Add(new Romb(pixel, Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text), picture, heartIndex));
                        listBox.Items.Add("Romb " + rombIndex);
                        rombIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 9:
                    try
                    {
                        ellipses.Add(new Ellipse(pixel, Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text), picture, ellipseIndex));
                        listBox.Items.Add("Ellipse " + ellipseIndex);
                        ellipseIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;

            }

            //ClearAll();
            Draw(penClear);
            Draw(penBlue);

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
                        boxes.Add(new Box(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(textBoxWidth.Text), picture, boxIndex));
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
                case 7:
                    try
                    {
                        rectangles.Add(new RectangleFigure(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text), picture, rectangleIndex));
                        listBox.Items.Add("Rectangle " + rectangleIndex);
                        rectangleIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 8:
                    try
                    {
                        rombs.Add(new Romb(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text), picture, heartIndex));
                        listBox.Items.Add("Romb " + rombIndex);
                        rombIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 9:
                    try
                    {
                        ellipses.Add(new Ellipse(Convert.ToInt32(X1coord.Text), Convert.ToInt32(Y1coord.Text), Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text), picture, ellipseIndex));
                        listBox.Items.Add("Ellipse " + ellipseIndex);
                        ellipseIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;


            }

            Draw(penBlue);
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
                case 7:
                    try
                    {
                        rectangles.Add(new RectangleFigure(picture, rectangleIndex));
                        listBox.Items.Add("Rectangle " + rectangleIndex);
                        rectangleIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 8:
                    try
                    {
                        rombs.Add(new Romb(picture, heartIndex));
                        listBox.Items.Add("Romb " + rombIndex);
                        rombIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;
                case 9:
                    try
                    {
                        ellipses.Add(new Ellipse(picture, ellipseIndex));
                        listBox.Items.Add("Ellipse " + ellipseIndex);
                        ellipseIndex++;
                    }
                    catch
                    {
                        MessageBox.Show("Неверные параметры");
                    }
                    break;

            }


            Draw(penBlue);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();

        }
    }
}


