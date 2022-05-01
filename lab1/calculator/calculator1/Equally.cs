using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    class Equally
    {
        double a, b, x;
        string C;
        public Equally(double a, double b, string C)
        {
            this.a = a;
            this.b = b;
            this.C = C;
            
        }

        public string Culculate()
        {
            if (C == "+")
            {
                x = a + b;
                return x.ToString();
            }
            if (C == "-")
            {
                x = a - b;
                return x.ToString();
            }
            if (C == "X")
            {
                x = a * b;
                return x.ToString();
            }
            if (C == "/")
            {
                x = a / b;
                return x.ToString();
            }
            return "Ошибка";
        }
    }
}
