using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alter_berechnen
{
    class BerechnuneAlter
    {
        private int _alter;
        private int _resultDays = 0;

        DateTime heute = DateTime.Today;
        DateTime geburtstag = new DateTime(2005, 2, 25);

        public int Alter
        {
            get
            {
                return _alter;
            }
            set
            {
                _alter = value;
            }
        }

    }

}
