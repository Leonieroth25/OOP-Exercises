using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaeche_eines_Rechtecks_berechnen
{
    public class Berechnung
    {
        public int _rflaeche;

        public int Rechteckflaeche
        {
            get
            {
                return _rflaeche;
            }

            private set
            {
                _rflaeche = value;
            }

        }

        public void Berechnungen(int rechteckhoehe, int rechteckbreite)
            {
                _rflaeche = rechteckhoehe * rechteckbreite;
            }
     
    }
}