using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    class Item
    {
        //private TFigure Item;   // свойство-указатель на следующий элемент
        public Item Next { get; set; }   // свойство-указатель на следующий элемент
        public TFigure Fig { get; set; }  // свойство-указатель адресуемой фигуры 
        public Item(Item aNext, TFigure aFig){ 
            Next = aNext; Fig = aFig; 
        }
    }

}
