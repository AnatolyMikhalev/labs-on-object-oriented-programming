using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    public class ElementaryContainer 
    {

        TFigure[] array;
        int count = 0;
        int N { get; set; }
        Random rnd = new Random();
        public ElementaryContainer(int n = 21)
        {
            N = n;
            array = new TFigure[N];
        }
        public ElementaryContainer(PictureBox picture)
        {
            N = 21;
            array = new TFigure[N];

            for(int i = 0; i < N; i++)
            {
                int rand = rnd.Next(6);
                switch (rand)
                {
                    case 0:
                        {
                            array[count] = new Box(picture, rnd);
                            break;
                        }
                    case 1:
                        {
                            array[count] = new RectangleFigure(picture, rnd);
                            break;
                        }
                    case 2:
                        {
                            array[count] = new Romb(picture, rnd);
                            break;
                        }
                    case 3:
                        {
                            array[count] = new Line(picture, rnd);
                            break;
                        }
                    case 4:
                        {
                            array[count] = new Circle(picture, rnd);
                            break;
                        }
                    case 5:
                        {
                            array[count] = new Ellipse(picture, rnd);
                            break;
                        }
                }

                count++;
            }
        }


        public void Add(PictureBox picture)
        {
            if(Count >= N){
                N += N / 10;
                Array.Resize<TFigure>(ref array, N);
            }

            int rand = rnd.Next(6);
            switch (rand)
            {
                case 0:
                    {
                        array[count] = new Box(picture, rnd);
                        break;
                    }
                case 1:
                    {
                        array[count] = new RectangleFigure(picture, rnd);
                        break;
                    }
                case 2:
                    {
                        array[count] = new Romb(picture, rnd);
                        break;
                    }
                case 3:
                    {
                        array[count] = new Line(picture, rnd);
                        break;
                    }
                case 4:
                    {
                        array[count] = new Circle(picture, rnd);
                        break;
                    }
                case 5:
                    {
                        array[count] = new Ellipse(picture, rnd);
                        break;
                    }
            }
            count++;

        }

        public void Iterator(Graphics graph, int k, int x = 0, int y = 0)
        {
            switch (k)
            {
                case 0:
                    {

                        Pen pen = new Pen(Color.Blue);
                        for (int i = 0; i < count; i++)
                        {
                            array[i].Show(graph, pen);
                        }

                        break;
                    }
                case 1:
                    {

                        for (int i = 0; i < count; i++)
                        {
                            array[i].Remove(graph);
                        }

                        break;
                    }
                case 2:
                    {

                        for (int i = 0; i < count; i++)
                        {
                            array[i].MoveTo(graph, x, y);
                        }

                        break;
                    }
            }
        }
        public void FreeAll()
        {
            Count = 0;
            N = 0;
            array = null;

        }
        int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (value < N)
                {
                    count = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

    }
}
