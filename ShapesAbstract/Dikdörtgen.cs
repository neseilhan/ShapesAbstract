using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAbstract
{
    class Dikdörtgen : DortgenBase
    {
        public override double AlanHesapla()
        {
            return UzunKenar * KısaKenar;
        }

        public override double CevreHesapla()
        {
            return (UzunKenar + KısaKenar) * 2;
        }
    }
}
