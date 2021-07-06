using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAbstract
{
    abstract class UcgenBase
    {
        public double Kenar { get; set; }
        public double Yükseklik { get; set; }

        public abstract double AlanHesapla();
        public abstract double CevreHesapla();
    }
}
