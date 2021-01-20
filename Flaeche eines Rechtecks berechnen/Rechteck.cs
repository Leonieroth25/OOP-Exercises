using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaeche_eines_Rechtecks_berechnen
{
    public class Rechteck
    {
        private int _rflaeche;

        

        public int BerechneFlaeche(int rechteckhoehe, int rechteckbreite)
        {
            _rflaeche = rechteckhoehe * rechteckbreite;

            return _rflaeche;
        }
     
    }
}