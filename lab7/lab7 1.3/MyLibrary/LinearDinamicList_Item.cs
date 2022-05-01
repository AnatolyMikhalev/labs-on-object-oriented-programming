using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    class LinearDinamicList_Item : IEnumerable
    {
        private TFigure[] _figures;
        public LinearDinamicList_Item(TFigure[] pArray)
        {
            _figures = new TFigure[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _figures[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public LinearDynamicList GetEnumerator()
        {
            return new LinearDynamicList(_figures);
        }
    }
}
