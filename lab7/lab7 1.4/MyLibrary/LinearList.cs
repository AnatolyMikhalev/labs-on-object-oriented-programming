using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    public class LinearList
    {
        private Item First;  // указатель на первый элемент списка
        Random rnd = new Random();
        public LinearList() { 
            First = null; 
        }  
        public LinearList(PictureBox picture) { 
            First = null; 
            for (int i = 0; i < 21; i++)
            {
                AddRandom(picture);
            }
        }  
        public void Add(TFigure aFig) 
        {
            First = new Item(First, aFig);
        }
        public void AddRandom(PictureBox picture)
        {

            int rand = rnd.Next(6);
            switch (rand)
            {
                case 0:
                    {
                        Add(new Box(picture, rnd));
                        break;
                    }
                case 1:
                    {
                        Add(new RectangleFigure(picture, rnd));
                        break;
                    }
                case 2:
                    {
                        Add(new Romb(picture, rnd));
                        break;
                    }
                case 3:
                    {
                        Add(new Line(picture, rnd));
                        break;
                    }
                case 4:
                    {
                        Add(new Circle(picture, rnd));
                        break;
                    }
                case 5:
                    {
                        Add(new Ellipse(picture, rnd));
                        break;
                    }
            }
        }
        public void Iterator(Graphics graph, int k, int x = 0, int y = 0)
        {
            Item Current = First; 
            switch (k)
            {
                case 0:
                    {
                        Pen pen = new Pen(Color.Blue);
                        while (Current != null)
                        {
                            Current.Fig.Show(graph, pen);
                            Current = Current.Next;
                        }
                        break;
                    }
                case 1:
                    {
                        while (Current != null)
                        {
                            Current.Fig.Remove(graph);
                            Current = Current.Next;
                        }

                        break;
                    }
                case 2:
                    {
                        while (Current != null)
                        {
                            Current.Fig.MoveTo(graph, x, y);
                            Current = Current.Next;
                        }

                        break;
                    }
            }
        }
        public void FreeAll()
        {
            First = null;

        }
    }


}
