using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAbstract
{
    class Kare : DortgenBase
    {
        public override double AlanHesapla()
        {
            return UzunKenar * UzunKenar;
        }

        public override double CevreHesapla()
        {
            return UzunKenar * 4;
        }
    }
}
