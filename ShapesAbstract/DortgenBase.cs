using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAbstract
{
    abstract class DortgenBase
    {
        public double UzunKenar { get; set; }
        public double KısaKenar { get; set; }

        public abstract double AlanHesapla();
        public abstract double CevreHesapla();
    }
}
