using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public  class Kare : Sekil
    {
        public Kare(double x) : base(x)
        {

        }
        public override double AlanHesapla()
        {
            return X * X;
        }
        public override string ToString()
        {
            return "Kare " + AlanHesapla() + "br²";
        }
    }
}
