using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAbstract
{
    class Eskenarucgen : UcgenBase
    {
        public override double AlanHesapla()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(Kenar, 2);
        }

        public override double CevreHesapla()
        {
            return Kenar * 3;
        }
    }
}
