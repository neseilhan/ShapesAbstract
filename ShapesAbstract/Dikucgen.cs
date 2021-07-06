using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAbstract
{
    class Dikucgen : UcgenBase
    {
        private double hipotenus;
        public override double AlanHesapla()
        {
            return Kenar * Yükseklik / 2;
        }

        public override double CevreHesapla()
        {
            double hipotenus = Math.Sqrt((Kenar * Kenar) + Math.Pow(Yükseklik, 2));
            return hipotenus + Kenar + Yükseklik;
        }
    }
}
