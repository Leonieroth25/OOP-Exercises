﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    public class Tannenbaum
    {


        string _resultat = string.Empty;

      
        public int KronenHoehe
        {
            get;
            set;
        }

        public int StammBreite
        {
            get;
            set;
        }

        public int StammHoehe
        {
            get;
            set;
        }

        public string Resultat
        {
            get
            {
                return _resultat;
            }
        }

        public Tannenbaum(int kronenHoehe, int stammBreite, int stammHoehe)
        {
            this.KronenHoehe = kronenHoehe;
            this.StammBreite = stammBreite;
            this.StammHoehe = stammHoehe;
        }

        public void Zeichne()
        {
            ZeichneKrone();
            ZeichneStamm();
        }

        private void ZeichneKrone()
        {
            for (int i = 1; i <= KronenHoehe; ++i)
                ZeichneZeile(KronenHoehe - i, 2 * i - 1);
        }

        private void ZeichneZeile(int positionErsterStern, int anzahlSterne)
        {
            int i;
            for (i = 1; i <= positionErsterStern; ++i)
                _resultat += " ";

            for (i = 1; i <= anzahlSterne; ++i)
                _resultat += "*";

            _resultat += Environment.NewLine;
        }

        private void ZeichneStamm()
        {
            for (int i = 1; i <= StammHoehe; ++i)
                ZeichneZeile(KronenHoehe - StammBreite / 2 - 1, StammBreite);
        }

    }
}
