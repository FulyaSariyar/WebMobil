using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public  class DikUcgen : Dikdörtgen
    {
        public DikUcgen(double x, double y) : base(x, y)
        {
        }
        public override double AlanHesapla()
        {
            return base.AlanHesapla() / 2;
        }
        public override double CevreHesapla()
        {
            return base.CevreHesapla() / 2 + base.KosegenHesapla();
        }
        public override string ToString()
        {
            return "DikÜçgen " + AlanHesapla() + "br²";
        }
    }
}
