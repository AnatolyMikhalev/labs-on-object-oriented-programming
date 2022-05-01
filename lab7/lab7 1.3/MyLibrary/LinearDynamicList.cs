using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    class LinearDynamicList : IEnumerator
    {
        public TFigure[] _figures;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public LinearDynamicList(TFigure[] list)
        {
            _figures = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _figures.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public TFigure Current
        {
            get
            {
                try
                {
                    return _figures[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

}
