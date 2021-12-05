using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Sekil
    {
        public Sekil(double x)
        {
            this.X = x;
        }
        private double _x;
        public double X
        {
            get { return _x; }

            set
            {
                if (value <= 0)
                    throw new Exception("X 0'dan büyük olmalıdır");
                _x = value;
            }
        }
        public abstract double AlanHesapla();
        public virtual double CevreHesapla()
        {
            return 4 * X;
        }
        public virtual double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
